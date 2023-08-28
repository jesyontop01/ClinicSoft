using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class SchMstShift
    {
        public SchMstShift()
        {
            SchMapEmployeeShifts = new HashSet<SchMapEmployeeShift>();
        }

        public int ShiftId { get; set; }
        public string? ShiftName { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public double? TotalHrs { get; set; }
        public bool? IsDefault { get; set; }

        public virtual ICollection<SchMapEmployeeShift> SchMapEmployeeShifts { get; set; }
    }
}
