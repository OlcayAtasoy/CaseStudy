using System;
using System.Collections.Generic;
using System.Text;

namespace ReportModules.ResponseModels
{
    public class ReportResponseModel
    {
        public Guid Id { get; set; }
        public DateTime ReportDate { get; set; }
        public string ReportStatus { get; set; }
        public string ReportLocation { get; set; }
        public long? PersonCount { get; set; }
        public long? PhoneNumberCount { get; set; }
        public int ReportServiceStatus { get; set; }
    }
}
