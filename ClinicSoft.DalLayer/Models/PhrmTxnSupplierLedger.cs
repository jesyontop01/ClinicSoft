using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmTxnSupplierLedger
    {
        public PhrmTxnSupplierLedger()
        {
            PhrmTxnSupplierLedgerTransactions = new HashSet<PhrmTxnSupplierLedgerTransaction>();
        }

        public int LedgerId { get; set; }
        public int SupplierId { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal DebitAmount { get; set; }
        public decimal BalanceAmount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual PhrmMstSupplier Supplier { get; set; } = null!;
        public virtual ICollection<PhrmTxnSupplierLedgerTransaction> PhrmTxnSupplierLedgerTransactions { get; set; }
    }
}
