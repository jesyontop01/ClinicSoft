using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmSaleItemsReturn
    {
        public int SaleItemReturnId { get; set; }
        public int? SaleItemId { get; set; }
        public int? PatientId { get; set; }
        public bool? IsInPatient { get; set; }
        public int? ItemId { get; set; }
        public string? BatchNo { get; set; }
        public string? ItemName { get; set; }
        public double? Quantity { get; set; }
        public decimal? SellingPrice { get; set; }
        public decimal? SubTotal { get; set; }
        public double? DiscountPercentage { get; set; }
        public double? Vatpercentage { get; set; }
        public decimal? ReturnAmount { get; set; }
        public string? ReturnRemarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PatPatient? Patient { get; set; }
        public virtual PhrmSaleItem? SaleItem { get; set; }
    }
}
