using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnStoreStock
    {
        public InvTxnStoreStock()
        {
            InvTxnStockTransactions = new HashSet<InvTxnStockTransaction>();
        }

        public int StoreStockId { get; set; }
        public int? StoreId { get; set; }
        public int? StockId { get; set; }
        public int? ItemId { get; set; }
        public decimal SellingPrice { get; set; }
        public double AvailableQuantity { get; set; }
        public double UnConfirmedQtyIn { get; set; }
        public double UnConfirmedQtyOut { get; set; }
        public bool IsActive { get; set; }

        public virtual InvMstItem? Item { get; set; }
        public virtual InvMstStock? Stock { get; set; }
        public virtual PhrmMstStore? Store { get; set; }
        public virtual ICollection<InvTxnStockTransaction> InvTxnStockTransactions { get; set; }
    }
}
