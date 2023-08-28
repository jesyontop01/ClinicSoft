using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTempStockMigrationCmh
    {
        public int SerialNo { get; set; }
        public string? AccountHead { get; set; }
        public string? ItemName { get; set; }
        public string? Category { get; set; }
        public string? PackagingTypeName { get; set; }
        public decimal? Price { get; set; }
        public int? StockQuantity { get; set; }
        public int? ItemId { get; set; }
    }
}
