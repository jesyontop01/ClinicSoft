using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class IcdReportingGroup
    {
        public IcdReportingGroup()
        {
            IcdDiseaseGroups = new HashSet<IcdDiseaseGroup>();
        }

        public int ReportingGroupId { get; set; }
        public int SerialNumber { get; set; }
        public string ReportingGroupName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
        public string? GroupCode { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<IcdDiseaseGroup> IcdDiseaseGroups { get; set; }
    }
}
