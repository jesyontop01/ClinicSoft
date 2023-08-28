using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccLedgerBalanceHistory
    {
        public int LedgerBalanceHistoryId { get; set; }
        public int? FiscalYearId { get; set; }
        public int? LedgerId { get; set; }
        public double? OpeningBalance { get; set; }
        public bool? OpeningDrCr { get; set; }
        public double? ClosingBalance { get; set; }
        public bool? ClosingDrCr { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? HospitalId { get; set; }

        public virtual AccMstFiscalYear? FiscalYear { get; set; }
        public virtual AccMstHospital? Hospital { get; set; }
        public virtual AccLedger? Ledger { get; set; }
    }
}
