using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Atlas.Infrastructure.CoreQueue.Models
{
    public class SAPCustomSIReturnModel
    {
        public int SummaryDeclarationId { get; set; }
        public string Guid { get; set; }
        public string UserName { get; set; }
        public string HashPassword { get; set; }
    }
}
