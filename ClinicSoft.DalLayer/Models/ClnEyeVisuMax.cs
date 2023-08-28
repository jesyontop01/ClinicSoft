using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnEyeVisuMax
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public int? Thickness { get; set; }
        public int? Diameter { get; set; }
        public string? Hinge { get; set; }
        public string? Glass { get; set; }
        public string? Sidecut { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsOd { get; set; }
    }
}
