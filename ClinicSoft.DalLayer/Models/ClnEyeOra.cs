using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnEyeOra
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public DateTime? Date { get; set; }
        public string? Timepoint { get; set; }
        public string? Iopcc { get; set; }
        public string? Crf { get; set; }
        public string? Ch { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsOd { get; set; }
    }
}
