using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnPurchaseRequestItem
    {
        public int PurchaseRequestItemId { get; set; }
        public int PurchaseRequestId { get; set; }
        public int? VendorId { get; set; }
        public int ItemId { get; set; }
        public double RequestedQuantity { get; set; }
        public string? RequestItemStatus { get; set; }
        public string? Remarks { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? CancelledOn { get; set; }
        public string? CancelRemarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? SupplyRequiredBefore { get; set; }
        public DateTime? QuantityVerifiedOn { get; set; }
        public string? ItemCategory { get; set; }

        public virtual InvTxnPurchaseRequest PurchaseRequest { get; set; } = null!;
    }
}
