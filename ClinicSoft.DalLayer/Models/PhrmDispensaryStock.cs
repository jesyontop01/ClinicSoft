using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmDispensaryStock
    {
        public int StockId { get; set; }
        public int? DispensaryId { get; set; }
        public int? ItemId { get; set; }
        public double? AvailableQuantity { get; set; }
        public decimal? Mrp { get; set; }
        public decimal? Price { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? BatchNo { get; set; }
        public int? GoodReceiptItemId { get; set; }
    }
}
