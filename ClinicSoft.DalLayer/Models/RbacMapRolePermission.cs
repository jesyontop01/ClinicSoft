using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class RbacMapRolePermission
    {
        public int RolePermissionMapId { get; set; }
        public int? RoleId { get; set; }
        public int? PermissionId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual RbacPermission? Permission { get; set; }
        public virtual RbacRole? Role { get; set; }
    }
}
