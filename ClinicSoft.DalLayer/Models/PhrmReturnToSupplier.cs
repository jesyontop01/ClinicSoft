using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmReturnToSupplier
    {
        public PhrmReturnToSupplier()
        {
            PhrmReturnToSupplierItems = new HashSet<PhrmReturnToSupplierItem>();
        }

        public int ReturnToSupplierId { get; set; }
        public int SupplierId { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal? DiscountAmount { get; set; }
        public string? CreditNoteId { get; set; }
        public int? CreditNotePrintId { get; set; }
        public string? Remarks { get; set; }
        public bool? IsTransferredToAcc { get; set; }
        public int? ReturnStatus { get; set; }
        public int? GoodReceiptId { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PhrmGoodsReceipt? GoodReceipt { get; set; }
        public virtual PhrmMstSupplier Supplier { get; set; } = null!;
        public virtual ICollection<PhrmReturnToSupplierItem> PhrmReturnToSupplierItems { get; set; }
    }
}
