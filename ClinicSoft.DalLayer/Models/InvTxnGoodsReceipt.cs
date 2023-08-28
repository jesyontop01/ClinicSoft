using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnGoodsReceipt
    {
        public InvTxnGoodsReceipt()
        {
            InvTxnGoodsReceiptItems = new HashSet<InvTxnGoodsReceiptItem>();
        }

        public int GoodsReceiptId { get; set; }
        public DateTime? GoodsReceiptDate { get; set; }
        public int? PurchaseOrderId { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? VendorId { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Vattotal { get; set; }
        public decimal? CcCharge { get; set; }
        public double? Discount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public int? PrintCount { get; set; }
        public string? BillNo { get; set; }
        public string? ReceiptNo { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string? OrderDate { get; set; }
        public int? CreditPeriod { get; set; }
        public string? PaymentMode { get; set; }
        public decimal? OtherCharges { get; set; }
        public bool? IsTransferredToAcc { get; set; }
        public decimal? Tdsrate { get; set; }
        public decimal? Tdsamount { get; set; }
        public decimal? TotalWithTds { get; set; }
        public decimal? InsuranceCharge { get; set; }
        public decimal? CarriageFreightCharge { get; set; }
        public decimal? PackingCharge { get; set; }
        public decimal? TransportCourierCharge { get; set; }
        public decimal? OtherCharge { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsCancel { get; set; }
        public string? CancelRemarks { get; set; }
        public int? GoodsReceiptNo { get; set; }
        public string? Grcategory { get; set; }
        public int? FiscalYearId { get; set; }
        public bool? IsVerificationEnabled { get; set; }
        public string? VerifierIds { get; set; }
        public int? VerificationId { get; set; }
        public string? Grstatus { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? CancelledOn { get; set; }
        public int? DonationId { get; set; }
        public DateTime? MaterialCoaDate { get; set; }
        public string? MaterialCoaNo { get; set; }
        public bool? IsSupplierApproved { get; set; }
        public bool? IsDeliveryTopClosed { get; set; }
        public bool? IsBoxNumbered { get; set; }
        public int GoodsArrivalNo { get; set; }
        public DateTime GoodsArrivalDate { get; set; }
        public int? Imirno { get; set; }
        public DateTime? Imirdate { get; set; }
        public int? ReceivedBy { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public string? ReceivedRemarks { get; set; }
        public int StoreId { get; set; }
        public bool? IsDonation { get; set; }
        public DateTime? VendorBillDate { get; set; }
        public int? GrgroupId { get; set; }
        public bool IsPaymentDoneFromAcc { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual InvMstDonation? Donation { get; set; }
        public virtual InvTxnPurchaseOrder? PurchaseOrder { get; set; }
        public virtual PhrmMstStore Store { get; set; } = null!;
        public virtual InvMstVendor? Vendor { get; set; }
        public virtual ICollection<InvTxnGoodsReceiptItem> InvTxnGoodsReceiptItems { get; set; }
    }
}
