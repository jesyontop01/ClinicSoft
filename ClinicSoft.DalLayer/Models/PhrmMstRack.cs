using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMstRack
    {
        public int RackId { get; set; }
        public int? ParentId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int LocationId { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
    }
}
