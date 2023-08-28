using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvMstCurrency
    {
        public InvMstCurrency()
        {
            InvMstVendors = new HashSet<InvMstVendor>();
            InvTxnPurchaseOrders = new HashSet<InvTxnPurchaseOrder>();
        }

        public int CurrencyId { get; set; }
        public string? CurrencyCode { get; set; }
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<InvMstVendor> InvMstVendors { get; set; }
        public virtual ICollection<InvTxnPurchaseOrder> InvTxnPurchaseOrders { get; set; }
    }
}
