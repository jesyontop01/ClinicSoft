using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class EmpEmployee
    {
        public EmpEmployee()
        {
            AdtBedCreatedByNavigations = new HashSet<AdtBed>();
            AdtBedModifiedByNavigations = new HashSet<AdtBed>();
            AdtDischargeSummaryAnaesthetists = new HashSet<AdtDischargeSummary>();
            AdtDischargeSummaryConsultants = new HashSet<AdtDischargeSummary>();
            AdtDischargeSummaryCreatedByNavigations = new HashSet<AdtDischargeSummary>();
            AdtDischargeSummaryDoctorIncharges = new HashSet<AdtDischargeSummary>();
            AdtDischargeSummaryModifiedByNavigations = new HashSet<AdtDischargeSummary>();
            AdtDischargeSummaryResidenceDrs = new HashSet<AdtDischargeSummary>();
            AdtDischargeTypeCreatedByNavigations = new HashSet<AdtDischargeType>();
            AdtDischargeTypeModifiedByNavigations = new HashSet<AdtDischargeType>();
            AdtMstBedFeatureCreatedByNavigations = new HashSet<AdtMstBedFeature>();
            AdtMstBedFeatureModifiedByNavigations = new HashSet<AdtMstBedFeature>();
            AdtMstWardCreatedByNavigations = new HashSet<AdtMstWard>();
            AdtMstWardModifiedByNavigations = new HashSet<AdtMstWard>();
            AdtPatientAdmissionAdmittingDoctors = new HashSet<AdtPatientAdmission>();
            AdtPatientAdmissionCreatedByNavigations = new HashSet<AdtPatientAdmission>();
            AdtPatientAdmissionDischargedByNavigations = new HashSet<AdtPatientAdmission>();
            AdtPatientAdmissionModifiedByNavigations = new HashSet<AdtPatientAdmission>();
            BilBillItemRequisitionCreatedByNavigations = new HashSet<BilBillItemRequisition>();
            BilBillItemRequisitionProviders = new HashSet<BilBillItemRequisition>();
            BilCfgCounters = new HashSet<BilCfgCounter>();
            BilCfgPackageCreatedByNavigations = new HashSet<BilCfgPackage>();
            BilCfgPackageModifiedByNavigations = new HashSet<BilCfgPackage>();
            BilTxnBillingTransactionItemCreatedByNavigations = new HashSet<BilTxnBillingTransactionItem>();
            BilTxnBillingTransactionItemRequestedByNavigations = new HashSet<BilTxnBillingTransactionItem>();
            BilTxnBillingTransactions = new HashSet<BilTxnBillingTransaction>();
            BilTxnCashHandovers = new HashSet<BilTxnCashHandover>();
            BilTxnDeposits = new HashSet<BilTxnDeposit>();
            BilTxnInvoiceReturnItems = new HashSet<BilTxnInvoiceReturnItem>();
            BilTxnInvoiceReturns = new HashSet<BilTxnInvoiceReturn>();
            ClnMedicationPrescriptions = new HashSet<ClnMedicationPrescription>();
            ClnMstNoteTypes = new HashSet<ClnMstNoteType>();
            ClnNotes = new HashSet<ClnNote>();
            CssdTxnItemTransactionCreatedByNavigations = new HashSet<CssdTxnItemTransaction>();
            CssdTxnItemTransactionDisinfectedByNavigations = new HashSet<CssdTxnItemTransaction>();
            CssdTxnItemTransactionDispatchedByNavigations = new HashSet<CssdTxnItemTransaction>();
            CssdTxnItemTransactionRequestedByNavigations = new HashSet<CssdTxnItemTransaction>();
            FrcFractionCalculations = new HashSet<FrcFractionCalculation>();
            IcdDiseaseGroups = new HashSet<IcdDiseaseGroup>();
            IcdReportingGroups = new HashSet<IcdReportingGroup>();
            InctvCfgItemGroupDistributions = new HashSet<InctvCfgItemGroupDistribution>();
            InctvMapEmployeeBillItemsMaps = new HashSet<InctvMapEmployeeBillItemsMap>();
            InsInsuranceBalanceAmountHistories = new HashSet<InsInsuranceBalanceAmountHistory>();
            InvAssetConditionCheckListCreatedByNavigations = new HashSet<InvAssetConditionCheckList>();
            InvAssetConditionCheckListModifiedByNavigations = new HashSet<InvAssetConditionCheckList>();
            InvAssetContractFileInfoCreatedByNavigations = new HashSet<InvAssetContractFileInfo>();
            InvAssetContractFileInfoModifiedByNavigations = new HashSet<InvAssetContractFileInfo>();
            InvAssetFaultHistoryCreatedByNavigations = new HashSet<InvAssetFaultHistory>();
            InvAssetFaultHistoryModifiedByNavigations = new HashSet<InvAssetFaultHistory>();
            InvAssetInsuranceCreatedByNavigations = new HashSet<InvAssetInsurance>();
            InvAssetInsuranceModifiedByNavigations = new HashSet<InvAssetInsurance>();
            InvAssetLocationHistories = new HashSet<InvAssetLocationHistory>();
            InvAssetServiceHistoryCreatedByNavigations = new HashSet<InvAssetServiceHistory>();
            InvAssetServiceHistoryModifiedByNavigations = new HashSet<InvAssetServiceHistory>();
            InvMstAccountHeads = new HashSet<InvMstAccountHead>();
            InvMstAssetCategoryCreatedByNavigations = new HashSet<InvMstAssetCategory>();
            InvMstAssetCategoryModifiedByNavigations = new HashSet<InvMstAssetCategory>();
            InvMstAssetDepreciationMethods = new HashSet<InvMstAssetDepreciationMethod>();
            InvMstCompanies = new HashSet<InvMstCompany>();
            InvMstItemCategories = new HashSet<InvMstItemCategory>();
            InvMstItems = new HashSet<InvMstItem>();
            InvMstPackagingTypes = new HashSet<InvMstPackagingType>();
            InvMstStockCreatedByNavigations = new HashSet<InvMstStock>();
            InvMstStockModifiedByNavigations = new HashSet<InvMstStock>();
            InvMstUnitOfMeasurements = new HashSet<InvMstUnitOfMeasurement>();
            InvMstVendors = new HashSet<InvMstVendor>();
            InvTxnAssetDepreciationCreatedByNavigations = new HashSet<InvTxnAssetDepreciation>();
            InvTxnAssetDepreciationModifiedByNavigations = new HashSet<InvTxnAssetDepreciation>();
            InvTxnFixedAssetRequisitionItems = new HashSet<InvTxnFixedAssetRequisitionItem>();
            InvTxnFixedAssetRequisitions = new HashSet<InvTxnFixedAssetRequisition>();
            InvTxnFixedAssetReturnItems = new HashSet<InvTxnFixedAssetReturnItem>();
            InvTxnFixedAssetReturns = new HashSet<InvTxnFixedAssetReturn>();
            InvTxnFixedAssetStocks = new HashSet<InvTxnFixedAssetStock>();
            InvTxnGoodsReceiptItems = new HashSet<InvTxnGoodsReceiptItem>();
            InvTxnGoodsReceipts = new HashSet<InvTxnGoodsReceipt>();
            InvTxnPurchaseOrderItemAuthorizedByNavigations = new HashSet<InvTxnPurchaseOrderItem>();
            InvTxnPurchaseOrderItemCreatedByNavigations = new HashSet<InvTxnPurchaseOrderItem>();
            InvTxnPurchaseOrders = new HashSet<InvTxnPurchaseOrder>();
            InvTxnRequisitionItemAuthorizedByNavigations = new HashSet<InvTxnRequisitionItem>();
            InvTxnRequisitionItemCreatedByNavigations = new HashSet<InvTxnRequisitionItem>();
            InvTxnRequisitions = new HashSet<InvTxnRequisition>();
            InvTxnReturnToVendorItems = new HashSet<InvTxnReturnToVendorItem>();
            InvTxnReturnToVendors = new HashSet<InvTxnReturnToVendor>();
            LabTestRequisitions = new HashSet<LabTestRequisition>();
            MatTxnPatientPayments = new HashSet<MatTxnPatientPayment>();
            MrTxnOutpatientFinalDiagnosisCreatedByNavigations = new HashSet<MrTxnOutpatientFinalDiagnosis>();
            MrTxnOutpatientFinalDiagnosisModifiedByNavigations = new HashSet<MrTxnOutpatientFinalDiagnosis>();
            MstDepartmentCreatedByNavigations = new HashSet<MstDepartment>();
            MstDepartmentModifiedByNavigations = new HashSet<MstDepartment>();
            OtTxnOtTeamsInfos = new HashSet<OtTxnOtTeamsInfo>();
            PatAppointments = new HashSet<PatAppointment>();
            PatCfgMembershipTypeCreatedByNavigations = new HashSet<PatCfgMembershipType>();
            PatCfgMembershipTypeModifiedByNavigations = new HashSet<PatCfgMembershipType>();
            PatPatientMembershipCreatedByNavigations = new HashSet<PatPatientMembership>();
            PatPatientMembershipModifiedByNavigations = new HashSet<PatPatientMembership>();
            PatPatientVisits = new HashSet<PatPatientVisit>();
            PhrmBilTransactionItems = new HashSet<PhrmBilTransactionItem>();
            PhrmBilTransactions = new HashSet<PhrmBilTransaction>();
            PhrmFiscalYearStocks = new HashSet<PhrmFiscalYearStock>();
            PhrmGoodsReceiptItems = new HashSet<PhrmGoodsReceiptItem>();
            PhrmGoodsReceipts = new HashSet<PhrmGoodsReceipt>();
            PhrmHistoryItems = new HashSet<PhrmHistoryItem>();
            PhrmHistoryStockBatchExpiries = new HashSet<PhrmHistoryStockBatchExpiry>();
            PhrmHistoryStockMrps = new HashSet<PhrmHistoryStockMrp>();
            PhrmMstCategories = new HashSet<PhrmMstCategory>();
            PhrmMstCompanies = new HashSet<PhrmMstCompany>();
            PhrmMstCounters = new HashSet<PhrmMstCounter>();
            PhrmMstItemCreatedByNavigations = new HashSet<PhrmMstItem>();
            PhrmMstItemModifiedByNavigations = new HashSet<PhrmMstItem>();
            PhrmMstItemTypes = new HashSet<PhrmMstItemType>();
            PhrmMstStockCreatedByNavigations = new HashSet<PhrmMstStock>();
            PhrmMstStockModifiedByNavigations = new HashSet<PhrmMstStock>();
            PhrmMstStores = new HashSet<PhrmMstStore>();
            PhrmMstSuppliers = new HashSet<PhrmMstSupplier>();
            PhrmMstTaxes = new HashSet<PhrmMstTax>();
            PhrmMstUnitOfMeasurements = new HashSet<PhrmMstUnitOfMeasurement>();
            PhrmPrescriptionCreatedByNavigations = new HashSet<PhrmPrescription>();
            PhrmPrescriptionItems = new HashSet<PhrmPrescriptionItem>();
            PhrmPrescriptionProviders = new HashSet<PhrmPrescription>();
            PhrmPurchaseOrderItemAuthorizedByNavigations = new HashSet<PhrmPurchaseOrderItem>();
            PhrmPurchaseOrderItemCreatedByNavigations = new HashSet<PhrmPurchaseOrderItem>();
            PhrmPurchaseOrders = new HashSet<PhrmPurchaseOrder>();
            PhrmReturnToSupplierItems = new HashSet<PhrmReturnToSupplierItem>();
            PhrmReturnToSuppliers = new HashSet<PhrmReturnToSupplier>();
            PhrmSaleItems = new HashSet<PhrmSaleItem>();
            PhrmSaleItemsReturns = new HashSet<PhrmSaleItemsReturn>();
            PhrmStockManages = new HashSet<PhrmStockManage>();
            PhrmStockTxnItems = new HashSet<PhrmStockTxnItem>();
            PhrmTxnDispensaryStockCreatedByNavigations = new HashSet<PhrmTxnDispensaryStock>();
            PhrmTxnDispensaryStockModifiedByNavigations = new HashSet<PhrmTxnDispensaryStock>();
            PhrmTxnDispensaryStockTransactions = new HashSet<PhrmTxnDispensaryStockTransaction>();
            PhrmTxnInvoiceItems = new HashSet<PhrmTxnInvoiceItem>();
            PhrmTxnInvoiceReturnItems = new HashSet<PhrmTxnInvoiceReturnItem>();
            PhrmTxnInvoiceReturns = new HashSet<PhrmTxnInvoiceReturn>();
            PhrmTxnInvoices = new HashSet<PhrmTxnInvoice>();
            PhrmTxnStockCreatedByNavigations = new HashSet<PhrmTxnStock>();
            PhrmTxnStockModifiedByNavigations = new HashSet<PhrmTxnStock>();
            PhrmTxnStockTransactions = new HashSet<PhrmTxnStockTransaction>();
            PhrmWriteOffItems = new HashSet<PhrmWriteOffItem>();
            PhrmWriteOffs = new HashSet<PhrmWriteOff>();
            RadMstImagingItemCreatedByNavigations = new HashSet<RadMstImagingItem>();
            RadMstImagingItemModifiedByNavigations = new HashSet<RadMstImagingItem>();
            RadMstImagingTypeCreatedByNavigations = new HashSet<RadMstImagingType>();
            RadMstImagingTypeModifiedByNavigations = new HashSet<RadMstImagingType>();
            RadReportingDoctorCreatedByNavigations = new HashSet<RadReportingDoctor>();
            RadReportingDoctorModifiedByNavigations = new HashSet<RadReportingDoctor>();
            SchEmployeeSchedules = new HashSet<SchEmployeeSchedule>();
            SchEmployeeShifts = new HashSet<SchEmployeeShift>();
            SchMapEmployeeShifts = new HashSet<SchMapEmployeeShift>();
            TxnEmpCashTransactions = new HashSet<TxnEmpCashTransaction>();
            TxnEmpDueAmounts = new HashSet<TxnEmpDueAmount>();
            WardInvConsumptionReceiptCreatedByNavigations = new HashSet<WardInvConsumptionReceipt>();
            WardInvConsumptionReceiptModifiedByNavigations = new HashSet<WardInvConsumptionReceipt>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public string? Lpno { get; set; }
        public string? Salutation { get; set; }
        public string? Gender { get; set; }
        public string? ContactNumber { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public string? Email { get; set; }
        public int? EmployeeRoleId { get; set; }
        public int? EmployeeTypeId { get; set; }
        public string? ContactAddress { get; set; }
        public short? Extension { get; set; }
        public short? SpeedDial { get; set; }
        public string? OfficeHour { get; set; }
        public string? RoomNo { get; set; }
        public string? Signature { get; set; }
        public string? LongSignature { get; set; }
        public string? MedCertificationNo { get; set; }
        public string? ImageFullPath { get; set; }
        public string? ImageName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? LabSignature { get; set; }
        public bool? IsAppointmentApplicable { get; set; }
        public int? DisplaySequence { get; set; }
        public string? SignatoryImageName { get; set; }
        public string? FullName { get; set; }
        public bool IsExternal { get; set; }
        public string? Pannumber { get; set; }
        public double? Tdspercent { get; set; }
        public bool? IsIncentiveApplicable { get; set; }
        public string? RadiologySignature { get; set; }
        public string? BloodGroup { get; set; }
        public string? DriverLicenseNo { get; set; }
        public string? NursingCertificationNo { get; set; }
        public string? HealthProfessionalCertificationNo { get; set; }
        public string? Phone { get; set; }

        public virtual MstDepartment? Department { get; set; }
        public virtual EmpEmployeeRole? EmployeeRole { get; set; }
        public virtual EmpEmployeeType? EmployeeType { get; set; }
        public virtual InvMstTerm? InvMstTerm { get; set; }
        public virtual RbacUser? RbacUser { get; set; }
        public virtual ICollection<AdtBed> AdtBedCreatedByNavigations { get; set; }
        public virtual ICollection<AdtBed> AdtBedModifiedByNavigations { get; set; }
        public virtual ICollection<AdtDischargeSummary> AdtDischargeSummaryAnaesthetists { get; set; }
        public virtual ICollection<AdtDischargeSummary> AdtDischargeSummaryConsultants { get; set; }
        public virtual ICollection<AdtDischargeSummary> AdtDischargeSummaryCreatedByNavigations { get; set; }
        public virtual ICollection<AdtDischargeSummary> AdtDischargeSummaryDoctorIncharges { get; set; }
        public virtual ICollection<AdtDischargeSummary> AdtDischargeSummaryModifiedByNavigations { get; set; }
        public virtual ICollection<AdtDischargeSummary> AdtDischargeSummaryResidenceDrs { get; set; }
        public virtual ICollection<AdtDischargeType> AdtDischargeTypeCreatedByNavigations { get; set; }
        public virtual ICollection<AdtDischargeType> AdtDischargeTypeModifiedByNavigations { get; set; }
        public virtual ICollection<AdtMstBedFeature> AdtMstBedFeatureCreatedByNavigations { get; set; }
        public virtual ICollection<AdtMstBedFeature> AdtMstBedFeatureModifiedByNavigations { get; set; }
        public virtual ICollection<AdtMstWard> AdtMstWardCreatedByNavigations { get; set; }
        public virtual ICollection<AdtMstWard> AdtMstWardModifiedByNavigations { get; set; }
        public virtual ICollection<AdtPatientAdmission> AdtPatientAdmissionAdmittingDoctors { get; set; }
        public virtual ICollection<AdtPatientAdmission> AdtPatientAdmissionCreatedByNavigations { get; set; }
        public virtual ICollection<AdtPatientAdmission> AdtPatientAdmissionDischargedByNavigations { get; set; }
        public virtual ICollection<AdtPatientAdmission> AdtPatientAdmissionModifiedByNavigations { get; set; }
        public virtual ICollection<BilBillItemRequisition> BilBillItemRequisitionCreatedByNavigations { get; set; }
        public virtual ICollection<BilBillItemRequisition> BilBillItemRequisitionProviders { get; set; }
        public virtual ICollection<BilCfgCounter> BilCfgCounters { get; set; }
        public virtual ICollection<BilCfgPackage> BilCfgPackageCreatedByNavigations { get; set; }
        public virtual ICollection<BilCfgPackage> BilCfgPackageModifiedByNavigations { get; set; }
        public virtual ICollection<BilTxnBillingTransactionItem> BilTxnBillingTransactionItemCreatedByNavigations { get; set; }
        public virtual ICollection<BilTxnBillingTransactionItem> BilTxnBillingTransactionItemRequestedByNavigations { get; set; }
        public virtual ICollection<BilTxnBillingTransaction> BilTxnBillingTransactions { get; set; }
        public virtual ICollection<BilTxnCashHandover> BilTxnCashHandovers { get; set; }
        public virtual ICollection<BilTxnDeposit> BilTxnDeposits { get; set; }
        public virtual ICollection<BilTxnInvoiceReturnItem> BilTxnInvoiceReturnItems { get; set; }
        public virtual ICollection<BilTxnInvoiceReturn> BilTxnInvoiceReturns { get; set; }
        public virtual ICollection<ClnMedicationPrescription> ClnMedicationPrescriptions { get; set; }
        public virtual ICollection<ClnMstNoteType> ClnMstNoteTypes { get; set; }
        public virtual ICollection<ClnNote> ClnNotes { get; set; }
        public virtual ICollection<CssdTxnItemTransaction> CssdTxnItemTransactionCreatedByNavigations { get; set; }
        public virtual ICollection<CssdTxnItemTransaction> CssdTxnItemTransactionDisinfectedByNavigations { get; set; }
        public virtual ICollection<CssdTxnItemTransaction> CssdTxnItemTransactionDispatchedByNavigations { get; set; }
        public virtual ICollection<CssdTxnItemTransaction> CssdTxnItemTransactionRequestedByNavigations { get; set; }
        public virtual ICollection<FrcFractionCalculation> FrcFractionCalculations { get; set; }
        public virtual ICollection<IcdDiseaseGroup> IcdDiseaseGroups { get; set; }
        public virtual ICollection<IcdReportingGroup> IcdReportingGroups { get; set; }
        public virtual ICollection<InctvCfgItemGroupDistribution> InctvCfgItemGroupDistributions { get; set; }
        public virtual ICollection<InctvMapEmployeeBillItemsMap> InctvMapEmployeeBillItemsMaps { get; set; }
        public virtual ICollection<InsInsuranceBalanceAmountHistory> InsInsuranceBalanceAmountHistories { get; set; }
        public virtual ICollection<InvAssetConditionCheckList> InvAssetConditionCheckListCreatedByNavigations { get; set; }
        public virtual ICollection<InvAssetConditionCheckList> InvAssetConditionCheckListModifiedByNavigations { get; set; }
        public virtual ICollection<InvAssetContractFileInfo> InvAssetContractFileInfoCreatedByNavigations { get; set; }
        public virtual ICollection<InvAssetContractFileInfo> InvAssetContractFileInfoModifiedByNavigations { get; set; }
        public virtual ICollection<InvAssetFaultHistory> InvAssetFaultHistoryCreatedByNavigations { get; set; }
        public virtual ICollection<InvAssetFaultHistory> InvAssetFaultHistoryModifiedByNavigations { get; set; }
        public virtual ICollection<InvAssetInsurance> InvAssetInsuranceCreatedByNavigations { get; set; }
        public virtual ICollection<InvAssetInsurance> InvAssetInsuranceModifiedByNavigations { get; set; }
        public virtual ICollection<InvAssetLocationHistory> InvAssetLocationHistories { get; set; }
        public virtual ICollection<InvAssetServiceHistory> InvAssetServiceHistoryCreatedByNavigations { get; set; }
        public virtual ICollection<InvAssetServiceHistory> InvAssetServiceHistoryModifiedByNavigations { get; set; }
        public virtual ICollection<InvMstAccountHead> InvMstAccountHeads { get; set; }
        public virtual ICollection<InvMstAssetCategory> InvMstAssetCategoryCreatedByNavigations { get; set; }
        public virtual ICollection<InvMstAssetCategory> InvMstAssetCategoryModifiedByNavigations { get; set; }
        public virtual ICollection<InvMstAssetDepreciationMethod> InvMstAssetDepreciationMethods { get; set; }
        public virtual ICollection<InvMstCompany> InvMstCompanies { get; set; }
        public virtual ICollection<InvMstItemCategory> InvMstItemCategories { get; set; }
        public virtual ICollection<InvMstItem> InvMstItems { get; set; }
        public virtual ICollection<InvMstPackagingType> InvMstPackagingTypes { get; set; }
        public virtual ICollection<InvMstStock> InvMstStockCreatedByNavigations { get; set; }
        public virtual ICollection<InvMstStock> InvMstStockModifiedByNavigations { get; set; }
        public virtual ICollection<InvMstUnitOfMeasurement> InvMstUnitOfMeasurements { get; set; }
        public virtual ICollection<InvMstVendor> InvMstVendors { get; set; }
        public virtual ICollection<InvTxnAssetDepreciation> InvTxnAssetDepreciationCreatedByNavigations { get; set; }
        public virtual ICollection<InvTxnAssetDepreciation> InvTxnAssetDepreciationModifiedByNavigations { get; set; }
        public virtual ICollection<InvTxnFixedAssetRequisitionItem> InvTxnFixedAssetRequisitionItems { get; set; }
        public virtual ICollection<InvTxnFixedAssetRequisition> InvTxnFixedAssetRequisitions { get; set; }
        public virtual ICollection<InvTxnFixedAssetReturnItem> InvTxnFixedAssetReturnItems { get; set; }
        public virtual ICollection<InvTxnFixedAssetReturn> InvTxnFixedAssetReturns { get; set; }
        public virtual ICollection<InvTxnFixedAssetStock> InvTxnFixedAssetStocks { get; set; }
        public virtual ICollection<InvTxnGoodsReceiptItem> InvTxnGoodsReceiptItems { get; set; }
        public virtual ICollection<InvTxnGoodsReceipt> InvTxnGoodsReceipts { get; set; }
        public virtual ICollection<InvTxnPurchaseOrderItem> InvTxnPurchaseOrderItemAuthorizedByNavigations { get; set; }
        public virtual ICollection<InvTxnPurchaseOrderItem> InvTxnPurchaseOrderItemCreatedByNavigations { get; set; }
        public virtual ICollection<InvTxnPurchaseOrder> InvTxnPurchaseOrders { get; set; }
        public virtual ICollection<InvTxnRequisitionItem> InvTxnRequisitionItemAuthorizedByNavigations { get; set; }
        public virtual ICollection<InvTxnRequisitionItem> InvTxnRequisitionItemCreatedByNavigations { get; set; }
        public virtual ICollection<InvTxnRequisition> InvTxnRequisitions { get; set; }
        public virtual ICollection<InvTxnReturnToVendorItem> InvTxnReturnToVendorItems { get; set; }
        public virtual ICollection<InvTxnReturnToVendor> InvTxnReturnToVendors { get; set; }
        public virtual ICollection<LabTestRequisition> LabTestRequisitions { get; set; }
        public virtual ICollection<MatTxnPatientPayment> MatTxnPatientPayments { get; set; }
        public virtual ICollection<MrTxnOutpatientFinalDiagnosis> MrTxnOutpatientFinalDiagnosisCreatedByNavigations { get; set; }
        public virtual ICollection<MrTxnOutpatientFinalDiagnosis> MrTxnOutpatientFinalDiagnosisModifiedByNavigations { get; set; }
        public virtual ICollection<MstDepartment> MstDepartmentCreatedByNavigations { get; set; }
        public virtual ICollection<MstDepartment> MstDepartmentModifiedByNavigations { get; set; }
        public virtual ICollection<OtTxnOtTeamsInfo> OtTxnOtTeamsInfos { get; set; }
        public virtual ICollection<PatAppointment> PatAppointments { get; set; }
        public virtual ICollection<PatCfgMembershipType> PatCfgMembershipTypeCreatedByNavigations { get; set; }
        public virtual ICollection<PatCfgMembershipType> PatCfgMembershipTypeModifiedByNavigations { get; set; }
        public virtual ICollection<PatPatientMembership> PatPatientMembershipCreatedByNavigations { get; set; }
        public virtual ICollection<PatPatientMembership> PatPatientMembershipModifiedByNavigations { get; set; }
        public virtual ICollection<PatPatientVisit> PatPatientVisits { get; set; }
        public virtual ICollection<PhrmBilTransactionItem> PhrmBilTransactionItems { get; set; }
        public virtual ICollection<PhrmBilTransaction> PhrmBilTransactions { get; set; }
        public virtual ICollection<PhrmFiscalYearStock> PhrmFiscalYearStocks { get; set; }
        public virtual ICollection<PhrmGoodsReceiptItem> PhrmGoodsReceiptItems { get; set; }
        public virtual ICollection<PhrmGoodsReceipt> PhrmGoodsReceipts { get; set; }
        public virtual ICollection<PhrmHistoryItem> PhrmHistoryItems { get; set; }
        public virtual ICollection<PhrmHistoryStockBatchExpiry> PhrmHistoryStockBatchExpiries { get; set; }
        public virtual ICollection<PhrmHistoryStockMrp> PhrmHistoryStockMrps { get; set; }
        public virtual ICollection<PhrmMstCategory> PhrmMstCategories { get; set; }
        public virtual ICollection<PhrmMstCompany> PhrmMstCompanies { get; set; }
        public virtual ICollection<PhrmMstCounter> PhrmMstCounters { get; set; }
        public virtual ICollection<PhrmMstItem> PhrmMstItemCreatedByNavigations { get; set; }
        public virtual ICollection<PhrmMstItem> PhrmMstItemModifiedByNavigations { get; set; }
        public virtual ICollection<PhrmMstItemType> PhrmMstItemTypes { get; set; }
        public virtual ICollection<PhrmMstStock> PhrmMstStockCreatedByNavigations { get; set; }
        public virtual ICollection<PhrmMstStock> PhrmMstStockModifiedByNavigations { get; set; }
        public virtual ICollection<PhrmMstStore> PhrmMstStores { get; set; }
        public virtual ICollection<PhrmMstSupplier> PhrmMstSuppliers { get; set; }
        public virtual ICollection<PhrmMstTax> PhrmMstTaxes { get; set; }
        public virtual ICollection<PhrmMstUnitOfMeasurement> PhrmMstUnitOfMeasurements { get; set; }
        public virtual ICollection<PhrmPrescription> PhrmPrescriptionCreatedByNavigations { get; set; }
        public virtual ICollection<PhrmPrescriptionItem> PhrmPrescriptionItems { get; set; }
        public virtual ICollection<PhrmPrescription> PhrmPrescriptionProviders { get; set; }
        public virtual ICollection<PhrmPurchaseOrderItem> PhrmPurchaseOrderItemAuthorizedByNavigations { get; set; }
        public virtual ICollection<PhrmPurchaseOrderItem> PhrmPurchaseOrderItemCreatedByNavigations { get; set; }
        public virtual ICollection<PhrmPurchaseOrder> PhrmPurchaseOrders { get; set; }
        public virtual ICollection<PhrmReturnToSupplierItem> PhrmReturnToSupplierItems { get; set; }
        public virtual ICollection<PhrmReturnToSupplier> PhrmReturnToSuppliers { get; set; }
        public virtual ICollection<PhrmSaleItem> PhrmSaleItems { get; set; }
        public virtual ICollection<PhrmSaleItemsReturn> PhrmSaleItemsReturns { get; set; }
        public virtual ICollection<PhrmStockManage> PhrmStockManages { get; set; }
        public virtual ICollection<PhrmStockTxnItem> PhrmStockTxnItems { get; set; }
        public virtual ICollection<PhrmTxnDispensaryStock> PhrmTxnDispensaryStockCreatedByNavigations { get; set; }
        public virtual ICollection<PhrmTxnDispensaryStock> PhrmTxnDispensaryStockModifiedByNavigations { get; set; }
        public virtual ICollection<PhrmTxnDispensaryStockTransaction> PhrmTxnDispensaryStockTransactions { get; set; }
        public virtual ICollection<PhrmTxnInvoiceItem> PhrmTxnInvoiceItems { get; set; }
        public virtual ICollection<PhrmTxnInvoiceReturnItem> PhrmTxnInvoiceReturnItems { get; set; }
        public virtual ICollection<PhrmTxnInvoiceReturn> PhrmTxnInvoiceReturns { get; set; }
        public virtual ICollection<PhrmTxnInvoice> PhrmTxnInvoices { get; set; }
        public virtual ICollection<PhrmTxnStock> PhrmTxnStockCreatedByNavigations { get; set; }
        public virtual ICollection<PhrmTxnStock> PhrmTxnStockModifiedByNavigations { get; set; }
        public virtual ICollection<PhrmTxnStockTransaction> PhrmTxnStockTransactions { get; set; }
        public virtual ICollection<PhrmWriteOffItem> PhrmWriteOffItems { get; set; }
        public virtual ICollection<PhrmWriteOff> PhrmWriteOffs { get; set; }
        public virtual ICollection<RadMstImagingItem> RadMstImagingItemCreatedByNavigations { get; set; }
        public virtual ICollection<RadMstImagingItem> RadMstImagingItemModifiedByNavigations { get; set; }
        public virtual ICollection<RadMstImagingType> RadMstImagingTypeCreatedByNavigations { get; set; }
        public virtual ICollection<RadMstImagingType> RadMstImagingTypeModifiedByNavigations { get; set; }
        public virtual ICollection<RadReportingDoctor> RadReportingDoctorCreatedByNavigations { get; set; }
        public virtual ICollection<RadReportingDoctor> RadReportingDoctorModifiedByNavigations { get; set; }
        public virtual ICollection<SchEmployeeSchedule> SchEmployeeSchedules { get; set; }
        public virtual ICollection<SchEmployeeShift> SchEmployeeShifts { get; set; }
        public virtual ICollection<SchMapEmployeeShift> SchMapEmployeeShifts { get; set; }
        public virtual ICollection<TxnEmpCashTransaction> TxnEmpCashTransactions { get; set; }
        public virtual ICollection<TxnEmpDueAmount> TxnEmpDueAmounts { get; set; }
        public virtual ICollection<WardInvConsumptionReceipt> WardInvConsumptionReceiptCreatedByNavigations { get; set; }
        public virtual ICollection<WardInvConsumptionReceipt> WardInvConsumptionReceiptModifiedByNavigations { get; set; }
    }
}
