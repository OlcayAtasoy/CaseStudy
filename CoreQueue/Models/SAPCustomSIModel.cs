using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Atlas.Infrastructure.CoreQueue.Models
{
    public class SAPCustomSIModel
    {
        public string XmlData { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int SummaryDeclarationId { get; set; }
    }
}
