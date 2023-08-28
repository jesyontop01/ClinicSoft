using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMstStore
    {
        public PhrmMstStore()
        {
            CssdTxnItemTransactions = new HashSet<CssdTxnItemTransaction>();
            InvMstItems = new HashSet<InvMstItem>();
            InvRequestForQuotations = new HashSet<InvRequestForQuotation>();
            InvTxnDispatchItemSourceStores = new HashSet<InvTxnDispatchItem>();
            InvTxnDispatchItemTargetStores = new HashSet<InvTxnDispatchItem>();
            InvTxnGoodsReceipts = new HashSet<InvTxnGoodsReceipt>();
            InvTxnPurchaseOrders = new HashSet<InvTxnPurchaseOrder>();
            InvTxnPurchaseRequests = new HashSet<InvTxnPurchaseRequest>();
            InvTxnReturnToVendors = new HashSet<InvTxnReturnToVendor>();
            InvTxnStockTransactions = new HashSet<InvTxnStockTransaction>();
            InvTxnStocks = new HashSet<InvTxnStock>();
            InvTxnStoreStocks = new HashSet<InvTxnStoreStock>();
            InvTxnWriteOffItems = new HashSet<InvTxnWriteOffItem>();
            MstMapStoreVerifications = new HashSet<MstMapStoreVerification>();
            PhrmDeposits = new HashSet<PhrmDeposit>();
            PhrmMstCounters = new HashSet<PhrmMstCounter>();
            PhrmStoreDispatchItemSourceStores = new HashSet<PhrmStoreDispatchItem>();
            PhrmStoreDispatchItemTargetStores = new HashSet<PhrmStoreDispatchItem>();
            PhrmStoreRequisitions = new HashSet<PhrmStoreRequisition>();
            PhrmTxnDispensaryStockTransactions = new HashSet<PhrmTxnDispensaryStockTransaction>();
            PhrmTxnDispensaryStocks = new HashSet<PhrmTxnDispensaryStock>();
            PhrmTxnInvoiceReturnItems = new HashSet<PhrmTxnInvoiceReturnItem>();
            PhrmTxnInvoiceReturns = new HashSet<PhrmTxnInvoiceReturn>();
            PhrmTxnInvoices = new HashSet<PhrmTxnInvoice>();
            PhrmTxnStockTransactions = new HashSet<PhrmTxnStockTransaction>();
            PhrmTxnStoreStocks = new HashSet<PhrmTxnStoreStock>();
            PhrmWriteOffs = new HashSet<PhrmWriteOff>();
            WardInvConsumptionReceipts = new HashSet<WardInvConsumptionReceipt>();
            WardInvStocks = new HashSet<WardInvStock>();
            WardInvTransactions = new HashSet<WardInvTransaction>();
        }

        public int StoreId { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public string? ContactNo { get; set; }
        public string? Email { get; set; }
        public string? StoreLabel { get; set; }
        public string? StoreDescription { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ParentStoreId { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? Code { get; set; }
        public int? MaxVerificationLevel { get; set; }
        public int? PermissionId { get; set; }
        public string? Category { get; set; }
        public string? SubCategory { get; set; }
        public string? PanNo { get; set; }
        public bool UseSeparateInvoiceHeader { get; set; }
        public string? AvailablePaymentModesJson { get; set; }
        public string? DefaultPaymentMode { get; set; }
        public int? InvGrgroupId { get; set; }
        public int? InvPogroupId { get; set; }
        public int? InvPrgroupId { get; set; }
        public int? InvReqDisGroupId { get; set; }
        public int? InvRfqgroupId { get; set; }
        public string? InvReceiptDisplayName { get; set; }
        public string? InvReceiptNoCode { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual ICollection<CssdTxnItemTransaction> CssdTxnItemTransactions { get; set; }
        public virtual ICollection<InvMstItem> InvMstItems { get; set; }
        public virtual ICollection<InvRequestForQuotation> InvRequestForQuotations { get; set; }
        public virtual ICollection<InvTxnDispatchItem> InvTxnDispatchItemSourceStores { get; set; }
        public virtual ICollection<InvTxnDispatchItem> InvTxnDispatchItemTargetStores { get; set; }
        public virtual ICollection<InvTxnGoodsReceipt> InvTxnGoodsReceipts { get; set; }
        public virtual ICollection<InvTxnPurchaseOrder> InvTxnPurchaseOrders { get; set; }
        public virtual ICollection<InvTxnPurchaseRequest> InvTxnPurchaseRequests { get; set; }
        public virtual ICollection<InvTxnReturnToVendor> InvTxnReturnToVendors { get; set; }
        public virtual ICollection<InvTxnStockTransaction> InvTxnStockTransactions { get; set; }
        public virtual ICollection<InvTxnStock> InvTxnStocks { get; set; }
        public virtual ICollection<InvTxnStoreStock> InvTxnStoreStocks { get; set; }
        public virtual ICollection<InvTxnWriteOffItem> InvTxnWriteOffItems { get; set; }
        public virtual ICollection<MstMapStoreVerification> MstMapStoreVerifications { get; set; }
        public virtual ICollection<PhrmDeposit> PhrmDeposits { get; set; }
        public virtual ICollection<PhrmMstCounter> PhrmMstCounters { get; set; }
        public virtual ICollection<PhrmStoreDispatchItem> PhrmStoreDispatchItemSourceStores { get; set; }
        public virtual ICollection<PhrmStoreDispatchItem> PhrmStoreDispatchItemTargetStores { get; set; }
        public virtual ICollection<PhrmStoreRequisition> PhrmStoreRequisitions { get; set; }
        public virtual ICollection<PhrmTxnDispensaryStockTransaction> PhrmTxnDispensaryStockTransactions { get; set; }
        public virtual ICollection<PhrmTxnDispensaryStock> PhrmTxnDispensaryStocks { get; set; }
        public virtual ICollection<PhrmTxnInvoiceReturnItem> PhrmTxnInvoiceReturnItems { get; set; }
        public virtual ICollection<PhrmTxnInvoiceReturn> PhrmTxnInvoiceReturns { get; set; }
        public virtual ICollection<PhrmTxnInvoice> PhrmTxnInvoices { get; set; }
        public virtual ICollection<PhrmTxnStockTransaction> PhrmTxnStockTransactions { get; set; }
        public virtual ICollection<PhrmTxnStoreStock> PhrmTxnStoreStocks { get; set; }
        public virtual ICollection<PhrmWriteOff> PhrmWriteOffs { get; set; }
        public virtual ICollection<WardInvConsumptionReceipt> WardInvConsumptionReceipts { get; set; }
        public virtual ICollection<WardInvStock> WardInvStocks { get; set; }
        public virtual ICollection<WardInvTransaction> WardInvTransactions { get; set; }
    }
}
