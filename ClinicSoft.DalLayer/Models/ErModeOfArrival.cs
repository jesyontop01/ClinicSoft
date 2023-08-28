using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ErModeOfArrival
    {
        public ErModeOfArrival()
        {
            ErPatients = new HashSet<ErPatient>();
        }

        public int ModeOfArrivalId { get; set; }
        public string? ModeOfArrivalName { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<ErPatient> ErPatients { get; set; }
    }
}
