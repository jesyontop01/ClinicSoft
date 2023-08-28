using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccMstVoucherHead
    {
        public int VoucherHeadId { get; set; }
        public string VoucherHeadName { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDefault { get; set; }
        public int? HospitalId { get; set; }

        public virtual AccMstHospital? Hospital { get; set; }
    }
}
