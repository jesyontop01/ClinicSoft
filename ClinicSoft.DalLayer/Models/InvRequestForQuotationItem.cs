using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvRequestForQuotationItem
    {
        public int ReqForQuotationItemId { get; set; }
        public int? ItemId { get; set; }
        public int? ReqForQuotationId { get; set; }
        public string? ItemName { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
