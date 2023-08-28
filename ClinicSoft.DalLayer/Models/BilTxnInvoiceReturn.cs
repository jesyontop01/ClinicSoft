using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilTxnInvoiceReturn
    {
        public BilTxnInvoiceReturn()
        {
            BilTxnInvoiceReturnItems = new HashSet<BilTxnInvoiceReturnItem>();
        }

        public int BillReturnId { get; set; }
        public int? CreditNoteNumber { get; set; }
        public int? FiscalYearId { get; set; }
        public string? InvoiceCode { get; set; }
        public int? RefInvoiceNum { get; set; }
        public int PatientId { get; set; }
        public int? BillingTransactionId { get; set; }
        public double? SubTotal { get; set; }
        public double? DiscountAmount { get; set; }
        public double? TaxableAmount { get; set; }
        public double? TaxTotal { get; set; }
        public double? TotalAmount { get; set; }
        public string? Remarks { get; set; }
        public int? CounterId { get; set; }
        public bool? IsActive { get; set; }
        public int? TaxId { get; set; }
        public string? FiscalYear { get; set; }
        public bool? IsRemoteSynced { get; set; }
        public bool? IsRealtime { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? PaymentMode { get; set; }
        public bool? IsInsuranceBilling { get; set; }
        public int? InsuranceProviderId { get; set; }
        public string? BillStatus { get; set; }
        public int? SettlementId { get; set; }

        public virtual BilTxnBillingTransaction? BillingTransaction { get; set; }
        public virtual BilCfgCounter? Counter { get; set; }
        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual BilCfgFiscalYear? FiscalYearNavigation { get; set; }
        public virtual PatPatient Patient { get; set; } = null!;
        public virtual ICollection<BilTxnInvoiceReturnItem> BilTxnInvoiceReturnItems { get; set; }
    }
}
