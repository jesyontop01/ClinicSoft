using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InsCfgInsuranceProvider
    {
        public InsCfgInsuranceProvider()
        {
            PatPatientInsuranceInfos = new HashSet<PatPatientInsuranceInfo>();
        }

        public int InsuranceProviderId { get; set; }
        public string? InsuranceProviderName { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<PatPatientInsuranceInfo> PatPatientInsuranceInfos { get; set; }
    }
}
