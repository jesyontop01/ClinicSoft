using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvMstAssetDepreciationMethod
    {
        public int AssetDeprnMethodId { get; set; }
        public string Method { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
    }
}
