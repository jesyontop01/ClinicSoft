using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnPrescriptionSlipAdviceDiagnosis
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public string? AdviceDiagnosis { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
