using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class OtTxnBookingDetail
    {
        public OtTxnBookingDetail()
        {
            OtTxnCheckListInfos = new HashSet<OtTxnCheckListInfo>();
            OtTxnOtTeamsInfos = new HashSet<OtTxnOtTeamsInfo>();
            OtTxnSummaries = new HashSet<OtTxnSummary>();
        }

        public int OtbookingId { get; set; }
        public int PatientId { get; set; }
        public int? PatientVisitId { get; set; }
        public DateTime? BookedForDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public string? SurgeryType { get; set; }
        public string? Diagnosis { get; set; }
        public string? ProcedureType { get; set; }
        public string? AnesthesiaType { get; set; }
        public string? Remarks { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? CancelledOn { get; set; }
        public string? CancellationRemarks { get; set; }
        public string? ConsentFormPath { get; set; }
        public string? PacformPath { get; set; }
        public bool? IsActive { get; set; }

        public virtual PatPatient Patient { get; set; } = null!;
        public virtual PatPatientVisit? PatientVisit { get; set; }
        public virtual ICollection<OtTxnCheckListInfo> OtTxnCheckListInfos { get; set; }
        public virtual ICollection<OtTxnOtTeamsInfo> OtTxnOtTeamsInfos { get; set; }
        public virtual ICollection<OtTxnSummary> OtTxnSummaries { get; set; }
    }
}
