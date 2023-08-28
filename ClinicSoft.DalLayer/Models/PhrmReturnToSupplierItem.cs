using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmReturnToSupplierItem
    {
        public int ReturnToSupplierItemId { get; set; }
        public int ReturnToSupplierId { get; set; }
        public int? ItemId { get; set; }
        public int GoodReceiptItemId { get; set; }
        public string? BatchNo { get; set; }
        public double Quantity { get; set; }
        public decimal? ItemPrice { get; set; }
        public decimal? SubTotal { get; set; }
        public double? DiscountPercentage { get; set; }
        public double? Vatpercentage { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? ReturnRemarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal? Mrp { get; set; }
        public double FreeQuantity { get; set; }
        public decimal? FreeRate { get; set; }
        public decimal? FreeAmount { get; set; }
        public decimal? OldItemPrice { get; set; }
        public decimal? DiscountedAmount { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PhrmGoodsReceiptItem GoodReceiptItem { get; set; } = null!;
        public virtual PhrmReturnToSupplier ReturnToSupplier { get; set; } = null!;
    }
}
