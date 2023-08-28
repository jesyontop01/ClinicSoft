using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AdtMstWard
    {
        public AdtMstWard()
        {
            AdtBeds = new HashSet<AdtBed>();
        }

        public int WardId { get; set; }
        public string? WardCode { get; set; }
        public string WardName { get; set; } = null!;
        public string? WardLocation { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public int? StoreId { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual ICollection<AdtBed> AdtBeds { get; set; }
    }
}
