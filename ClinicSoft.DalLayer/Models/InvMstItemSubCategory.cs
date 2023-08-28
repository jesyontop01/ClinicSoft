using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvMstItemSubCategory
    {
        public InvMstItemSubCategory()
        {
            InvMstAssetCategories = new HashSet<InvMstAssetCategory>();
        }

        public int SubCategoryId { get; set; }
        public string Code { get; set; } = null!;
        public string SubCategoryName { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsConsumable { get; set; }
        public string? Description { get; set; }
        public int? LedgerId { get; set; }

        public virtual ICollection<InvMstAssetCategory> InvMstAssetCategories { get; set; }
    }
}
