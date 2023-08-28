using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvRequestForQuotation
    {
        public InvRequestForQuotation()
        {
            InvRequestForQuotationVendors = new HashSet<InvRequestForQuotationVendor>();
        }

        public int ReqForQuotationId { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? RequestedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? RequestedOn { get; set; }
        public DateTime? RequestedCloseOn { get; set; }
        public string? Status { get; set; }
        public int StoreId { get; set; }
        public int? RfqgroupId { get; set; }
        public int? FiscalYearId { get; set; }
        public int? RequestForQuotationNo { get; set; }

        public virtual PhrmMstStore Store { get; set; } = null!;
        public virtual ICollection<InvRequestForQuotationVendor> InvRequestForQuotationVendors { get; set; }
    }
}
