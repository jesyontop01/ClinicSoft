using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class RadCfgReportTemplate
    {
        public int TemplateId { get; set; }
        public string? ModuleName { get; set; }
        public string? TemplateCode { get; set; }
        public string TemplateName { get; set; } = null!;
        public string TemplateHtml { get; set; } = null!;
        public string? FooterNote { get; set; }
        public string? Remarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
