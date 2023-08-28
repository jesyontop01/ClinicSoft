using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmPrescription
    {
        public int PrescriptionId { get; set; }
        public int? PatientId { get; set; }
        public int? ProviderId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? ProviderFullName { get; set; }
        public bool? IsInPatient { get; set; }
        public string? PrescriptionStatus { get; set; }
        public string? Notes { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PatPatient? Patient { get; set; }
        public virtual EmpEmployee? Provider { get; set; }
    }
}
