using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmTxnDispensaryStock
    {
        public int DispensaryStockId { get; set; }
        public int StoreId { get; set; }
        public int StockId { get; set; }
        public int ItemId { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double AvailableQuantity { get; set; }
        public double UnConfirmedQuantity { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? Mrp { get; set; }
        public bool? IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual PhrmMstItem Item { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual PhrmTxnStock Stock { get; set; } = null!;
        public virtual PhrmMstStore Store { get; set; } = null!;
    }
}
