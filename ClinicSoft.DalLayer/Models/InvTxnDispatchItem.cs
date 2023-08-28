using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnDispatchItem
    {
        public int DispatchItemsId { get; set; }
        public int? DepartmentId { get; set; }
        public int RequisitionItemId { get; set; }
        public double? DispatchedQuantity { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? ReceivedBy { get; set; }
        public int? ItemId { get; set; }
        public int? DispatchId { get; set; }
        public int StoreId { get; set; }
        public int? RequisitionId { get; set; }
        public string? Remarks { get; set; }
        public int? ReceivedById { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public string? ReceivedRemarks { get; set; }
        public DateTime? MatIssueDate { get; set; }
        public string? MatIssueTo { get; set; }
        public int? SourceStoreId { get; set; }
        public int? TargetStoreId { get; set; }
        public string? ItemRemarks { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? DispatchedDate { get; set; }
        public int? ReqDisGroupId { get; set; }
        public int? FiscalYearId { get; set; }
        public int? DispatchNo { get; set; }

        public virtual InvTxnRequisitionItem RequisitionItem { get; set; } = null!;
        public virtual PhrmMstStore? SourceStore { get; set; }
        public virtual PhrmMstStore? TargetStore { get; set; }
    }
}
