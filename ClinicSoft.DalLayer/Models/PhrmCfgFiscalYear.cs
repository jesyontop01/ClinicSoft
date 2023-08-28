using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmCfgFiscalYear
    {
        public PhrmCfgFiscalYear()
        {
            PhrmFiscalYearStocks = new HashSet<PhrmFiscalYearStock>();
            PhrmPurchaseOrders = new HashSet<PhrmPurchaseOrder>();
            PhrmStoreRequisitions = new HashSet<PhrmStoreRequisition>();
            PhrmTxnDispensaryStockTransactions = new HashSet<PhrmTxnDispensaryStockTransaction>();
            PhrmTxnStockTransactions = new HashSet<PhrmTxnStockTransaction>();
            PhrmTxnSupplierLedgerTransactions = new HashSet<PhrmTxnSupplierLedgerTransaction>();
        }

        public int FiscalYearId { get; set; }
        public string? FiscalYearName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? NpFiscalYearName { get; set; }
        public bool? IsClosed { get; set; }
        public DateTime? ClosedOn { get; set; }
        public int? ClosedBy { get; set; }

        public virtual ICollection<PhrmFiscalYearStock> PhrmFiscalYearStocks { get; set; }
        public virtual ICollection<PhrmPurchaseOrder> PhrmPurchaseOrders { get; set; }
        public virtual ICollection<PhrmStoreRequisition> PhrmStoreRequisitions { get; set; }
        public virtual ICollection<PhrmTxnDispensaryStockTransaction> PhrmTxnDispensaryStockTransactions { get; set; }
        public virtual ICollection<PhrmTxnStockTransaction> PhrmTxnStockTransactions { get; set; }
        public virtual ICollection<PhrmTxnSupplierLedgerTransaction> PhrmTxnSupplierLedgerTransactions { get; set; }
    }
}
