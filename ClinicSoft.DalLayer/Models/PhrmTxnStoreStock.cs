using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmTxnStoreStock
    {
        public PhrmTxnStoreStock()
        {
            PhrmGoodsReceiptItems = new HashSet<PhrmGoodsReceiptItem>();
            PhrmTxnStockTransactions = new HashSet<PhrmTxnStockTransaction>();
        }

        public int StoreStockId { get; set; }
        public int? StoreId { get; set; }
        public int? StockId { get; set; }
        public int? ItemId { get; set; }
        public double AvailableQuantity { get; set; }
        public double UnConfirmedQtyIn { get; set; }
        public double UnConfirmedQtyOut { get; set; }
        public bool IsActive { get; set; }

        public virtual PhrmMstItem? Item { get; set; }
        public virtual PhrmMstStock? Stock { get; set; }
        public virtual PhrmMstStore? Store { get; set; }
        public virtual ICollection<PhrmGoodsReceiptItem> PhrmGoodsReceiptItems { get; set; }
        public virtual ICollection<PhrmTxnStockTransaction> PhrmTxnStockTransactions { get; set; }
    }
}
