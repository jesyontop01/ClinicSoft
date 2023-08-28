using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class LabGovReportMapping
    {
        public int ReportMapId { get; set; }
        public int? ReportItemId { get; set; }
        public int? LabItemId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsComponentBased { get; set; }
        public string? ComponentName { get; set; }
        public bool? IsResultCount { get; set; }
        public string? PositiveIndicator { get; set; }
        public int? ComponentId { get; set; }

        public virtual LabMstGovReportItem? ReportItem { get; set; }
    }
}
