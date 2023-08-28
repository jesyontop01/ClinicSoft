using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ProllEmpLeave
    {
        public int EmpLeaveId { get; set; }
        public int LeaveRuleId { get; set; }
        public DateTime Date { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int RequestedTo { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        /// <summary>
        /// Shows leave status of the employee like pending, cancel, approved, approvedCancel
        /// </summary>
        public string LeaveStatus { get; set; } = null!;
        public int EmployeeId { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? CancelledOn { get; set; }
    }
}
