using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvAssetServiceHistory
    {
        public int AssetServiceId { get; set; }
        public int FixedAssetStockId { get; set; }
        public DateTime ServiceDate { get; set; }
        public string? ServiceRemarks { get; set; }
        public DateTime? ServiceCompleteDate { get; set; }
        public string? ServiceCompleteRemarks { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual InvTxnFixedAssetStock FixedAssetStock { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
    }
}
