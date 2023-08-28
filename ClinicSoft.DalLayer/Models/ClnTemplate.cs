using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnTemplate
    {
        public int TemplateId { get; set; }
        public string? TemplateName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsForNursing { get; set; }
    }
}
