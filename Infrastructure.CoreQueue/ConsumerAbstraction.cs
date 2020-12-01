using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CoreQueue
{
    public abstract class ConsumerAbstraction<T> where T : class
    {
        private string _jobName = String.Empty;
        private const string RetryHeader = "RETRY-COUNT";
        private int _currentRetryCount;
        public int currentRetryCount
        {
            get { return _currentRetryCount; }
        }
        public int RetryCount { get; set; } = 10;


        private IModel _model;

        public IModel ModelInstance
        {
            get { return _model; }
        }

        public ConsumerAbstraction(string jobName)
        {
            _jobName = jobName;
        }
        public abstract bool DoWork(T data);


        public void Run(string queueName)
        {
            DisplaySettings(queueName);

            var connectionFactory = new ConnectionFactory
            {
                HostName = AppSettings.HostName,
                UserName = AppSettings.UserName,
                Password = AppSettings.Password
            };

            var connection = connectionFactory.CreateConnection();
            _model = connection.CreateModel();
            _model.BasicQos(0, 1, false);

            var eventingBasicConsumer = new EventingBasicConsumer(_model);

            eventingBasicConsumer.Received += (sender, deliveryArgs) =>
            {
                string message = string.Empty;
                try
                {
                    var data = JsonConvert.DeserializeObject<T>(message);

                    var success = DoWork(data);

                    if (success)
                    {
                        _model.BasicAck(deliveryArgs.DeliveryTag, false);
                    }
                    else
                    {
                        _currentRetryCount = GetRetryAttempts(deliveryArgs.BasicProperties);
                        if (currentRetryCount < RetryCount)
                        {
                            _currentRetryCount++;
                            var properties = _model.CreateBasicProperties();
                            properties.Headers = CopyMessageHeaders(deliveryArgs.BasicProperties.Headers);
                            SetRetryAttempts(properties, _currentRetryCount);

                            _model.BasicPublish(deliveryArgs.Exchange, deliveryArgs.RoutingKey, properties, deliveryArgs.Body);

                            _model.BasicAck(deliveryArgs.DeliveryTag, false);
                        }
                        else
                        {
                            _model.BasicReject(deliveryArgs.DeliveryTag, false);
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine($"MainEx:{ex.ToString()}");
                    _model.BasicReject(deliveryArgs.DeliveryTag, false);
                    var logMessage = String.Format("{0} ==> Ex: {1} ==> Data: {2}", _jobName, ex.Message, message);
                    var exception = JsonConvert.SerializeObject(ex);
                }
            };

            _model.BasicConsume(queueName, false, eventingBasicConsumer);
        }

        private IDictionary<string, object> CopyMessageHeaders(IDictionary<string, object> existingProperties)
        {
            var newProperties = new Dictionary<string, object>();
            if (existingProperties != null)
            {
                var enumerator = existingProperties.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    newProperties.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            return newProperties;
        }
        private void SetRetryAttempts(IBasicProperties properties, int newAttempts)
        {
            if (properties.Headers.ContainsKey(RetryHeader))
                properties.Headers[RetryHeader] = newAttempts;
            else
                properties.Headers.Add(RetryHeader, newAttempts);
        }
        private int GetRetryAttempts(IBasicProperties properties)
        {
            if (properties.Headers == null || properties.Headers.ContainsKey(RetryHeader) == false)
                return 0;

            var val = properties.Headers[RetryHeader];

            if (val == null)
                return 0;

            return Convert.ToInt32(val);
        }

        private void DisplaySettings(string queueName)
        {
            Console.WriteLine("Starting RabbitMQ queue processor");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Host: {0}", AppSettings.HostName);
            Console.WriteLine("Username: {0}", AppSettings.UserName);
            Console.WriteLine("Password: {0}", AppSettings.Password);
            Console.WriteLine("QueueName: {0}", queueName);
        }
    }
}
