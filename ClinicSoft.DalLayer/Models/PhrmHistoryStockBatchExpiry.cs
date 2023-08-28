using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmHistoryStockBatchExpiry
    {
        public int PhrmstockBatchExpiryHistoryId { get; set; }
        public int StockId { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int CreatedBy { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual PhrmMstStock Stock { get; set; } = null!;
    }
}
