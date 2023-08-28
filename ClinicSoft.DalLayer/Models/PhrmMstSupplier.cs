using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMstSupplier
    {
        public PhrmMstSupplier()
        {
            PhrmGoodsReceipts = new HashSet<PhrmGoodsReceipt>();
            PhrmHistoryItems = new HashSet<PhrmHistoryItem>();
            PhrmPurchaseOrders = new HashSet<PhrmPurchaseOrder>();
            PhrmReturnToSuppliers = new HashSet<PhrmReturnToSupplier>();
            PhrmTxnSupplierLedgerTransactions = new HashSet<PhrmTxnSupplierLedgerTransaction>();
            PhrmTxnSupplierLedgers = new HashSet<PhrmTxnSupplierLedger>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; } = null!;
        public string? ContactNo { get; set; }
        public string? Description { get; set; }
        public string? City { get; set; }
        public string? Pannumber { get; set; }
        public string? ContactAddress { get; set; }
        public string? Email { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public int? CreditPeriod { get; set; }
        public string? AdditionalContactInformation { get; set; }
        public bool? IsLedgerRequired { get; set; }
        public string? Dda { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual ICollection<PhrmGoodsReceipt> PhrmGoodsReceipts { get; set; }
        public virtual ICollection<PhrmHistoryItem> PhrmHistoryItems { get; set; }
        public virtual ICollection<PhrmPurchaseOrder> PhrmPurchaseOrders { get; set; }
        public virtual ICollection<PhrmReturnToSupplier> PhrmReturnToSuppliers { get; set; }
        public virtual ICollection<PhrmTxnSupplierLedgerTransaction> PhrmTxnSupplierLedgerTransactions { get; set; }
        public virtual ICollection<PhrmTxnSupplierLedger> PhrmTxnSupplierLedgers { get; set; }
    }
}
