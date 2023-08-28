using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class FrcDesignation
    {
        public FrcDesignation()
        {
            FrcFractionCalculations = new HashSet<FrcFractionCalculation>();
        }

        public int DesignationId { get; set; }
        public string DesignationName { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<FrcFractionCalculation> FrcFractionCalculations { get; set; }
    }
}
