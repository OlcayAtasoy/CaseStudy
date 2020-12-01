using DirectoryModules.RequestModels;
using DirectoryModules.ResponseModels;
using Infrastructure.CoreQueue.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryModules.Contracts
{
    public interface IDirectoryContract
    {
        DirectoryResponseModel CreateDirection(DirectionCreateRequestModel request);
        DirectoryResponseModel RemoveDirection(DirectionRemoveRequestModel request);
        object GetDirectoryListGridData();
        object GetCommunicationInformationListGridData(GetCommunicationInformationListGridDataRequestModel requestModel);
        bool ExecuteReportJob(ReportsRequestModel requestModel);
    }
}
