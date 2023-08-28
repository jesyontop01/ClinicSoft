using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class LabMstGovReportItem
    {
        public LabMstGovReportItem()
        {
            LabGovReportMappings = new HashSet<LabGovReportMapping>();
        }

        public int ReportItemId { get; set; }
        public int? SerialNumber { get; set; }
        public string? TestName { get; set; }
        public string? GroupName { get; set; }
        public string? DisplayName { get; set; }
        public bool? HasInnerItems { get; set; }
        public string? InnerTestGroupName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<LabGovReportMapping> LabGovReportMappings { get; set; }
    }
}
