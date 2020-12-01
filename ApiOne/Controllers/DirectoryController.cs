using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DirectoryModules.Contracts;
using DirectoryModules.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace ApiOne.Controllers
{
    public partial class DirectoryController : Controller
    {
        private readonly IDirectoryContract _directoryContract;
        public DirectoryController(IDirectoryContract directoryContract)
        {
            _directoryContract = directoryContract;
        }
        [HttpPost]
        public ActionResult CreateDirection([FromBody]DirectionCreateRequestModel request)
        {
            var response = _directoryContract.CreateDirection(request);

            return Ok(response);
        }
        [HttpPost]
        public ActionResult RemoveDirection([FromBody]DirectionRemoveRequestModel request)
        {
            var response = _directoryContract.RemoveDirection(request);

            return Ok(response);
        }
        [HttpPost]
        public object GetDirectoryListGridData()
        {
            return Ok(_directoryContract.GetDirectoryListGridData());
        }
        [HttpPost]
        public object GetDirectoryListGridData([FromBody]GetCommunicationInformationListGridDataRequestModel request)
        {
            return Ok(_directoryContract.GetCommunicationInformationListGridData(request));
        }
        
    }
}