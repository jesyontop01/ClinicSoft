using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMstPackingType
    {
        public PhrmMstPackingType()
        {
            PhrmMstItems = new HashSet<PhrmMstItem>();
        }

        public int PackingTypeId { get; set; }
        public string PackingName { get; set; } = null!;
        public double? PackingQuantity { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<PhrmMstItem> PhrmMstItems { get; set; }
    }
}
