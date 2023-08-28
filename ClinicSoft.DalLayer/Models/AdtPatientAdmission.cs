using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AdtPatientAdmission
    {
        public int PatientVisitId { get; set; }
        public int PatientId { get; set; }
        public int PatientAdmissionId { get; set; }
        public int? AdmittingDoctorId { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public string? AdmissionNotes { get; set; }
        public string? AdmissionOrders { get; set; }
        public string? AdmissionStatus { get; set; }
        public string? BillStatusOnDischarge { get; set; }
        public int? DischargedBy { get; set; }
        public string? DischargeRemarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? CareOfPersonName { get; set; }
        public string? CareOfPersonPhoneNo { get; set; }
        public string? CareOfPersonRelation { get; set; }
        public DateTime? CancelledOn { get; set; }
        public int? CancelledBy { get; set; }
        public string? CancelledRemark { get; set; }
        public string? ProcedureType { get; set; }
        public bool? IsPoliceCase { get; set; }
        public bool? IsInsurancePatient { get; set; }
        public int? DiscountSchemeId { get; set; }
        public string? AdmissionCase { get; set; }
        public bool IsItemDiscountEnabled { get; set; }
        public double? ProvisionalDiscPercent { get; set; }

        public virtual EmpEmployee? AdmittingDoctor { get; set; }
        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual EmpEmployee? DischargedByNavigation { get; set; }
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual PatPatient Patient { get; set; } = null!;
        public virtual PatPatientVisit PatientVisit { get; set; } = null!;
    }
}
