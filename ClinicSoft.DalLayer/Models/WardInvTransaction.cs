using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class WardInvTransaction
    {
        public int TransactionId { get; set; }
        public int? StoreId { get; set; }
        public int ItemId { get; set; }
        public int? StockId { get; set; }
        public int? GoodsReceiptItemId { get; set; }
        public double? Quantity { get; set; }
        public string TransactionType { get; set; } = null!;
        public string Remarks { get; set; } = null!;
        public string? ReceivedBy { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ReferenceNo { get; set; }
        public string? InOut { get; set; }
        public decimal? Price { get; set; }
        public decimal? Mrp { get; set; }
        public int? FiscalYearId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsTransferToAcc { get; set; }
        public int SubstoreId { get; set; }

        public virtual PhrmMstStore Substore { get; set; } = null!;
    }
}
