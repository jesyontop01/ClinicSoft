using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class CoreDyntmpTemplate
    {
        public CoreDyntmpTemplate()
        {
            CoreDyntmpQuestionnaires = new HashSet<CoreDyntmpQuestionnaire>();
        }

        public int TemplateId { get; set; }
        public string? Code { get; set; }
        public string? Text { get; set; }
        public string? ModuleName { get; set; }

        public virtual ICollection<CoreDyntmpQuestionnaire> CoreDyntmpQuestionnaires { get; set; }
    }
}
