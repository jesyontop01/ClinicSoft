using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class RbacMapUserRole
    {
        public int UserRoleMapId { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual RbacRole? Role { get; set; }
        public virtual RbacUser? User { get; set; }
    }
}
