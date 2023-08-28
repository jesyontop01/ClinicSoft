using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvMstUnitOfMeasurement
    {
        public InvMstUnitOfMeasurement()
        {
            InvMstItems = new HashSet<InvMstItem>();
        }

        public int Uomid { get; set; }
        public string? Uomname { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? Description { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<InvMstItem> InvMstItems { get; set; }
    }
}
