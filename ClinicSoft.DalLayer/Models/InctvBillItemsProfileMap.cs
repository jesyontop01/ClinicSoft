using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InctvBillItemsProfileMap
    {
        public int BillItemProfileMapId { get; set; }
        public int? BillItemPriceId { get; set; }
        public int? ProfileId { get; set; }
        public double? AssignedToPercent { get; set; }
        public double? ReferredByPercent { get; set; }
        public int? PriceCategoryId { get; set; }
        public string? BillingTypesApplicable { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual BilCfgBillItemPrice? BillItemPrice { get; set; }
        public virtual InctvMstProfile? Profile { get; set; }
    }
}
