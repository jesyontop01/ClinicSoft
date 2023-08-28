using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmStoreStock
    {
        public PhrmStoreStock()
        {
            PhrmExpiryDateBatchNoHistories = new HashSet<PhrmExpiryDateBatchNoHistory>();
            PhrmStockTxnItemsMrphistories = new HashSet<PhrmStockTxnItemsMrphistory>();
        }

        public int StoreStockId { get; set; }
        public int? ItemId { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double? Quantity { get; set; }
        public double? FreeQuantity { get; set; }
        public decimal? Price { get; set; }
        public double? DiscountPercentage { get; set; }
        public double? Vatpercentage { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? InOut { get; set; }
        public int? ReferenceNo { get; set; }
        public DateTime? ReferenceItemCreatedOn { get; set; }
        public string? TransactionType { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal? Mrp { get; set; }
        public int? GoodsReceiptItemId { get; set; }
        public double? Cccharge { get; set; }
        public string? StoreName { get; set; }
        public int? StoreId { get; set; }
        public string? Remark { get; set; }
        public string? ItemName { get; set; }
        public bool? IsActive { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<PhrmExpiryDateBatchNoHistory> PhrmExpiryDateBatchNoHistories { get; set; }
        public virtual ICollection<PhrmStockTxnItemsMrphistory> PhrmStockTxnItemsMrphistories { get; set; }
    }
}
