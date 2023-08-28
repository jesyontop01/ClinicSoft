using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilTxnBillingTransaction
    {
        public BilTxnBillingTransaction()
        {
            BilTxnBillingTransactionItems = new HashSet<BilTxnBillingTransactionItem>();
            BilTxnInvoiceReturnItems = new HashSet<BilTxnInvoiceReturnItem>();
            BilTxnInvoiceReturns = new HashSet<BilTxnInvoiceReturn>();
        }

        public int BillingTransactionId { get; set; }
        public int? FiscalYearId { get; set; }
        public string? InvoiceCode { get; set; }
        public int? InvoiceNo { get; set; }
        public int PatientId { get; set; }
        public double? SubTotal { get; set; }
        public double? DiscountAmount { get; set; }
        public double? TaxableAmount { get; set; }
        public double? TaxTotal { get; set; }
        public double? TotalAmount { get; set; }
        public double? TotalQuantity { get; set; }
        public string? PaymentMode { get; set; }
        public string? PaymentDetails { get; set; }
        public string? TransactionType { get; set; }
        public string? BillStatus { get; set; }
        public double? PaidAmount { get; set; }
        public double? DiscountPercent { get; set; }
        public int? TaxId { get; set; }
        public int? PatientVisitId { get; set; }
        public DateTime? PaidDate { get; set; }
        public double? DepositAmount { get; set; }
        public double? DepositReturnAmount { get; set; }
        public double? DepositBalance { get; set; }
        public string? Remarks { get; set; }
        public int? CounterId { get; set; }
        public double? Tender { get; set; }
        public double? Change { get; set; }
        public int? PrintCount { get; set; }
        public int? SettlementId { get; set; }
        public bool? ReturnStatus { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public bool? IsRealtime { get; set; }
        public bool? IsRemoteSynced { get; set; }
        public double? NonTaxableAmount { get; set; }
        public int? PaymentReceivedBy { get; set; }
        public int? PaidCounterId { get; set; }
        public int? PackageId { get; set; }
        public string? PackageName { get; set; }
        public bool? IsInsuranceBilling { get; set; }
        public bool? IsInsuranceClaimed { get; set; }
        public DateTime? InsuranceClaimedDate { get; set; }
        public int? InsuranceProviderId { get; set; }
        public int? OrganizationId { get; set; }
        public double? ExchangeRate { get; set; }
        public DateTime? InsTransactionDate { get; set; }
        public DateTime? PrintedOn { get; set; }
        public int? PrintedBy { get; set; }
        public int? PartialReturnTxnId { get; set; }
        public decimal? AdjustmentTotalAmount { get; set; }
        public bool? IsCreditBillPaidSync { get; set; }
        public string? InvoiceType { get; set; }
        public string? LabTypeName { get; set; }
        public long? ClaimCode { get; set; }
        public double? DepositAvailable { get; set; }
        public double? DepositUsed { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual PatPatient Patient { get; set; } = null!;
        public virtual BilTxnSettlement? Settlement { get; set; }
        public virtual ICollection<BilTxnBillingTransactionItem> BilTxnBillingTransactionItems { get; set; }
        public virtual ICollection<BilTxnInvoiceReturnItem> BilTxnInvoiceReturnItems { get; set; }
        public virtual ICollection<BilTxnInvoiceReturn> BilTxnInvoiceReturns { get; set; }
    }
}
