using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmPurchaseOrder
    {
        public PhrmPurchaseOrder()
        {
            PhrmGoodsReceipts = new HashSet<PhrmGoodsReceipt>();
            PhrmPurchaseOrderItems = new HashSet<PhrmPurchaseOrderItem>();
        }

        public int PurchaseOrderId { get; set; }
        public int? SupplierId { get; set; }
        public DateTime? Podate { get; set; }
        public string? Postatus { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? DeliveryAddress { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? Remarks { get; set; }
        public int? TermsId { get; set; }
        public int? PurchaseNo { get; set; }
        public int FiscalYearId { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? PurchaseOrderNo { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PhrmCfgFiscalYear FiscalYear { get; set; } = null!;
        public virtual PhrmMstSupplier? Supplier { get; set; }
        public virtual ICollection<PhrmGoodsReceipt> PhrmGoodsReceipts { get; set; }
        public virtual ICollection<PhrmPurchaseOrderItem> PhrmPurchaseOrderItems { get; set; }
    }
}
