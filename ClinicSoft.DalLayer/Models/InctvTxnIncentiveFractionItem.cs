using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InctvTxnIncentiveFractionItem
    {
        public int InctvTxnItemId { get; set; }
        public string InvoiceNoFormatted { get; set; } = null!;
        public DateTime? TransactionDate { get; set; }
        public string? PriceCategory { get; set; }
        public int? BillingTransactionId { get; set; }
        public int? BillingTransactionItemId { get; set; }
        public int? PatientId { get; set; }
        public int? BillItemPriceId { get; set; }
        public string? ItemName { get; set; }
        public double? TotalBillAmount { get; set; }
        public string? IncentiveType { get; set; }
        public int? IncentiveReceiverId { get; set; }
        public string? IncentiveReceiverName { get; set; }
        public double? IncentivePercent { get; set; }
        public double? IncentiveAmount { get; set; }
        public bool? IsPaymentProcessed { get; set; }
        public int? PaymentInfoId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsMainDoctor { get; set; }
        public double? Tdspercentage { get; set; }
        public double? Tdsamount { get; set; }
        public bool? IsTransferToAcc { get; set; }
        public bool? IsReturnTxn { get; set; }
        public double? Quantity { get; set; }
    }
}
