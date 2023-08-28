using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvMstItem
    {
        public InvMstItem()
        {
            CssdTxnItemTransactions = new HashSet<CssdTxnItemTransaction>();
            InvMstStocks = new HashSet<InvMstStock>();
            InvTxnFixedAssetRequisitionItems = new HashSet<InvTxnFixedAssetRequisitionItem>();
            InvTxnFixedAssetStocks = new HashSet<InvTxnFixedAssetStock>();
            InvTxnGoodsReceiptItems = new HashSet<InvTxnGoodsReceiptItem>();
            InvTxnPurchaseOrderItems = new HashSet<InvTxnPurchaseOrderItem>();
            InvTxnRequisitionItems = new HashSet<InvTxnRequisitionItem>();
            InvTxnReturnToVendorItems = new HashSet<InvTxnReturnToVendorItem>();
            InvTxnStoreStocks = new HashSet<InvTxnStoreStock>();
            InvTxnWriteOffItems = new HashSet<InvTxnWriteOffItem>();
        }

        public int ItemId { get; set; }
        public int? ItemCategoryId { get; set; }
        public int? PackagingTypeId { get; set; }
        public string? ItemName { get; set; }
        public string? ItemType { get; set; }
        public string? Description { get; set; }
        public double? ReOrderQuantity { get; set; }
        public int? UnitOfMeasurementId { get; set; }
        public double? MinStockQuantity { get; set; }
        public double? BudgetedQuantity { get; set; }
        public decimal? StandardRate { get; set; }
        public decimal? Vat { get; set; }
        public double? UnitQuantity { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? Code { get; set; }
        public int? CompanyId { get; set; }
        public int? SubCategoryId { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsVatapplicable { get; set; }
        public string? Mssno { get; set; }
        public string? Hsncode { get; set; }
        public int? VendorId { get; set; }
        public bool? IsCssdApplicable { get; set; }
        public bool? IsColdStorageApplicable { get; set; }
        public bool IsPatConsumptionApplicable { get; set; }
        public int? MaintenanceOwnerRoleId { get; set; }
        public int? StoreId { get; set; }
        public int? RegisterPageNumber { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual InvMstItemCategory? ItemCategory { get; set; }
        public virtual RbacRole? MaintenanceOwnerRole { get; set; }
        public virtual InvMstPackagingType? PackagingType { get; set; }
        public virtual PhrmMstStore? Store { get; set; }
        public virtual InvMstUnitOfMeasurement? UnitOfMeasurement { get; set; }
        public virtual ICollection<CssdTxnItemTransaction> CssdTxnItemTransactions { get; set; }
        public virtual ICollection<InvMstStock> InvMstStocks { get; set; }
        public virtual ICollection<InvTxnFixedAssetRequisitionItem> InvTxnFixedAssetRequisitionItems { get; set; }
        public virtual ICollection<InvTxnFixedAssetStock> InvTxnFixedAssetStocks { get; set; }
        public virtual ICollection<InvTxnGoodsReceiptItem> InvTxnGoodsReceiptItems { get; set; }
        public virtual ICollection<InvTxnPurchaseOrderItem> InvTxnPurchaseOrderItems { get; set; }
        public virtual ICollection<InvTxnRequisitionItem> InvTxnRequisitionItems { get; set; }
        public virtual ICollection<InvTxnReturnToVendorItem> InvTxnReturnToVendorItems { get; set; }
        public virtual ICollection<InvTxnStoreStock> InvTxnStoreStocks { get; set; }
        public virtual ICollection<InvTxnWriteOffItem> InvTxnWriteOffItems { get; set; }
    }
}
