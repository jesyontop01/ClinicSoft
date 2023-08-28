using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ProllMstWeekendHoliday
    {
        public int WeekendHolidayId { get; set; }
        public int Year { get; set; }
        public string? DayName { get; set; }
        public string? Value { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ApprovedBy { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsActive { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? Description { get; set; }
    }
}
