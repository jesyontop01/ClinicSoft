using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ErDischargeSummary
    {
        public int ErdischargeSummaryId { get; set; }
        public int? PatientId { get; set; }
        public int? PatientVisitId { get; set; }
        public string? DischargeType { get; set; }
        public string? ChiefComplaints { get; set; }
        public string? TreatmentInEr { get; set; }
        public string? Investigations { get; set; }
        public string? AdviceOnDischarge { get; set; }
        public string? OnExamination { get; set; }
        public string? ProvisionalDiagnosis { get; set; }
        public string? DoctorName { get; set; }
        public string? MedicalOfficer { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
