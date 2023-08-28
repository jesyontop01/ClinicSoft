using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnAllergy
    {
        public int PatientAllergyId { get; set; }
        public int PatientId { get; set; }
        public string? AllergyType { get; set; }
        public string? Severity { get; set; }
        public string? Comments { get; set; }
        public int? AllergenAdvRecId { get; set; }
        public bool? Verified { get; set; }
        public string? Reaction { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? AllergenAdvRecName { get; set; }

        public virtual PatPatient Patient { get; set; } = null!;
    }
}
