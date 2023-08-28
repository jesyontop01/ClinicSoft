using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccFiscalYearLog
    {
        public int LogId { get; set; }
        public int? FiscalYearId { get; set; }
        public string? LogType { get; set; }
        public string? LogDetails { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? HospitalId { get; set; }

        public virtual AccMstHospital? Hospital { get; set; }
    }
}
