using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvAssetFaultHistory
    {
        public int FaultHistoryId { get; set; }
        public int FixedAssetStockId { get; set; }
        public DateTime? FaultResolvedDate { get; set; }
        public string? FaultResolvedRemarks { get; set; }
        public string? FaultDescription { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? FaultDate { get; set; }
        public bool IsFaultResolved { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual InvTxnFixedAssetStock FixedAssetStock { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
    }
}
