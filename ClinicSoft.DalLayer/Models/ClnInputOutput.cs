using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnInputOutput
    {
        public int InputOutputId { get; set; }
        public int PatientVisitId { get; set; }
        public string? IntakeType { get; set; }
        public string? OutputType { get; set; }
        public string? Unit { get; set; }
        public double? TotalIntake { get; set; }
        public double? TotalOutput { get; set; }
        public double? Balance { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual PatPatientVisit PatientVisit { get; set; } = null!;
    }
}
