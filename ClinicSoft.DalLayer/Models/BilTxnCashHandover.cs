using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilTxnCashHandover
    {
        public int HandoverTxnId { get; set; }
        public int? HandoverByEmpId { get; set; }
        public int? HandoverToEmpId { get; set; }
        public string? HandoverType { get; set; }
        public int? CounterId { get; set; }
        public string? BankName { get; set; }
        public string? VoucherNumber { get; set; }
        public DateTime? VoucherDate { get; set; }
        public double? HandoverAmount { get; set; }
        public double? DueAmount { get; set; }
        public string? HandoverRemarks { get; set; }
        public int? ReceivedById { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public string? ReceiveRemarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual BilCfgCounter? Counter { get; set; }
        public virtual EmpEmployee? HandoverByEmp { get; set; }
    }
}
