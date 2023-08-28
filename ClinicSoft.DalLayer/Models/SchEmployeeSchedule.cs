using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class SchEmployeeSchedule
    {
        public int EmployeeSchid { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? Date { get; set; }
        public string? DayName { get; set; }
        public bool? IsWorkingDay { get; set; }
        public bool? IsPresent { get; set; }

        public virtual EmpEmployee? Employee { get; set; }
    }
}
