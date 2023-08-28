using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvMstStock
    {
        public InvMstStock()
        {
            InvTxnReturnToVendorItems = new HashSet<InvTxnReturnToVendorItem>();
            InvTxnStoreStocks = new HashSet<InvTxnStoreStock>();
        }

        public int StockId { get; set; }
        public int ItemId { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal CostPrice { get; set; }
        public decimal Mrp { get; set; }
        public string? Specification { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsActive { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual InvMstItem Item { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual ICollection<InvTxnReturnToVendorItem> InvTxnReturnToVendorItems { get; set; }
        public virtual ICollection<InvTxnStoreStock> InvTxnStoreStocks { get; set; }
    }
}
