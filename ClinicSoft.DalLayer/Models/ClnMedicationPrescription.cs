using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnMedicationPrescription
    {
        public int MedicationPrescriptionId { get; set; }
        public int PatientId { get; set; }
        public int MedicationId { get; set; }
        public int ProviderId { get; set; }
        public string Route { get; set; } = null!;
        public string Frequency { get; set; } = null!;
        public int Duration { get; set; }
        public string? DurationType { get; set; }
        public string? Dose { get; set; }
        public int? Refill { get; set; }
        public string? TypeofMedication { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual PatPatient Patient { get; set; } = null!;
        public virtual EmpEmployee Provider { get; set; } = null!;
    }
}
