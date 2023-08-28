using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccReverseTransaction
    {
        public int ReverseTransactionId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? Section { get; set; }
        public int? Tuid { get; set; }
        public string? Reason { get; set; }
        public string? JsonData { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? FiscalYearId { get; set; }
        public int? HospitalId { get; set; }

        public virtual AccMstHospital? Hospital { get; set; }
    }
}
