using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class RadMstImagingItem
    {
        public RadMstImagingItem()
        {
            RadPatientImagingReports = new HashSet<RadPatientImagingReport>();
            RadPatientImagingRequisitions = new HashSet<RadPatientImagingRequisition>();
        }

        public int ImagingItemId { get; set; }
        public int ImagingTypeId { get; set; }
        public string? ProcedureCode { get; set; }
        public string? ImagingItemName { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public int? TemplateId { get; set; }
        public bool? IsValidForReporting { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual RadMstImagingType ImagingType { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual ICollection<RadPatientImagingReport> RadPatientImagingReports { get; set; }
        public virtual ICollection<RadPatientImagingRequisition> RadPatientImagingRequisitions { get; set; }
    }
}
