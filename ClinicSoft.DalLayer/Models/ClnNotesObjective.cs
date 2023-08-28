using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnNotesObjective
    {
        public int ObjectiveNotesId { get; set; }
        public int? PatientId { get; set; }
        public int? PatientVisitId { get; set; }
        public string? Heent { get; set; }
        public string? Chest { get; set; }
        public string? Cvs { get; set; }
        public string? Abdomen { get; set; }
        public string? Extremity { get; set; }
        public string? Skin { get; set; }
        public string? Neurological { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int NotesId { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual ClnNote Notes { get; set; } = null!;
    }
}
