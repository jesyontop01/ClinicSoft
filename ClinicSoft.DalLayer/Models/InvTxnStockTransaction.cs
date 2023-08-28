using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnStockTransaction
    {
        public int StockTransactionId { get; set; }
        public int? StockId { get; set; }
        public int? ItemId { get; set; }
        public int? GoodsReceiptItemId { get; set; }
        public double? Quantity { get; set; }
        public string? InOut { get; set; }
        public int? ReferenceNo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? TransactionType { get; set; }
        public bool? IsTransferredToAcc { get; set; }
        public decimal? Mrp { get; set; }
        public decimal? CostPrice { get; set; }
        public int? FiscalYearId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public bool? IsActive { get; set; }
        public int? StoreId { get; set; }
        public int? StoreStockId { get; set; }
        public double? InQty { get; set; }
        public double? OutQty { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? Remarks { get; set; }

        public virtual PhrmMstStore? Store { get; set; }
        public virtual InvTxnStoreStock? StoreStock { get; set; }
    }
}
