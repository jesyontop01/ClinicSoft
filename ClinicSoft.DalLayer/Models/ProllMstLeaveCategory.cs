using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ProllMstLeaveCategory
    {
        public int LeaveCategoryId { get; set; }
        public string LeaveCategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public string CategoryCode { get; set; } = null!;
    }
}
