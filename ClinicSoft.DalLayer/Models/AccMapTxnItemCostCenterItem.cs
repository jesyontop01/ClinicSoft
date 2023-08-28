using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccMapTxnItemCostCenterItem
    {
        public int TxnItemCostCenterItemId { get; set; }
        public int? TransactionItemId { get; set; }
        public int? CostCenterItemId { get; set; }
        public double? Amount { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? HospitalId { get; set; }

        public virtual AccMstHospital? Hospital { get; set; }
    }
}
