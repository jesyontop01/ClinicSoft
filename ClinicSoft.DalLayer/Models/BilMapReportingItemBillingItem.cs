using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilMapReportingItemBillingItem
    {
        public int RptItemBillItemMappingId { get; set; }
        public int? ReportingItemsId { get; set; }
        public int? BillItemPriceId { get; set; }
        public bool? IsActive { get; set; }
    }
}
