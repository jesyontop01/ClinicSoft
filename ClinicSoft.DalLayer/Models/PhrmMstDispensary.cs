using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMstDispensary
    {
        public int DispensaryId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? ContactNo { get; set; }
        public string? Email { get; set; }
        public string? DispensaryLabel { get; set; }
        public string? DispensaryDescription { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public int? PermissionId { get; set; }
        public string? Type { get; set; }
    }
}
