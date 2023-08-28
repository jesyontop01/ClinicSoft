using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmHistoryItem
    {
        public int HistoryItemId { get; set; }
        public int? ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public string? ItemCode { get; set; }
        public int? CompanyId { get; set; }
        public int? SupplierId { get; set; }
        public int? ItemTypeId { get; set; }
        public int? Uomid { get; set; }
        public decimal? StandardPrice { get; set; }
        public decimal? SellingPrice { get; set; }
        public double? ReOrderQuantity { get; set; }
        public double? MinStockQuantity { get; set; }
        public double? BudgetedQuantity { get; set; }
        public double? Vatpercentage { get; set; }
        public bool? IsVatapplicable { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual PhrmMstCompany? Company { get; set; }
        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PhrmMstItemType? ItemType { get; set; }
        public virtual PhrmMstSupplier? Supplier { get; set; }
        public virtual PhrmMstUnitOfMeasurement? Uom { get; set; }
    }
}
