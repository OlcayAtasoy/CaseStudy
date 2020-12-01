using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryModules.RequestModels
{
    public class CommunicationInformationRequestModel
    {
        public Guid Id { get; set; }
        public int InformationTypeId { get; set; }
        public bool IsDeleted { get; set; }
        public string InformationContent { get; set; }
    }
}
