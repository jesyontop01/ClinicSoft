using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnRequisitionItemsForPo
    {
        public int RequisitionItemId { get; set; }
        public int RequisitionId { get; set; }
        public int ItemId { get; set; }
        public double Quantity { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
