using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccMstFiscalYear
    {
        public AccMstFiscalYear()
        {
            AccLedgerBalanceHistories = new HashSet<AccLedgerBalanceHistory>();
        }

        public int FiscalYearId { get; set; }
        public string FiscalYearName { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public string? NpFiscalYearName { get; set; }
        public bool? IsClosed { get; set; }
        public DateTime? ClosedOn { get; set; }
        public int? ClosedBy { get; set; }
        public bool? ReadyToClose { get; set; }
        public int? HospitalId { get; set; }

        public virtual AccMstHospital? Hospital { get; set; }
        public virtual ICollection<AccLedgerBalanceHistory> AccLedgerBalanceHistories { get; set; }
    }
}
