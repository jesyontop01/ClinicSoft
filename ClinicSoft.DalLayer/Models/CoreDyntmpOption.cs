using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class CoreDyntmpOption
    {
        public int OptionId { get; set; }
        public string? Text { get; set; }
        public int? QuestionId { get; set; }
        public bool? IsDefault { get; set; }
        public bool? ShowChildOnSelect { get; set; }
        public bool? IsActive { get; set; }

        public virtual CoreDyntmpQuestion? Question { get; set; }
    }
}
