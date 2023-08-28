using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilMstServiceDepartment
    {
        public BilMstServiceDepartment()
        {
            BilBillItemRequisitions = new HashSet<BilBillItemRequisition>();
            BilCfgBillItemPrices = new HashSet<BilCfgBillItemPrice>();
            BilTxnBillingTransactionItems = new HashSet<BilTxnBillingTransactionItem>();
            BilTxnInvoiceReturnItems = new HashSet<BilTxnInvoiceReturnItem>();
        }

        public int ServiceDepartmentId { get; set; }
        public string? ServiceDepartmentName { get; set; }
        public string? ServiceDepartmentShortName { get; set; }
        public int? DepartmentId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? IntegrationName { get; set; }
        public int? ParentServiceDepartmentId { get; set; }

        public virtual MstDepartment? Department { get; set; }
        public virtual ICollection<BilBillItemRequisition> BilBillItemRequisitions { get; set; }
        public virtual ICollection<BilCfgBillItemPrice> BilCfgBillItemPrices { get; set; }
        public virtual ICollection<BilTxnBillingTransactionItem> BilTxnBillingTransactionItems { get; set; }
        public virtual ICollection<BilTxnInvoiceReturnItem> BilTxnInvoiceReturnItems { get; set; }
    }
}
