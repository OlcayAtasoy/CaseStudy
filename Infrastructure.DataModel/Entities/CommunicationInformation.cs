using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataModel.Entities
{
    public class CommunicationInformation
    {
        public Guid? Id { get; set; }
        public Guid? DirectoryId { get; set; }
        public int InformationTypeId { get; set; }
        public string InformationContent{ get; set; }
        public bool IsDeleted { get; set; }
    }
}
