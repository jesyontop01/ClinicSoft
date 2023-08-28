using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class WardInternalConsumption
    {
        public int ConsumptionId { get; set; }
        public int? WardId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SubStoreId { get; set; }
        public double? TotalAmount { get; set; }
        public string? Remark { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ConsumedBy { get; set; }
    }
}
