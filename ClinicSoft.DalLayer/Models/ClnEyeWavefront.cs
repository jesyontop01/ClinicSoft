using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnEyeWavefront
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public DateTime? Date { get; set; }
        public string? Timepoint { get; set; }
        public string? Coma { get; set; }
        public string? SphAb { get; set; }
        public string? HoRms { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsOd { get; set; }
    }
}
