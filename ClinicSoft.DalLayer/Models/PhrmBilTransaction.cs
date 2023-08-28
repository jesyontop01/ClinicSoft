using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmBilTransaction
    {
        public PhrmBilTransaction()
        {
            PhrmBilTransactionItems = new HashSet<PhrmBilTransactionItem>();
        }

        public int BilTransactionId { get; set; }
        public int? PatientId { get; set; }
        public int? CounterId { get; set; }
        public DateTime? PaidDate { get; set; }
        public string? TransactionType { get; set; }
        public double? TotalQuantity { get; set; }
        public decimal? SubTotal { get; set; }
        public double? DiscountPercentage { get; set; }
        public decimal? DiscountAmount { get; set; }
        public double? Vatpercentage { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? AmountFromDeposit { get; set; }
        public decimal? CreditAmount { get; set; }
        public string? BilStatus { get; set; }
        public int? PrintCount { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual PhrmMstCounter? Counter { get; set; }
        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PatPatient? Patient { get; set; }
        public virtual ICollection<PhrmBilTransactionItem> PhrmBilTransactionItems { get; set; }
    }
}
