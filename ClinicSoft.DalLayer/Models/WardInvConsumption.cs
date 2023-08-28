using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class WardInvConsumption
    {
        public int ConsumptionId { get; set; }
        public int DepartmentId { get; set; }
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public double? Quantity { get; set; }
        public string? Remark { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? DepartmentName { get; set; }
        public string? UsedBy { get; set; }
        public int? StoreId { get; set; }
        public bool? IsTransferToAcc { get; set; }
        public DateTime? ConsumptionDate { get; set; }
        public int? ConsumptionReceiptId { get; set; }

        public virtual WardInvConsumptionReceipt? ConsumptionReceipt { get; set; }
    }
}
