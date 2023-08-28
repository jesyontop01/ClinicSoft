using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class EmpEmployeePreference
    {
        public int PreferenceId { get; set; }
        public string? PreferenceName { get; set; }
        public string? PreferenceValue { get; set; }
        public int EmployeeId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual EmpEmployee Employee { get; set; } = null!;
    }
}
