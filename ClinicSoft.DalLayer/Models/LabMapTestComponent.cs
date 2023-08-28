using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class LabMapTestComponent
    {
        public int ComponentMapId { get; set; }
        public long LabTestId { get; set; }
        public int ComponentId { get; set; }
        public int? DisplaySequence { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? GroupName { get; set; }
        public int? IndentationCount { get; set; }
        public bool? ShowInSheet { get; set; }

        public virtual LabMstComponent Component { get; set; } = null!;
        public virtual LabLabTest LabTest { get; set; } = null!;
    }
}
