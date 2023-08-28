using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnNotesProcedure
    {
        public int ProcedureNoteId { get; set; }
        public int? NotesId { get; set; }
        public int? PatientId { get; set; }
        public int? PatientVisitId { get; set; }
        public string? FreeText { get; set; }
        public string? LinesProse { get; set; }
        public string? Remarks { get; set; }
        public string? Site { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? Date { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
