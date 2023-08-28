using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilTxnInvoiceReturnItem
    {
        public int BillReturnItemId { get; set; }
        public int BillReturnId { get; set; }
        public int BillingTransactionItemId { get; set; }
        public int BillingTransactionId { get; set; }
        public int PatientId { get; set; }
        public int ServiceDepartmentId { get; set; }
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public double? Price { get; set; }
        public double? RetQuantity { get; set; }
        public double? RetSubTotal { get; set; }
        public double? RetDiscountAmount { get; set; }
        public double? RetTaxAmount { get; set; }
        public double? RetTotalAmount { get; set; }
        public double? RetDiscountPercent { get; set; }
        public int? ProviderId { get; set; }
        public string? BillStatus { get; set; }
        public long? RequisitionId { get; set; }
        public DateTime? RequisitionDate { get; set; }
        public int? RetCounterId { get; set; }
        public string? RetRemarks { get; set; }
        public int? RequestedBy { get; set; }
        public int? PatientVisitId { get; set; }
        public int? BillingPackageId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? BillingType { get; set; }
        public int? RequestingDeptId { get; set; }
        public string? VisitType { get; set; }
        public string? PriceCategory { get; set; }
        public int? PatientInsurancePackageId { get; set; }
        public bool? IsInsurance { get; set; }
        public int? DiscountSchemeId { get; set; }
        public bool? IsCashBillSyncToAcc { get; set; }
        public bool? IsCreditBillSyncToAcc { get; set; }
        public string? LabTypeName { get; set; }

        public virtual BilTxnInvoiceReturn BillReturn { get; set; } = null!;
        public virtual BilTxnBillingTransaction BillingTransaction { get; set; } = null!;
        public virtual BilTxnBillingTransactionItem BillingTransactionItem { get; set; } = null!;
        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual PatPatient Patient { get; set; } = null!;
        public virtual PatPatientVisit? PatientVisit { get; set; }
        public virtual BilCfgCounter? RetCounter { get; set; }
        public virtual BilMstServiceDepartment ServiceDepartment { get; set; } = null!;
    }
}
