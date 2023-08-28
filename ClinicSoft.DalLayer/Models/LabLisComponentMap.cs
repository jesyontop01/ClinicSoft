using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class LabLisComponentMap
    {
        public int LiscomponentMapId { get; set; }
        public int ComponentId { get; set; }
        public int? LiscomponentId { get; set; }
        public int? MachineId { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ConversionFactor { get; set; }

        public virtual LabMstComponent Component { get; set; } = null!;
    }
}
