using ApiOne.Controllers;
using Infrastructure.CoreQueue;
using Infrastructure.CoreQueue.Model;
using Infrastructure.DataModel.Entities;
using Infrastructure.DataModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportingJob
{
    public class Worker : ConsumerAbstraction<ReportsRequestModel>
    {

        DirectoryController _directoryController;
        IServiceProvider _serviceProvider;
        MyDbContext _myDbContext;

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
            _directoryController.GetExecuteReportJob(data);
        }
    }
}
