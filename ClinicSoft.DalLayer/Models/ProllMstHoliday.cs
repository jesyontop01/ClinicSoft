using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ProllMstHoliday
    {
        public int HolidayId { get; set; }
        public int FiscalYearId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
        public int ApprovedBy { get; set; }
        public DateTime Date { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
