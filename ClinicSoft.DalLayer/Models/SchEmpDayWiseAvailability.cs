using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class SchEmpDayWiseAvailability
    {
        public int? EmployeeId { get; set; }
        public int? DayId { get; set; }
        public string? DayName { get; set; }
        public bool? IsWorking { get; set; }

        public virtual EmpEmployee? Employee { get; set; }
    }
}
