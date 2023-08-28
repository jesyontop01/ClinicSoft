using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MstCountrySubDivision
    {
        public MstCountrySubDivision()
        {
            MstMunicipalities = new HashSet<MstMunicipality>();
        }

        public int CountrySubDivisionId { get; set; }
        public int CountryId { get; set; }
        public string? CountrySubDivisionName { get; set; }
        public string? CountrySubDivisionCode { get; set; }
        public string? MapAreaCode { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual MstCountry Country { get; set; } = null!;
        public virtual ICollection<MstMunicipality> MstMunicipalities { get; set; }
    }
}
