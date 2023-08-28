using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccMstLedgerGroup
    {
        public AccMstLedgerGroup()
        {
            AccMstMappingDetails = new HashSet<AccMstMappingDetail>();
        }

        public int LedgerGroupId { get; set; }
        public string? PrimaryGroup { get; set; }
        public string? Coa { get; set; }
        public string? LedgerGroupName { get; set; }
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int? HospitalId { get; set; }
        public int? Coaid { get; set; }

        public virtual AccMstHospital? Hospital { get; set; }
        public virtual ICollection<AccMstMappingDetail> AccMstMappingDetails { get; set; }
    }
}
