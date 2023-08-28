using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnPurchaseOrderItem
    {
        public int PurchaseOrderItemId { get; set; }
        public int? ItemId { get; set; }
        public double? Quantity { get; set; }
        public int? PurchaseOrderId { get; set; }
        public decimal? StandardRate { get; set; }
        public decimal? TotalAmount { get; set; }
        public double? ReceivedQuantity { get; set; }
        public double? PendingQuantity { get; set; }
        public int? DeliveryDays { get; set; }
        public string? AuthorizedRemark { get; set; }
        public int? AuthorizedBy { get; set; }
        public DateTime? AuthorizedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? Remark { get; set; }
        public string? PoitemStatus { get; set; }
        public string? PoitemSpecification { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public decimal? Vatamount { get; set; }
        public bool? IsActive { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? CancelledOn { get; set; }
        public string? CancelRemarks { get; set; }
        public double? VatPercentage { get; set; }
        public string? ItemCategory { get; set; }
        public string? VendorItemCode { get; set; }

        public virtual EmpEmployee? AuthorizedByNavigation { get; set; }
        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual InvMstItem? Item { get; set; }
        public virtual InvTxnPurchaseOrder? PurchaseOrder { get; set; }
    }
}
