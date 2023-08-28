using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class RadPatientImagingReport
    {
        public int ImagingReportId { get; set; }
        public int? ImagingRequisitionId { get; set; }
        public int? PatientId { get; set; }
        public int? PatientVisitId { get; set; }
        public string? ProviderName { get; set; }
        public int? ImagingTypeId { get; set; }
        public string? ImagingTypeName { get; set; }
        public int? ImagingItemId { get; set; }
        public string? ImagingItemName { get; set; }
        public string? ImageFullPath { get; set; }
        public string? ImageName { get; set; }
        public string? ReportText { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? OrderStatus { get; set; }
        public int? ReportingDoctorId { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ReportTemplateId { get; set; }
        public string? PatientStudyId { get; set; }
        public string? Signatories { get; set; }
        public string? Indication { get; set; }
        public string? RadiologyNo { get; set; }

        public virtual RadMstImagingItem? ImagingItem { get; set; }
        public virtual RadPatientImagingRequisition? ImagingRequisition { get; set; }
        public virtual PatPatient? Patient { get; set; }
        public virtual PatPatientVisit? PatientVisit { get; set; }
    }
}
