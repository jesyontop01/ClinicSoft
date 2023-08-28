using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnReturnToVendor
    {
        public InvTxnReturnToVendor()
        {
            InvTxnReturnToVendorItems = new HashSet<InvTxnReturnToVendorItem>();
        }

        public int ReturnToVendorId { get; set; }
        public DateTime ReturnDate { get; set; }
        public int? VendorId { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Vattotal { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? CreditNoteId { get; set; }
        public int? CreditNotePrintNo { get; set; }
        public string? Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int StoreId { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual PhrmMstStore Store { get; set; } = null!;
        public virtual InvMstVendor? Vendor { get; set; }
        public virtual ICollection<InvTxnReturnToVendorItem> InvTxnReturnToVendorItems { get; set; }
    }
}
