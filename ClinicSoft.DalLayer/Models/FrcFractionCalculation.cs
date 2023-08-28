using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class FrcFractionCalculation
    {
        public int FractionCalculationId { get; set; }
        public int PercentSettingId { get; set; }
        public int BillTxnItemId { get; set; }
        public int DoctorId { get; set; }
        public int? IsParentId { get; set; }
        public int DesignationId { get; set; }
        public decimal? InitialPercent { get; set; }
        public decimal? FinalPercent { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public decimal? FinalAmount { get; set; }
        public int? Hierarchy { get; set; }

        public virtual BilTxnBillingTransactionItem BillTxnItem { get; set; } = null!;
        public virtual FrcDesignation Designation { get; set; } = null!;
        public virtual EmpEmployee Doctor { get; set; } = null!;
        public virtual FrcPercentSetting PercentSetting { get; set; } = null!;
    }
}
