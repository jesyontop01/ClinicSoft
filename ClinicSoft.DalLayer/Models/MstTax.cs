using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MstTax
    {
        public int TaxId { get; set; }
        public string TaxName { get; set; } = null!;
        public double TaxPercentage { get; set; }
        public string TaxLabel { get; set; } = null!;
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
