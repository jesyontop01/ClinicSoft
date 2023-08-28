using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmExpiryDateBatchNoHistory
    {
        public int PhrmexpBatchHistoryId { get; set; }
        public int? StoreStockId { get; set; }
        public DateTime? OldExpiryDate { get; set; }
        public string? OldBatchNo { get; set; }
        public DateTime? EndDate { get; set; }
        public int? CreatedBy { get; set; }

        public virtual PhrmStoreStock? StoreStock { get; set; }
    }
}
