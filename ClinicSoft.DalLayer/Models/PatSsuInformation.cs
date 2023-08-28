using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PatSsuInformation
    {
        public int SsuInfoId { get; set; }
        public int PatientId { get; set; }
        public int TargetGroupId { get; set; }
        public string TargetGroup { get; set; } = null!;
        public string? TgCertificateType { get; set; }
        public string? TgCertificateNo { get; set; }
        public string? IncomeSource { get; set; }
        public string? PatFamilyFinancialStatus { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual PatPatient Patient { get; set; } = null!;
    }
}
