using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MstIcd10
    {
        public MstIcd10()
        {
            ClnActiveMedicals = new HashSet<ClnActiveMedical>();
            ClnFamilyHistories = new HashSet<ClnFamilyHistory>();
            ClnPastMedicals = new HashSet<ClnPastMedical>();
            ClnSurgicalHistories = new HashSet<ClnSurgicalHistory>();
            MrTxnInpatientDiagnoses = new HashSet<MrTxnInpatientDiagnosis>();
            MrTxnOutpatientFinalDiagnoses = new HashSet<MrTxnOutpatientFinalDiagnosis>();
        }

        public int Icd10id { get; set; }
        public string IcdshortCode { get; set; } = null!;
        public string Icd10code { get; set; } = null!;
        public bool? ValidForCoding { get; set; }
        public string? Icd10description { get; set; }
        public string? Icd10longDescription { get; set; }
        public bool? Active { get; set; }
        public bool? Revision { get; set; }
        public int DiseaseGroupId { get; set; }

        public virtual IcdDiseaseGroup DiseaseGroup { get; set; } = null!;
        public virtual ICollection<ClnActiveMedical> ClnActiveMedicals { get; set; }
        public virtual ICollection<ClnFamilyHistory> ClnFamilyHistories { get; set; }
        public virtual ICollection<ClnPastMedical> ClnPastMedicals { get; set; }
        public virtual ICollection<ClnSurgicalHistory> ClnSurgicalHistories { get; set; }
        public virtual ICollection<MrTxnInpatientDiagnosis> MrTxnInpatientDiagnoses { get; set; }
        public virtual ICollection<MrTxnOutpatientFinalDiagnosis> MrTxnOutpatientFinalDiagnoses { get; set; }
    }
}
