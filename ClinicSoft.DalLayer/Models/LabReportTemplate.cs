using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class LabReportTemplate
    {
        public LabReportTemplate()
        {
            LabLabTests = new HashSet<LabLabTest>();
        }

        public int ReportTemplateId { get; set; }
        public string? ReportTemplateShortName { get; set; }
        public string? ReportTemplateName { get; set; }
        public string? TemplateFileName { get; set; }
        public string? NegativeTemplateFileName { get; set; }
        public bool? IsDefault { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? HeaderText { get; set; }
        public string? ColSettingsJson { get; set; }
        public string? TemplateType { get; set; }
        public string? TemplateHtml { get; set; }
        public string? Description { get; set; }
        public string? FooterText { get; set; }
        public int? DisplaySequence { get; set; }

        public virtual ICollection<LabLabTest> LabLabTests { get; set; }
    }
}
