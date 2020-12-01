using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryModules.RequestModels
{
    public class DirectionCreateRequestModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public List<CommunicationInformationRequestModel> CommunicationInformation { get; set; }
    }
}
