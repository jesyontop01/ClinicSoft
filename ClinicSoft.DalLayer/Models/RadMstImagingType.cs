using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class RadMstImagingType
    {
        public RadMstImagingType()
        {
            RadMstImagingItems = new HashSet<RadMstImagingItem>();
            RadReportingDoctors = new HashSet<RadReportingDoctor>();
        }

        public int ImagingTypeId { get; set; }
        public string ImagingTypeName { get; set; } = null!;
        public string? ProcedureCoding { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual ICollection<RadMstImagingItem> RadMstImagingItems { get; set; }
        public virtual ICollection<RadReportingDoctor> RadReportingDoctors { get; set; }
    }
}
