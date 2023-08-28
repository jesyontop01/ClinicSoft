using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmTxnInvoiceItem
    {
        public PhrmTxnInvoiceItem()
        {
            PhrmTxnInvoiceReturnItems = new HashSet<PhrmTxnInvoiceReturnItem>();
        }

        public int InvoiceItemId { get; set; }
        public int? InvoiceId { get; set; }
        public int? CompanyId { get; set; }
        public int? ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? BatchNo { get; set; }
        public double? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Mrp { get; set; }
        public decimal? GrItemPrice { get; set; }
        public double? FreeQuantity { get; set; }
        public decimal? SubTotal { get; set; }
        public double? Vatpercentage { get; set; }
        public double? DiscountPercentage { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? BilItemStatus { get; set; }
        public string? Remark { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? PrescriptionItemId { get; set; }
        public int? CounterId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? PatientId { get; set; }
        public int? GrItemId { get; set; }
        public string? VisitType { get; set; }
        public decimal? TotalDisAmt { get; set; }
        public decimal? PerItemDisAmt { get; set; }
        public int StoreId { get; set; }
        public int? GenericId { get; set; }
        public string? GenericName { get; set; }
        public decimal? Vatamount { get; set; }

        public virtual PhrmMstCompany? Company { get; set; }
        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PhrmTxnInvoice? Invoice { get; set; }
        public virtual ICollection<PhrmTxnInvoiceReturnItem> PhrmTxnInvoiceReturnItems { get; set; }
    }
}
