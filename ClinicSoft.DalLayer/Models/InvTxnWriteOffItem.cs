using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnWriteOffItem
    {
        public int WriteOffId { get; set; }
        public int? GoodsReceiptItemId { get; set; }
        public int? StockId { get; set; }
        public string? BatchNo { get; set; }
        public int? ItemId { get; set; }
        public decimal? ItemRate { get; set; }
        public double? WriteOffQuantity { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? WriteOffDate { get; set; }
        public string? Remark { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsTransferredToAcc { get; set; }
        public int StoreId { get; set; }

        public virtual InvMstItem? Item { get; set; }
        public virtual PhrmMstStore Store { get; set; } = null!;
    }
}
