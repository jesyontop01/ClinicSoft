using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmBilTransactionItem
    {
        public int BilTransactionItemId { get; set; }
        public int? BilTransactionId { get; set; }
        public int? ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? BatchNo { get; set; }
        public int? PatientId { get; set; }
        public int? CounterId { get; set; }
        public decimal? ItemPrice { get; set; }
        public decimal? SellingPrice { get; set; }
        public double? Quantity { get; set; }
        public double? FreeQuantity { get; set; }
        public decimal? SubTotal { get; set; }
        public double? DiscountPercentage { get; set; }
        public decimal? DiscountAmount { get; set; }
        public double? Vatpercentage { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public DateTime? PaidDate { get; set; }
        public string? TransactionType { get; set; }
        public int? ReferenceId { get; set; }
        public string? BillStatus { get; set; }
        public string? Remarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual PhrmBilTransaction? BilTransaction { get; set; }
        public virtual PhrmMstCounter? Counter { get; set; }
        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PatPatient? Patient { get; set; }
    }
}
