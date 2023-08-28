using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmTxnInvoice
    {
        public PhrmTxnInvoice()
        {
            PhrmTxnInvoiceItems = new HashSet<PhrmTxnInvoiceItem>();
            PhrmTxnInvoiceReturnItems = new HashSet<PhrmTxnInvoiceReturnItem>();
            PhrmTxnInvoiceReturns = new HashSet<PhrmTxnInvoiceReturn>();
        }

        public int InvoiceId { get; set; }
        public int? PatientId { get; set; }
        public int? CounterId { get; set; }
        public bool? IsOutdoorPat { get; set; }
        public double? TotalQuantity { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public string? BilStatus { get; set; }
        public decimal? CreditAmount { get; set; }
        public string? Remark { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public decimal? Tender { get; set; }
        public decimal? Change { get; set; }
        public int? PrintCount { get; set; }
        public decimal? Adjustment { get; set; }
        public int? InvoicePrintId { get; set; }
        public bool? IsReturn { get; set; }
        public bool? IsRealtime { get; set; }
        public bool? IsRemoteSynced { get; set; }
        public int? FiscalYearId { get; set; }
        public bool? IsTransferredToAcc { get; set; }
        public int? ProviderId { get; set; }
        public string? VisitType { get; set; }
        public decimal? DepositDeductAmount { get; set; }
        public string? PaymentMode { get; set; }
        public int? SettlementId { get; set; }
        public DateTime? PaidDate { get; set; }
        public DateTime? CreditDate { get; set; }
        public int? OrganizationId { get; set; }
        public int StoreId { get; set; }
        public long? ClaimCode { get; set; }
        public double? DiscountPer { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PatPatient? Patient { get; set; }
        public virtual PhrmMstStore Store { get; set; } = null!;
        public virtual ICollection<PhrmTxnInvoiceItem> PhrmTxnInvoiceItems { get; set; }
        public virtual ICollection<PhrmTxnInvoiceReturnItem> PhrmTxnInvoiceReturnItems { get; set; }
        public virtual ICollection<PhrmTxnInvoiceReturn> PhrmTxnInvoiceReturns { get; set; }
    }
}
