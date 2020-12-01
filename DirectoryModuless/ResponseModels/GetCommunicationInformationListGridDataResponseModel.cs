using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryModules.ResponseModels
{
    public class GetCommunicationInformationListGridDataResponseModel
    {
        public Guid? Id { get; set; }
        public string InformationTypeName { get; set; }
        public bool IsDeleted { get; set; }
        public string InformationContent { get; set; }
    }
}
