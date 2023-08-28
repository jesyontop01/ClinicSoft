using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnRequisition
    {
        public InvTxnRequisition()
        {
            InvTxnRequisitionItems = new HashSet<InvTxnRequisitionItem>();
        }

        public int RequisitionId { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? RequisitionDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? RequisitionStatus { get; set; }
        public int? IssueNo { get; set; }
        public int RequestFromStoreId { get; set; }
        public int? VerificationId { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsCancel { get; set; }
        public string? CancelRemarks { get; set; }
        public int RequisitionNo { get; set; }
        public string? Remarks { get; set; }
        public DateTime? MatIssueDate { get; set; }
        public string? MatIssueTo { get; set; }
        public int RequestToStoreId { get; set; }
        public int? ReqDisGroupId { get; set; }
        public int? FiscalYearId { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual MstDepartment? Department { get; set; }
        public virtual TxnVerification? Verification { get; set; }
        public virtual ICollection<InvTxnRequisitionItem> InvTxnRequisitionItems { get; set; }
    }
}
