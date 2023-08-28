using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class CssdTxnItemTransaction
    {
        public int CssdTxnId { get; set; }
        public int FixedAssetStockId { get; set; }
        public int ItemId { get; set; }
        public int StoreId { get; set; }
        public int RequestedBy { get; set; }
        public DateTime RequestedOn { get; set; }
        public string? RequestRemarks { get; set; }
        public string? DisinfectantName { get; set; }
        public int? DisinfectedBy { get; set; }
        public DateTime? DisinfectedOn { get; set; }
        public string? DisinfectionRemarks { get; set; }
        public int? DispatchedBy { get; set; }
        public DateTime? DispatchedOn { get; set; }
        public string? DispatchRemarks { get; set; }
        public string? CssdStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual EmpEmployee? DisinfectedByNavigation { get; set; }
        public virtual EmpEmployee? DispatchedByNavigation { get; set; }
        public virtual InvTxnFixedAssetStock FixedAssetStock { get; set; } = null!;
        public virtual InvMstItem Item { get; set; } = null!;
        public virtual EmpEmployee RequestedByNavigation { get; set; } = null!;
        public virtual PhrmMstStore Store { get; set; } = null!;
    }
}
