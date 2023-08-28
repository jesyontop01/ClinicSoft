using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccLedger
    {
        public AccLedger()
        {
            AccLedgerBalanceHistories = new HashSet<AccLedgerBalanceHistory>();
            AccTransactionItems = new HashSet<AccTransactionItem>();
        }

        public int LedgerId { get; set; }
        public int? LedgerGroupId { get; set; }
        public string LedgerName { get; set; } = null!;
        public string? Description { get; set; }
        public int? SectionId { get; set; }
        public int? LedgerReferenceId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsCostCenterApplicable { get; set; }
        public double? OpeningBalance { get; set; }
        public bool? DrCr { get; set; }
        public string? Name { get; set; }
        public string? LedgerType { get; set; }
        public string? Code { get; set; }
        public string? Panno { get; set; }
        public string? Address { get; set; }
        public string? MobileNo { get; set; }
        public int? CreditPeriod { get; set; }
        public decimal? Tdspercent { get; set; }
        public string? LandlineNo { get; set; }
        public string? MigrationStatus { get; set; }
        public int? HospitalId { get; set; }
        public string? MigrationRemark { get; set; }

        public virtual AccMstHospital? Hospital { get; set; }
        public virtual ICollection<AccLedgerBalanceHistory> AccLedgerBalanceHistories { get; set; }
        public virtual ICollection<AccTransactionItem> AccTransactionItems { get; set; }
    }
}
