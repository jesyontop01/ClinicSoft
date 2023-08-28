using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilMapFreeServiceBillingItem
    {
        public int FreeServiceAndBillingItemMappingId { get; set; }
        public int? FreeServiceId { get; set; }
        public int? BillItemPriceId { get; set; }
        public bool? IsActive { get; set; }
    }
}
