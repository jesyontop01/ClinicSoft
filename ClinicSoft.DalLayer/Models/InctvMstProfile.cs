using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InctvMstProfile
    {
        public InctvMstProfile()
        {
            InctvBillItemsProfileMaps = new HashSet<InctvBillItemsProfileMap>();
        }

        public int ProfileId { get; set; }
        public string? ProfileName { get; set; }
        public int? PriceCategoryId { get; set; }
        public bool? IsActive { get; set; }
        public double? Tdspercentage { get; set; }
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual BilCfgPriceCategory? PriceCategory { get; set; }
        public virtual ICollection<InctvBillItemsProfileMap> InctvBillItemsProfileMaps { get; set; }
    }
}
