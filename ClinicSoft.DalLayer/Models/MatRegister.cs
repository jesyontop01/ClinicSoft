using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MatRegister
    {
        public int MaternityRegisterId { get; set; }
        public int? MaternityPatientId { get; set; }
        public int? PatientId { get; set; }
        public string? Gender { get; set; }
        public int? WeightInGram { get; set; }
        public string? OutcomeOfBaby { get; set; }
        public string? OutcomeOfMother { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual MatPatient? MaternityPatient { get; set; }
        public virtual PatPatient? Patient { get; set; }
    }
}
