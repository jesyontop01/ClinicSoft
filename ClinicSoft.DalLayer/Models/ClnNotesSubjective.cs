using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnNotesSubjective
    {
        public int SubjectiveNoteId { get; set; }
        public int NotesId { get; set; }
        public int PatientId { get; set; }
        public int PatientVisitId { get; set; }
        public string? ChiefComplaint { get; set; }
        public string? HistoryOfPresentingIllness { get; set; }
        public string? ReviewOfSystems { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual ClnNote Notes { get; set; } = null!;
    }
}
