using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvQuotationItem
    {
        public int QuotationItemId { get; set; }
        public int? QuotationId { get; set; }
        public int? VendorId { get; set; }
        public int? ItemId { get; set; }
        public string? ItemName { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public DateTime? UpLoadedOn { get; set; }
        public int? UpLoadedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
