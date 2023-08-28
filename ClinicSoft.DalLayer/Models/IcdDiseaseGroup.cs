using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class IcdDiseaseGroup
    {
        public IcdDiseaseGroup()
        {
            MstIcd10s = new HashSet<MstIcd10>();
        }

        public int DiseaseGroupId { get; set; }
        public int SerialNumber { get; set; }
        public string Icdcode { get; set; } = null!;
        public string DiseaseGroupName { get; set; } = null!;
        public int ReportingGroupId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual IcdReportingGroup ReportingGroup { get; set; } = null!;
        public virtual ICollection<MstIcd10> MstIcd10s { get; set; }
    }
}
