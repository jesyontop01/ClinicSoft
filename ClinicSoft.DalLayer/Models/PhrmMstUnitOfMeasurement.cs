using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMstUnitOfMeasurement
    {
        public PhrmMstUnitOfMeasurement()
        {
            PhrmHistoryItems = new HashSet<PhrmHistoryItem>();
            PhrmMstItems = new HashSet<PhrmMstItem>();
        }

        public int Uomid { get; set; }
        public string Uomname { get; set; } = null!;
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual ICollection<PhrmHistoryItem> PhrmHistoryItems { get; set; }
        public virtual ICollection<PhrmMstItem> PhrmMstItems { get; set; }
    }
}
