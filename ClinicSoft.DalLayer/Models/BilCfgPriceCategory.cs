using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilCfgPriceCategory
    {
        public BilCfgPriceCategory()
        {
            InctvMstProfiles = new HashSet<InctvMstProfile>();
        }

        public int PriceCategoryId { get; set; }
        public string? PriceCategoryName { get; set; }
        public string? DisplayName { get; set; }
        public string? BillingColumnName { get; set; }
        public bool? IsDefault { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<InctvMstProfile> InctvMstProfiles { get; set; }
    }
}
