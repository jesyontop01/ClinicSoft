using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmGoodsReceipt
    {
        public PhrmGoodsReceipt()
        {
            PhrmGoodsReceiptItems = new HashSet<PhrmGoodsReceiptItem>();
            PhrmReturnToSuppliers = new HashSet<PhrmReturnToSupplier>();
        }

        public int GoodReceiptId { get; set; }
        public int? PurchaseOrderId { get; set; }
        public int? SupplierId { get; set; }
        public DateTime? GoodReceiptDate { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? Remarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal? Vatamount { get; set; }
        public string? InvoiceNo { get; set; }
        public decimal? Adjustment { get; set; }
        public int? GoodReceiptPrintId { get; set; }
        public bool? IsCancel { get; set; }
        public bool? IsTransferredToAcc { get; set; }
        public int? StoreId { get; set; }
        public string? TransactionType { get; set; }
        public int? CreditPeriod { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? FiscalYearId { get; set; }
        public string? CancelRemarks { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? CancelledOn { get; set; }
        public bool? IsPacking { get; set; }
        public bool? IsItemDiscountApplicable { get; set; }
        public int? CancelBy { get; set; }
        public DateTime? CancelOn { get; set; }
        public string? PaymentStatus { get; set; }
        public DateTime? SupplierBillDate { get; set; }
        public bool IsPaymentDoneFromAcc { get; set; }
        public double? DiscountPercentage { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PhrmPurchaseOrder? PurchaseOrder { get; set; }
        public virtual PhrmMstSupplier? Supplier { get; set; }
        public virtual ICollection<PhrmGoodsReceiptItem> PhrmGoodsReceiptItems { get; set; }
        public virtual ICollection<PhrmReturnToSupplier> PhrmReturnToSuppliers { get; set; }
    }
}
