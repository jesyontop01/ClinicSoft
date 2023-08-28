using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MrTxnInpatientDiagnosis
    {
        public int DiagnosisId { get; set; }
        public int PatientId { get; set; }
        public int PatientVisitId { get; set; }
        public int MedicalRecordId { get; set; }
        public int Icd10id { get; set; }
        public string Icd10code { get; set; } = null!;
        public string Icd10name { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedBy { get; set; }
        public int? ModifiedOn { get; set; }
        public bool IsActive { get; set; }

        public virtual MstIcd10 Icd10 { get; set; } = null!;
        public virtual MrRecordSummary MedicalRecord { get; set; } = null!;
        public virtual PatPatient Patient { get; set; } = null!;
        public virtual PatPatientVisit PatientVisit { get; set; } = null!;
    }
}
