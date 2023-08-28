using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PatPatientAddress
    {
        public int PatientAddressId { get; set; }
        public int PatientId { get; set; }
        public string AddressType { get; set; } = null!;
        public string Street1 { get; set; } = null!;
        public string? Street2 { get; set; }
        public int? CountrySubDivisionId { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public int? CountryId { get; set; }

        public virtual MstCountry? Country { get; set; }
        public virtual PatPatient Patient { get; set; } = null!;
    }
}
