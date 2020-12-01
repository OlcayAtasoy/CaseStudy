using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CoreQueue.Model
{
    public class ReportsRequestModel
    {
        public bool ReportRequest { get; set; }
        public int ReportServiceStatus { get; set; }
        public DateTime ReportDate { get; set; }


    }
}
