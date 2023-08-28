using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PatPatient
    {
        public PatPatient()
        {
            AdtPatientAdmissions = new HashSet<AdtPatientAdmission>();
            BilBillItemRequisitions = new HashSet<BilBillItemRequisition>();
            BilTxnBillingTransactions = new HashSet<BilTxnBillingTransaction>();
            BilTxnDeposits = new HashSet<BilTxnDeposit>();
            BilTxnInvoiceReturnItems = new HashSet<BilTxnInvoiceReturnItem>();
            BilTxnInvoiceReturns = new HashSet<BilTxnInvoiceReturn>();
            ClnActiveMedicals = new HashSet<ClnActiveMedical>();
            ClnAllergies = new HashSet<ClnAllergy>();
            ClnFamilyHistories = new HashSet<ClnFamilyHistory>();
            ClnHomeMedications = new HashSet<ClnHomeMedication>();
            ClnMedicationPrescriptions = new HashSet<ClnMedicationPrescription>();
            ClnNotesEmergencies = new HashSet<ClnNotesEmergency>();
            ClnPastMedicals = new HashSet<ClnPastMedical>();
            ClnSocialHistories = new HashSet<ClnSocialHistory>();
            ClnSurgicalHistories = new HashSet<ClnSurgicalHistory>();
            ErFileUploads = new HashSet<ErFileUpload>();
            ErPatients = new HashSet<ErPatient>();
            LabTestRequisitions = new HashSet<LabTestRequisition>();
            MatFileUploads = new HashSet<MatFileUpload>();
            MatMaternityAncs = new HashSet<MatMaternityAnc>();
            MatPatients = new HashSet<MatPatient>();
            MatRegisters = new HashSet<MatRegister>();
            MatTxnPatientPayments = new HashSet<MatTxnPatientPayment>();
            MrTxnInpatientDiagnoses = new HashSet<MrTxnInpatientDiagnosis>();
            MrTxnOutpatientFinalDiagnoses = new HashSet<MrTxnOutpatientFinalDiagnosis>();
            OtTxnBookingDetails = new HashSet<OtTxnBookingDetail>();
            OtTxnOtTeamsInfos = new HashSet<OtTxnOtTeamsInfo>();
            PatAppointments = new HashSet<PatAppointment>();
            PatHealthCardInfos = new HashSet<PatHealthCardInfo>();
            PatPatientAddresses = new HashSet<PatPatientAddress>();
            PatPatientInsuranceInfos = new HashSet<PatPatientInsuranceInfo>();
            PatPatientKinOrEmergencyContacts = new HashSet<PatPatientKinOrEmergencyContact>();
            PatPatientMemberships = new HashSet<PatPatientMembership>();
            PatPatientVisits = new HashSet<PatPatientVisit>();
            PatSsuInformations = new HashSet<PatSsuInformation>();
            PhrmBilTransactionItems = new HashSet<PhrmBilTransactionItem>();
            PhrmBilTransactions = new HashSet<PhrmBilTransaction>();
            PhrmPrescriptions = new HashSet<PhrmPrescription>();
            PhrmRequisitions = new HashSet<PhrmRequisition>();
            PhrmSaleItems = new HashSet<PhrmSaleItem>();
            PhrmSaleItemsReturns = new HashSet<PhrmSaleItemsReturn>();
            PhrmTxnInvoices = new HashSet<PhrmTxnInvoice>();
            PhrmTxnSettlements = new HashSet<PhrmTxnSettlement>();
            RadPatientImagingReports = new HashSet<RadPatientImagingReport>();
            WardInvConsumptionReceipts = new HashSet<WardInvConsumptionReceipt>();
        }

        public int PatientId { get; set; }
        public string Lpno { get; set; } = null!;
        public string ClinicCardNo { get; set; } = null!;
        public string? Salutation { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string Gender { get; set; } = null!;
        public string? Age { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public int? CountrySubDivisionId { get; set; }
        public int? CountryId { get; set; }
        public string? BloodGroup { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Email { get; set; }
        public string? Empi { get; set; }
        public bool? PhoneAcceptsText { get; set; }
        public string? IdcardNumber { get; set; }
        public string? IdcardType { get; set; }
        public string? Race { get; set; }
        public string? EthnicGroup { get; set; }
        public string? Occupation { get; set; }
        public string? PreviousLastName { get; set; }
        public string? EmployerInfo { get; set; }
        public bool? IsDobVerified { get; set; }
        public int? MembershipTypeId { get; set; }
        public bool? IsStaff { get; set; }
        public bool? IsOutdoorPat { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? PatientNameLocal { get; set; }
        public int? DialysisCode { get; set; }
        public string? LandLineNumber { get; set; }
        public string? PassportNumber { get; set; }
        public string? ShortName { get; set; }
        public bool? InsHasInsurance { get; set; }
        public string? InsNshiNumber { get; set; }
        public double? InsInsuranceBalance { get; set; }
        public bool? IsRetired { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public bool? SsuIsActive { get; set; }
        public long? InsLatestClaimCode { get; set; }
        public bool? IsVaccinationPatient { get; set; }
        public bool? IsVaccinationActive { get; set; }
        public int? VaccinationRegNo { get; set; }
        public int? VaccinationFiscalYearId { get; set; }
        public int? MunicipalityId { get; set; }

        public virtual PatCfgMembershipType? MembershipType { get; set; }
        public virtual PatPatientGurantorInfo? PatPatientGurantorInfo { get; set; }
        public virtual ICollection<AdtPatientAdmission> AdtPatientAdmissions { get; set; }
        public virtual ICollection<BilBillItemRequisition> BilBillItemRequisitions { get; set; }
        public virtual ICollection<BilTxnBillingTransaction> BilTxnBillingTransactions { get; set; }
        public virtual ICollection<BilTxnDeposit> BilTxnDeposits { get; set; }
        public virtual ICollection<BilTxnInvoiceReturnItem> BilTxnInvoiceReturnItems { get; set; }
        public virtual ICollection<BilTxnInvoiceReturn> BilTxnInvoiceReturns { get; set; }
        public virtual ICollection<ClnActiveMedical> ClnActiveMedicals { get; set; }
        public virtual ICollection<ClnAllergy> ClnAllergies { get; set; }
        public virtual ICollection<ClnFamilyHistory> ClnFamilyHistories { get; set; }
        public virtual ICollection<ClnHomeMedication> ClnHomeMedications { get; set; }
        public virtual ICollection<ClnMedicationPrescription> ClnMedicationPrescriptions { get; set; }
        public virtual ICollection<ClnNotesEmergency> ClnNotesEmergencies { get; set; }
        public virtual ICollection<ClnPastMedical> ClnPastMedicals { get; set; }
        public virtual ICollection<ClnSocialHistory> ClnSocialHistories { get; set; }
        public virtual ICollection<ClnSurgicalHistory> ClnSurgicalHistories { get; set; }
        public virtual ICollection<ErFileUpload> ErFileUploads { get; set; }
        public virtual ICollection<ErPatient> ErPatients { get; set; }
        public virtual ICollection<LabTestRequisition> LabTestRequisitions { get; set; }
        public virtual ICollection<MatFileUpload> MatFileUploads { get; set; }
        public virtual ICollection<MatMaternityAnc> MatMaternityAncs { get; set; }
        public virtual ICollection<MatPatient> MatPatients { get; set; }
        public virtual ICollection<MatRegister> MatRegisters { get; set; }
        public virtual ICollection<MatTxnPatientPayment> MatTxnPatientPayments { get; set; }
        public virtual ICollection<MrTxnInpatientDiagnosis> MrTxnInpatientDiagnoses { get; set; }
        public virtual ICollection<MrTxnOutpatientFinalDiagnosis> MrTxnOutpatientFinalDiagnoses { get; set; }
        public virtual ICollection<OtTxnBookingDetail> OtTxnBookingDetails { get; set; }
        public virtual ICollection<OtTxnOtTeamsInfo> OtTxnOtTeamsInfos { get; set; }
        public virtual ICollection<PatAppointment> PatAppointments { get; set; }
        public virtual ICollection<PatHealthCardInfo> PatHealthCardInfos { get; set; }
        public virtual ICollection<PatPatientAddress> PatPatientAddresses { get; set; }
        public virtual ICollection<PatPatientInsuranceInfo> PatPatientInsuranceInfos { get; set; }
        public virtual ICollection<PatPatientKinOrEmergencyContact> PatPatientKinOrEmergencyContacts { get; set; }
        public virtual ICollection<PatPatientMembership> PatPatientMemberships { get; set; }
        public virtual ICollection<PatPatientVisit> PatPatientVisits { get; set; }
        public virtual ICollection<PatSsuInformation> PatSsuInformations { get; set; }
        public virtual ICollection<PhrmBilTransactionItem> PhrmBilTransactionItems { get; set; }
        public virtual ICollection<PhrmBilTransaction> PhrmBilTransactions { get; set; }
        public virtual ICollection<PhrmPrescription> PhrmPrescriptions { get; set; }
        public virtual ICollection<PhrmRequisition> PhrmRequisitions { get; set; }
        public virtual ICollection<PhrmSaleItem> PhrmSaleItems { get; set; }
        public virtual ICollection<PhrmSaleItemsReturn> PhrmSaleItemsReturns { get; set; }
        public virtual ICollection<PhrmTxnInvoice> PhrmTxnInvoices { get; set; }
        public virtual ICollection<PhrmTxnSettlement> PhrmTxnSettlements { get; set; }
        public virtual ICollection<RadPatientImagingReport> RadPatientImagingReports { get; set; }
        public virtual ICollection<WardInvConsumptionReceipt> WardInvConsumptionReceipts { get; set; }
    }
}
