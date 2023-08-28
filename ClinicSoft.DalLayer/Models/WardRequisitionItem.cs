using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class WardRequisitionItem
    {
        public int RequisitionItemId { get; set; }
        public int RequisitionId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int? DispatchedQty { get; set; }
    }
}
