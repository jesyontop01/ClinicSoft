using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InctvCfgItemGroupDistribution
    {
        public int ItemGroupDistributionId { get; set; }
        public string? IncentiveType { get; set; }
        public int? BillItemPriceId { get; set; }
        public int? EmployeeBillItemsMapId { get; set; }
        public int? FromEmployeeId { get; set; }
        public int? DistributeToEmployeeId { get; set; }
        public double? DistributionPercent { get; set; }
        public double? FixedDistributionAmount { get; set; }
        public bool? IsFixedAmount { get; set; }
        public int? DisplaySeq { get; set; }
        public string? Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual InctvMapEmployeeBillItemsMap? EmployeeBillItemsMap { get; set; }
    }
}
