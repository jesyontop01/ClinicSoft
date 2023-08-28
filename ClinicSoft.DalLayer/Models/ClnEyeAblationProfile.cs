using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnEyeAblationProfile
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public string? Profile { get; set; }
        public string? Dzpfactor { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsOd { get; set; }
        public string? Notes { get; set; }
        public bool IsSxdone { get; set; }
        public bool IsPtkperformed { get; set; }
    }
}
