using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CoreQueue
{
    public class Publisher
    {
        public bool Publish<T>(string QueueName, T data, IModel model = null) where T : class
        {
            IConnection connection = null;
            bool externalConnection = false;

            try
            {
                if (model == null)
                {
                    externalConnection = true;
                    var connectionFactory = new ConnectionFactory
                    {
                        HostName = AppSettings.HostName,
                        UserName = AppSettings.UserName,
                        Password = AppSettings.Password
                    };

                    connection = connectionFactory.CreateConnection();
                    model = connection.CreateModel();
                }


                //Setup properties
                var properties = model.CreateBasicProperties();
                properties.Persistent = true;

                byte[] messageBuffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));


                model.BasicPublish("", QueueName, properties, messageBuffer);
                return true;
            }
            catch (System.Exception)
            {
                externalConnection = false;
                return false;
            }
            finally
            {
                if (externalConnection)
                {
                    model.Dispose();
                    connection.Dispose();
                }
            }
        }
    }
}
