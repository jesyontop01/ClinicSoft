using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvRequestForQuotationVendor
    {
        public int ReqForQuotationVendorId { get; set; }
        public int VendorId { get; set; }
        public int ReqForQuotationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual InvRequestForQuotation ReqForQuotation { get; set; } = null!;
        public virtual InvMstVendor Vendor { get; set; } = null!;
    }
}
