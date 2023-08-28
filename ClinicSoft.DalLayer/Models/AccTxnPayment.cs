using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccTxnPayment
    {
        public int PaymentId { get; set; }
        public int TransactionId { get; set; }
        public string? VoucherNumber { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? ReceiverLedgerId { get; set; }
        public int? GoodReceiptId { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? VoucherAmount { get; set; }
        public decimal? RemainingAmount { get; set; }
        public string? PaymentMode { get; set; }
        public string? Remarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual AccTransaction Transaction { get; set; } = null!;
    }
}
