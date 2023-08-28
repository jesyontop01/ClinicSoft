using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ProllAttendanceDailyTimeRecord
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? RecordDateTime { get; set; }
    }
}
