using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmPurchaseOrderItem
    {
        public int PurchaseOrderItemId { get; set; }
        public int? ItemId { get; set; }
        public int? PurchaseOrderId { get; set; }
        public double? Quantity { get; set; }
        public decimal? StandaredPrice { get; set; }
        public double? ReceivedQuantity { get; set; }
        public double? PendingQuantity { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? DeliveryDays { get; set; }
        public string? AuthorizedRemark { get; set; }
        public string? Remarks { get; set; }
        public string? PoitemStatus { get; set; }
        public int? AuthorizedBy { get; set; }
        public DateTime? AuthorizedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsCancel { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual EmpEmployee? AuthorizedByNavigation { get; set; }
        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PhrmPurchaseOrder? PurchaseOrder { get; set; }
    }
}
