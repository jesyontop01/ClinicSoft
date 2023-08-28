using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AdtDischargeType
    {
        public AdtDischargeType()
        {
            AdtDischargeSummaries = new HashSet<AdtDischargeSummary>();
            AdtMstDeathTypes = new HashSet<AdtMstDeathType>();
            AdtMstDischargeConditionTypes = new HashSet<AdtMstDischargeConditionType>();
        }

        public int DischargeTypeId { get; set; }
        public string DischargeTypeName { get; set; } = null!;
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual ICollection<AdtDischargeSummary> AdtDischargeSummaries { get; set; }
        public virtual ICollection<AdtMstDeathType> AdtMstDeathTypes { get; set; }
        public virtual ICollection<AdtMstDischargeConditionType> AdtMstDischargeConditionTypes { get; set; }
    }
}
