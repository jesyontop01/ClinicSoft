using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MstMunicipality
    {
        public int MunicipalityId { get; set; }
        public string MunicipalityName { get; set; } = null!;
        public int CountryId { get; set; }
        public int CountrySubDivisionId { get; set; }
        public bool? IsActive { get; set; }
        public string? Type { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual MstCountry Country { get; set; } = null!;
        public virtual MstCountrySubDivision CountrySubDivision { get; set; } = null!;
    }
}
