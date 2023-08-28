using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class RadMstFilmType
    {
        public int FilmTypeId { get; set; }
        public string? FilmType { get; set; }
        public int? ImagingTypeId { get; set; }
        public string FilmTypeDisplayName { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
