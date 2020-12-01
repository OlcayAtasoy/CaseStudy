using Infrastructure.CoreQueue;
using Infrastructure.CoreQueue.Model;
using Infrastructure.DataModel.Entities;
using Infrastructure.DataModel.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ReportingJob
{
    public class Worker : ConsumerAbstraction<ReportsRequestModel>
    {
        IServiceProvider _serviceProvider;
        MyDbContext _myDbContext;
        private const string apiTwoJobUrl = "http://localhost:44340/Report/GetExecuteReportJob";
        public Worker(
            MyDbContext myDbContext,
            IServiceProvider serviceProvider
            ) : base("ReportJob")
        {
            this._serviceProvider = serviceProvider;
            _myDbContext = myDbContext;
        }
        public override bool DoWork(ReportsRequestModel data)
        {
            Start(data);
            return true;
        }
        private void Start(ReportsRequestModel data)
        {
            POSTData(data, apiTwoJobUrl);
        }

        private static HttpClient _httpClient = new HttpClient();

        public bool POSTData(object json, string url)
        {
            using (var content = new StringContent(JsonConvert.SerializeObject(json), System.Text.Encoding.UTF8, "application/json"))
            {
                HttpResponseMessage result = _httpClient.PostAsync(url, content).Result;
                if (result.StatusCode == System.Net.HttpStatusCode.Created)
                    return true;
                string returnValue = result.Content.ReadAsStringAsync().Result;
                throw new Exception($"Failed to POST data: ({result.StatusCode}): {returnValue}");
            }
        }
    }
}
