using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnEyeLaserDataEntry
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public string? Profile { get; set; }
        public double? Sph { get; set; }
        public double? Cyf { get; set; }
        public int? Axis { get; set; }
        public string? Zone { get; set; }
        public string? Transmission { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsOd { get; set; }
    }
}
