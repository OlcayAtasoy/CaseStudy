using Infrastructure.DataModel.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryModules.RequestModels
{
    public class CommunicationInformationRemoveRequestModel
    {
        public Guid Id { get; set; }
        public int InformationTypeId { get; set; }
        public string InformationContent { get; set; }
        public bool IsDeleted { get; set; }
        public Guid DirectoryId { get; set; }
        public ChangeState ChangeState { get; set; }
    }
}
