using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InctvEmployeeIncentiveInfo
    {
        public int EmployeeIncentiveInfoId { get; set; }
        public int? EmployeeId { get; set; }
        public double? Tdspercent { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
