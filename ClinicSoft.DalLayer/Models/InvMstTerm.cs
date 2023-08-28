using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvMstTerm
    {
        public int TermsId { get; set; }
        public string? Text { get; set; }
        public string Type { get; set; } = null!;
        public int? OrderBy { get; set; }
        public bool? IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ShortName { get; set; } = null!;
        public int? TermsApplicationEnumId { get; set; }

        public virtual EmpEmployee Terms { get; set; } = null!;
    }
}
