using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PatCfgMembershipType
    {
        public PatCfgMembershipType()
        {
            PatPatientMemberships = new HashSet<PatPatientMembership>();
            PatPatients = new HashSet<PatPatient>();
        }

        public int MembershipTypeId { get; set; }
        public string MembershipTypeName { get; set; } = null!;
        public double DiscountPercent { get; set; }
        public string? Description { get; set; }
        public int? ExpiryMonths { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? CommunityName { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual ICollection<PatPatientMembership> PatPatientMemberships { get; set; }
        public virtual ICollection<PatPatient> PatPatients { get; set; }
    }
}
