using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilTxnDeposit
    {
        public int DepositId { get; set; }
        public int? FiscalYearId { get; set; }
        public int? ReceiptNo { get; set; }
        public int? PatientVisitId { get; set; }
        public int PatientId { get; set; }
        public string? DepositType { get; set; }
        public double Amount { get; set; }
        public string? Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CounterId { get; set; }
        public int? PrintCount { get; set; }
        public string? PaymentMode { get; set; }
        public string? PaymentDetails { get; set; }
        public int? BillingTransactionId { get; set; }
        public int? SettlementId { get; set; }
        public double? DepositBalance { get; set; }
        public string? CareOf { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsTransferTransaction { get; set; }
        public string? ModifiedRemarks { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? PrintedOn { get; set; }
        public int? PrintedBy { get; set; }
        public bool? IsDepositSync { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual PatPatient Patient { get; set; } = null!;
    }
}
