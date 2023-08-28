using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MstRptDynamicReportingItem
    {
        public int ReportingItemsId { get; set; }
        public string? ReportingItemName { get; set; }
        public int DynamicReportId { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? RptCountUnit { get; set; }

        public virtual MstRptDynamicReportName DynamicReport { get; set; } = null!;
    }
}
