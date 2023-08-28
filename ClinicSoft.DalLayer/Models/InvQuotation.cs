using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvQuotation
    {
        public int QuotationId { get; set; }
        public int? ReqForQuotationId { get; set; }
        public int? VendorId { get; set; }
        public string? VendorName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? Status { get; set; }
        public int? StoreId { get; set; }
        public int? RfqgroupId { get; set; }
        public DateTime? IssuedDate { get; set; }
        public int? FiscalYearId { get; set; }
        public int? QuotationNo { get; set; }
    }
}
