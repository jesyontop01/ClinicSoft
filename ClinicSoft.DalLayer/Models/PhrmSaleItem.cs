using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmSaleItem
    {
        public PhrmSaleItem()
        {
            PhrmSaleItemsReturns = new HashSet<PhrmSaleItemsReturn>();
        }

        public int SaleItemId { get; set; }
        public int? PrescriptionItemsId { get; set; }
        public string? CompanyName { get; set; }
        public int? PatientId { get; set; }
        public bool? IsInPatient { get; set; }
        public int? ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public double? Quantity { get; set; }
        public decimal? SellingPrice { get; set; }
        public double? FreeQuantity { get; set; }
        public decimal? SubTotal { get; set; }
        public double? Vatpercentage { get; set; }
        public double? DiscountPercentage { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? Uomname { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PatPatient? Patient { get; set; }
        public virtual PhrmPrescriptionItem? PrescriptionItems { get; set; }
        public virtual ICollection<PhrmSaleItemsReturn> PhrmSaleItemsReturns { get; set; }
    }
}
