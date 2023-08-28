using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmRequisitionItem
    {
        public int RequisitionItemId { get; set; }
        public int RequisitionId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }

        public virtual PhrmRequisition Requisition { get; set; } = null!;
    }
}
