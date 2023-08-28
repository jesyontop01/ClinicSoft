using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class LabTestRequisition
    {
        public LabTestRequisition()
        {
            LabTxnTestComponentResults = new HashSet<LabTxnTestComponentResult>();
        }

        public long RequisitionId { get; set; }
        public int? PatientId { get; set; }
        public string? PatientName { get; set; }
        public long LabTestId { get; set; }
        public string? LabTestName { get; set; }
        public int? SampleCode { get; set; }
        public string? LabTestSpecimen { get; set; }
        public string? LabTestSpecimenSource { get; set; }
        public int? PatientVisitId { get; set; }
        public DateTime? OrderDateTime { get; set; }
        public int? ProviderId { get; set; }
        public string? ProviderName { get; set; }
        public string? BillingStatus { get; set; }
        public string? OrderStatus { get; set; }
        public int? SampleCreatedBy { get; set; }
        public DateTime? SampleCreatedOn { get; set; }
        public string? Urgency { get; set; }
        public string? Comments { get; set; }
        public string? Diagnosis { get; set; }
        public string? ProcedureCode { get; set; }
        public string? Loinc { get; set; }
        public string? RequisitionRemarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DiagnosisId { get; set; }
        public int ReportTemplateId { get; set; }
        public bool? IsActive { get; set; }
        public string? VisitType { get; set; }
        public string? RunNumberType { get; set; }
        public int? LabReportId { get; set; }
        public long? BarCodeNumber { get; set; }
        public string? WardName { get; set; }
        public bool? IsVerified { get; set; }
        public int? VerifiedBy { get; set; }
        public DateTime? VerifiedOn { get; set; }
        public int? ResultingVendorId { get; set; }
        public bool? HasInsurance { get; set; }
        public int? ResultAddedBy { get; set; }
        public DateTime? ResultAddedOn { get; set; }
        public int? PrintedBy { get; set; }
        public int? PrintCount { get; set; }
        public string? SampleCodeFormatted { get; set; }
        public DateTime? SampleCollectedOnDateTime { get; set; }
        public int? BillCancelledBy { get; set; }
        public DateTime? BillCancelledOn { get; set; }
        public string? LabTypeName { get; set; }
        public bool? IsSmsSend { get; set; }
        public string? GoogleFileIdForCovid { get; set; }
        public string? CovidFileName { get; set; }
        public bool? IsFileUploaded { get; set; }
        public DateTime? UploadedOn { get; set; }
        public int? UploadedBy { get; set; }
        public bool? IsFileUploadedToTeleMedicine { get; set; }
        public int? UploadedByToTeleMedicine { get; set; }
        public DateTime? UploadedOnToTeleMedicine { get; set; }

        public virtual LabBarCode? BarCodeNumberNavigation { get; set; }
        public virtual ClnDiagnosis? DiagnosisNavigation { get; set; }
        public virtual LabLabTest LabTest { get; set; } = null!;
        public virtual PatPatient? Patient { get; set; }
        public virtual PatPatientVisit? PatientVisit { get; set; }
        public virtual EmpEmployee? Provider { get; set; }
        public virtual ICollection<LabTxnTestComponentResult> LabTxnTestComponentResults { get; set; }
    }
}
