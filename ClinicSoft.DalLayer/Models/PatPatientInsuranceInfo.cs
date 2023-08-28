using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PatPatientInsuranceInfo
    {
        public int PatientInsuranceInfoId { get; set; }
        public int PatientId { get; set; }
        public string? InsuranceNumber { get; set; }
        public string? InsuranceName { get; set; }
        public string? CardNumber { get; set; }
        public string? SubscriberFirstName { get; set; }
        public string? SubscriberLastName { get; set; }
        public string? SubscriberGender { get; set; }
        public DateTime? SubscriberDob { get; set; }
        public string? SubscriberIdcardNumber { get; set; }
        public int? SubscriberIdcardType { get; set; }
        public double InitialBalance { get; set; }
        public double CurrentBalance { get; set; }
        public int InsuranceProviderId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string? Imiscode { get; set; }
        public bool? InsHasInsurance { get; set; }
        public string? InsNshiNumber { get; set; }
        public double? InsInsuranceBalance { get; set; }
        public int? InsInsuranceProviderId { get; set; }
        public bool? InsIsFamilyHead { get; set; }
        public string? InsFamilyHeadNshi { get; set; }
        public string? InsFamilyHeadName { get; set; }
        public bool? InsIsFirstServicePoint { get; set; }

        public virtual InsCfgInsuranceProvider InsuranceProvider { get; set; } = null!;
        public virtual PatPatient Patient { get; set; } = null!;
    }
}
