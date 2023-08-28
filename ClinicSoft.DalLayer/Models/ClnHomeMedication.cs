using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnHomeMedication
    {
        public int HomeMedicationId { get; set; }
        public int PatientId { get; set; }
        public DateTime? LastTaken { get; set; }
        public string? Route { get; set; }
        public string? Dose { get; set; }
        public string? Comments { get; set; }
        public int? MedicationId { get; set; }
        public string? OtherMedication { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? Frequency { get; set; }
        public string? MedicationType { get; set; }
        public int? PatientVisitId { get; set; }
        public int? FrequencyId { get; set; }
        public int? Days { get; set; }

        public virtual PatPatient Patient { get; set; } = null!;
    }
}
