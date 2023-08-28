using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilCfgBillItemPriceHistory
    {
        public int BillItemPriceHistoryId { get; set; }
        public int? BillItemPriceId { get; set; }
        public int? ServiceDepartmentId { get; set; }
        public int? ItemId { get; set; }
        public double? Price { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
