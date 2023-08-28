using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvCfgFiscalYear
    {
        public InvCfgFiscalYear()
        {
            InvFiscalYearStocks = new HashSet<InvFiscalYearStock>();
        }

        public int FiscalYearId { get; set; }
        public string? FiscalYearName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? NpFiscalYearName { get; set; }
        public bool? IsClosed { get; set; }
        public DateTime? ClosedOn { get; set; }
        public int? ClosedBy { get; set; }

        public virtual ICollection<InvFiscalYearStock> InvFiscalYearStocks { get; set; }
    }
}
