using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMstCompany
    {
        public PhrmMstCompany()
        {
            PhrmHistoryItems = new HashSet<PhrmHistoryItem>();
            PhrmMstItems = new HashSet<PhrmMstItem>();
            PhrmTxnInvoiceItems = new HashSet<PhrmTxnInvoiceItem>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? ContactNo { get; set; }
        public string? Description { get; set; }
        public string? ContactAddress { get; set; }
        public string? Email { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? Code { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual ICollection<PhrmHistoryItem> PhrmHistoryItems { get; set; }
        public virtual ICollection<PhrmMstItem> PhrmMstItems { get; set; }
        public virtual ICollection<PhrmTxnInvoiceItem> PhrmTxnInvoiceItems { get; set; }
    }
}
