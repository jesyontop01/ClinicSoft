using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ProllDailyMuster
    {
        public long DailyMusterId { get; set; }
        public long EmployeeId { get; set; }
        public bool Present { get; set; }
        public string? AttStatus { get; set; }
        public string? ColorCode { get; set; }
        public TimeSpan? TimeIn { get; set; }
        public TimeSpan? TimeOut { get; set; }
        public int? Day { get; set; }
        public int? Month { get; set; }
        public long? Year { get; set; }
        public decimal? HoursInDay { get; set; }
    }
}
