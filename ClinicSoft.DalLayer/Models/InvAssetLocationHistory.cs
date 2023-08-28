using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvAssetLocationHistory
    {
        public int AssetsLocationHistoryId { get; set; }
        public int FixedAssetStockId { get; set; }
        public string? OldLocation { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int CreatedBy { get; set; }
        public int? OldAssetHolderId { get; set; }
        public int OldStoreId { get; set; }
        public int? OldSubStoreId { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual InvTxnFixedAssetStock FixedAssetStock { get; set; } = null!;
    }
}
