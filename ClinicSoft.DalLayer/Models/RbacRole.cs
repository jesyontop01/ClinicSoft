using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class RbacRole
    {
        public RbacRole()
        {
            InvMstItems = new HashSet<InvMstItem>();
            RbacMapRolePermissions = new HashSet<RbacMapRolePermission>();
            RbacMapUserRoles = new HashSet<RbacMapUserRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string? RoleDescription { get; set; }
        public int? ApplicationId { get; set; }
        public bool? IsSysAdmin { get; set; }
        public bool? IsActive { get; set; }
        public int? RolePriority { get; set; }
        public int? DefaultRouteId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? RoleType { get; set; }

        public virtual RbacApplication? Application { get; set; }
        public virtual RbacRouteConfig? DefaultRoute { get; set; }
        public virtual ICollection<InvMstItem> InvMstItems { get; set; }
        public virtual ICollection<RbacMapRolePermission> RbacMapRolePermissions { get; set; }
        public virtual ICollection<RbacMapUserRole> RbacMapUserRoles { get; set; }
    }
}
