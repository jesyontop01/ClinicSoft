using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class RadPatientImagingRequisition
    {
        public RadPatientImagingRequisition()
        {
            RadPatientImagingReports = new HashSet<RadPatientImagingReport>();
        }

        public int ImagingRequisitionId { get; set; }
        public int? PatientVisitId { get; set; }
        public int? PatientId { get; set; }
        public string? ProviderName { get; set; }
        public int? ImagingTypeId { get; set; }
        public string? ImagingTypeName { get; set; }
        public int ImagingItemId { get; set; }
        public string? ImagingItemName { get; set; }
        public string? ProcedureCode { get; set; }
        public string? RequisitionRemarks { get; set; }
        public string? OrderStatus { get; set; }
        public DateTime? ImagingDate { get; set; }
        public int? ProviderId { get; set; }
        public string? BillingStatus { get; set; }
        public string? Urgency { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DiagnosisId { get; set; }
        public bool? HasInsurance { get; set; }
        public string? WardName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsScanned { get; set; }
        public int? ScannedBy { get; set; }
        public DateTime? ScannedOn { get; set; }
        public string? ScanRemarks { get; set; }
        public int? BillCancelledBy { get; set; }
        public DateTime? BillCancelledOn { get; set; }
        public int? FilmTypeId { get; set; }
        public int? FilmQuantity { get; set; }
        public bool IsReportSaved { get; set; }

        public virtual ClnDiagnosis? Diagnosis { get; set; }
        public virtual RadMstImagingItem ImagingItem { get; set; } = null!;
        public virtual PatPatientVisit? PatientVisit { get; set; }
        public virtual ICollection<RadPatientImagingReport> RadPatientImagingReports { get; set; }
    }
}
