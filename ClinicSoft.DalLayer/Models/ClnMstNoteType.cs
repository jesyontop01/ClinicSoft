using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnMstNoteType
    {
        public ClnMstNoteType()
        {
            ClnNotes = new HashSet<ClnNote>();
        }

        public int NoteTypeId { get; set; }
        public string NoteType { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsForNursing { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<ClnNote> ClnNotes { get; set; }
    }
}
