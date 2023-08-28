using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AdtMstBedFeature
    {
        public int BedFeatureId { get; set; }
        public string BedFeatureName { get; set; } = null!;
        public string? BedFeatureFullName { get; set; }
        public double BedPrice { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
    }
}
