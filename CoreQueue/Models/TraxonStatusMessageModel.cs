using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Atlas.Infrastructure.CoreQueue.Models
{
    public class TraxonStatusMessageModel
    {
        public string MawbInformationId { get; set; }
        public string StatusCode { get; set; }
        public string TypeCode { get; set; }
        public string Payload { get; set; }
        public string Reason { get; set; }
    }
}
