using DirectoryModules.RequestModels;
using DirectoryModules.ResponseModels;
using Infrastructure.CoreQueue.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryModules.Contracts
{
    public interface IReportContract
    {
        bool GetReport(ReportsRequestModel request);
        object GetReportsListData();
    }
}
