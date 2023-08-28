using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class VwBilTxnItemsInfoWithDateSeparationIncomeSegregation
    {
        public int BillingTransactionItemId { get; set; }
        public int PatientId { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public int ServiceDepartmentId { get; set; }
        public string? ServiceDepartmentName { get; set; }
        public int? ProviderId { get; set; }
        public string? ProviderName { get; set; }
        public string BillingType { get; set; } = null!;
        public int? RequestingDeptId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? CancelledDate { get; set; }
        public DateTime? ProvisionalDate { get; set; }
        public DateTime? CreditDate { get; set; }
        public double? Price { get; set; }
        public double? Quantity { get; set; }
        public double? SubTotal { get; set; }
        public double? DiscountAmount { get; set; }
        public double? TotalAmount { get; set; }
        public double? ReturnAmount { get; set; }
        public string? ReturnRemarks { get; set; }
        public string? CancelRemarks { get; set; }
        public string? PaymentMode { get; set; }
        public string? VisitType { get; set; }
        public string InvoiceNumber { get; set; } = null!;
        public bool? IsInsurance { get; set; }
    }
}
