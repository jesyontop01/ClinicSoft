using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccMstCostCenterItem
    {
        public int CostCenterItemId { get; set; }
        public string CostCenterItemName { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public int? HospitalId { get; set; }

        public virtual AccMstHospital? Hospital { get; set; }
    }
}
