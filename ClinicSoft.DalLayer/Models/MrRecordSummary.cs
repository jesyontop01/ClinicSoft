using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MrRecordSummary
    {
        public MrRecordSummary()
        {
            MrTxnInpatientDiagnoses = new HashSet<MrTxnInpatientDiagnosis>();
        }

        public int MedicalRecordId { get; set; }
        public int PatientVisitId { get; set; }
        public int PatientId { get; set; }
        public string? FileNumber { get; set; }
        public int DischargeTypeId { get; set; }
        public int? DischargeConditionId { get; set; }
        public int? DeliveryTypeId { get; set; }
        public int? DeathPeriodTypeId { get; set; }
        public int? OperationTypeId { get; set; }
        public int? OperatedByDoctor { get; set; }
        public int? GravitaId { get; set; }
        public int? GestationalWeek { get; set; }
        public string? OperationDiagnosis { get; set; }
        public string? Remarks { get; set; }
        public string? AllTests { get; set; }
        public string? Icdcode { get; set; }
        public DateTime? OperationDate { get; set; }
        public bool? IsOperationConducted { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? ReferredDate { get; set; }
        public TimeSpan? ReferredTime { get; set; }
        public int? NumberOfBabies { get; set; }
        public int? BloodLost { get; set; }
        public string? BloodLostUnit { get; set; }
        public string? GestationalUnit { get; set; }
        public int? GestationalDay { get; set; }

        public virtual ICollection<MrTxnInpatientDiagnosis> MrTxnInpatientDiagnoses { get; set; }
    }
}
