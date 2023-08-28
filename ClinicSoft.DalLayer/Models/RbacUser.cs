using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class RbacUser
    {
        public RbacUser()
        {
            RbacMapUserRoles = new HashSet<RbacMapUserRole>();
        }

        public int UserId { get; set; }
        public int? EmployeeId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Email { get; set; }
        public bool? NeedsPasswordUpdate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsActive { get; set; }
        public int? LandingPageRouteId { get; set; }

        public virtual EmpEmployee? Employee { get; set; }
        public virtual ICollection<RbacMapUserRole> RbacMapUserRoles { get; set; }
    }
}
