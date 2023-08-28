using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnFixedAssetStock
    {
        public InvTxnFixedAssetStock()
        {
            CssdTxnItemTransactions = new HashSet<CssdTxnItemTransaction>();
            InvAssetConditionCheckLists = new HashSet<InvAssetConditionCheckList>();
            InvAssetContractFileInfos = new HashSet<InvAssetContractFileInfo>();
            InvAssetFaultHistories = new HashSet<InvAssetFaultHistory>();
            InvAssetInsurances = new HashSet<InvAssetInsurance>();
            InvAssetLocationHistories = new HashSet<InvAssetLocationHistory>();
            InvAssetServiceHistories = new HashSet<InvAssetServiceHistory>();
            InvTxnAssetDepreciations = new HashSet<InvTxnAssetDepreciation>();
            InvTxnFixedAssetReturnItems = new HashSet<InvTxnFixedAssetReturnItem>();
        }

        public int FixedAssetStockId { get; set; }
        public int? GoodsReceiptItemId { get; set; }
        public int ItemId { get; set; }
        public string? BarCodeNumber { get; set; }
        public string? AssetsLocation { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? WarrantyExpiryDate { get; set; }
        public decimal? ItemRate { get; set; }
        public decimal? Mrp { get; set; }
        public double? DiscountPercent { get; set; }
        public decimal? DiscountAmount { get; set; }
        public double? Vat { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? CcCharge { get; set; }
        public decimal? CcAmount { get; set; }
        public decimal? OtherCharge { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? CancelledOn { get; set; }
        public int? CounterId { get; set; }
        public bool? IsBarCodeGenerated { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsAssetDamaged { get; set; }
        public string? DamagedRemarks { get; set; }
        public string? UndamagedRemarks { get; set; }
        public string? Performance { get; set; }
        public int? TotalLife { get; set; }
        public double? YearOfUse { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public bool IsUnderMaintenance { get; set; }
        public string? BuildingBlockNumber { get; set; }
        public string? Floors { get; set; }
        public string? RoomNumber { get; set; }
        public string? RoomPosition { get; set; }
        public string? SerialNo { get; set; }
        public string? ModelNo { get; set; }
        public bool IsMaintenanceRequired { get; set; }
        public int? ExpectedValueAfterUsefulLife { get; set; }
        public bool IsAssetDamageConfirmed { get; set; }
        public bool IsAssetScraped { get; set; }
        public decimal? ScrapAmount { get; set; }
        public string? ScrapRemarks { get; set; }
        public string? ScrapCancelRemarks { get; set; }
        public DateTime? InstallationDate { get; set; }
        public int? DonationId { get; set; }
        public int? PeriodicServiceDays { get; set; }
        public int? AssetHolderId { get; set; }
        public int StoreId { get; set; }
        public int? SubStoreId { get; set; }
        public string? CssdStatus { get; set; }
        public string? AssetCode { get; set; }
        public string? StockSpecification { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual InvTxnGoodsReceiptItem? GoodsReceiptItem { get; set; }
        public virtual InvMstItem Item { get; set; } = null!;
        public virtual ICollection<CssdTxnItemTransaction> CssdTxnItemTransactions { get; set; }
        public virtual ICollection<InvAssetConditionCheckList> InvAssetConditionCheckLists { get; set; }
        public virtual ICollection<InvAssetContractFileInfo> InvAssetContractFileInfos { get; set; }
        public virtual ICollection<InvAssetFaultHistory> InvAssetFaultHistories { get; set; }
        public virtual ICollection<InvAssetInsurance> InvAssetInsurances { get; set; }
        public virtual ICollection<InvAssetLocationHistory> InvAssetLocationHistories { get; set; }
        public virtual ICollection<InvAssetServiceHistory> InvAssetServiceHistories { get; set; }
        public virtual ICollection<InvTxnAssetDepreciation> InvTxnAssetDepreciations { get; set; }
        public virtual ICollection<InvTxnFixedAssetReturnItem> InvTxnFixedAssetReturnItems { get; set; }
    }
}
