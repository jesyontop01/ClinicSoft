using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccTransactionItem
    {
        public int TransactionItemId { get; set; }
        public int? TransactionId { get; set; }
        public int? LedgerId { get; set; }
        public bool? DrCr { get; set; }
        public double? Amount { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public string? Description { get; set; }
        public int? HospitalId { get; set; }

        public virtual AccMstHospital? Hospital { get; set; }
        public virtual AccLedger? Ledger { get; set; }
        public virtual AccTransaction? Transaction { get; set; }
    }
}
