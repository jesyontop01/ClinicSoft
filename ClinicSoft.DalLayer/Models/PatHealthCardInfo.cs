using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PatHealthCardInfo
    {
        public int PatHealthCardId { get; set; }
        public int PatientId { get; set; }
        public string? InfoOnCardJson { get; set; }
        public DateTime? BillingDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public string? Remarks { get; set; }

        public virtual PatPatient Patient { get; set; } = null!;
    }
}
