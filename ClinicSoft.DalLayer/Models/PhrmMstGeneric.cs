using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMstGeneric
    {
        public PhrmMstGeneric()
        {
            PhrmMstItems = new HashSet<PhrmMstItem>();
        }

        public int GenericId { get; set; }
        public string? GenericName { get; set; }
        public string? GeneralCategory { get; set; }
        public string? TherapeuticCategory { get; set; }
        public string? Counseling { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public int? CategoryId { get; set; }
        public bool? IsAllergen { get; set; }

        public virtual ICollection<PhrmMstItem> PhrmMstItems { get; set; }
    }
}
