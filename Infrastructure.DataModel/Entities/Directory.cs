using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataModel.Entities
{
    public class Directory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public int CommunicationInformationId { get; set; }
    }
}
