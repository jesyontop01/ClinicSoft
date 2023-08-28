using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnNote
    {
        public ClnNote()
        {
            AdtDischargeSummaries = new HashSet<AdtDischargeSummary>();
            ClnNotesEmergencies = new HashSet<ClnNotesEmergency>();
            ClnNotesObjectives = new HashSet<ClnNotesObjective>();
            ClnNotesSubjectives = new HashSet<ClnNotesSubjective>();
        }

        public int NotesId { get; set; }
        public int PatientId { get; set; }
        public int PatientVisitId { get; set; }
        public int ProviderId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? FollowUp { get; set; }
        public string? Remarks { get; set; }
        public bool? IsPending { get; set; }
        public int? TemplateId { get; set; }
        public string? TemplateName { get; set; }
        public int? SecondaryDoctorId { get; set; }
        public int? NoteTypeId { get; set; }
        public string? FollowUpUnit { get; set; }
        public string? Icdselected { get; set; }

        public virtual ClnMstNoteType? NoteType { get; set; }
        public virtual PatPatientVisit PatientVisit { get; set; } = null!;
        public virtual EmpEmployee? SecondaryDoctor { get; set; }
        public virtual ICollection<AdtDischargeSummary> AdtDischargeSummaries { get; set; }
        public virtual ICollection<ClnNotesEmergency> ClnNotesEmergencies { get; set; }
        public virtual ICollection<ClnNotesObjective> ClnNotesObjectives { get; set; }
        public virtual ICollection<ClnNotesSubjective> ClnNotesSubjectives { get; set; }
    }
}
