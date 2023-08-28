using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilTxnBillingTransactionItem
    {
        public BilTxnBillingTransactionItem()
        {
            BilHistoryBillingTransactionItems = new HashSet<BilHistoryBillingTransactionItem>();
            BilTxnInvoiceReturnItems = new HashSet<BilTxnInvoiceReturnItem>();
            FrcFractionCalculations = new HashSet<FrcFractionCalculation>();
        }

        public int BillingTransactionItemId { get; set; }
        public int? BillingTransactionId { get; set; }
        public int PatientId { get; set; }
        public int ServiceDepartmentId { get; set; }
        public string? ServiceDepartmentName { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public double? Price { get; set; }
        public double? Quantity { get; set; }
        public double? SubTotal { get; set; }
        public double? DiscountAmount { get; set; }
        public double? TaxableAmount { get; set; }
        public double? Tax { get; set; }
        public double? TotalAmount { get; set; }
        public double? DiscountPercent { get; set; }
        public double? DiscountPercentAgg { get; set; }
        public int? ProviderId { get; set; }
        public string? ProviderName { get; set; }
        public string? BillStatus { get; set; }
        public long? RequisitionId { get; set; }
        public DateTime? RequisitionDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public int? CounterId { get; set; }
        public DateTime? CounterDay { get; set; }
        public string? Remarks { get; set; }
        public bool? ReturnStatus { get; set; }
        public double? ReturnQuantity { get; set; }
        public double? ReturnTax { get; set; }
        public DateTime? CancelledOn { get; set; }
        public int? CancelledBy { get; set; }
        public string? CancelRemarks { get; set; }
        public int? RequestedBy { get; set; }
        public int? PatientVisitId { get; set; }
        public int? BillingPackageId { get; set; }
        public double? TaxPercent { get; set; }
        public string? ProcedureCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public double? NonTaxableAmount { get; set; }
        public int? PaymentReceivedBy { get; set; }
        public int? PaidCounterId { get; set; }
        public string? BillingType { get; set; }
        public int? RequestingDeptId { get; set; }
        public int? IsTransferredToAcc { get; set; }
        public string? VisitType { get; set; }
        public string? PriceCategory { get; set; }
        public int? PatientInsurancePackageId { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ProvisionalReceiptNo { get; set; }
        public int? ProvisionalFiscalYearId { get; set; }
        public bool? IsInsurance { get; set; }
        public int? DiscountSchemeId { get; set; }
        public bool? IsCashBillSync { get; set; }
        public bool? IsCreditBillSync { get; set; }
        public bool? IsCashBillReturnSync { get; set; }
        public bool? IsCreditBillReturnSync { get; set; }
        public string? OrderStatus { get; set; }
        public string? LabTypeName { get; set; }

        public virtual BilCfgPackage? BillingPackage { get; set; }
        public virtual BilTxnBillingTransaction? BillingTransaction { get; set; }
        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual PatPatientVisit? PatientVisit { get; set; }
        public virtual EmpEmployee? RequestedByNavigation { get; set; }
        public virtual BilMstServiceDepartment ServiceDepartment { get; set; } = null!;
        public virtual ICollection<BilHistoryBillingTransactionItem> BilHistoryBillingTransactionItems { get; set; }
        public virtual ICollection<BilTxnInvoiceReturnItem> BilTxnInvoiceReturnItems { get; set; }
        public virtual ICollection<FrcFractionCalculation> FrcFractionCalculations { get; set; }
    }
}
