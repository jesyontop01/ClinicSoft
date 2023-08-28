using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class WardInternalConsumptionItem
    {
        public int ConsumptionItemId { get; set; }
        public int? ConsumptionId { get; set; }
        public int? ItemId { get; set; }
        public int? WardId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SubstoreId { get; set; }
        public string? BatchNo { get; set; }
        public string? ItemName { get; set; }
        public double? Mrp { get; set; }
        public int? Quantity { get; set; }
        public double? Subtotal { get; set; }
        public string? Remark { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public decimal? Price { get; set; }
    }
}
