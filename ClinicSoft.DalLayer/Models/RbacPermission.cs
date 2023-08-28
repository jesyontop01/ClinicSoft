using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class RbacPermission
    {
        public RbacPermission()
        {
            RbacMapRolePermissions = new HashSet<RbacMapRolePermission>();
            RbacRouteConfigs = new HashSet<RbacRouteConfig>();
        }

        public int PermissionId { get; set; }
        public string PermissionName { get; set; } = null!;
        public string? Description { get; set; }
        public int? ApplicationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual RbacApplication? Application { get; set; }
        public virtual ICollection<RbacMapRolePermission> RbacMapRolePermissions { get; set; }
        public virtual ICollection<RbacRouteConfig> RbacRouteConfigs { get; set; }
    }
}
