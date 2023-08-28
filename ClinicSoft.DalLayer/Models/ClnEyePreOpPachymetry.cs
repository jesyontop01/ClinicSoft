using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnEyePreOpPachymetry
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public string? Profile { get; set; }
        public int? PentMin { get; set; }
        public int? PentCentral { get; set; }
        public int? Usmin { get; set; }
        public int? VisanteMin { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsOd { get; set; }
    }
}
