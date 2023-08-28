using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMstItem
    {
        public PhrmMstItem()
        {
            PhrmFiscalYearStocks = new HashSet<PhrmFiscalYearStock>();
            PhrmMstStockBarcodes = new HashSet<PhrmMstStockBarcode>();
            PhrmMstStocks = new HashSet<PhrmMstStock>();
            PhrmTxnDispensaryStockTransactions = new HashSet<PhrmTxnDispensaryStockTransaction>();
            PhrmTxnDispensaryStocks = new HashSet<PhrmTxnDispensaryStock>();
            PhrmTxnInvoiceReturnItems = new HashSet<PhrmTxnInvoiceReturnItem>();
            PhrmTxnStockTransactions = new HashSet<PhrmTxnStockTransaction>();
            PhrmTxnStocks = new HashSet<PhrmTxnStock>();
            PhrmTxnStoreStocks = new HashSet<PhrmTxnStoreStock>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public int? GenericId { get; set; }
        public string? ItemCode { get; set; }
        public int? CompanyId { get; set; }
        public int? ItemTypeId { get; set; }
        public int? Uomid { get; set; }
        public double? ReOrderQuantity { get; set; }
        public double? MinStockQuantity { get; set; }
        public double? BudgetedQuantity { get; set; }
        public double? PurchaseVatpercentage { get; set; }
        public bool? IsVatapplicable { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsInternationalBrand { get; set; }
        public string? Abccategory { get; set; }
        public string? Ved { get; set; }
        public string? Dosage { get; set; }
        public string? Frequency { get; set; }
        public string? Duration { get; set; }
        public int? Rack { get; set; }
        public int? SalesCategoryId { get; set; }
        public double? Cccharge { get; set; }
        public bool IsNarcotic { get; set; }
        public int? StoreRackId { get; set; }
        public int? PackingTypeId { get; set; }
        public bool? IsInsuranceApplicable { get; set; }
        public decimal? GovtInsurancePrice { get; set; }
        public double? SalesVatpercentage { get; set; }

        public virtual PhrmMstCompany? Company { get; set; }
        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PhrmMstGeneric? Generic { get; set; }
        public virtual PhrmMstItemType? ItemType { get; set; }
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual PhrmMstPackingType? PackingType { get; set; }
        public virtual PhrmMstUnitOfMeasurement? Uom { get; set; }
        public virtual ICollection<PhrmFiscalYearStock> PhrmFiscalYearStocks { get; set; }
        public virtual ICollection<PhrmMstStockBarcode> PhrmMstStockBarcodes { get; set; }
        public virtual ICollection<PhrmMstStock> PhrmMstStocks { get; set; }
        public virtual ICollection<PhrmTxnDispensaryStockTransaction> PhrmTxnDispensaryStockTransactions { get; set; }
        public virtual ICollection<PhrmTxnDispensaryStock> PhrmTxnDispensaryStocks { get; set; }
        public virtual ICollection<PhrmTxnInvoiceReturnItem> PhrmTxnInvoiceReturnItems { get; set; }
        public virtual ICollection<PhrmTxnStockTransaction> PhrmTxnStockTransactions { get; set; }
        public virtual ICollection<PhrmTxnStock> PhrmTxnStocks { get; set; }
        public virtual ICollection<PhrmTxnStoreStock> PhrmTxnStoreStocks { get; set; }
    }
}
