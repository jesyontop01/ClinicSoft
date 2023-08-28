using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccMstSectionList
    {
        public int Id { get; set; }
        public int? SectionId { get; set; }
        public string? SectionName { get; set; }
        public string? SectionCode { get; set; }
        public int? HospitalId { get; set; }
        public bool IsDefault { get; set; }
        public bool? IsActive { get; set; }

        public virtual AccMstHospital? Hospital { get; set; }
    }
}
