using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmGoodsReceiptItem
    {
        public PhrmGoodsReceiptItem()
        {
            PhrmReturnToSupplierItems = new HashSet<PhrmReturnToSupplierItem>();
            PhrmStockTxnItems = new HashSet<PhrmStockTxnItem>();
        }

        public int GoodReceiptItemId { get; set; }
        public int? GoodReceiptId { get; set; }
        public string? CompanyName { get; set; }
        public string? SupplierName { get; set; }
        public int? ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double? ReceivedQuantity { get; set; }
        public double? FreeQuantity { get; set; }
        public double? RejectedQuantity { get; set; }
        public string? Uomname { get; set; }
        public decimal? SellingPrice { get; set; }
        public decimal? GritemPrice { get; set; }
        public decimal? SubTotal { get; set; }
        public double? Vatpercentage { get; set; }
        public double? DiscountPercentage { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal? Mrp { get; set; }
        public double? AvailableQuantity { get; set; }
        public double? Cccharge { get; set; }
        public int? CounterId { get; set; }
        public bool? IsTransferredToAcc { get; set; }
        public decimal? GrPerItemVatamt { get; set; }
        public decimal? GrPerItemDisAmt { get; set; }
        public decimal? GrTotalDisAmt { get; set; }
        public decimal? StripRate { get; set; }
        public bool? IsPacking { get; set; }
        public bool? IsItemDiscountApplicable { get; set; }
        public double? PackingQty { get; set; }
        public decimal? StripMrp { get; set; }
        public int? PackingTypeId { get; set; }
        public int? StockId { get; set; }
        public bool? IsCancel { get; set; }
        public int? StoreStockId { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PhrmGoodsReceipt? GoodReceipt { get; set; }
        public virtual PhrmTxnStoreStock? StoreStock { get; set; }
        public virtual ICollection<PhrmReturnToSupplierItem> PhrmReturnToSupplierItems { get; set; }
        public virtual ICollection<PhrmStockTxnItem> PhrmStockTxnItems { get; set; }
    }
}
