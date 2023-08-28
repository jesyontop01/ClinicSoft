using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class WardStock
    {
        public WardStock()
        {
            WardTransactions = new HashSet<WardTransaction>();
        }

        public int StockId { get; set; }
        public int? WardId { get; set; }
        public int? ItemId { get; set; }
        public int? AvailableQuantity { get; set; }
        public double? Mrp { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? StockType { get; set; }
        public int? DepartmentId { get; set; }
        public int? StoreId { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<WardTransaction> WardTransactions { get; set; }
    }
}
