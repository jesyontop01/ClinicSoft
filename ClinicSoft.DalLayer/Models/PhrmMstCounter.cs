using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMstCounter
    {
        public PhrmMstCounter()
        {
            PhrmBilTransactionItems = new HashSet<PhrmBilTransactionItem>();
            PhrmBilTransactions = new HashSet<PhrmBilTransaction>();
        }

        public int CounterId { get; set; }
        public string CounterName { get; set; } = null!;
        public string? CounterType { get; set; }
        public DateTime? BeginningDate { get; set; }
        public DateTime? ClosingDate { get; set; }
        public int? StoreId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PhrmMstStore? Store { get; set; }
        public virtual ICollection<PhrmBilTransactionItem> PhrmBilTransactionItems { get; set; }
        public virtual ICollection<PhrmBilTransaction> PhrmBilTransactions { get; set; }
    }
}
