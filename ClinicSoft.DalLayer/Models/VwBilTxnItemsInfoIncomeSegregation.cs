using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class VwBilTxnItemsInfoIncomeSegregation
    {
        public DateTime? BillingDate { get; set; }
        public int BillingTransactionItemId { get; set; }
        public int? BillingTransactionId { get; set; }
        public string BillStatus { get; set; } = null!;
        public int ServiceDepartmentId { get; set; }
        public int ItemId { get; set; }
        public int PatientId { get; set; }
        public int? ProviderId { get; set; }
        public double? PaidPrice { get; set; }
        public double? PaidQuantity { get; set; }
        public double? PaidSubTotal { get; set; }
        public double? PaidDiscountAmount { get; set; }
        public double? PaidTax { get; set; }
        public double? PaidTotalAmount { get; set; }
        public double? UnpaidPrice { get; set; }
        public double? UnpaidQuantity { get; set; }
        public double? UnpaidSubTotal { get; set; }
        public double? UnpaidDiscountAmount { get; set; }
        public double? UnpaidTax { get; set; }
        public double? UnpaidTotalAmount { get; set; }
        public double? CancelPrice { get; set; }
        public double? CancelQuantity { get; set; }
        public double? CancelSubTotal { get; set; }
        public double? CancelDiscountAmount { get; set; }
        public double? CancelTax { get; set; }
        public double? CancelTotalAmount { get; set; }
        public DateTime? CreatedOn { get; set; }
        public double? ReturnQuantity { get; set; }
        public double? ReturnSubTotal { get; set; }
        public double? ReturnDiscountAmount { get; set; }
        public double? ReturnTax { get; set; }
        public double? ReturnTotalAmount { get; set; }
    }
}
