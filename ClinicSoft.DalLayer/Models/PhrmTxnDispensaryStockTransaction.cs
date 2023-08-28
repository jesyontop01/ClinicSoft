using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmTxnDispensaryStockTransaction
    {
        public int DispensaryStockTransactionId { get; set; }
        public int StoreId { get; set; }
        public int StockId { get; set; }
        public int FiscalYearId { get; set; }
        public int ItemId { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string InOut { get; set; } = null!;
        public string TransactionType { get; set; } = null!;
        public DateTime TransactionDate { get; set; }
        public double Quantity { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? Mrp { get; set; }
        public int? ReferenceNo { get; set; }
        public string? Remarks { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsTransferedToAcc { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual PhrmCfgFiscalYear FiscalYear { get; set; } = null!;
        public virtual PhrmMstItem Item { get; set; } = null!;
        public virtual PhrmTxnStock Stock { get; set; } = null!;
        public virtual PhrmMstStore Store { get; set; } = null!;
    }
}
