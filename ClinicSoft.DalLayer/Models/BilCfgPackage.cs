using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilCfgPackage
    {
        public BilCfgPackage()
        {
            BilTxnBillingTransactionItems = new HashSet<BilTxnBillingTransactionItem>();
        }

        public int BillingPackageId { get; set; }
        public string? BillingPackageName { get; set; }
        public string? Description { get; set; }
        public double TotalPrice { get; set; }
        public double DiscountPercent { get; set; }
        public string? BillingItemsXml { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? PackageCode { get; set; }
        public bool InsuranceApplicable { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual ICollection<BilTxnBillingTransactionItem> BilTxnBillingTransactionItems { get; set; }
    }
}
