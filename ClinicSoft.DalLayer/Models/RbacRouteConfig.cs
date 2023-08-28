using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class RbacRouteConfig
    {
        public RbacRouteConfig()
        {
            RbacRoles = new HashSet<RbacRole>();
        }

        public int RouteId { get; set; }
        public string? RouteName { get; set; }
        public string? RouteDescription { get; set; }
        public string DisplayName { get; set; } = null!;
        public string? UrlFullPath { get; set; }
        public string? RouterLink { get; set; }
        public int? PermissionId { get; set; }
        public int? ParentRouteId { get; set; }
        public string? Css { get; set; }
        public bool? DefaultShow { get; set; }
        public int? DisplaySeq { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsSecondaryNavInDropdown { get; set; }

        public virtual RbacPermission? Permission { get; set; }
        public virtual ICollection<RbacRole> RbacRoles { get; set; }
    }
}
