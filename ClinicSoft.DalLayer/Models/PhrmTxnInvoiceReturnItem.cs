using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmTxnInvoiceReturnItem
    {
        public int InvoiceReturnItemId { get; set; }
        public int? InvoiceItemId { get; set; }
        public int? InvoiceId { get; set; }
        public double? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? SubTotal { get; set; }
        public double? Vatpercentage { get; set; }
        public double? DiscountPercentage { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? Remark { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? BatchNo { get; set; }
        public decimal? Mrp { get; set; }
        public int? CounterId { get; set; }
        public int? CreditNoteNumber { get; set; }
        public int? FiscalYearId { get; set; }
        public bool? IsTransferredToAcc { get; set; }
        public int? ItemId { get; set; }
        public int? InvoiceReturnId { get; set; }
        public double? ReturnedQty { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? TotalDisAmt { get; set; }
        public decimal? PerItemDisAmt { get; set; }
        public int StoreId { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PhrmTxnInvoice? Invoice { get; set; }
        public virtual PhrmTxnInvoiceItem? InvoiceItem { get; set; }
        public virtual PhrmTxnInvoiceReturn? InvoiceReturn { get; set; }
        public virtual PhrmMstItem? Item { get; set; }
        public virtual PhrmMstStore Store { get; set; } = null!;
    }
}
