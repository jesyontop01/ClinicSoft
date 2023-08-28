using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnFixedAssetReturnItem
    {
        public int ReturnItemId { get; set; }
        public int? ItemId { get; set; }
        public int? ReturnId { get; set; }
        public int? FixedAssetStockId { get; set; }
        public string? SerialNo { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public string? Remark { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual InvTxnFixedAssetStock? FixedAssetStock { get; set; }
        public virtual InvTxnFixedAssetReturn? Return { get; set; }
    }
}
