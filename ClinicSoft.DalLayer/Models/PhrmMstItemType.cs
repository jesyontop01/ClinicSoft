using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMstItemType
    {
        public PhrmMstItemType()
        {
            PhrmHistoryItems = new HashSet<PhrmHistoryItem>();
            PhrmMstItems = new HashSet<PhrmMstItem>();
        }

        public int ItemTypeId { get; set; }
        public int? CategoryId { get; set; }
        public string ItemTypeName { get; set; } = null!;
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual PhrmMstCategory? Category { get; set; }
        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual ICollection<PhrmHistoryItem> PhrmHistoryItems { get; set; }
        public virtual ICollection<PhrmMstItem> PhrmMstItems { get; set; }
    }
}
