using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmStockTxnItem
    {
        public PhrmStockTxnItem()
        {
            PhrmStockManages = new HashSet<PhrmStockManage>();
        }

        public int StockTxnItemId { get; set; }
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
        public int DispensaryId { get; set; }
        public bool? IsTransferredToAcc { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PhrmGoodsReceiptItem? GoodsReceiptItem { get; set; }
        public virtual ICollection<PhrmStockManage> PhrmStockManages { get; set; }
    }
}
