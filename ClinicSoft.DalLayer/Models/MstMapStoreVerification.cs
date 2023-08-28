using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MstMapStoreVerification
    {
        public int StoreVerificationMapId { get; set; }
        public int StoreId { get; set; }
        public int MaxVerificationLevel { get; set; }
        public int VerificationLevel { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsActive { get; set; }
        public int? PermissionId { get; set; }

        public virtual PhrmMstStore Store { get; set; } = null!;
    }
}
