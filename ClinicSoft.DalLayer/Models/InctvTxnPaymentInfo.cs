using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InctvTxnPaymentInfo
    {
        public int PaymentInfoId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? ReceiverId { get; set; }
        public double? TotalAmount { get; set; }
        public double? Tdsamount { get; set; }
        public double? NetPayAmount { get; set; }
        public bool? IsPostedToAccounting { get; set; }
        public DateTime? AccountingPostedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public double? AdjustedAmount { get; set; }
        public string? VoucherNumber { get; set; }
        public string? Remarks { get; set; }
    }
}
