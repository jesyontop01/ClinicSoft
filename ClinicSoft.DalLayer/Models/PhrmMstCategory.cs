using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMstCategory
    {
        public PhrmMstCategory()
        {
            PhrmMstItemTypes = new HashSet<PhrmMstItemType>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual ICollection<PhrmMstItemType> PhrmMstItemTypes { get; set; }
    }
}
