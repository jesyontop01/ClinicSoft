using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MstRptDynamicReportName
    {
        public MstRptDynamicReportName()
        {
            MstRptDynamicReportingItems = new HashSet<MstRptDynamicReportingItem>();
        }

        public int DynamicReportId { get; set; }
        public string ReportName { get; set; } = null!;
        public string ReportCode { get; set; } = null!;
        public string ReportDescription { get; set; } = null!;
        public string Module { get; set; } = null!;
        public string? UsedInSpname { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }

        public virtual ICollection<MstRptDynamicReportingItem> MstRptDynamicReportingItems { get; set; }
    }
}
