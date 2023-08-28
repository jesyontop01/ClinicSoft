using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MatMaternityAnc
    {
        public int MaternityAncid { get; set; }
        public int? MaternityPatientId { get; set; }
        public DateTime? AncdateTime { get; set; }
        public int? PatientId { get; set; }
        public string? VisitNumber { get; set; }
        public string? Ancplace { get; set; }
        public int? PregnancyPeriodInWeeks { get; set; }
        public string? ConditionOfAnc { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public double Weight { get; set; }

        public virtual MatPatient? MaternityPatient { get; set; }
        public virtual PatPatient? Patient { get; set; }
    }
}
