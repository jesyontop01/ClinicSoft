using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class WardInvStock
    {
        public int StockId { get; set; }
        public int? StoreId { get; set; }
        public int? ItemId { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double? AvailableQuantity { get; set; }
        public double UnConfirmedQty { get; set; }
        public int? DepartmentId { get; set; }
        public decimal? Mrp { get; set; }
        public decimal? Price { get; set; }
        public int? GoodsReceiptItemId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int SubstoreId { get; set; }

        public virtual PhrmMstStore Substore { get; set; } = null!;
    }
}
