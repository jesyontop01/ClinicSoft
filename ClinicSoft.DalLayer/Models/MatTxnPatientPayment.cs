using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MatTxnPatientPayment
    {
        public int PatientPaymentId { get; set; }
        public int FiscalYearId { get; set; }
        public int? ReceiptNo { get; set; }
        public string? TransactionType { get; set; }
        public int PatientId { get; set; }
        public double? InAmount { get; set; }
        public double? OutAmount { get; set; }
        public string? Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual BilCfgFiscalYear FiscalYear { get; set; } = null!;
        public virtual PatPatient Patient { get; set; } = null!;
    }
}
