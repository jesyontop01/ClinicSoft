using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class TxnEmpDueAmount
    {
        public int EmployeeDueId { get; set; }
        public int EmployeeId { get; set; }
        public double? LatestDueAmount { get; set; }
        public DateTime? LatestTransactionDate { get; set; }

        public virtual EmpEmployee Employee { get; set; } = null!;
    }
}
