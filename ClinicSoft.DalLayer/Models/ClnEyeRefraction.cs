using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnEyeRefraction
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public DateTime? Date { get; set; }
        public string? TimePoint { get; set; }
        public int? Ucva { get; set; }
        public string? Ulett { get; set; }
        public string? Nuc { get; set; }
        public double? Sph { get; set; }
        public double? Cyf { get; set; }
        public int? Axis { get; set; }
        public int? Bscva { get; set; }
        public string? Blett { get; set; }
        public string? Dcnv { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsOd { get; set; }
    }
}
