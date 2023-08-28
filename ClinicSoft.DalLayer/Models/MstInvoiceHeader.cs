using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MstInvoiceHeader
    {
        public MstInvoiceHeader()
        {
            InvTxnPurchaseOrders = new HashSet<InvTxnPurchaseOrder>();
        }

        public int InvoiceHeaderId { get; set; }
        public string? Module { get; set; }
        public string? HeaderDescription { get; set; }
        public string? HospitalName { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Pan { get; set; }
        public string? Telephone { get; set; }
        public string? Dda { get; set; }
        public string? LogoFileName { get; set; }
        public string? LogoFileExtention { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<InvTxnPurchaseOrder> InvTxnPurchaseOrders { get; set; }
    }
}
