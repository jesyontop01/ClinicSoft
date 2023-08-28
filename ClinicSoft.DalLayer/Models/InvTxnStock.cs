using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnStock
    {
        public int StockId { get; set; }
        public int? ItemId { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double? ReceivedQuantity { get; set; }
        public double? AvailableQuantity { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? GoodsReceiptId { get; set; }
        public decimal? Mrp { get; set; }
        public decimal? Price { get; set; }
        public int StoreId { get; set; }
        public string? StockSpecification { get; set; }

        public virtual PhrmMstStore Store { get; set; } = null!;
    }
}
