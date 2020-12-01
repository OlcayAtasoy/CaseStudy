using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryModules.RequestModels
{
    public class DirectionRemoveRequestModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public bool IsDeleted { get; set; }
        public List<CommunicationInformationRemoveRequestModel> CommunicationInformation { get; set; }
    }
}
