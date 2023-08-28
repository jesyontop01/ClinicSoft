using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class LabTestCategory
    {
        public int TestCategoryId { get; set; }
        public string? TestCategoryName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDefault { get; set; }
        public int? PermissionId { get; set; }
        public bool? IsActive { get; set; }
    }
}
