using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmStockManage
    {
        public int StockManageId { get; set; }
        public int? ItemId { get; set; }
        public string? BatchNo { get; set; }
        public decimal? Mrp { get; set; }
        public decimal? Price { get; set; }
        public double? Quantity { get; set; }
        public int? StockTxnItemId { get; set; }
        public double? Vatpercentage { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? InOut { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public string? Remark { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PhrmStockTxnItem? StockTxnItem { get; set; }
    }
}
