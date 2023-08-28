using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MstLabType
    {
        public int LabTypeId { get; set; }
        public string LabTypeName { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDefault { get; set; }
    }
}
