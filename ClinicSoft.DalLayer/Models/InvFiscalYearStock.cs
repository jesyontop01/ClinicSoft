using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvFiscalYearStock
    {
        public int FiscalYrStockId { get; set; }
        public int FiscalYearId { get; set; }
        public int? StoreId { get; set; }
        public int? StockId { get; set; }
        public int? GritemId { get; set; }
        public int? ItemId { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? Mrp { get; set; }
        public decimal? Price { get; set; }
        public double? OpeningQty { get; set; }
        public double? ClosingQty { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual InvCfgFiscalYear FiscalYear { get; set; } = null!;
    }
}
