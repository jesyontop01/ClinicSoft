using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnPrescriptionSlipSchrime
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public string? Od { get; set; }
        public string? Os { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
