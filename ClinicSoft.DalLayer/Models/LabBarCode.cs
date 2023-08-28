using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class LabBarCode
    {
        public LabBarCode()
        {
            LabTestRequisitions = new HashSet<LabTestRequisition>();
        }

        public int BarCodeId { get; set; }
        public long BarCodeNumber { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<LabTestRequisition> LabTestRequisitions { get; set; }
    }
}
