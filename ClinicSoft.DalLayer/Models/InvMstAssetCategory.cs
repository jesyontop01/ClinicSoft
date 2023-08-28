using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvMstAssetCategory
    {
        public int AssetCategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int ParentId { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual InvMstItemSubCategory SubCategory { get; set; } = null!;
    }
}
