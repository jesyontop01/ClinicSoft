using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnKvPatientClinicalInfo
    {
        public int InfoId { get; set; }
        public int? PatientId { get; set; }
        public int? PatientVisitId { get; set; }
        public string? KeyName { get; set; }
        public string? Value { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
