using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PatPatientMembership
    {
        public int PatientMembershipId { get; set; }
        public int PatientId { get; set; }
        public int MembershipTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual PatCfgMembershipType MembershipType { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual PatPatient Patient { get; set; } = null!;
    }
}
