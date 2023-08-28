using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmTxnSupplierLedgerTransaction
    {
        public int LedgerTransactionId { get; set; }
        public int FiscalYearId { get; set; }
        public int LedgerId { get; set; }
        public int SupplierId { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public string? Remarks { get; set; }
        public string TransactionType { get; set; } = null!;
        public int? ReferenceNo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual PhrmCfgFiscalYear FiscalYear { get; set; } = null!;
        public virtual PhrmTxnSupplierLedger Ledger { get; set; } = null!;
        public virtual PhrmMstSupplier Supplier { get; set; } = null!;
    }
}
