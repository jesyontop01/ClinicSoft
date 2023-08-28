using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InsInsuranceBalanceAmountHistory
    {
        public int HistoryId { get; set; }
        public int? PatientId { get; set; }
        public decimal? PreviousAmount { get; set; }
        public decimal? UpdatedAmount { get; set; }
        public string Remark { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
    }
}
