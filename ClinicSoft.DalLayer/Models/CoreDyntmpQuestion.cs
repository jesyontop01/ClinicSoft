using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class CoreDyntmpQuestion
    {
        public CoreDyntmpQuestion()
        {
            CoreDyntmpOptions = new HashSet<CoreDyntmpOption>();
        }

        public int QuestionId { get; set; }
        public int? TemplateId { get; set; }
        public int? QnairId { get; set; }
        public string? Text { get; set; }
        public string? Type { get; set; }
        public int? ParentQtnId { get; set; }
        public bool? ShowChilds { get; set; }
        public int? DisplaySeq { get; set; }

        public virtual CoreDyntmpQuestionnaire? Qnair { get; set; }
        public virtual ICollection<CoreDyntmpOption> CoreDyntmpOptions { get; set; }
    }
}
