using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Atlas.Infrastructure.CoreQueue.Models
{
    public class SAP_ECC_FI
    {
        public int Id { get; set; }
        public DateTime? ProvisionDate { get; set; }
        public string LongPositionNumberPrefix { get; set; }
        public int? ProvisionStep { get; set; }
        public int? Z2_LockRecordDetailId { get; set; }
        public DateTime? ProvisionReverseDate { get; set; }

        public int? CopiedInvoiceAccountingItemId { get; set; }

        public string FleetSapCustomerCode { get; set; }

    }
}
