using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Atlas.Infrastructure.CoreQueue.Models
{
    public class SAP_ECC_FI_Reverse
    {
        public int Id { get; set; }
        public DateTime? ProvisionDate { get; set; }
        public DateTime ReverseRecordDate { get; set; }
        public int ReverseRecordReasonId { get; set; }
        public int? InvoiceAccountingItemId { get; set; }

    }
}
