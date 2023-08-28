using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InctvMapEmployeeBillItemsMap
    {
        public InctvMapEmployeeBillItemsMap()
        {
            InctvCfgItemGroupDistributions = new HashSet<InctvCfgItemGroupDistribution>();
        }

        public int EmployeeBillItemsMapId { get; set; }
        public int? EmployeeId { get; set; }
        public int? BillItemPriceId { get; set; }
        public double? AssignedToPercent { get; set; }
        public double? ReferredByPercent { get; set; }
        public int? PriceCategoryId { get; set; }
        public bool? HasGroupDistribution { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? BillingTypesApplicable { get; set; }

        public virtual BilCfgBillItemPrice? BillItemPrice { get; set; }
        public virtual EmpEmployee? Employee { get; set; }
        public virtual ICollection<InctvCfgItemGroupDistribution> InctvCfgItemGroupDistributions { get; set; }
    }
}
