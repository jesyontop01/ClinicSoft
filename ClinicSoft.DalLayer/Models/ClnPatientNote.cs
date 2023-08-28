using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnPatientNote
    {
        public int PatientNoteId { get; set; }
        public int PatientVisitId { get; set; }
        public string? NoteType { get; set; }
        public string? ObjectiveNote { get; set; }
        public string? SubjectiveNote { get; set; }
        public string? AssessmentNote { get; set; }
        public string? PlanNote { get; set; }
        public DateTime? RecordedOnDate { get; set; }
        public string? Addendum { get; set; }
        public string? Orders { get; set; }

        public virtual PatPatientVisit PatientVisit { get; set; } = null!;
    }
}
