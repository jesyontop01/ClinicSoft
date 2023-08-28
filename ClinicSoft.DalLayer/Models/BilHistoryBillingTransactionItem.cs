using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilHistoryBillingTransactionItem
    {
        public int BillTxnItemHistoryId { get; set; }
        public string? HistoryType { get; set; }
        public int BillingTransactionItemId { get; set; }
        public int? BillingTransactionId { get; set; }
        public int PatientId { get; set; }
        public int? PatientVisitId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CounterId { get; set; }
        public string? Remarks { get; set; }
        public int ServiceDepartmentId { get; set; }
        public string? ServiceDepartmentName { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public double? Price { get; set; }
        public double? Quantity { get; set; }
        public double? SubTotal { get; set; }
        public double? DiscountAmount { get; set; }
        public double? TaxableAmount { get; set; }
        public double? Tax { get; set; }
        public double? TotalAmount { get; set; }
        public double? DiscountPercent { get; set; }
        public double? DiscountPercentAgg { get; set; }
        public int? ProviderId { get; set; }
        public string? ProviderName { get; set; }
        public long? RequisitionId { get; set; }
        public DateTime? CounterDay { get; set; }
        public double? TaxPercent { get; set; }
        public double? NonTaxableAmount { get; set; }
        public string? PatientType { get; set; }
        public int? RequestingDeptId { get; set; }
        public int? IsTransferredToAcc { get; set; }

        public virtual BilTxnBillingTransactionItem BillingTransactionItem { get; set; } = null!;
    }
}
