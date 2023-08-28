using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AdtBabyBirthDetail
    {
        public int BabyBirthDetailsId { get; set; }
        public string? CertificateNumber { get; set; }
        public string? Sex { get; set; }
        public string? FathersName { get; set; }
        public decimal? WeightOfBaby { get; set; }
        public DateTime? BirthDate { get; set; }
        public TimeSpan? BirthTime { get; set; }
        public int? DischargeSummaryId { get; set; }
        public int? PatientVisitId { get; set; }
        public int? PatientId { get; set; }
        public int? MedicalRecordId { get; set; }
        public string? BirthType { get; set; }
        public string? BirthNumberType { get; set; }
        public int? IssuedBy { get; set; }
        public int? CertifiedBy { get; set; }
        public string FiscalYear { get; set; } = null!;
        public int? PrintedBy { get; set; }
        public int? PrintCount { get; set; }
        public DateTime? PrintedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public int BirthConditionId { get; set; }

        public virtual AdtMstBabyBirthCondition BirthCondition { get; set; } = null!;
    }
}
