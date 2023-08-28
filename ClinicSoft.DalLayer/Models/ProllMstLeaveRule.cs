using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ProllMstLeaveRule
    {
        public int LeaveRuleId { get; set; }
        public int LeaveCategoryId { get; set; }
        public int Year { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
        public bool? IsApproved { get; set; }
        public int ApprovedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public double? PayPercent { get; set; }
        public int Days { get; set; }
    }
}
