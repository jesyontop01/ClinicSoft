using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnSurgicalHistory
    {
        public int SurgicalHistoryId { get; set; }
        public int PatientId { get; set; }
        public string? SurgeryType { get; set; }
        public string? Icd10code { get; set; }
        public string? Icd10description { get; set; }
        public DateTime? SurgeryDate { get; set; }
        public string? Note { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual MstIcd10? Icd10codeNavigation { get; set; }
        public virtual PatPatient Patient { get; set; } = null!;
    }
}
