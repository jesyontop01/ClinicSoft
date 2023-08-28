using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class TxnEmpCashTransaction
    {
        public int CashTxnId { get; set; }
        public string TransactionType { get; set; } = null!;
        public int? ReferenceNo { get; set; }
        public int EmployeeId { get; set; }
        public double? InAmount { get; set; }
        public double? OutAmount { get; set; }
        public string? Description { get; set; }
        public DateTime? TransactionDate { get; set; }
        public bool IsActive { get; set; }
        public int? CounterId { get; set; }

        public virtual EmpEmployee Employee { get; set; } = null!;
    }
}
