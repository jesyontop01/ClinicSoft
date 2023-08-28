using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmNarcoticSaleRecord
    {
        public int NarcoticRecordId { get; set; }
        public string? BuyerName { get; set; }
        public int? EmployeId { get; set; }
        public int? ItemId { get; set; }
        public int? Quantity { get; set; }
        public string? DoctorName { get; set; }
        public string? Nmcnumber { get; set; }
        public string? Batch { get; set; }
        public int? Refill { get; set; }
        public string? ImgUrl { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? InvoiceId { get; set; }
        public int? InvoiceItemId { get; set; }
    }
}
