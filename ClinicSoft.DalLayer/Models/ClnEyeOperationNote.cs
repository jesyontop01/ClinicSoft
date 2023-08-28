using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnEyeOperationNote
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public string? Notes { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsOd { get; set; }
    }
}
