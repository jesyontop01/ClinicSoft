using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class SchMapEmployeeShift
    {
        public int EmployeeShiftMapId { get; set; }
        public int? EmployeeId { get; set; }
        public int? ShiftId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual EmpEmployee? Employee { get; set; }
        public virtual SchMstShift? Shift { get; set; }
    }
}
