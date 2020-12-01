using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Atlas.Infrastructure.CoreQueue.Models
{
    public class MDMReceiveResponseModel
    {
        public string MDMNo { get; set; }
        public string AtlasCode { get; set; }
        public string Message { get; set; }
        public string StatusCode { get; set; }
    }
}
