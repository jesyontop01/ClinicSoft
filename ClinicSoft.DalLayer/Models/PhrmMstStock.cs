using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMstStock
    {
        public PhrmMstStock()
        {
            PhrmHistoryStockBatchExpiries = new HashSet<PhrmHistoryStockBatchExpiry>();
            PhrmHistoryStockMrps = new HashSet<PhrmHistoryStockMrp>();
            PhrmTxnStockTransactions = new HashSet<PhrmTxnStockTransaction>();
            PhrmTxnStoreStocks = new HashSet<PhrmTxnStoreStock>();
        }

        public int StockId { get; set; }
        public int ItemId { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal CostPrice { get; set; }
        public decimal Mrp { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsActive { get; set; }
        public int? BarcodeId { get; set; }

        public virtual PhrmMstStockBarcode? Barcode { get; set; }
        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual PhrmMstItem Item { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual ICollection<PhrmHistoryStockBatchExpiry> PhrmHistoryStockBatchExpiries { get; set; }
        public virtual ICollection<PhrmHistoryStockMrp> PhrmHistoryStockMrps { get; set; }
        public virtual ICollection<PhrmTxnStockTransaction> PhrmTxnStockTransactions { get; set; }
        public virtual ICollection<PhrmTxnStoreStock> PhrmTxnStoreStocks { get; set; }
    }
}
