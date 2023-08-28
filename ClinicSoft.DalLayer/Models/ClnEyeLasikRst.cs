using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnEyeLasikRst
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public string? PachymetryMicrons { get; set; }
        public string? PachymetryNotes { get; set; }
        public string? FlapDepthMicrons { get; set; }
        public string? FlapDepthNotes { get; set; }
        public string? AblationDepthMicrons { get; set; }
        public string? AblationDepthNotes { get; set; }
        public string? PredictedRstmicrons { get; set; }
        public string? PredictedRstnotes { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsOd { get; set; }
    }
}
