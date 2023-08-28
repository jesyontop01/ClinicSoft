using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmStock
    {
        public int StockId { get; set; }
        public int? ItemId { get; set; }
        public double? AvailableQuantity { get; set; }
        public double? Mrp { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double? Price { get; set; }
    }
}
