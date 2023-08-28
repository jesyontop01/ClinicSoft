using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnFixedAssetRequisition
    {
        public InvTxnFixedAssetRequisition()
        {
            InvTxnFixedAssetRequisitionItems = new HashSet<InvTxnFixedAssetRequisitionItem>();
        }

        public int RequisitionId { get; set; }
        public DateTime? RequisitionDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? RequisitionStatus { get; set; }
        public int? IssueNo { get; set; }
        public int StoreId { get; set; }
        public int SubStoreId { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsCancel { get; set; }
        public string? CancelRemarks { get; set; }
        public int RequisitionNo { get; set; }
        public string? Remarks { get; set; }
        public bool? IsDirectDispatch { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<InvTxnFixedAssetRequisitionItem> InvTxnFixedAssetRequisitionItems { get; set; }
    }
}
