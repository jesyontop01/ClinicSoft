using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvMstItemCategory
    {
        public InvMstItemCategory()
        {
            InvMstItems = new HashSet<InvMstItem>();
        }

        public int ItemCategoryId { get; set; }
        public string? ItemCategoryName { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public string? Description { get; set; }
        public string? CategoryCode { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<InvMstItem> InvMstItems { get; set; }
    }
}
