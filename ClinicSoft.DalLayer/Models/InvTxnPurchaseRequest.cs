using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnPurchaseRequest
    {
        public InvTxnPurchaseRequest()
        {
            InvTxnPurchaseRequestItems = new HashSet<InvTxnPurchaseRequestItem>();
        }

        public int PurchaseRequestId { get; set; }
        public DateTime? RequestDate { get; set; }
        public int? Prnumber { get; set; }
        public int? VendorId { get; set; }
        public string? RequestStatus { get; set; }
        public int? VerificationId { get; set; }
        public bool? IsPocreated { get; set; }
        public string? Remarks { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? CancelledOn { get; set; }
        public string? CancelRemarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsActive { get; set; }
        public string? Prcategory { get; set; }
        public int StoreId { get; set; }
        public int? PrgroupId { get; set; }
        public int? FiscalYearId { get; set; }

        public virtual PhrmMstStore Store { get; set; } = null!;
        public virtual ICollection<InvTxnPurchaseRequestItem> InvTxnPurchaseRequestItems { get; set; }
    }
}
