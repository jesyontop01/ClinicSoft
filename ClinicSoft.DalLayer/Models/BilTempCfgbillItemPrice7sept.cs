using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilTempCfgbillItemPrice7sept
    {
        public int BillItemPriceId { get; set; }
        public int? ServiceDepartmentId { get; set; }
        public string? ItemName { get; set; }
        public double? Price { get; set; }
        public int? ItemId { get; set; }
        public bool? TaxApplicable { get; set; }
        public bool? DiscountApplicable { get; set; }
        public string? Description { get; set; }
        public string? ProcedureCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public int? DisplaySeq { get; set; }
    }
}
