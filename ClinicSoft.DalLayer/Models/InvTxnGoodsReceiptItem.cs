using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnGoodsReceiptItem
    {
        public InvTxnGoodsReceiptItem()
        {
            InvTxnFixedAssetStocks = new HashSet<InvTxnFixedAssetStock>();
        }

        public int GoodsReceiptItemId { get; set; }
        public int GoodsReceiptId { get; set; }
        public int? ItemId { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double? ReceivedQuantity { get; set; }
        public double? FreeQuantity { get; set; }
        public double? RejectedQuantity { get; set; }
        public decimal? ItemRate { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? TotalAmount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Mrp { get; set; }
        public double? DiscountPercent { get; set; }
        public decimal? CcCharge { get; set; }
        public int? CounterId { get; set; }
        public decimal? DiscountAmount { get; set; }
        public double? Vat { get; set; }
        public decimal? CcAmount { get; set; }
        public decimal? OtherCharge { get; set; }
        public bool? IsTransferredToAcc { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? GritemDate { get; set; }
        public bool? IsActive { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? CancelledOn { get; set; }
        public DateTime? SamplingDate { get; set; }
        public int? NoOfBoxes { get; set; }
        public int? SamplingQuantity { get; set; }
        public string? IdentificationLabel { get; set; }
        public string? IsSamplingLabel { get; set; }
        public string? SamplingBoxes { get; set; }
        public int? SampleRemoved { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public double ArrivalQuantity { get; set; }
        public string? MaterialNo { get; set; }
        public int? StockId { get; set; }
        public string? GritemSpecification { get; set; }
        public string? Remarks { get; set; }
        public string? ItemCategory { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual InvTxnGoodsReceipt GoodsReceipt { get; set; } = null!;
        public virtual InvMstItem? Item { get; set; }
        public virtual ICollection<InvTxnFixedAssetStock> InvTxnFixedAssetStocks { get; set; }
    }
}
