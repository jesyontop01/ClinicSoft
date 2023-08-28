using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmWriteOffItem
    {
        public int WriteOffItemId { get; set; }
        public int WriteOffId { get; set; }
        public int? ItemId { get; set; }
        public string? BatchNo { get; set; }
        public decimal? ItemPrice { get; set; }
        public double? WriteOffQuantity { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? Vatpercentage { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? WriteOffItemRemark { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual PhrmWriteOff WriteOff { get; set; } = null!;
    }
}
