using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMstSalesCategory
    {
        public int SalesCategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsBatchApplicable { get; set; }
        public bool? IsExpiryApplicable { get; set; }
        public bool? IsActive { get; set; }
    }
}
