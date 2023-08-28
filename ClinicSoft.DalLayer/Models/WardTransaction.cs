using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class WardTransaction
    {
        public int TransactionId { get; set; }
        public int? WardId { get; set; }
        public int ItemId { get; set; }
        public int? StockId { get; set; }
        public int Quantity { get; set; }
        public string TransactionType { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string Remarks { get; set; } = null!;
        public bool IsWard { get; set; }
        public int? NewWardId { get; set; }
        public string? ReceivedBy { get; set; }
        public int? StoreId { get; set; }
        public string? InOut { get; set; }
        public decimal? Price { get; set; }

        public virtual WardStock? Stock { get; set; }
    }
}
