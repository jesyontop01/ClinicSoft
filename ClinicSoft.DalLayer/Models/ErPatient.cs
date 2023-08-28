using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ErPatient
    {
        public ErPatient()
        {
            ErFileUploads = new HashSet<ErFileUpload>();
            ErPatientCases = new HashSet<ErPatientCase>();
        }

        public int ErpatientId { get; set; }
        public int ErpatientNumber { get; set; }
        public int? PatientId { get; set; }
        public int? PatientVisitId { get; set; }
        public int? ErdischargeSummaryId { get; set; }
        public DateTime VisitDateTime { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string? Age { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? ContactNo { get; set; }
        public int? ProviderId { get; set; }
        public string? ProviderName { get; set; }
        public string? Address { get; set; }
        public string? Case { get; set; }
        public string? ConditionOnArrival { get; set; }
        public int? ModeOfArrival { get; set; }
        public string? CareOfPerson { get; set; }
        public string? ReferredBy { get; set; }
        public string? ReferredTo { get; set; }
        public string? Erstatus { get; set; }
        public string? TriageCode { get; set; }
        public int? TriagedBy { get; set; }
        public DateTime? TriagedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsExistingPatient { get; set; }
        public string? FinalizedStatus { get; set; }
        public string? FinalizedRemarks { get; set; }
        public int? FinalizedBy { get; set; }
        public DateTime? FinalizedOn { get; set; }
        public bool? IsPoliceCase { get; set; }
        public string? OldPatientId { get; set; }
        public string? CareOfPersonContactNumber { get; set; }

        public virtual ErModeOfArrival? ModeOfArrivalNavigation { get; set; }
        public virtual PatPatient? Patient { get; set; }
        public virtual PatPatientVisit? PatientVisit { get; set; }
        public virtual ICollection<ErFileUpload> ErFileUploads { get; set; }
        public virtual ICollection<ErPatientCase> ErPatientCases { get; set; }
    }
}
