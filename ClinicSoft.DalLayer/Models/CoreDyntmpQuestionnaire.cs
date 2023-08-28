using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class CoreDyntmpQuestionnaire
    {
        public CoreDyntmpQuestionnaire()
        {
            CoreDyntmpQuestions = new HashSet<CoreDyntmpQuestion>();
        }

        public int QnairId { get; set; }
        public string? Text { get; set; }
        public int? TemplateId { get; set; }
        public int? DisplaySeq { get; set; }

        public virtual CoreDyntmpTemplate? Template { get; set; }
        public virtual ICollection<CoreDyntmpQuestion> CoreDyntmpQuestions { get; set; }
    }
}
