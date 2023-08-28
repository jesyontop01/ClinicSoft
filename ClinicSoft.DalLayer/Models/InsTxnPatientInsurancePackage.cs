using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InsTxnPatientInsurancePackage
    {
        public int PatientInsurancePackageId { get; set; }
        public int? PackageId { get; set; }
        public int? PatientId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsCompleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
