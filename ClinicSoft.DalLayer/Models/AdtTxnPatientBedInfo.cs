using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AdtTxnPatientBedInfo
    {
        public int PatientBedInfoId { get; set; }
        public int PatientVisitId { get; set; }
        public int PatientId { get; set; }
        public int WardId { get; set; }
        public int BedId { get; set; }
        public int BedFeatureId { get; set; }
        public double? BedPrice { get; set; }
        public string? Action { get; set; }
        public string? Remarks { get; set; }
        public DateTime StartedOn { get; set; }
        public DateTime? EndedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public int? RequestingDeptId { get; set; }
        public int? BedQuantity { get; set; }
        public int? SecondaryDoctorId { get; set; }
        public string? OutAction { get; set; }
        public int? ReceivedBy { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? BedOnHoldEnabled { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? CancelledOn { get; set; }
        public string? CancelRemarks { get; set; }

        public virtual AdtBed Bed { get; set; } = null!;
        public virtual AdtMstBedFeature BedFeature { get; set; } = null!;
        public virtual AdtMstWard Ward { get; set; } = null!;
    }
}
