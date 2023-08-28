using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PatPatientVisit
    {
        public PatPatientVisit()
        {
            BilBillItemRequisitions = new HashSet<BilBillItemRequisition>();
            BilTxnBillingTransactionItems = new HashSet<BilTxnBillingTransactionItem>();
            BilTxnInvoiceReturnItems = new HashSet<BilTxnInvoiceReturnItem>();
            ClnInputOutputs = new HashSet<ClnInputOutput>();
            ClnNotes = new HashSet<ClnNote>();
            ClnNotesEmergencies = new HashSet<ClnNotesEmergency>();
            ClnPatientNotes = new HashSet<ClnPatientNote>();
            ClnPatientVitals = new HashSet<ClnPatientVital>();
            ErPatients = new HashSet<ErPatient>();
            InverseParentVisit = new HashSet<PatPatientVisit>();
            LabTestRequisitions = new HashSet<LabTestRequisition>();
            MrTxnInpatientDiagnoses = new HashSet<MrTxnInpatientDiagnosis>();
            MrTxnOutpatientFinalDiagnoses = new HashSet<MrTxnOutpatientFinalDiagnosis>();
            OtTxnBookingDetails = new HashSet<OtTxnBookingDetail>();
            OtTxnOtTeamsInfos = new HashSet<OtTxnOtTeamsInfo>();
            RadPatientImagingReports = new HashSet<RadPatientImagingReport>();
            RadPatientImagingRequisitions = new HashSet<RadPatientImagingRequisition>();
        }

        public int PatientVisitId { get; set; }
        public int PatientId { get; set; }
        public DateTime? VisitDate { get; set; }
        public string? ProviderName { get; set; }
        public string? Comments { get; set; }
        public string? ReferredByProvider { get; set; }
        public string? VisitType { get; set; }
        public string? VisitStatus { get; set; }
        public TimeSpan? VisitTime { get; set; }
        public int? VisitDuration { get; set; }
        public string? VisitCode { get; set; }
        public int? ProviderId { get; set; }
        public int? AppointmentId { get; set; }
        public string? BillingStatus { get; set; }
        public int? ReferredByProviderId { get; set; }
        public string? AppointmentType { get; set; }
        public int? ParentVisitId { get; set; }
        public bool? IsVisitContinued { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string? Remarks { get; set; }
        public bool? IsSignedVisitSummary { get; set; }
        public int? TransferredProviderId { get; set; }
        public long? ClaimCode { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? ConcludeDate { get; set; }
        public int? QueueNo { get; set; }
        public bool? IsTriaged { get; set; }
        public bool? InsHasInsurance { get; set; }
        public string? QueueStatus { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PatPatientVisit? ParentVisit { get; set; }
        public virtual PatPatient Patient { get; set; } = null!;
        public virtual AdtDischargeSummary? AdtDischargeSummary { get; set; }
        public virtual AdtPatientAdmission? AdtPatientAdmission { get; set; }
        public virtual ICollection<BilBillItemRequisition> BilBillItemRequisitions { get; set; }
        public virtual ICollection<BilTxnBillingTransactionItem> BilTxnBillingTransactionItems { get; set; }
        public virtual ICollection<BilTxnInvoiceReturnItem> BilTxnInvoiceReturnItems { get; set; }
        public virtual ICollection<ClnInputOutput> ClnInputOutputs { get; set; }
        public virtual ICollection<ClnNote> ClnNotes { get; set; }
        public virtual ICollection<ClnNotesEmergency> ClnNotesEmergencies { get; set; }
        public virtual ICollection<ClnPatientNote> ClnPatientNotes { get; set; }
        public virtual ICollection<ClnPatientVital> ClnPatientVitals { get; set; }
        public virtual ICollection<ErPatient> ErPatients { get; set; }
        public virtual ICollection<PatPatientVisit> InverseParentVisit { get; set; }
        public virtual ICollection<LabTestRequisition> LabTestRequisitions { get; set; }
        public virtual ICollection<MrTxnInpatientDiagnosis> MrTxnInpatientDiagnoses { get; set; }
        public virtual ICollection<MrTxnOutpatientFinalDiagnosis> MrTxnOutpatientFinalDiagnoses { get; set; }
        public virtual ICollection<OtTxnBookingDetail> OtTxnBookingDetails { get; set; }
        public virtual ICollection<OtTxnOtTeamsInfo> OtTxnOtTeamsInfos { get; set; }
        public virtual ICollection<RadPatientImagingReport> RadPatientImagingReports { get; set; }
        public virtual ICollection<RadPatientImagingRequisition> RadPatientImagingRequisitions { get; set; }
    }
}
