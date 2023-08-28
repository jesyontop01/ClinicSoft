using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class RadReportingDoctor
    {
        public int ReportingDoctorId { get; set; }
        public string DoctorSignatureJson { get; set; } = null!;
        public int ImagingTypeId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual RadMstImagingType ImagingType { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
    }
}
