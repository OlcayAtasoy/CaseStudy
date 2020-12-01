using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Atlas.Infrastructure.CoreQueue.Models
{
    public class MDMSendResponseModel
    {
        public bool IsSuccess { get; set; }
        public List<string> ErrorMessages { get; set; }
    }
}
