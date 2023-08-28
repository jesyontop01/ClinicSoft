using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class VaccVaccine
    {
        public VaccVaccine()
        {
            VaccPatientVaccineDetails = new HashSet<VaccPatientVaccineDetail>();
        }

        public int VaccineId { get; set; }
        public string VaccineName { get; set; } = null!;
        public int NumberOfDoses { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<VaccPatientVaccineDetail> VaccPatientVaccineDetails { get; set; }
    }
}
