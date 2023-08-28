using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ErFileUpload
    {
        public int FileId { get; set; }
        public int? ErpatientId { get; set; }
        public int? PatientId { get; set; }
        public string? FileName { get; set; }
        public string? DisplayName { get; set; }
        public string? FileType { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual ErPatient? Erpatient { get; set; }
        public virtual PatPatient? Patient { get; set; }
    }
}
