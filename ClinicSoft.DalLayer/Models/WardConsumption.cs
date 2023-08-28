using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class WardConsumption
    {
        public int ConsumptionId { get; set; }
        public int WardId { get; set; }
        public int? InvoiceId { get; set; }
        public int? InvoiceItemId { get; set; }
        public int? PatientId { get; set; }
        public int ItemId { get; set; }
        public int? VisitId { get; set; }
        public string? ItemName { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? Quantity { get; set; }
        public decimal Mrp { get; set; }
        public decimal? SubTotal { get; set; }
        public string? Remark { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? StoreId { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
