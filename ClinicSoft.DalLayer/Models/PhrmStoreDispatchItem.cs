using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmStoreDispatchItem
    {
        public int DispatchItemsId { get; set; }
        public int? RequisitionItemId { get; set; }
        public double? DispatchedQuantity { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? ReceivedBy { get; set; }
        public int? ItemId { get; set; }
        public int? DispatchId { get; set; }
        public int TargetStoreId { get; set; }
        public int? RequisitionId { get; set; }
        public DateTime? DispatchedDate { get; set; }
        public string? ItemRemarks { get; set; }
        public string? Remarks { get; set; }
        public string? ReceivedRemarks { get; set; }
        public int? ReceivedById { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? Mrp { get; set; }
        public int? SourceStoreId { get; set; }

        public virtual PhrmStoreRequisition? Requisition { get; set; }
        public virtual PhrmMstStore? SourceStore { get; set; }
        public virtual PhrmMstStore TargetStore { get; set; } = null!;
    }
}
