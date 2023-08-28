using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnSocialHistory
    {
        public int SocialHistoryId { get; set; }
        public int PatientId { get; set; }
        public string? SmokingHistory { get; set; }
        public string? AlcoholHistory { get; set; }
        public string? DrugHistory { get; set; }
        public string? Occupation { get; set; }
        public string? FamilySupport { get; set; }
        public string? Note { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual PatPatient Patient { get; set; } = null!;
    }
}
