using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MrTxnOutpatientFinalDiagnosis
    {
        public int FinalDiagnosisId { get; set; }
        public int PatientId { get; set; }
        public int PatientVisitId { get; set; }
        public int Icd10id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsActive { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual MstIcd10 Icd10 { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual PatPatient Patient { get; set; } = null!;
        public virtual PatPatientVisit PatientVisit { get; set; } = null!;
    }
}
