using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AdtBed
    {
        public int BedId { get; set; }
        public string? BedCode { get; set; }
        public int BedNumber { get; set; }
        public int WardId { get; set; }
        public bool IsOccupied { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsReserved { get; set; }
        public bool? OnHold { get; set; }
        public DateTime? HoldedOn { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual AdtMstWard Ward { get; set; } = null!;
    }
}
