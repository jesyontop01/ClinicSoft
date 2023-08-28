using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmFiscalYearStock
    {
        public int FiscalYearStockId { get; set; }
        public int FiscalYearId { get; set; }
        public int? StoreId { get; set; }
        public string? StoreType { get; set; }
        public int StockId { get; set; }
        public int ItemId { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? Mrp { get; set; }
        public double? OpeningQuantity { get; set; }
        public double? ClosingQuantity { get; set; }
        public string? Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual PhrmCfgFiscalYear FiscalYear { get; set; } = null!;
        public virtual PhrmMstItem Item { get; set; } = null!;
        public virtual PhrmTxnStock Stock { get; set; } = null!;
    }
}
