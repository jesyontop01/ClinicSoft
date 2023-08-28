using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmHistoryStockMrp
    {
        public int PhrmstockMrphistoryId { get; set; }
        public int StockId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Mrp { get; set; }
        public int CreatedBy { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual PhrmMstStock Stock { get; set; } = null!;
    }
}
