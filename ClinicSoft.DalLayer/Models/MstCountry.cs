using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MstCountry
    {
        public MstCountry()
        {
            MstCountrySubDivisions = new HashSet<MstCountrySubDivision>();
            MstMunicipalities = new HashSet<MstMunicipality>();
            PatPatientAddresses = new HashSet<PatPatientAddress>();
        }

        public int CountryId { get; set; }
        public string? CountryShortName { get; set; }
        public string? CountryName { get; set; }
        public string? Isdcode { get; set; }
        public string? CountrySubDivisionType { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<MstCountrySubDivision> MstCountrySubDivisions { get; set; }
        public virtual ICollection<MstMunicipality> MstMunicipalities { get; set; }
        public virtual ICollection<PatPatientAddress> PatPatientAddresses { get; set; }
    }
}
