using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvMstVendor
    {
        public InvMstVendor()
        {
            InvRequestForQuotationVendors = new HashSet<InvRequestForQuotationVendor>();
            InvTxnGoodsReceipts = new HashSet<InvTxnGoodsReceipt>();
            InvTxnPurchaseOrders = new HashSet<InvTxnPurchaseOrder>();
            InvTxnReturnToVendorItems = new HashSet<InvTxnReturnToVendorItem>();
            InvTxnReturnToVendors = new HashSet<InvTxnReturnToVendor>();
        }

        public int VendorId { get; set; }
        public string? VendorName { get; set; }
        public string? ContactAddress { get; set; }
        public string? ContactNo { get; set; }
        public string? Email { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public int? DefaultCurrencyId { get; set; }
        public string? VendorCode { get; set; }
        public string? ContactPerson { get; set; }
        public double? Tds { get; set; }
        public DateTime? GovtRegDate { get; set; }
        public string? PanNo { get; set; }
        public double? CreditPeriod { get; set; }
        public bool? IsTdsapplicable { get; set; }
        public string? DefaultItemJson { get; set; }
        public int? CountryId { get; set; }
        public string? CompanyPosition { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? CompanyPosition2 { get; set; }
        public string? Name2 { get; set; }
        public string? PhoneNumber2 { get; set; }
        public string? BankDetails { get; set; }
        public string? Sarfno { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual InvMstCurrency? DefaultCurrency { get; set; }
        public virtual ICollection<InvRequestForQuotationVendor> InvRequestForQuotationVendors { get; set; }
        public virtual ICollection<InvTxnGoodsReceipt> InvTxnGoodsReceipts { get; set; }
        public virtual ICollection<InvTxnPurchaseOrder> InvTxnPurchaseOrders { get; set; }
        public virtual ICollection<InvTxnReturnToVendorItem> InvTxnReturnToVendorItems { get; set; }
        public virtual ICollection<InvTxnReturnToVendor> InvTxnReturnToVendors { get; set; }
    }
}
