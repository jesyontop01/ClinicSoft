using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccMstHospital
    {
        public AccMstHospital()
        {
            AccFiscalYearLogs = new HashSet<AccFiscalYearLog>();
            AccLedgerBalanceHistories = new HashSet<AccLedgerBalanceHistory>();
            AccLedgerMappings = new HashSet<AccLedgerMapping>();
            AccLedgers = new HashSet<AccLedger>();
            AccMapTxnItemCostCenterItems = new HashSet<AccMapTxnItemCostCenterItem>();
            AccMstCostCenterItems = new HashSet<AccMstCostCenterItem>();
            AccMstFiscalYears = new HashSet<AccMstFiscalYear>();
            AccMstLedgerGroups = new HashSet<AccMstLedgerGroup>();
            AccMstSectionLists = new HashSet<AccMstSectionList>();
            AccMstVoucherHeads = new HashSet<AccMstVoucherHead>();
            AccReverseTransactions = new HashSet<AccReverseTransaction>();
            AccTransactionItems = new HashSet<AccTransactionItem>();
            AccTransactions = new HashSet<AccTransaction>();
        }

        public int HospitalId { get; set; }
        public string? HospitalShortName { get; set; }
        public string? HospitalLongName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<AccFiscalYearLog> AccFiscalYearLogs { get; set; }
        public virtual ICollection<AccLedgerBalanceHistory> AccLedgerBalanceHistories { get; set; }
        public virtual ICollection<AccLedgerMapping> AccLedgerMappings { get; set; }
        public virtual ICollection<AccLedger> AccLedgers { get; set; }
        public virtual ICollection<AccMapTxnItemCostCenterItem> AccMapTxnItemCostCenterItems { get; set; }
        public virtual ICollection<AccMstCostCenterItem> AccMstCostCenterItems { get; set; }
        public virtual ICollection<AccMstFiscalYear> AccMstFiscalYears { get; set; }
        public virtual ICollection<AccMstLedgerGroup> AccMstLedgerGroups { get; set; }
        public virtual ICollection<AccMstSectionList> AccMstSectionLists { get; set; }
        public virtual ICollection<AccMstVoucherHead> AccMstVoucherHeads { get; set; }
        public virtual ICollection<AccReverseTransaction> AccReverseTransactions { get; set; }
        public virtual ICollection<AccTransactionItem> AccTransactionItems { get; set; }
        public virtual ICollection<AccTransaction> AccTransactions { get; set; }
    }
}
