using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AdtMapBedFeaturesMap
    {
        public int BedFeatureCfgid { get; set; }
        public int BedId { get; set; }
        public int WardId { get; set; }
        public int BedFeatureId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual AdtBed Bed { get; set; } = null!;
        public virtual AdtMstBedFeature BedFeature { get; set; } = null!;
        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual AdtMstWard Ward { get; set; } = null!;
    }
}
