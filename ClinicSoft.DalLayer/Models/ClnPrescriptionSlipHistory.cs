using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnPrescriptionSlipHistory
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public string? History { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
