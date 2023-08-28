using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AdtPatientCertificate
    {
        public int CertificateId { get; set; }
        public string? FiscalYearName { get; set; }
        public string CertificateNumber { get; set; } = null!;
        public string? CertificateType { get; set; }
        public string? IssuedBySignatories { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? DischargeSummaryId { get; set; }
        public string CertifiedBySignatories { get; set; } = null!;
        public string? BirthType { get; set; }
        public DateTime? DeathDate { get; set; }
        public TimeSpan? DeathTime { get; set; }
        public string? DeathCause { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public string? Spouse { get; set; }
    }
}
