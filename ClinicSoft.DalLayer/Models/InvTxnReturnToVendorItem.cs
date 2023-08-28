using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnReturnToVendorItem
    {
        public int ReturnToVendorItemId { get; set; }
        public int? VendorId { get; set; }
        public int? ItemId { get; set; }
        public int? GoodsReceiptItemId { get; set; }
        public int? StockId { get; set; }
        public string? BatchNo { get; set; }
        public double? Quantity { get; set; }
        public decimal? ItemRate { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? Remark { get; set; }
        public string? ReturnType { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public bool? IsTransferredToAcc { get; set; }
        public decimal? Vat { get; set; }
        public int? GoodsReceiptId { get; set; }
        public int? CreditNoteNo { get; set; }
        public int? ReturnToVendorId { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual InvMstItem? Item { get; set; }
        public virtual InvTxnReturnToVendor? ReturnToVendor { get; set; }
        public virtual InvMstStock? Stock { get; set; }
        public virtual InvMstVendor? Vendor { get; set; }
    }
}
