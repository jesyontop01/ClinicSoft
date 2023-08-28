using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvAssetConditionCheckList
    {
        public int AssetConditionCheckListId { get; set; }
        public int? AssetConditionId { get; set; }
        public int FixedAssetStockId { get; set; }
        public bool? Condition { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual InvTxnFixedAssetStock FixedAssetStock { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
    }
}
