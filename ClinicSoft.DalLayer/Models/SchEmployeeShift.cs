using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class SchEmployeeShift
    {
        public int EmpShiftId { get; set; }
        public int? EmployeeId { get; set; }
        public string? ShiftName { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }

        public virtual EmpEmployee? Employee { get; set; }
    }
}
