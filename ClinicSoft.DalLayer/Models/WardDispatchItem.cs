using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class WardDispatchItem
    {
        public int DispatchItemId { get; set; }
        public int? DispatchId { get; set; }
        public int? RequisitionItemId { get; set; }
        public int? ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int Quantity { get; set; }
        public decimal Mrp { get; set; }
        public decimal? SubTotal { get; set; }
        public string? Remark { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal? Price { get; set; }
    }
}
