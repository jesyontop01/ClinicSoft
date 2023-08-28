using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilTxnSettlement
    {
        public BilTxnSettlement()
        {
            BilTxnBillingTransactions = new HashSet<BilTxnBillingTransaction>();
        }

        public int SettlementId { get; set; }
        public int? FiscalYearId { get; set; }
        public int SettlementReceiptNo { get; set; }
        public DateTime? SettlementDate { get; set; }
        public string? SettlementType { get; set; }
        public int PatientId { get; set; }
        public double? PayableAmount { get; set; }
        public double? RefundableAmount { get; set; }
        public double? PaidAmount { get; set; }
        public double? ReturnedAmount { get; set; }
        public double? DepositDeducted { get; set; }
        public double? DueAmount { get; set; }
        public double? DiscountAmount { get; set; }
        public string? PaymentMode { get; set; }
        public string? PaymentDetails { get; set; }
        public int? CounterId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? Remarks { get; set; }
        public int? PrintCount { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? PrintedOn { get; set; }
        public int? PrintedBy { get; set; }
        public bool? IsCashDiscountSync { get; set; }
        public double? CollectionFromReceivable { get; set; }
        public double? DiscountReturnAmount { get; set; }

        public virtual ICollection<BilTxnBillingTransaction> BilTxnBillingTransactions { get; set; }
    }
}
