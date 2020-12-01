using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DirectoryModules.Contracts;
using Infrastructure.CoreQueue.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiTwo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly IReportContract _reportContract;
        public ReportController(IReportContract reportContract)
        {
            _reportContract = reportContract;
        }
        [HttpPost]
        public bool GetExecuteReportJob(ReportsRequestModel requestModel)
        {
            return _reportContract.GetReport(requestModel);
        }
        [HttpPost]
        public object GetReportsListData()
        {
            return Ok(_reportContract.GetReportsListData());
        }

    }
}
