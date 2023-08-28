using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilCfgCounter
    {
        public BilCfgCounter()
        {
            BilTxnCashHandovers = new HashSet<BilTxnCashHandover>();
            BilTxnInvoiceReturnItems = new HashSet<BilTxnInvoiceReturnItem>();
            BilTxnInvoiceReturns = new HashSet<BilTxnInvoiceReturn>();
        }

        public int CounterId { get; set; }
        public string CounterName { get; set; } = null!;
        public string CounterType { get; set; } = null!;
        public DateTime? BeginningDate { get; set; }
        public DateTime? ClosingDate { get; set; }
        public int? BranchId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<BilTxnCashHandover> BilTxnCashHandovers { get; set; }
        public virtual ICollection<BilTxnInvoiceReturnItem> BilTxnInvoiceReturnItems { get; set; }
        public virtual ICollection<BilTxnInvoiceReturn> BilTxnInvoiceReturns { get; set; }
    }
}
