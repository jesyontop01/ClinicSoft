using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnFixedAssetDispatchItem
    {
        public int DispatchItemId { get; set; }
        public int? DispatchId { get; set; }
        public int? RequisitionItemId { get; set; }
        public int? ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? BarCodeNumber { get; set; }
        public decimal Mrp { get; set; }
        public decimal? SubTotal { get; set; }
        public string? Remark { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal? Price { get; set; }
        public int? FixedAssetStockId { get; set; }
        public int? RequisitionId { get; set; }
    }
}
