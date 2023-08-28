using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilSyncBillingAccounting
    {
        public int BillingAccountingSyncId { get; set; }
        public int? ReferenceId { get; set; }
        public string? ReferenceModelName { get; set; }
        public int? ServiceDepartmentId { get; set; }
        public int? ItemId { get; set; }
        public string? IncomeLedgerName { get; set; }
        public int? PatientId { get; set; }
        public string? TransactionType { get; set; }
        public string? PaymentMode { get; set; }
        public double? SubTotal { get; set; }
        public double? TaxAmount { get; set; }
        public double? DiscountAmount { get; set; }
        public double? TotalAmount { get; set; }
        public bool? IsTransferedToAcc { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public double? SettlementDiscountAmount { get; set; }
        public string? Remark { get; set; }
        public int? CreditOrganizationId { get; set; }
    }
}
