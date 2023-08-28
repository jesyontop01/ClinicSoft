using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnPurchaseOrder
    {
        public InvTxnPurchaseOrder()
        {
            InvTxnGoodsReceipts = new HashSet<InvTxnGoodsReceipt>();
            InvTxnPurchaseOrderItems = new HashSet<InvTxnPurchaseOrderItem>();
        }

        public int PurchaseOrderId { get; set; }
        public int? VendorId { get; set; }
        public DateTime? PoDate { get; set; }
        public string? Postatus { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? Vat { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? DeliveryAddress { get; set; }
        public int? CurrencyId { get; set; }
        public string? Poremark { get; set; }
        public string? TermsConditions { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsCancel { get; set; }
        public int? RequisitionId { get; set; }
        public bool? IsVerificationEnabled { get; set; }
        public string? VerifierIds { get; set; }
        public int? VerificationId { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? CancelledOn { get; set; }
        public string? CancelRemarks { get; set; }
        public int? InvoiceHeaderId { get; set; }
        public string? PerformanceInvoiceNo { get; set; }
        public string? Pocategory { get; set; }
        public int StoreId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? PogroupId { get; set; }
        public int? FiscalYearId { get; set; }
        public int? Ponumber { get; set; }
        public string? ReferenceNo { get; set; }
        public string? InvoicingAddress { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactPersonEmail { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual InvMstCurrency? Currency { get; set; }
        public virtual MstInvoiceHeader? InvoiceHeader { get; set; }
        public virtual PhrmMstStore Store { get; set; } = null!;
        public virtual InvMstVendor? Vendor { get; set; }
        public virtual ICollection<InvTxnGoodsReceipt> InvTxnGoodsReceipts { get; set; }
        public virtual ICollection<InvTxnPurchaseOrderItem> InvTxnPurchaseOrderItems { get; set; }
    }
}
