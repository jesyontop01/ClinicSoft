using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnRequisitionItem
    {
        public InvTxnRequisitionItem()
        {
            InvTxnDispatchItems = new HashSet<InvTxnDispatchItem>();
        }

        public int RequisitionItemId { get; set; }
        public int? ItemId { get; set; }
        public int? Quantity { get; set; }
        public int? RequisitionId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? AuthorizedOn { get; set; }
        public int? AuthorizedBy { get; set; }
        public double? ReceivedQuantity { get; set; }
        public double? PendingQuantity { get; set; }
        public string? AuthorizedRemark { get; set; }
        public string? RequisitionItemStatus { get; set; }
        public string? Remark { get; set; }
        public int? IssueNo { get; set; }
        public double? CancelQuantity { get; set; }
        public int? CancelBy { get; set; }
        public DateTime? CancelOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int RequisitionNo { get; set; }
        public string? CancelRemarks { get; set; }
        public string? Mssno { get; set; }
        public string? FirstWeekQty { get; set; }
        public string? SecondWeekQty { get; set; }
        public string? ThirdWeekQty { get; set; }
        public string? FourthWeekQty { get; set; }
        public string? Minno { get; set; }
        public DateTime? Mindate { get; set; }
        public string? MatIssueTo { get; set; }
        public DateTime? MatIssueDate { get; set; }

        public virtual EmpEmployee? AuthorizedByNavigation { get; set; }
        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual InvMstItem? Item { get; set; }
        public virtual InvTxnRequisition? Requisition { get; set; }
        public virtual ICollection<InvTxnDispatchItem> InvTxnDispatchItems { get; set; }
    }
}
