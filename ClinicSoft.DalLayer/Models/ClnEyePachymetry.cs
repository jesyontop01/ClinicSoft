using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnEyePachymetry
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public DateTime? Date { get; set; }
        public string? TimepointPre { get; set; }
        public string? Usmin { get; set; }
        public string? VisanteRst { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsOd { get; set; }
    }
}
