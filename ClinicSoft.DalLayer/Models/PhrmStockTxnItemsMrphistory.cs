using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmStockTxnItemsMrphistory
    {
        public int PhrmstockTxnItemMrphistoryId { get; set; }
        public int? PhrmstockTxnItemId { get; set; }
        public decimal? Mrp { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? LocationId { get; set; }
        public decimal? OldMrp { get; set; }
        public int? StoreStockId { get; set; }

        public virtual PhrmStoreStock? StoreStock { get; set; }
    }
}
