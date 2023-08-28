using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmTxnInvoiceReturn
    {
        public PhrmTxnInvoiceReturn()
        {
            PhrmTxnInvoiceReturnItems = new HashSet<PhrmTxnInvoiceReturnItem>();
        }

        public int InvoiceReturnId { get; set; }
        public int? InvoiceId { get; set; }
        public int? PatientId { get; set; }
        public int? CounterId { get; set; }
        public int? CreditNoteId { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public decimal? Tender { get; set; }
        public decimal? Change { get; set; }
        public int? PrintCount { get; set; }
        public decimal? Adjustment { get; set; }
        public bool? IsRealtime { get; set; }
        public bool? IsRemoteSynced { get; set; }
        public int? FiscalYearId { get; set; }
        public bool? IsTransferredToAcc { get; set; }
        public string? PaymentMode { get; set; }
        public string? Remarks { get; set; }
        public int StoreId { get; set; }
        public long? ClaimCode { get; set; }
        public bool? IsManualReturn { get; set; }
        public string? ReferenceInvoiceNo { get; set; }
        public DateTime? ReferenceInvoiceDate { get; set; }
        public int? SettlementId { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PhrmTxnInvoice? Invoice { get; set; }
        public virtual PhrmMstStore Store { get; set; } = null!;
        public virtual ICollection<PhrmTxnInvoiceReturnItem> PhrmTxnInvoiceReturnItems { get; set; }
    }
}
