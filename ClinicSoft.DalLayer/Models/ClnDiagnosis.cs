using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnDiagnosis
    {
        public ClnDiagnosis()
        {
            LabTestRequisitions = new HashSet<LabTestRequisition>();
            PhrmPrescriptionItems = new HashSet<PhrmPrescriptionItem>();
            RadPatientImagingRequisitions = new HashSet<RadPatientImagingRequisition>();
        }

        public int DiagnosisId { get; set; }
        public int? NotesId { get; set; }
        public int? PatientId { get; set; }
        public int? PatientVisitId { get; set; }
        public string? Icd10code { get; set; }
        public string? Icd10description { get; set; }
        public int? Icd10id { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<LabTestRequisition> LabTestRequisitions { get; set; }
        public virtual ICollection<PhrmPrescriptionItem> PhrmPrescriptionItems { get; set; }
        public virtual ICollection<RadPatientImagingRequisition> RadPatientImagingRequisitions { get; set; }
    }
}
