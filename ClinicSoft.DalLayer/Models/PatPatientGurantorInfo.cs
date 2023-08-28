using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PatPatientGurantorInfo
    {
        public int PatientGurantorInfo { get; set; }
        public int PatientId { get; set; }
        public string? PatientRelationship { get; set; }
        public string? GuarantorName { get; set; }
        public string? GuarantorGender { get; set; }
        public int? GuarantorCountryId { get; set; }
        public string? GuarantorPhoneNumber { get; set; }
        public DateTime? GuarantorDateOfBirth { get; set; }
        public string? GuarantorStreet1 { get; set; }
        public string? GuarantorStreet2 { get; set; }
        public string? GuarantorCity { get; set; }
        public int? GuarantorCountrySubDivisionId { get; set; }
        public string? GuarantorZipcode { get; set; }
        public bool? GuarantorSelf { get; set; }

        public virtual PatPatient Patient { get; set; } = null!;
    }
}
