using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnNotesPrescriptionNote
    {
        public int PrescriptionNoteId { get; set; }
        public int? NotesId { get; set; }
        public int? PatientId { get; set; }
        public int? PatientVisitId { get; set; }
        public string? PrescriptionNoteText { get; set; }
        public string? OldMedicationStopped { get; set; }
        public string? NewMedicationStarted { get; set; }
        public string? Icdremarks { get; set; }
        public string? Icdselected { get; set; }
        public string? OrdersSelected { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
