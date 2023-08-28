using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class NephHemodialysisRecord
    {
        public int HemodialysisRecordId { get; set; }
        public int PatientId { get; set; }
        public int? PatientVisitId { get; set; }
        public string? Diagnosis { get; set; }
        public string? Schedule { get; set; }
        public DateTime? NextHd { get; set; }
        public DateTime? CurrentHdDate { get; set; }
        public string? IdNo { get; set; }
        public string? HdNo { get; set; }
        public string? TreatmentOrderDryWeight { get; set; }
        public string? TreatmentOrderDialysisFlow { get; set; }
        public string? TreatmentOrderBlood { get; set; }
        public string? TreatmentOrderTimeInMin { get; set; }
        public string? TreatmentOrderUsedNo { get; set; }
        public string? TreatmentOrderBloodTransfusion { get; set; }
        public string? TreatmentOrderHeparineSalineCirculation { get; set; }
        public string? TreatmentOrderHeparineSalineBolus { get; set; }
        public string? TreatmentOrderHeparineSalineContinuous { get; set; }
        public bool? VascularAccessAvf { get; set; }
        public bool? VascularAccessSubclavian { get; set; }
        public bool? VascularAccessJugular { get; set; }
        public bool? VascularAccessFemoralCatheter { get; set; }
        public bool? VascularAccessPermCath { get; set; }
        public string? BloodTransBloodGroup { get; set; }
        public string? BloodTransToday { get; set; }
        public string? BloodTransBagNo { get; set; }
        public bool? BloodTransNextBt { get; set; }
        public DateTime? BloodTransCollectionDate { get; set; }
        public DateTime? BloodTransExpDate { get; set; }
        public string? TreatmentDataPreWeight { get; set; }
        public string? TreatmentDataPostWeight { get; set; }
        public string? TreatmentDataPreTemperature { get; set; }
        public string? TreatmentDataPostTemperature { get; set; }
        public string? TreatmentDataPrePulse { get; set; }
        public string? TreatmentDataPostPulse { get; set; }
        public string? TreatmentDataPreStandBp { get; set; }
        public string? TreatmentDataPostStandBp { get; set; }
        public string? TreatmentDataPreSitBp { get; set; }
        public string? TreatmentDataPostSitBp { get; set; }
        public string? TreatmentDataUfGoal { get; set; }
        public string? TreatmentDataMachineNo { get; set; }
        public string? TreatmentDataMachineConductivity { get; set; }
        public string? TreatmentDataMachineTemperature { get; set; }
        public string? TreatmentDataMachineMachineCheck { get; set; }
        public string? TreatmentDataInitials { get; set; }
        public string? TreatmentDataPreLab { get; set; }
        public string? TreatmentDataPostLab { get; set; }
        public string? TreatmentDataHbPcV { get; set; }
        public string? TreatmentDataBloodSugar { get; set; }
        public string? TreatmentDataTimeOn { get; set; }
        public string? TreatmentDataTimeOnBy { get; set; }
        public string? TreatmentDataTimeOff { get; set; }
        public string? TreatmentDataTimeOffBy { get; set; }
        public string? OnExaminationPallor { get; set; }
        public string? OnExaminationIctercus { get; set; }
        public string? OnExaminationJvp { get; set; }
        public string? OnExaminationRash { get; set; }
        public string? OnExaminationLymphnode { get; set; }
        public string? OnExaminationChest { get; set; }
        public string? OnExaminationCvs { get; set; }
        public string? OnExaminationPa { get; set; }
        public string? OnExaminationSpo2 { get; set; }
        public string? OnExaminationOthers { get; set; }
        public string? ChiefComplaint { get; set; }
        public string? CommentsDrugs { get; set; }
        public string? PostDialysisAssesment { get; set; }
        public string? TotalBloodVolume { get; set; }
        public string? TotalHeparinSaline { get; set; }
        public string? TotalFluidRemoved { get; set; }
        public string? WeightDifference { get; set; }
        public string? PtSentToHospital { get; set; }
        public string? PtSentToHome { get; set; }
        public bool? IsDialyzerDiscard { get; set; }
        public bool? IsSubmitted { get; set; }
        public DateTime? IsSubmittedOn { get; set; }
        public string? CheckedByName { get; set; }
        public string? VerifiedByName { get; set; }
        public string? SignatoryName1 { get; set; }
        public string? SignatoryName2 { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
