using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class RbacApplication
    {
        public RbacApplication()
        {
            RbacPermissions = new HashSet<RbacPermission>();
            RbacRoles = new HashSet<RbacRole>();
        }

        public int ApplicationId { get; set; }
        public string? ApplicationCode { get; set; }
        public string ApplicationName { get; set; } = null!;
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<RbacPermission> RbacPermissions { get; set; }
        public virtual ICollection<RbacRole> RbacRoles { get; set; }
    }
}
