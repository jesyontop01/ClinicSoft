using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvMstAccountHead
    {
        public int AccountHeadId { get; set; }
        public string? AccountHeadName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? Description { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
    }
}
