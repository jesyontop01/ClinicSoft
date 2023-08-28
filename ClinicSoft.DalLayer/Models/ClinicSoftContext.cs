using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClinicSoftContext : DbContext
    {
        public ClinicSoftContext()
        {
        }

        public ClinicSoftContext(DbContextOptions<ClinicSoftContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccBillLedgerMapping> AccBillLedgerMappings { get; set; } = null!;
        public virtual DbSet<AccFiscalYearLog> AccFiscalYearLogs { get; set; } = null!;
        public virtual DbSet<AccInvoiceDatum> AccInvoiceData { get; set; } = null!;
        public virtual DbSet<AccLedger> AccLedgers { get; set; } = null!;
        public virtual DbSet<AccLedger2076772> AccLedger2076772s { get; set; } = null!;
        public virtual DbSet<AccLedgerBalanceHistory> AccLedgerBalanceHistories { get; set; } = null!;
        public virtual DbSet<AccLedgerCharak> AccLedgerCharaks { get; set; } = null!;
        public virtual DbSet<AccLedgerMapping> AccLedgerMappings { get; set; } = null!;
        public virtual DbSet<AccLogEditVoucher> AccLogEditVouchers { get; set; } = null!;
        public virtual DbSet<AccMapTxnItemCostCenterItem> AccMapTxnItemCostCenterItems { get; set; } = null!;
        public virtual DbSet<AccMstBankReconciliationCategory> AccMstBankReconciliationCategories { get; set; } = null!;
        public virtual DbSet<AccMstChartOfAccount> AccMstChartOfAccounts { get; set; } = null!;
        public virtual DbSet<AccMstCodeDetail> AccMstCodeDetails { get; set; } = null!;
        public virtual DbSet<AccMstCostCenterItem> AccMstCostCenterItems { get; set; } = null!;
        public virtual DbSet<AccMstFiscalYear> AccMstFiscalYears { get; set; } = null!;
        public virtual DbSet<AccMstGroupMapping> AccMstGroupMappings { get; set; } = null!;
        public virtual DbSet<AccMstHospital> AccMstHospitals { get; set; } = null!;
        public virtual DbSet<AccMstHospitalTransferRulesMapping> AccMstHospitalTransferRulesMappings { get; set; } = null!;
        public virtual DbSet<AccMstLedgerGroup> AccMstLedgerGroups { get; set; } = null!;
        public virtual DbSet<AccMstMappingDetail> AccMstMappingDetails { get; set; } = null!;
        public virtual DbSet<AccMstPrimaryGroup> AccMstPrimaryGroups { get; set; } = null!;
        public virtual DbSet<AccMstSectionList> AccMstSectionLists { get; set; } = null!;
        public virtual DbSet<AccMstVoucher> AccMstVouchers { get; set; } = null!;
        public virtual DbSet<AccMstVoucherHead> AccMstVoucherHeads { get; set; } = null!;
        public virtual DbSet<AccReverseTransaction> AccReverseTransactions { get; set; } = null!;
        public virtual DbSet<AccTransaction> AccTransactions { get; set; } = null!;
        public virtual DbSet<AccTransactionHistory> AccTransactionHistories { get; set; } = null!;
        public virtual DbSet<AccTransactionItem> AccTransactionItems { get; set; } = null!;
        public virtual DbSet<AccTransactionItemDetail> AccTransactionItemDetails { get; set; } = null!;
        public virtual DbSet<AccTxnBankReconciliation> AccTxnBankReconciliations { get; set; } = null!;
        public virtual DbSet<AccTxnLink> AccTxnLinks { get; set; } = null!;
        public virtual DbSet<AccTxnPayment> AccTxnPayments { get; set; } = null!;
        public virtual DbSet<AdtBabyBirthDetail> AdtBabyBirthDetails { get; set; } = null!;
        public virtual DbSet<AdtBed> AdtBeds { get; set; } = null!;
        public virtual DbSet<AdtBedReservation> AdtBedReservations { get; set; } = null!;
        public virtual DbSet<AdtDeathDeatil> AdtDeathDeatils { get; set; } = null!;
        public virtual DbSet<AdtDischargeCancel> AdtDischargeCancels { get; set; } = null!;
        public virtual DbSet<AdtDischargeSummary> AdtDischargeSummaries { get; set; } = null!;
        public virtual DbSet<AdtDischargeSummaryMedication> AdtDischargeSummaryMedications { get; set; } = null!;
        public virtual DbSet<AdtDischargeType> AdtDischargeTypes { get; set; } = null!;
        public virtual DbSet<AdtMapBedFeaturesMap> AdtMapBedFeaturesMaps { get; set; } = null!;
        public virtual DbSet<AdtMstBabyBirthCondition> AdtMstBabyBirthConditions { get; set; } = null!;
        public virtual DbSet<AdtMstBedFeature> AdtMstBedFeatures { get; set; } = null!;
        public virtual DbSet<AdtMstDeathType> AdtMstDeathTypes { get; set; } = null!;
        public virtual DbSet<AdtMstDeliveryType> AdtMstDeliveryTypes { get; set; } = null!;
        public virtual DbSet<AdtMstDischargeConditionType> AdtMstDischargeConditionTypes { get; set; } = null!;
        public virtual DbSet<AdtMstGravitum> AdtMstGravita { get; set; } = null!;
        public virtual DbSet<AdtMstWard> AdtMstWards { get; set; } = null!;
        public virtual DbSet<AdtPatientAdmission> AdtPatientAdmissions { get; set; } = null!;
        public virtual DbSet<AdtPatientCertificate> AdtPatientCertificates { get; set; } = null!;
        public virtual DbSet<AdtTxnPatientBedInfo> AdtTxnPatientBedInfos { get; set; } = null!;
        public virtual DbSet<AllAbnormalDataTable> AllAbnormalDataTables { get; set; } = null!;
        public virtual DbSet<BedInformationModel> BedInformationModels { get; set; } = null!;
        public virtual DbSet<BilBillItemRequisition> BilBillItemRequisitions { get; set; } = null!;
        public virtual DbSet<BilCfgBillItemPrice> BilCfgBillItemPrices { get; set; } = null!;
        public virtual DbSet<BilCfgBillItemPriceHistory> BilCfgBillItemPriceHistories { get; set; } = null!;
        public virtual DbSet<BilCfgCounter> BilCfgCounters { get; set; } = null!;
        public virtual DbSet<BilCfgFiscalYear> BilCfgFiscalYears { get; set; } = null!;
        public virtual DbSet<BilCfgPackage> BilCfgPackages { get; set; } = null!;
        public virtual DbSet<BilCfgPriceCategory> BilCfgPriceCategories { get; set; } = null!;
        public virtual DbSet<BilHistoryBillingTransactionItem> BilHistoryBillingTransactionItems { get; set; } = null!;
        public virtual DbSet<BilMapFreeServiceBillingItem> BilMapFreeServiceBillingItems { get; set; } = null!;
        public virtual DbSet<BilMapReportingItemBillingItem> BilMapReportingItemBillingItems { get; set; } = null!;
        public virtual DbSet<BilMstCreditOrganization> BilMstCreditOrganizations { get; set; } = null!;
        public virtual DbSet<BilMstHandover> BilMstHandovers { get; set; } = null!;
        public virtual DbSet<BilMstServiceDepartment> BilMstServiceDepartments { get; set; } = null!;
        public virtual DbSet<BilSyncBillingAccounting> BilSyncBillingAccountings { get; set; } = null!;
        public virtual DbSet<BilTempCfgbillItemPrice7sept> BilTempCfgbillItemPrice7septs { get; set; } = null!;
        public virtual DbSet<BilTempItemsMapping> BilTempItemsMappings { get; set; } = null!;
        public virtual DbSet<BilTxnBillingTransaction> BilTxnBillingTransactions { get; set; } = null!;
        public virtual DbSet<BilTxnBillingTransactionItem> BilTxnBillingTransactionItems { get; set; } = null!;
        public virtual DbSet<BilTxnCashHandover> BilTxnCashHandovers { get; set; } = null!;
        public virtual DbSet<BilTxnDenomination> BilTxnDenominations { get; set; } = null!;
        public virtual DbSet<BilTxnDeposit> BilTxnDeposits { get; set; } = null!;
        public virtual DbSet<BilTxnInvoiceReturn> BilTxnInvoiceReturns { get; set; } = null!;
        public virtual DbSet<BilTxnInvoiceReturnItem> BilTxnInvoiceReturnItems { get; set; } = null!;
        public virtual DbSet<BilTxnSettlement> BilTxnSettlements { get; set; } = null!;
        public virtual DbSet<CfgPrintExportSetting> CfgPrintExportSettings { get; set; } = null!;
        public virtual DbSet<CfgPrinterSetting> CfgPrinterSettings { get; set; } = null!;
        public virtual DbSet<ClnActiveMedical> ClnActiveMedicals { get; set; } = null!;
        public virtual DbSet<ClnAllergy> ClnAllergies { get; set; } = null!;
        public virtual DbSet<ClnDiagnosis> ClnDiagnoses { get; set; } = null!;
        public virtual DbSet<ClnEyeAblationProfile> ClnEyeAblationProfiles { get; set; } = null!;
        public virtual DbSet<ClnEyeLaserDataEntry> ClnEyeLaserDataEntries { get; set; } = null!;
        public virtual DbSet<ClnEyeLasikRst> ClnEyeLasikRsts { get; set; } = null!;
        public virtual DbSet<ClnEyeOperationNote> ClnEyeOperationNotes { get; set; } = null!;
        public virtual DbSet<ClnEyeOra> ClnEyeOras { get; set; } = null!;
        public virtual DbSet<ClnEyePachymetry> ClnEyePachymetries { get; set; } = null!;
        public virtual DbSet<ClnEyePreOpPachymetry> ClnEyePreOpPachymetries { get; set; } = null!;
        public virtual DbSet<ClnEyeRefraction> ClnEyeRefractions { get; set; } = null!;
        public virtual DbSet<ClnEyeScanImage> ClnEyeScanImages { get; set; } = null!;
        public virtual DbSet<ClnEyeSmileIncision> ClnEyeSmileIncisions { get; set; } = null!;
        public virtual DbSet<ClnEyeSmileSetting> ClnEyeSmileSettings { get; set; } = null!;
        public virtual DbSet<ClnEyeVisuMax> ClnEyeVisuMaxes { get; set; } = null!;
        public virtual DbSet<ClnEyeWavefront> ClnEyeWavefronts { get; set; } = null!;
        public virtual DbSet<ClnFamilyHistory> ClnFamilyHistories { get; set; } = null!;
        public virtual DbSet<ClnHomeMedication> ClnHomeMedications { get; set; } = null!;
        public virtual DbSet<ClnInputOutput> ClnInputOutputs { get; set; } = null!;
        public virtual DbSet<ClnKvPatientClinicalInfo> ClnKvPatientClinicalInfos { get; set; } = null!;
        public virtual DbSet<ClnMedicationPrescription> ClnMedicationPrescriptions { get; set; } = null!;
        public virtual DbSet<ClnMstEye> ClnMstEyes { get; set; } = null!;
        public virtual DbSet<ClnMstFrequency> ClnMstFrequencies { get; set; } = null!;
        public virtual DbSet<ClnMstNoteType> ClnMstNoteTypes { get; set; } = null!;
        public virtual DbSet<ClnMstPrescriptionSlip> ClnMstPrescriptionSlips { get; set; } = null!;
        public virtual DbSet<ClnNote> ClnNotes { get; set; } = null!;
        public virtual DbSet<ClnNotesEmergency> ClnNotesEmergencies { get; set; } = null!;
        public virtual DbSet<ClnNotesFreeText> ClnNotesFreeTexts { get; set; } = null!;
        public virtual DbSet<ClnNotesObjective> ClnNotesObjectives { get; set; } = null!;
        public virtual DbSet<ClnNotesPrescriptionNote> ClnNotesPrescriptionNotes { get; set; } = null!;
        public virtual DbSet<ClnNotesProcedure> ClnNotesProcedures { get; set; } = null!;
        public virtual DbSet<ClnNotesProgress> ClnNotesProgresses { get; set; } = null!;
        public virtual DbSet<ClnNotesSubjective> ClnNotesSubjectives { get; set; } = null!;
        public virtual DbSet<ClnPastMedical> ClnPastMedicals { get; set; } = null!;
        public virtual DbSet<ClnPatImage> ClnPatImages { get; set; } = null!;
        public virtual DbSet<ClnPatientNote> ClnPatientNotes { get; set; } = null!;
        public virtual DbSet<ClnPatientVisitNote> ClnPatientVisitNotes { get; set; } = null!;
        public virtual DbSet<ClnPatientVisitProcedure> ClnPatientVisitProcedures { get; set; } = null!;
        public virtual DbSet<ClnPatientVital> ClnPatientVitals { get; set; } = null!;
        public virtual DbSet<ClnPrescriptionSlipAcceptance> ClnPrescriptionSlipAcceptances { get; set; } = null!;
        public virtual DbSet<ClnPrescriptionSlipAdviceDiagnosis> ClnPrescriptionSlipAdviceDiagnoses { get; set; } = null!;
        public virtual DbSet<ClnPrescriptionSlipDilate> ClnPrescriptionSlipDilates { get; set; } = null!;
        public virtual DbSet<ClnPrescriptionSlipFinalClass> ClnPrescriptionSlipFinalClasses { get; set; } = null!;
        public virtual DbSet<ClnPrescriptionSlipHistory> ClnPrescriptionSlipHistories { get; set; } = null!;
        public virtual DbSet<ClnPrescriptionSlipIop> ClnPrescriptionSlipIops { get; set; } = null!;
        public virtual DbSet<ClnPrescriptionSlipPlup> ClnPrescriptionSlipPlups { get; set; } = null!;
        public virtual DbSet<ClnPrescriptionSlipRetinoscopy> ClnPrescriptionSlipRetinoscopies { get; set; } = null!;
        public virtual DbSet<ClnPrescriptionSlipSchrime> ClnPrescriptionSlipSchrimes { get; set; } = null!;
        public virtual DbSet<ClnPrescriptionSlipTbut> ClnPrescriptionSlipTbuts { get; set; } = null!;
        public virtual DbSet<ClnPrescriptionSlipVaUnaided> ClnPrescriptionSlipVaUnaideds { get; set; } = null!;
        public virtual DbSet<ClnReferralSource> ClnReferralSources { get; set; } = null!;
        public virtual DbSet<ClnSocialHistory> ClnSocialHistories { get; set; } = null!;
        public virtual DbSet<ClnSurgicalHistory> ClnSurgicalHistories { get; set; } = null!;
        public virtual DbSet<ClnTemplate> ClnTemplates { get; set; } = null!;
        public virtual DbSet<CoreCfgLookUp> CoreCfgLookUps { get; set; } = null!;
        public virtual DbSet<CoreCfgParameter> CoreCfgParameters { get; set; } = null!;
        public virtual DbSet<CoreDistributedCache> CoreDistributedCaches { get; set; } = null!;
        public virtual DbSet<CoreDyntmpOption> CoreDyntmpOptions { get; set; } = null!;
        public virtual DbSet<CoreDyntmpQuestion> CoreDyntmpQuestions { get; set; } = null!;
        public virtual DbSet<CoreDyntmpQuestionnaire> CoreDyntmpQuestionnaires { get; set; } = null!;
        public virtual DbSet<CoreDyntmpTemplate> CoreDyntmpTemplates { get; set; } = null!;
        public virtual DbSet<CoreLookupDetail> CoreLookupDetails { get; set; } = null!;
        public virtual DbSet<CoreNotification> CoreNotifications { get; set; } = null!;
        public virtual DbSet<CssdTxnItemTransaction> CssdTxnItemTransactions { get; set; } = null!;
        public virtual DbSet<DanpheAudit> DanpheAudits { get; set; } = null!;
        public virtual DbSet<DanpheLogInInformation> DanpheLogInInformations { get; set; } = null!;
        public virtual DbSet<DocTxnVisitSummary> DocTxnVisitSummaries { get; set; } = null!;
        public virtual DbSet<EmpEmployee> EmpEmployees { get; set; } = null!;
        public virtual DbSet<EmpEmployeePreference> EmpEmployeePreferences { get; set; } = null!;
        public virtual DbSet<EmpEmployeeRole> EmpEmployeeRoles { get; set; } = null!;
        public virtual DbSet<EmpEmployeeType> EmpEmployeeTypes { get; set; } = null!;
        public virtual DbSet<EmployeeInfoModel> EmployeeInfoModels { get; set; } = null!;
        public virtual DbSet<EngNepaliDateMapped> EngNepaliDateMappeds { get; set; } = null!;
        public virtual DbSet<ErDischargeSummary> ErDischargeSummaries { get; set; } = null!;
        public virtual DbSet<ErFileUpload> ErFileUploads { get; set; } = null!;
        public virtual DbSet<ErModeOfArrival> ErModeOfArrivals { get; set; } = null!;
        public virtual DbSet<ErPatient> ErPatients { get; set; } = null!;
        public virtual DbSet<ErPatientCase> ErPatientCases { get; set; } = null!;
        public virtual DbSet<FrcDesignation> FrcDesignations { get; set; } = null!;
        public virtual DbSet<FrcFractionCalculation> FrcFractionCalculations { get; set; } = null!;
        public virtual DbSet<FrcPercentSetting> FrcPercentSettings { get; set; } = null!;
        public virtual DbSet<GovtInsuranceItem> GovtInsuranceItems { get; set; } = null!;
        public virtual DbSet<IcdDiseaseGroup> IcdDiseaseGroups { get; set; } = null!;
        public virtual DbSet<IcdReportingGroup> IcdReportingGroups { get; set; } = null!;
        public virtual DbSet<InctvBillItemsProfileMap> InctvBillItemsProfileMaps { get; set; } = null!;
        public virtual DbSet<InctvCfgItemGroupDistribution> InctvCfgItemGroupDistributions { get; set; } = null!;
        public virtual DbSet<InctvEmployeeIncentiveInfo> InctvEmployeeIncentiveInfos { get; set; } = null!;
        public virtual DbSet<InctvMapEmployeeBillItemsMap> InctvMapEmployeeBillItemsMaps { get; set; } = null!;
        public virtual DbSet<InctvMstProfile> InctvMstProfiles { get; set; } = null!;
        public virtual DbSet<InctvTxnIncentiveFractionItem> InctvTxnIncentiveFractionItems { get; set; } = null!;
        public virtual DbSet<InctvTxnPaymentInfo> InctvTxnPaymentInfos { get; set; } = null!;
        public virtual DbSet<InsCfgInsuranceProvider> InsCfgInsuranceProviders { get; set; } = null!;
        public virtual DbSet<InsInsuranceBalanceAmountHistory> InsInsuranceBalanceAmountHistories { get; set; } = null!;
        public virtual DbSet<InsTxnPatientInsurancePackage> InsTxnPatientInsurancePackages { get; set; } = null!;
        public virtual DbSet<InvAssetConditionCheckList> InvAssetConditionCheckLists { get; set; } = null!;
        public virtual DbSet<InvAssetContractFileInfo> InvAssetContractFileInfos { get; set; } = null!;
        public virtual DbSet<InvAssetFaultHistory> InvAssetFaultHistories { get; set; } = null!;
        public virtual DbSet<InvAssetInsurance> InvAssetInsurances { get; set; } = null!;
        public virtual DbSet<InvAssetLocationHistory> InvAssetLocationHistories { get; set; } = null!;
        public virtual DbSet<InvAssetServiceHistory> InvAssetServiceHistories { get; set; } = null!;
        public virtual DbSet<InvCfgFiscalYear> InvCfgFiscalYears { get; set; } = null!;
        public virtual DbSet<InvFiscalYearStock> InvFiscalYearStocks { get; set; } = null!;
        public virtual DbSet<InvMstAccountHead> InvMstAccountHeads { get; set; } = null!;
        public virtual DbSet<InvMstAssetCategory> InvMstAssetCategories { get; set; } = null!;
        public virtual DbSet<InvMstAssetDepreciationMethod> InvMstAssetDepreciationMethods { get; set; } = null!;
        public virtual DbSet<InvMstAssetLocation> InvMstAssetLocations { get; set; } = null!;
        public virtual DbSet<InvMstCompany> InvMstCompanies { get; set; } = null!;
        public virtual DbSet<InvMstCurrency> InvMstCurrencies { get; set; } = null!;
        public virtual DbSet<InvMstDonation> InvMstDonations { get; set; } = null!;
        public virtual DbSet<InvMstItem> InvMstItems { get; set; } = null!;
        public virtual DbSet<InvMstItemCategory> InvMstItemCategories { get; set; } = null!;
        public virtual DbSet<InvMstItemSubCategory> InvMstItemSubCategories { get; set; } = null!;
        public virtual DbSet<InvMstPackagingType> InvMstPackagingTypes { get; set; } = null!;
        public virtual DbSet<InvMstStock> InvMstStocks { get; set; } = null!;
        public virtual DbSet<InvMstTerm> InvMstTerms { get; set; } = null!;
        public virtual DbSet<InvMstUnitOfMeasurement> InvMstUnitOfMeasurements { get; set; } = null!;
        public virtual DbSet<InvMstVendor> InvMstVendors { get; set; } = null!;
        public virtual DbSet<InvQuotation> InvQuotations { get; set; } = null!;
        public virtual DbSet<InvQuotationItem> InvQuotationItems { get; set; } = null!;
        public virtual DbSet<InvQuotationUploadedFile> InvQuotationUploadedFiles { get; set; } = null!;
        public virtual DbSet<InvRequestForQuotation> InvRequestForQuotations { get; set; } = null!;
        public virtual DbSet<InvRequestForQuotationItem> InvRequestForQuotationItems { get; set; } = null!;
        public virtual DbSet<InvRequestForQuotationVendor> InvRequestForQuotationVendors { get; set; } = null!;
        public virtual DbSet<InvTempItemPriceWithVat> InvTempItemPriceWithVats { get; set; } = null!;
        public virtual DbSet<InvTempStockMigrationCmh> InvTempStockMigrationCmhs { get; set; } = null!;
        public virtual DbSet<InvTempTxnNewStockTxn> InvTempTxnNewStockTxns { get; set; } = null!;
        public virtual DbSet<InvTxnAssetDepreciation> InvTxnAssetDepreciations { get; set; } = null!;
        public virtual DbSet<InvTxnDispatchItem> InvTxnDispatchItems { get; set; } = null!;
        public virtual DbSet<InvTxnFixedAssetDispatch> InvTxnFixedAssetDispatches { get; set; } = null!;
        public virtual DbSet<InvTxnFixedAssetDispatchItem> InvTxnFixedAssetDispatchItems { get; set; } = null!;
        public virtual DbSet<InvTxnFixedAssetRequisition> InvTxnFixedAssetRequisitions { get; set; } = null!;
        public virtual DbSet<InvTxnFixedAssetRequisitionItem> InvTxnFixedAssetRequisitionItems { get; set; } = null!;
        public virtual DbSet<InvTxnFixedAssetReturn> InvTxnFixedAssetReturns { get; set; } = null!;
        public virtual DbSet<InvTxnFixedAssetReturnItem> InvTxnFixedAssetReturnItems { get; set; } = null!;
        public virtual DbSet<InvTxnFixedAssetStock> InvTxnFixedAssetStocks { get; set; } = null!;
        public virtual DbSet<InvTxnGoodsReceipt> InvTxnGoodsReceipts { get; set; } = null!;
        public virtual DbSet<InvTxnGoodsReceiptItem> InvTxnGoodsReceiptItems { get; set; } = null!;
        public virtual DbSet<InvTxnPurchaseOrder> InvTxnPurchaseOrders { get; set; } = null!;
        public virtual DbSet<InvTxnPurchaseOrderItem> InvTxnPurchaseOrderItems { get; set; } = null!;
        public virtual DbSet<InvTxnPurchaseRequest> InvTxnPurchaseRequests { get; set; } = null!;
        public virtual DbSet<InvTxnPurchaseRequestItem> InvTxnPurchaseRequestItems { get; set; } = null!;
        public virtual DbSet<InvTxnRequisition> InvTxnRequisitions { get; set; } = null!;
        public virtual DbSet<InvTxnRequisitionForPo> InvTxnRequisitionForPos { get; set; } = null!;
        public virtual DbSet<InvTxnRequisitionItem> InvTxnRequisitionItems { get; set; } = null!;
        public virtual DbSet<InvTxnRequisitionItemsForPo> InvTxnRequisitionItemsForPos { get; set; } = null!;
        public virtual DbSet<InvTxnReturnToVendor> InvTxnReturnToVendors { get; set; } = null!;
        public virtual DbSet<InvTxnReturnToVendorItem> InvTxnReturnToVendorItems { get; set; } = null!;
        public virtual DbSet<InvTxnStock> InvTxnStocks { get; set; } = null!;
        public virtual DbSet<InvTxnStockTransaction> InvTxnStockTransactions { get; set; } = null!;
        public virtual DbSet<InvTxnStoreStock> InvTxnStoreStocks { get; set; } = null!;
        public virtual DbSet<InvTxnWriteOffItem> InvTxnWriteOffItems { get; set; } = null!;
        public virtual DbSet<IrdLog> IrdLogs { get; set; } = null!;
        public virtual DbSet<LabBarCode> LabBarCodes { get; set; } = null!;
        public virtual DbSet<LabGovReportMapping> LabGovReportMappings { get; set; } = null!;
        public virtual DbSet<LabLabTest> LabLabTests { get; set; } = null!;
        public virtual DbSet<LabLabTestsWithCorrectedCategory> LabLabTestsWithCorrectedCategories { get; set; } = null!;
        public virtual DbSet<LabLisComponentMap> LabLisComponentMaps { get; set; } = null!;
        public virtual DbSet<LabLisSyncedComponentDetail> LabLisSyncedComponentDetails { get; set; } = null!;
        public virtual DbSet<LabMapTestComponent> LabMapTestComponents { get; set; } = null!;
        public virtual DbSet<LabMstComponent> LabMstComponents { get; set; } = null!;
        public virtual DbSet<LabMstGovReportItem> LabMstGovReportItems { get; set; } = null!;
        public virtual DbSet<LabMstLabVendor> LabMstLabVendors { get; set; } = null!;
        public virtual DbSet<LabMstRunNumberSetting> LabMstRunNumberSettings { get; set; } = null!;
        public virtual DbSet<LabMstTestSpeciman> LabMstTestSpecimen { get; set; } = null!;
        public virtual DbSet<LabReportTemplate> LabReportTemplates { get; set; } = null!;
        public virtual DbSet<LabSm> LabSms { get; set; } = null!;
        public virtual DbSet<LabTestCategory> LabTestCategories { get; set; } = null!;
        public virtual DbSet<LabTestRequisition> LabTestRequisitions { get; set; } = null!;
        public virtual DbSet<LabTxnLabReport> LabTxnLabReports { get; set; } = null!;
        public virtual DbSet<LabTxnTestComponentResult> LabTxnTestComponentResults { get; set; } = null!;
        public virtual DbSet<MatFileUpload> MatFileUploads { get; set; } = null!;
        public virtual DbSet<MatMaternityAnc> MatMaternityAncs { get; set; } = null!;
        public virtual DbSet<MatPatient> MatPatients { get; set; } = null!;
        public virtual DbSet<MatRegister> MatRegisters { get; set; } = null!;
        public virtual DbSet<MatTxnPatientPayment> MatTxnPatientPayments { get; set; } = null!;
        public virtual DbSet<MrMstOperationType> MrMstOperationTypes { get; set; } = null!;
        public virtual DbSet<MrRecordSummary> MrRecordSummaries { get; set; } = null!;
        public virtual DbSet<MrTxnInpatientDiagnosis> MrTxnInpatientDiagnoses { get; set; } = null!;
        public virtual DbSet<MrTxnOutpatientFinalDiagnosis> MrTxnOutpatientFinalDiagnoses { get; set; } = null!;
        public virtual DbSet<MstBank> MstBanks { get; set; } = null!;
        public virtual DbSet<MstCountry> MstCountries { get; set; } = null!;
        public virtual DbSet<MstCountrySubDivision> MstCountrySubDivisions { get; set; } = null!;
        public virtual DbSet<MstDepartment> MstDepartments { get; set; } = null!;
        public virtual DbSet<MstEthnicGroup> MstEthnicGroups { get; set; } = null!;
        public virtual DbSet<MstGovFreeServiceCategory> MstGovFreeServiceCategories { get; set; } = null!;
        public virtual DbSet<MstIcd10> MstIcd10s { get; set; } = null!;
        public virtual DbSet<MstInvoiceHeader> MstInvoiceHeaders { get; set; } = null!;
        public virtual DbSet<MstLabType> MstLabTypes { get; set; } = null!;
        public virtual DbSet<MstLoinc> MstLoincs { get; set; } = null!;
        public virtual DbSet<MstMapStoreVerification> MstMapStoreVerifications { get; set; } = null!;
        public virtual DbSet<MstMunicipality> MstMunicipalities { get; set; } = null!;
        public virtual DbSet<MstReaction> MstReactions { get; set; } = null!;
        public virtual DbSet<MstRptDynamicReportName> MstRptDynamicReportNames { get; set; } = null!;
        public virtual DbSet<MstRptDynamicReportingItem> MstRptDynamicReportingItems { get; set; } = null!;
        public virtual DbSet<MstTax> MstTaxes { get; set; } = null!;
        public virtual DbSet<MstemailSendDetail> MstemailSendDetails { get; set; } = null!;
        public virtual DbSet<NephHemodialysisRecord> NephHemodialysisRecords { get; set; } = null!;
        public virtual DbSet<NewItemHam> NewItemHams { get; set; } = null!;
        public virtual DbSet<Oppatient> Oppatients { get; set; } = null!;
        public virtual DbSet<OtTxnBookingDetail> OtTxnBookingDetails { get; set; } = null!;
        public virtual DbSet<OtTxnCheckListInfo> OtTxnCheckListInfos { get; set; } = null!;
        public virtual DbSet<OtTxnOtTeamsInfo> OtTxnOtTeamsInfos { get; set; } = null!;
        public virtual DbSet<OtTxnSummary> OtTxnSummaries { get; set; } = null!;
        public virtual DbSet<PatAppointment> PatAppointments { get; set; } = null!;
        public virtual DbSet<PatCfgMembershipType> PatCfgMembershipTypes { get; set; } = null!;
        public virtual DbSet<PatHealthCardInfo> PatHealthCardInfos { get; set; } = null!;
        public virtual DbSet<PatNeighbourhoodCardDetail> PatNeighbourhoodCardDetails { get; set; } = null!;
        public virtual DbSet<PatPatient> PatPatients { get; set; } = null!;
        public virtual DbSet<PatPatientAddress> PatPatientAddresses { get; set; } = null!;
        public virtual DbSet<PatPatientFile> PatPatientFiles { get; set; } = null!;
        public virtual DbSet<PatPatientGurantorInfo> PatPatientGurantorInfos { get; set; } = null!;
        public virtual DbSet<PatPatientInsuranceInfo> PatPatientInsuranceInfos { get; set; } = null!;
        public virtual DbSet<PatPatientKinOrEmergencyContact> PatPatientKinOrEmergencyContacts { get; set; } = null!;
        public virtual DbSet<PatPatientMembership> PatPatientMemberships { get; set; } = null!;
        public virtual DbSet<PatPatientVisit> PatPatientVisits { get; set; } = null!;
        public virtual DbSet<PatSsuInformation> PatSsuInformations { get; set; } = null!;
        public virtual DbSet<PhrmBilTransaction> PhrmBilTransactions { get; set; } = null!;
        public virtual DbSet<PhrmBilTransactionItem> PhrmBilTransactionItems { get; set; } = null!;
        public virtual DbSet<PhrmCfgFiscalYear> PhrmCfgFiscalYears { get; set; } = null!;
        public virtual DbSet<PhrmDeposit> PhrmDeposits { get; set; } = null!;
        public virtual DbSet<PhrmDispensaryStock> PhrmDispensaryStocks { get; set; } = null!;
        public virtual DbSet<PhrmExpiryDateBatchNoHistory> PhrmExpiryDateBatchNoHistories { get; set; } = null!;
        public virtual DbSet<PhrmFiscalYearStock> PhrmFiscalYearStocks { get; set; } = null!;
        public virtual DbSet<PhrmGoodsReceipt> PhrmGoodsReceipts { get; set; } = null!;
        public virtual DbSet<PhrmGoodsReceiptItem> PhrmGoodsReceiptItems { get; set; } = null!;
        public virtual DbSet<PhrmHistoryItem> PhrmHistoryItems { get; set; } = null!;
        public virtual DbSet<PhrmHistoryStockBatchExpiry> PhrmHistoryStockBatchExpiries { get; set; } = null!;
        public virtual DbSet<PhrmHistoryStockMrp> PhrmHistoryStockMrps { get; set; } = null!;
        public virtual DbSet<PhrmMapGenericDosaseNfreq> PhrmMapGenericDosaseNfreqs { get; set; } = null!;
        public virtual DbSet<PhrmMstCategory> PhrmMstCategories { get; set; } = null!;
        public virtual DbSet<PhrmMstCompany> PhrmMstCompanies { get; set; } = null!;
        public virtual DbSet<PhrmMstCounter> PhrmMstCounters { get; set; } = null!;
        public virtual DbSet<PhrmMstCreditOrganization> PhrmMstCreditOrganizations { get; set; } = null!;
        public virtual DbSet<PhrmMstDispensary> PhrmMstDispensaries { get; set; } = null!;
        public virtual DbSet<PhrmMstGeneric> PhrmMstGenerics { get; set; } = null!;
        public virtual DbSet<PhrmMstItem> PhrmMstItems { get; set; } = null!;
        public virtual DbSet<PhrmMstItemType> PhrmMstItemTypes { get; set; } = null!;
        public virtual DbSet<PhrmMstPackingType> PhrmMstPackingTypes { get; set; } = null!;
        public virtual DbSet<PhrmMstRack> PhrmMstRacks { get; set; } = null!;
        public virtual DbSet<PhrmMstSalesCategory> PhrmMstSalesCategories { get; set; } = null!;
        public virtual DbSet<PhrmMstStock> PhrmMstStocks { get; set; } = null!;
        public virtual DbSet<PhrmMstStockBarcode> PhrmMstStockBarcodes { get; set; } = null!;
        public virtual DbSet<PhrmMstStore> PhrmMstStores { get; set; } = null!;
        public virtual DbSet<PhrmMstSupplier> PhrmMstSuppliers { get; set; } = null!;
        public virtual DbSet<PhrmMstTax> PhrmMstTaxes { get; set; } = null!;
        public virtual DbSet<PhrmMstUnitOfMeasurement> PhrmMstUnitOfMeasurements { get; set; } = null!;
        public virtual DbSet<PhrmNarcoticSaleRecord> PhrmNarcoticSaleRecords { get; set; } = null!;
        public virtual DbSet<PhrmPrescription> PhrmPrescriptions { get; set; } = null!;
        public virtual DbSet<PhrmPrescriptionItem> PhrmPrescriptionItems { get; set; } = null!;
        public virtual DbSet<PhrmPurchaseOrder> PhrmPurchaseOrders { get; set; } = null!;
        public virtual DbSet<PhrmPurchaseOrderItem> PhrmPurchaseOrderItems { get; set; } = null!;
        public virtual DbSet<PhrmRequisition> PhrmRequisitions { get; set; } = null!;
        public virtual DbSet<PhrmRequisitionItem> PhrmRequisitionItems { get; set; } = null!;
        public virtual DbSet<PhrmReturnToSupplier> PhrmReturnToSuppliers { get; set; } = null!;
        public virtual DbSet<PhrmReturnToSupplierItem> PhrmReturnToSupplierItems { get; set; } = null!;
        public virtual DbSet<PhrmSaleItem> PhrmSaleItems { get; set; } = null!;
        public virtual DbSet<PhrmSaleItemsReturn> PhrmSaleItemsReturns { get; set; } = null!;
        public virtual DbSet<PhrmStock> PhrmStocks { get; set; } = null!;
        public virtual DbSet<PhrmStockManage> PhrmStockManages { get; set; } = null!;
        public virtual DbSet<PhrmStockTxnItem> PhrmStockTxnItems { get; set; } = null!;
        public virtual DbSet<PhrmStockTxnItemsMrphistory> PhrmStockTxnItemsMrphistories { get; set; } = null!;
        public virtual DbSet<PhrmStoreDispatchItem> PhrmStoreDispatchItems { get; set; } = null!;
        public virtual DbSet<PhrmStoreRequisition> PhrmStoreRequisitions { get; set; } = null!;
        public virtual DbSet<PhrmStoreRequisitionItem> PhrmStoreRequisitionItems { get; set; } = null!;
        public virtual DbSet<PhrmStoreStock> PhrmStoreStocks { get; set; } = null!;
        public virtual DbSet<PhrmTxnDispensaryStock> PhrmTxnDispensaryStocks { get; set; } = null!;
        public virtual DbSet<PhrmTxnDispensaryStockTransaction> PhrmTxnDispensaryStockTransactions { get; set; } = null!;
        public virtual DbSet<PhrmTxnInvoice> PhrmTxnInvoices { get; set; } = null!;
        public virtual DbSet<PhrmTxnInvoiceItem> PhrmTxnInvoiceItems { get; set; } = null!;
        public virtual DbSet<PhrmTxnInvoiceReturn> PhrmTxnInvoiceReturns { get; set; } = null!;
        public virtual DbSet<PhrmTxnInvoiceReturnItem> PhrmTxnInvoiceReturnItems { get; set; } = null!;
        public virtual DbSet<PhrmTxnSettlement> PhrmTxnSettlements { get; set; } = null!;
        public virtual DbSet<PhrmTxnStock> PhrmTxnStocks { get; set; } = null!;
        public virtual DbSet<PhrmTxnStockTransaction> PhrmTxnStockTransactions { get; set; } = null!;
        public virtual DbSet<PhrmTxnStoreStock> PhrmTxnStoreStocks { get; set; } = null!;
        public virtual DbSet<PhrmTxnSupplierLedger> PhrmTxnSupplierLedgers { get; set; } = null!;
        public virtual DbSet<PhrmTxnSupplierLedgerTransaction> PhrmTxnSupplierLedgerTransactions { get; set; } = null!;
        public virtual DbSet<PhrmWriteOff> PhrmWriteOffs { get; set; } = null!;
        public virtual DbSet<PhrmWriteOffItem> PhrmWriteOffItems { get; set; } = null!;
        public virtual DbSet<ProllAttendanceDailyTimeRecord> ProllAttendanceDailyTimeRecords { get; set; } = null!;
        public virtual DbSet<ProllDailyMuster> ProllDailyMusters { get; set; } = null!;
        public virtual DbSet<ProllEmpLeave> ProllEmpLeaves { get; set; } = null!;
        public virtual DbSet<ProllMstHoliday> ProllMstHolidays { get; set; } = null!;
        public virtual DbSet<ProllMstLeaveCategory> ProllMstLeaveCategories { get; set; } = null!;
        public virtual DbSet<ProllMstLeaveRule> ProllMstLeaveRules { get; set; } = null!;
        public virtual DbSet<ProllMstWeekendHoliday> ProllMstWeekendHolidays { get; set; } = null!;
        public virtual DbSet<RadCfgReportTemplate> RadCfgReportTemplates { get; set; } = null!;
        public virtual DbSet<RadMstFilmType> RadMstFilmTypes { get; set; } = null!;
        public virtual DbSet<RadMstImagingItem> RadMstImagingItems { get; set; } = null!;
        public virtual DbSet<RadMstImagingType> RadMstImagingTypes { get; set; } = null!;
        public virtual DbSet<RadPatientImagingReport> RadPatientImagingReports { get; set; } = null!;
        public virtual DbSet<RadPatientImagingRequisition> RadPatientImagingRequisitions { get; set; } = null!;
        public virtual DbSet<RadReportingDoctor> RadReportingDoctors { get; set; } = null!;
        public virtual DbSet<RbacApplication> RbacApplications { get; set; } = null!;
        public virtual DbSet<RbacMapRolePermission> RbacMapRolePermissions { get; set; } = null!;
        public virtual DbSet<RbacMapUserRole> RbacMapUserRoles { get; set; } = null!;
        public virtual DbSet<RbacPermission> RbacPermissions { get; set; } = null!;
        public virtual DbSet<RbacRole> RbacRoles { get; set; } = null!;
        public virtual DbSet<RbacRouteConfig> RbacRouteConfigs { get; set; } = null!;
        public virtual DbSet<RbacUser> RbacUsers { get; set; } = null!;
        public virtual DbSet<ResetVoucherNo207677> ResetVoucherNo207677s { get; set; } = null!;
        public virtual DbSet<SchEmpDayWiseAvailability> SchEmpDayWiseAvailabilities { get; set; } = null!;
        public virtual DbSet<SchEmployeeSchedule> SchEmployeeSchedules { get; set; } = null!;
        public virtual DbSet<SchEmployeeShift> SchEmployeeShifts { get; set; } = null!;
        public virtual DbSet<SchMapEmployeeShift> SchMapEmployeeShifts { get; set; } = null!;
        public virtual DbSet<SchMstShift> SchMstShifts { get; set; } = null!;
        public virtual DbSet<ServiceDepartmentMstIntegrationName> ServiceDepartmentMstIntegrationNames { get; set; } = null!;
        public virtual DbSet<TblBillItemTemp> TblBillItemTemps { get; set; } = null!;
        public virtual DbSet<Temp10> Temp10s { get; set; } = null!;
        public virtual DbSet<TempLabNewPrice> TempLabNewPrices { get; set; } = null!;
        public virtual DbSet<TempRange> TempRanges { get; set; } = null!;
        public virtual DbSet<TxnEmpCashTransaction> TxnEmpCashTransactions { get; set; } = null!;
        public virtual DbSet<TxnEmpDueAmount> TxnEmpDueAmounts { get; set; } = null!;
        public virtual DbSet<TxnPrintInformation> TxnPrintInformations { get; set; } = null!;
        public virtual DbSet<TxnSm> TxnSms { get; set; } = null!;
        public virtual DbSet<TxnVerification> TxnVerifications { get; set; } = null!;
        public virtual DbSet<UpdatedBillItemPriceTable> UpdatedBillItemPriceTables { get; set; } = null!;
        public virtual DbSet<VaccPatientVaccineDetail> VaccPatientVaccineDetails { get; set; } = null!;
        public virtual DbSet<VaccVaccine> VaccVaccines { get; set; } = null!;
        public virtual DbSet<VwBilTxnItemsInfo> VwBilTxnItemsInfos { get; set; } = null!;
        public virtual DbSet<VwBilTxnItemsInfoIncomeSegregation> VwBilTxnItemsInfoIncomeSegregations { get; set; } = null!;
        public virtual DbSet<VwBilTxnItemsInfoWithDateSeparation> VwBilTxnItemsInfoWithDateSeparations { get; set; } = null!;
        public virtual DbSet<VwBilTxnItemsInfoWithDateSeparationIncomeSegregation> VwBilTxnItemsInfoWithDateSeparationIncomeSegregations { get; set; } = null!;
        public virtual DbSet<VwBilTxnItemsInfoWithDateSeparationMisReport> VwBilTxnItemsInfoWithDateSeparationMisReports { get; set; } = null!;
        public virtual DbSet<WardConsumption> WardConsumptions { get; set; } = null!;
        public virtual DbSet<WardDispatch> WardDispatches { get; set; } = null!;
        public virtual DbSet<WardDispatchItem> WardDispatchItems { get; set; } = null!;
        public virtual DbSet<WardInformationModel> WardInformationModels { get; set; } = null!;
        public virtual DbSet<WardInternalConsumption> WardInternalConsumptions { get; set; } = null!;
        public virtual DbSet<WardInternalConsumptionItem> WardInternalConsumptionItems { get; set; } = null!;
        public virtual DbSet<WardInvConsumption> WardInvConsumptions { get; set; } = null!;
        public virtual DbSet<WardInvConsumptionReceipt> WardInvConsumptionReceipts { get; set; } = null!;
        public virtual DbSet<WardInvStock> WardInvStocks { get; set; } = null!;
        public virtual DbSet<WardInvTransaction> WardInvTransactions { get; set; } = null!;
        public virtual DbSet<WardRequisition> WardRequisitions { get; set; } = null!;
        public virtual DbSet<WardRequisitionItem> WardRequisitionItems { get; set; } = null!;
        public virtual DbSet<WardStock> WardStocks { get; set; } = null!;
        public virtual DbSet<WardTransaction> WardTransactions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=cyborg;Database=DanpheEMR_OS;User Id=sa;Password=ghost;Persist Security Info=True;");
           
            
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccBillLedgerMapping>(entity =>
            {
                entity.HasKey(e => e.BillLedgerMappingId);

                entity.ToTable("ACC_Bill_LedgerMapping");
            });

            modelBuilder.Entity<AccFiscalYearLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("ACC_FiscalYear_Log");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LogDetails)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LogType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.AccFiscalYearLogs)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK_ACC_FiscalYear_Log_Acc_MST_Hospital");
            });

            modelBuilder.Entity<AccInvoiceDatum>(entity =>
            {
                entity.HasKey(e => e.InvoiceDataId);

                entity.ToTable("ACC_InvoiceData");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IncomeLedgerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceModelName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccLedger>(entity =>
            {
                entity.HasKey(e => e.LedgerId);

                entity.ToTable("ACC_Ledger");

                entity.HasIndex(e => new { e.LedgerName, e.LedgerGroupId }, "UC_LedgerName_LedgerGroupId")
                    .IsUnique();

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LandlineNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerName).HasMaxLength(200);

                entity.Property(e => e.LedgerType).IsUnicode(false);

                entity.Property(e => e.MigrationRemark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MigrationStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Panno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PANNo");

                entity.Property(e => e.Tdspercent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDSPercent");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.AccLedgers)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK_ACC_Ledger_Acc_MST_Hospital");
            });

            modelBuilder.Entity<AccLedger2076772>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACC_Ledger_2076_77_2");

                entity.Property(e => e.Coa)
                    .HasMaxLength(255)
                    .HasColumnName("COA");

                entity.Property(e => e.Coacode).HasColumnName("COACode");

                entity.Property(e => e.LedgerGroupName).HasMaxLength(255);

                entity.Property(e => e.LedgerName).HasMaxLength(255);

                entity.Property(e => e.MigrationRemark)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccLedgerBalanceHistory>(entity =>
            {
                entity.HasKey(e => e.LedgerBalanceHistoryId);

                entity.ToTable("ACC_LedgerBalanceHistory");

                entity.HasIndex(e => new { e.FiscalYearId, e.LedgerId }, "UQ_ACC_LedgerBalanceHistory_FiscalYearId_LedgerId")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.FiscalYear)
                    .WithMany(p => p.AccLedgerBalanceHistories)
                    .HasForeignKey(d => d.FiscalYearId)
                    .HasConstraintName("FK_ACC_LedgerBalanceHistory_FiscalYear");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.AccLedgerBalanceHistories)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK_ACC_LedgerBalanceHistory_Acc_MST_Hospital");

                entity.HasOne(d => d.Ledger)
                    .WithMany(p => p.AccLedgerBalanceHistories)
                    .HasForeignKey(d => d.LedgerId)
                    .HasConstraintName("FK_ACC_LedgerBalanceHistory_Ledger");
            });

            modelBuilder.Entity<AccLedgerCharak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACC_LedgerCharak$");

                entity.Property(e => e.Coa)
                    .HasMaxLength(255)
                    .HasColumnName("COA");

                entity.Property(e => e.Coacode).HasColumnName("COACode");

                entity.Property(e => e.LedgerGroupName).HasMaxLength(255);

                entity.Property(e => e.LedgerName).HasMaxLength(255);

                entity.Property(e => e.MigrationStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccLedgerMapping>(entity =>
            {
                entity.HasKey(e => e.LedgerMappingId);

                entity.ToTable("ACC_Ledger_Mapping");

                entity.Property(e => e.LedgerType).IsUnicode(false);

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.AccLedgerMappings)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK_ACC_Ledger_Mapping_Acc_MST_Hospital");
            });

            modelBuilder.Entity<AccLogEditVoucher>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("ACC_Log_EditVoucher");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalYearId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccMapTxnItemCostCenterItem>(entity =>
            {
                entity.HasKey(e => e.TxnItemCostCenterItemId);

                entity.ToTable("ACC_Map_TxnItemCostCenterItem");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.AccMapTxnItemCostCenterItems)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK_ACC_Map_TxnItemCostCenterItem_Acc_MST_Hospital");
            });

            modelBuilder.Entity<AccMstBankReconciliationCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("ACC_MST_Bank_ReconciliationCategory");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccMstChartOfAccount>(entity =>
            {
                entity.HasKey(e => e.ChartOfAccountId);

                entity.ToTable("ACC_MST_ChartOfAccounts");

                entity.Property(e => e.ChartOfAccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Coacode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COACode");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AccMstCodeDetail>(entity =>
            {
                entity.ToTable("ACC_MST_CodeDetails");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccMstCostCenterItem>(entity =>
            {
                entity.HasKey(e => e.CostCenterItemId);

                entity.ToTable("ACC_MST_CostCenterItems");

                entity.Property(e => e.CostCenterItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.AccMstCostCenterItems)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK_ACC_MST_CostCenterItems_Acc_MST_Hospital");
            });

            modelBuilder.Entity<AccMstFiscalYear>(entity =>
            {
                entity.HasKey(e => e.FiscalYearId);

                entity.ToTable("ACC_MST_FiscalYears");

                entity.Property(e => e.ClosedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FiscalYearName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NpFiscalYearName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.AccMstFiscalYears)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK_ACC_MST_FiscalYears_Acc_MST_Hospital");
            });

            modelBuilder.Entity<AccMstGroupMapping>(entity =>
            {
                entity.HasKey(e => e.GroupMappingId)
                    .HasName("PK_AccountingGroupMapping");

                entity.ToTable("ACC_MST_GroupMapping");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccMstHospital>(entity =>
            {
                entity.HasKey(e => e.HospitalId)
                    .HasName("PK_HospitalId");

                entity.ToTable("ACC_MST_Hospital");

                entity.HasIndex(e => e.HospitalShortName, "UK_Acc_HospitalShortName")
                    .IsUnique();

                entity.Property(e => e.HospitalLongName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccMstHospitalTransferRulesMapping>(entity =>
            {
                entity.HasKey(e => e.HospitalTransferRulesMapId)
                    .HasName("PK_HospitalTransferRulesMapId");

                entity.ToTable("ACC_MST_Hospital_TransferRules_Mapping");
            });

            modelBuilder.Entity<AccMstLedgerGroup>(entity =>
            {
                entity.HasKey(e => e.LedgerGroupId);

                entity.ToTable("ACC_MST_LedgerGroup");

                entity.Property(e => e.Coa)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COA");

                entity.Property(e => e.Coaid).HasColumnName("COAId");

                entity.Property(e => e.Code)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerGroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PrimaryGroup)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.AccMstLedgerGroups)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK_ACC_MST_LedgerGroup_Acc_MST_Hospital");
            });

            modelBuilder.Entity<AccMstMappingDetail>(entity =>
            {
                entity.HasKey(e => e.AccountingMappingDetailId);

                entity.ToTable("ACC_MST_MappingDetail");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.HasOne(d => d.GroupMapping)
                    .WithMany(p => p.AccMstMappingDetails)
                    .HasForeignKey(d => d.GroupMappingId)
                    .HasConstraintName("FK_ACC_MST_MappingDetail_ACC_MST_GroupMapping");

                entity.HasOne(d => d.LedgerGroup)
                    .WithMany(p => p.AccMstMappingDetails)
                    .HasForeignKey(d => d.LedgerGroupId)
                    .HasConstraintName("FK_ACC_MST_MappingDetail_ACC_MST_LedgerGroup");
            });

            modelBuilder.Entity<AccMstPrimaryGroup>(entity =>
            {
                entity.HasKey(e => e.PrimaryGroupId);

                entity.ToTable("ACC_MST_PrimaryGroup");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PrimaryGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryGroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccMstSectionList>(entity =>
            {
                entity.ToTable("ACC_MST_SectionList");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SectionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SectionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.AccMstSectionLists)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK_ACC_MST_SectionList_Acc_MST_Hospital");
            });

            modelBuilder.Entity<AccMstVoucher>(entity =>
            {
                entity.HasKey(e => e.VoucherId);

                entity.ToTable("ACC_MST_Vouchers");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IscopyDescription).HasColumnName("ISCopyDescription");

                entity.Property(e => e.ShowChequeNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowPayeeName).HasDefaultValueSql("((0))");

                entity.Property(e => e.VoucherCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccMstVoucherHead>(entity =>
            {
                entity.HasKey(e => e.VoucherHeadId);

                entity.ToTable("ACC_MST_VoucherHead");

                entity.HasIndex(e => e.VoucherHeadName, "UQ__ACC_MST___199AD4830D3A7AE0")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.VoucherHeadName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.AccMstVoucherHeads)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK_ACC_MST_VoucherHead_Acc_MST_Hospital");
            });

            modelBuilder.Entity<AccReverseTransaction>(entity =>
            {
                entity.HasKey(e => e.ReverseTransactionId)
                    .HasName("PK_ACC_UndoTransaction");

                entity.ToTable("ACC_ReverseTransaction");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.Tuid).HasColumnName("TUId");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.AccReverseTransactions)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK_ACC_ReverseTransaction_Acc_MST_Hospital");
            });

            modelBuilder.Entity<AccTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("ACC_Transactions");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsAllowReverseVoucher).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsEditable).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NewVoucherNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldVoucherNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayeeName).HasMaxLength(100);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tuid).HasColumnName("TUId");

                entity.Property(e => e.VoucherNumber)
                    .HasMaxLength(50)
                    .HasComment("It like hospital code with transaction id i.e. HAMS_TransactionId , \r\nIt will be null when comes from inventory");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.AccTransactions)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK_ACC_Transactions_Acc_MST_Hospital");

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.AccTransactions)
                    .HasForeignKey(d => d.VoucherId)
                    .HasConstraintName("FK_ACC_Transactions_ACC_MST_Vouchers");
            });

            modelBuilder.Entity<AccTransactionHistory>(entity =>
            {
                entity.ToTable("ACC_Transaction_History");

                entity.Property(e => e.SyncedOn).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccTransactionItem>(entity =>
            {
                entity.HasKey(e => e.TransactionItemId);

                entity.ToTable("ACC_TransactionItems");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.AccTransactionItems)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK_ACC_TransactionItems_Acc_MST_Hospital");

                entity.HasOne(d => d.Ledger)
                    .WithMany(p => p.AccTransactionItems)
                    .HasForeignKey(d => d.LedgerId)
                    .HasConstraintName("FK_ACC_TransactionItems_ACC_Ledger");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.AccTransactionItems)
                    .HasForeignKey(d => d.TransactionId)
                    .HasConstraintName("FK_ACC_TransactionItems_ACC_Transactions");
            });

            modelBuilder.Entity<AccTransactionItemDetail>(entity =>
            {
                entity.HasKey(e => e.TransactionItemDetailId);

                entity.ToTable("ACC_TransactionItemDetail");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceType)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccTxnBankReconciliation>(entity =>
            {
                entity.ToTable("ACC_TXN_Bank_Reconciliation");

                entity.Property(e => e.BankBalance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BankTransactionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Difference).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.VerifiedOn).HasColumnType("datetime");

                entity.Property(e => e.VoucherNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccTxnLink>(entity =>
            {
                entity.HasKey(e => e.AccountingTxnLinkId);

                entity.ToTable("ACC_TXN_Link");

                entity.Property(e => e.ReferenceId).IsUnicode(false);

                entity.Property(e => e.ReferenceIdOne).IsUnicode(false);

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.AccTxnLinks)
                    .HasForeignKey(d => d.TransactionId)
                    .HasConstraintName("FK_ACC_TXN_Link_ACC_Transactions");
            });

            modelBuilder.Entity<AccTxnPayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.ToTable("ACC_TXN_Payment");

                entity.Property(e => e.CreatedOn).HasPrecision(3);

                entity.Property(e => e.GoodReceiptId).HasColumnName("GoodReceiptID");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.PaymentDate).HasPrecision(3);

                entity.Property(e => e.PaymentMode).HasMaxLength(50);

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.VoucherAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.VoucherNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.AccTxnPayments)
                    .HasForeignKey(d => d.TransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Acc_TXN_Payment_ACC_Transactions");
            });

            modelBuilder.Entity<AdtBabyBirthDetail>(entity =>
            {
                entity.HasKey(e => e.BabyBirthDetailsId);

                entity.ToTable("ADT_BabyBirthDetails");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BirthNumberType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BirthType)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateNumber).HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FathersName).HasMaxLength(50);

                entity.Property(e => e.FiscalYear)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PrintedOn).HasColumnType("datetime");

                entity.Property(e => e.Sex).HasMaxLength(50);

                entity.Property(e => e.WeightOfBaby).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.BirthCondition)
                    .WithMany(p => p.AdtBabyBirthDetails)
                    .HasForeignKey(d => d.BirthConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_BirthConditionId_birthDetails_birthCondition");
            });

            modelBuilder.Entity<AdtBed>(entity =>
            {
                entity.HasKey(e => e.BedId);

                entity.ToTable("ADT_Bed");

                entity.Property(e => e.BedId).HasColumnName("BedID");

                entity.Property(e => e.BedCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.HoldedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AdtBedCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_Bed_Created_EMP_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AdtBedModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_ADT_Bed_Modified_EMP_Employee");

                entity.HasOne(d => d.Ward)
                    .WithMany(p => p.AdtBeds)
                    .HasForeignKey(d => d.WardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_Bed_ADT_Ward");
            });

            modelBuilder.Entity<AdtBedReservation>(entity =>
            {
                entity.HasKey(e => e.ReservedBedInfoId)
                    .HasName("ReservedBedInfoId");

                entity.ToTable("ADT_BedReservation");

                entity.Property(e => e.AdmissionNotes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AdmissionStartsOn).HasColumnType("datetime");

                entity.Property(e => e.AutoCancelledOn).HasColumnType("datetime");

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ReservedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdtDeathDeatil>(entity =>
            {
                entity.HasKey(e => e.DeathId)
                    .HasName("PK_DeathId");

                entity.ToTable("ADT_DeathDeatils");

                entity.Property(e => e.Age)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CauseOfDeath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeathDate).HasColumnType("datetime");

                entity.Property(e => e.FatherName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalYear)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.MotherName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PrintedOn).HasColumnType("datetime");

                entity.Property(e => e.SpouseOf)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.VisitCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdtDischargeCancel>(entity =>
            {
                entity.HasKey(e => e.DischargeCancelId);

                entity.ToTable("ADT_DischargeCancel");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DischargeCancelNote)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DischargedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdtDischargeSummary>(entity =>
            {
                entity.HasKey(e => e.PatientVisitId);

                entity.ToTable("ADT_DischargeSummary");

                entity.Property(e => e.PatientVisitId).ValueGeneratedNever();

                entity.Property(e => e.Activities)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AdviceOnDischarge)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Allergies)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CaseSummary)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ChiefComplaint)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Condition)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeathPeriod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Diagnosis)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosisFreeText)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Diet)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DischargeSummaryId).ValueGeneratedOnAdd();

                entity.Property(e => e.HistologyReport)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalCourse)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IsSubmitted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LabTests)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Medications)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OperativeFindings)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OperativeProcedure)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Others)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PastHistory)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.PendingReports)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalExamination)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.PresentingIllness)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureNts)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrarName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedImagingItems).HasMaxLength(2000);

                entity.Property(e => e.SpeicialNotes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Treatment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Anaesthetists)
                    .WithMany(p => p.AdtDischargeSummaryAnaesthetists)
                    .HasForeignKey(d => d.AnaesthetistsId)
                    .HasConstraintName("FK_ADT_DischargeSummary_Anaesthetists_EMP_Employee");

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.AdtDischargeSummaryConsultants)
                    .HasForeignKey(d => d.ConsultantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_DischargeSummary_Consultant_EMP_Employee");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AdtDischargeSummaryCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_DischargeSummary_CreatedBy_EMP_Employee");

                entity.HasOne(d => d.DischargeType)
                    .WithMany(p => p.AdtDischargeSummaries)
                    .HasForeignKey(d => d.DischargeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_DischargeSummary_ADT_DischargeType");

                entity.HasOne(d => d.DoctorIncharge)
                    .WithMany(p => p.AdtDischargeSummaryDoctorIncharges)
                    .HasForeignKey(d => d.DoctorInchargeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_DischargeSummary_DoctorIncharge_EMP_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AdtDischargeSummaryModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_ADT_DischargeSummary_ModifiedBy_EMP_Employee");

                entity.HasOne(d => d.Notes)
                    .WithMany(p => p.AdtDischargeSummaries)
                    .HasForeignKey(d => d.NotesId)
                    .HasConstraintName("FK__ADT_Disch__Notes__7E251262");

                entity.HasOne(d => d.PatientVisit)
                    .WithOne(p => p.AdtDischargeSummary)
                    .HasForeignKey<AdtDischargeSummary>(d => d.PatientVisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_DischargeSummary_PAT_PatientVisits");

                entity.HasOne(d => d.ResidenceDr)
                    .WithMany(p => p.AdtDischargeSummaryResidenceDrs)
                    .HasForeignKey(d => d.ResidenceDrId)
                    .HasConstraintName("FK_ADT_DischargeSummary_ResidenceDr_EMP_Employee");
            });

            modelBuilder.Entity<AdtDischargeSummaryMedication>(entity =>
            {
                entity.HasKey(e => e.DischargeSummaryMedicationId);

                entity.ToTable("ADT_DischargeSummaryMedication");

                entity.Property(e => e.Medicine).HasMaxLength(100);

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.OldNewMedicineType).HasComment("OldNewMedicineType represents 1.New Medicines, 2. Old medicines to be continued, 3.Old medicines to be stopped");
            });

            modelBuilder.Entity<AdtDischargeType>(entity =>
            {
                entity.HasKey(e => e.DischargeTypeId);

                entity.ToTable("ADT_DischargeType");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DischargeTypeName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AdtDischargeTypeCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_DischargeType_CreatedBy_EMP_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AdtDischargeTypeModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_ADT_DischargeType_ModifiedBy_EMP_Employee");
            });

            modelBuilder.Entity<AdtMapBedFeaturesMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADT_MAP_BedFeaturesMap");

                entity.Property(e => e.BedFeatureCfgid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BedFeatureCFGId");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.BedFeature)
                    .WithMany()
                    .HasForeignKey(d => d.BedFeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_MAP_BedFeaturesMap_ADT_BedFeature");

                entity.HasOne(d => d.Bed)
                    .WithMany()
                    .HasForeignKey(d => d.BedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_MAP_BedFeaturesMap_ADT_Bed");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_BedFeaturesMap_Created_EMP_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_ADT_BedFeaturesMap_Modified_EMP_Employee");

                entity.HasOne(d => d.Ward)
                    .WithMany()
                    .HasForeignKey(d => d.WardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_MAP_BedFeaturesMap_ADT_Ward");
            });

            modelBuilder.Entity<AdtMstBabyBirthCondition>(entity =>
            {
                entity.HasKey(e => e.BabyBirthConditionId);

                entity.ToTable("ADT_MST_BabyBirthCondition");

                entity.Property(e => e.BirthConditionType).HasMaxLength(50);
            });

            modelBuilder.Entity<AdtMstBedFeature>(entity =>
            {
                entity.HasKey(e => e.BedFeatureId);

                entity.ToTable("ADT_MST_BedFeature");

                entity.Property(e => e.BedFeatureFullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BedFeatureName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AdtMstBedFeatureCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_BedFeature_Created_EMP_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AdtMstBedFeatureModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_ADT_BedFeature_Modified_EMP_Employee");
            });

            modelBuilder.Entity<AdtMstDeathType>(entity =>
            {
                entity.HasKey(e => e.DeathTypeId);

                entity.ToTable("ADT_MST_DeathType");

                entity.Property(e => e.DeathType).HasMaxLength(50);

                entity.HasOne(d => d.DischargeType)
                    .WithMany(p => p.AdtMstDeathTypes)
                    .HasForeignKey(d => d.DischargeTypeId)
                    .HasConstraintName("FK_ADT_DeathType_DischargeType");
            });

            modelBuilder.Entity<AdtMstDeliveryType>(entity =>
            {
                entity.HasKey(e => e.DeliveryTypeId);

                entity.ToTable("ADT_MST_DeliveryType");

                entity.Property(e => e.DeliveryTypeName).HasMaxLength(50);

                entity.HasOne(d => d.DischargeCondition)
                    .WithMany(p => p.AdtMstDeliveryTypes)
                    .HasForeignKey(d => d.DischargeConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeliveryType_DischargeConditionType");
            });

            modelBuilder.Entity<AdtMstDischargeConditionType>(entity =>
            {
                entity.HasKey(e => e.DischargeConditionId);

                entity.ToTable("ADT_MST_DischargeConditionType");

                entity.Property(e => e.Condition).HasMaxLength(50);

                entity.HasOne(d => d.DischargeType)
                    .WithMany(p => p.AdtMstDischargeConditionTypes)
                    .HasForeignKey(d => d.DischargeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_DischargeConditionType_DischargeType");
            });

            modelBuilder.Entity<AdtMstGravitum>(entity =>
            {
                entity.HasKey(e => e.GravitaId)
                    .HasName("PK_GravitaId");

                entity.ToTable("ADT_MST_Gravita");

                entity.Property(e => e.GravitaName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdtMstWard>(entity =>
            {
                entity.HasKey(e => e.WardId);

                entity.ToTable("ADT_MST_Ward");

                entity.HasIndex(e => e.WardCode, "UC_WardCode")
                    .IsUnique();

                entity.HasIndex(e => e.WardName, "UC_WardName")
                    .IsUnique();

                entity.Property(e => e.WardId).HasColumnName("WardID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.WardCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WardLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WardName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AdtMstWardCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_Ward_Created_EMP_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AdtMstWardModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_ADT_Ward_Modified_EMP_Employee");
            });

            modelBuilder.Entity<AdtPatientAdmission>(entity =>
            {
                entity.HasKey(e => e.PatientVisitId);

                entity.ToTable("ADT_PatientAdmission");

                entity.HasIndex(e => e.IsInsurancePatient, "IX_TblAdmission_IsInsurancePatient");

                entity.HasIndex(e => new { e.PatientVisitId, e.PatientId }, "IX_TblAdmission_VisitId_PatientId");

                entity.Property(e => e.PatientVisitId).ValueGeneratedNever();

                entity.Property(e => e.AdmissionCase)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdmissionDate).HasColumnType("datetime");

                entity.Property(e => e.AdmissionNotes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AdmissionOrders)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AdmissionStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BillStatusOnDischarge)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.CancelledRemark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CareOfPersonName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CareOfPersonPhoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CareOfPersonRelation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.DischargeRemarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PatientAdmissionId).ValueGeneratedOnAdd();

                entity.Property(e => e.ProcedureType)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.AdmittingDoctor)
                    .WithMany(p => p.AdtPatientAdmissionAdmittingDoctors)
                    .HasForeignKey(d => d.AdmittingDoctorId)
                    .HasConstraintName("FK_ADT_PatientAdmission_EMP_Employee");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AdtPatientAdmissionCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_ADT_PatientAdmission_CreatedBy_EMP_Employee");

                entity.HasOne(d => d.DischargedByNavigation)
                    .WithMany(p => p.AdtPatientAdmissionDischargedByNavigations)
                    .HasForeignKey(d => d.DischargedBy)
                    .HasConstraintName("FK_ADT_PatientAdmission_DischargedBy_EMP_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AdtPatientAdmissionModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_ADT_PatientAdmission_ModifiedBy_EMP_Employee");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.AdtPatientAdmissions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_PatientAdmission_PAT_Patient");

                entity.HasOne(d => d.PatientVisit)
                    .WithOne(p => p.AdtPatientAdmission)
                    .HasForeignKey<AdtPatientAdmission>(d => d.PatientVisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_PatientAdmission_PAT_PatientVisits");
            });

            modelBuilder.Entity<AdtPatientCertificate>(entity =>
            {
                entity.HasKey(e => e.CertificateId);

                entity.ToTable("ADT_PatientCertificate");

                entity.Property(e => e.CertificateNumber).HasMaxLength(50);

                entity.Property(e => e.CertificateType).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeathDate).HasColumnType("date");

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.FiscalYearName).HasMaxLength(50);

                entity.Property(e => e.MotherName).HasMaxLength(50);

                entity.Property(e => e.Spouse).HasMaxLength(50);
            });

            modelBuilder.Entity<AdtTxnPatientBedInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADT_TXN_PatientBedInfo");

                entity.HasIndex(e => e.PatientVisitId, "IX_TblPatientBedInfo_VisitId");

                entity.Property(e => e.Action)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CancelRemarks).HasMaxLength(600);

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OutAction)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientBedInfoId).ValueGeneratedOnAdd();

                entity.Property(e => e.ReceivedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartedOn).HasColumnType("datetime");

                entity.HasOne(d => d.BedFeature)
                    .WithMany()
                    .HasForeignKey(d => d.BedFeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_TXN_PatientBedInfo_ADT_BedFeature");

                entity.HasOne(d => d.Bed)
                    .WithMany()
                    .HasForeignKey(d => d.BedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_TXN_PatientBedInfo_ADT_Bed");

                entity.HasOne(d => d.Ward)
                    .WithMany()
                    .HasForeignKey(d => d.WardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADT_TXN_PatientBedInfo_ADT_MST_Ward");
            });

            modelBuilder.Entity<AllAbnormalDataTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AllAbnormalDataTable");

                entity.Property(e => e.Range)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.TestComponentResultId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<BedInformationModel>(entity =>
            {
                entity.HasKey(e => e.BedNumber)
                    .HasName("PK_dbo.BedInformationModels");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<BilBillItemRequisition>(entity =>
            {
                entity.HasKey(e => e.BillItemRequisitionId);

                entity.ToTable("BIL_BillItemRequisition");

                entity.Property(e => e.BillStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BilBillItemRequisitionCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_BillItemRequisition_EMP_Employee");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.BilBillItemRequisitions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_BillItemRequisition_PAT_Patient");

                entity.HasOne(d => d.PatientVisit)
                    .WithMany(p => p.BilBillItemRequisitions)
                    .HasForeignKey(d => d.PatientVisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_BillItemRequisition_PAT_PatientVisits");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.BilBillItemRequisitionProviders)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_BillItemRequisition_ProviderId_EMP_Employee");

                entity.HasOne(d => d.ServiceDepartment)
                    .WithMany(p => p.BilBillItemRequisitions)
                    .HasForeignKey(d => d.ServiceDepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_BillItemRequisition_BIL_MST_ServiceDepartment");
            });

            modelBuilder.Entity<BilCfgBillItemPrice>(entity =>
            {
                entity.HasKey(e => e.BillItemPriceId);

                entity.ToTable("BIL_CFG_BillItemPrice");

                entity.HasIndex(e => new { e.ServiceDepartmentId, e.ItemId }, "UK_SrvDeptAndItemId")
                    .IsUnique();

                entity.Property(e => e.AllowMultipleQty).HasDefaultValueSql("((1))");

                entity.Property(e => e.Category)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DefaultDoctorList)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountApplicable).HasDefaultValueSql("((1))");

                entity.Property(e => e.DisplaySeq).HasDefaultValueSql("((100))");

                entity.Property(e => e.Ehsprice).HasColumnName("EHSPrice");

                entity.Property(e => e.IntegrationName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsDoctorMandatory).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsEhspriceApplicable)
                    .HasColumnName("IsEHSPriceApplicable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsForeignerPriceApplicable).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsFractionApplicable).HasColumnName("isFractionApplicable");

                entity.Property(e => e.IsInsForeignerPriceApplicable).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNormalPriceApplicable).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsOt).HasColumnName("IsOT");

                entity.Property(e => e.IsSaarcpriceApplicable)
                    .HasColumnName("IsSAARCPriceApplicable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsValidForReporting).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsZeroPriceAllowed).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ProcedureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SaarccitizenPrice).HasColumnName("SAARCCitizenPrice");

                entity.Property(e => e.TaxApplicable).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ServiceDepartment)
                    .WithMany(p => p.BilCfgBillItemPrices)
                    .HasForeignKey(d => d.ServiceDepartmentId)
                    .HasConstraintName("FK_BIL_CFG_BillItemPrice_MST_ServiceDepartment");
            });

            modelBuilder.Entity<BilCfgBillItemPriceHistory>(entity =>
            {
                entity.HasKey(e => e.BillItemPriceHistoryId)
                    .HasName("PK_BillItemPriceHistoryId");

                entity.ToTable("BIL_CFG_BillItemPrice_History");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BilCfgCounter>(entity =>
            {
                entity.HasKey(e => e.CounterId);

                entity.ToTable("BIL_CFG_Counter");

                entity.HasIndex(e => new { e.CounterName, e.CounterType }, "UK_BillingCounterName_Type")
                    .IsUnique();

                entity.Property(e => e.BeginningDate).HasColumnType("datetime");

                entity.Property(e => e.ClosingDate).HasColumnType("datetime");

                entity.Property(e => e.CounterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CounterType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BilCfgCounters)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_CFG_Counter_EMP_Employee");
            });

            modelBuilder.Entity<BilCfgFiscalYear>(entity =>
            {
                entity.HasKey(e => e.FiscalYearId);

                entity.ToTable("BIL_CFG_FiscalYears");

                entity.HasIndex(e => e.FiscalYearName, "UK_BIL_CFG_FiscalYears")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndYear).HasColumnType("datetime");

                entity.Property(e => e.FiscalYearFormatted)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalYearName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartYear).HasColumnType("datetime");
            });

            modelBuilder.Entity<BilCfgPackage>(entity =>
            {
                entity.HasKey(e => e.BillingPackageId);

                entity.ToTable("BIL_CFG_Packages");

                entity.Property(e => e.BillingItemsXml)
                    .HasColumnType("xml")
                    .HasColumnName("BillingItemsXML");

                entity.Property(e => e.BillingPackageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PackageCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BilCfgPackageCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.BilCfgPackageModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<BilCfgPriceCategory>(entity =>
            {
                entity.HasKey(e => e.PriceCategoryId);

                entity.ToTable("BIL_CFG_PriceCategory");

                entity.Property(e => e.BillingColumnName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PriceCategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BilHistoryBillingTransactionItem>(entity =>
            {
                entity.HasKey(e => e.BillTxnItemHistoryId)
                    .HasName("PK_BIL_TXN_BillCancellationItems");

                entity.ToTable("BIL_History_BillingTransactionItems");

                entity.Property(e => e.CounterDay).HasColumnType("date");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.HistoryType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsTransferredToAcc).HasColumnName("IsTransferredToACC");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.BillingTransactionItem)
                    .WithMany(p => p.BilHistoryBillingTransactionItems)
                    .HasForeignKey(d => d.BillingTransactionItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_History_BillingTransactionItems_BIL_TXN_BillingTransactionItems");
            });

            modelBuilder.Entity<BilMapFreeServiceBillingItem>(entity =>
            {
                entity.HasKey(e => e.FreeServiceAndBillingItemMappingId);

                entity.ToTable("BIL_MAP_FreeService_BillingItems");
            });

            modelBuilder.Entity<BilMapReportingItemBillingItem>(entity =>
            {
                entity.HasKey(e => e.RptItemBillItemMappingId);

                entity.ToTable("BIL_MAP_ReportingItem_BillingItems");

                entity.Property(e => e.RptItemBillItemMappingId).HasColumnName("RptItem_BillItemMappingId");
            });

            modelBuilder.Entity<BilMstCreditOrganization>(entity =>
            {
                entity.HasKey(e => e.OrganizationId)
                    .HasName("PK__BIL_MST___CADB0B1207C8222E");

                entity.ToTable("BIL_MST_Credit_Organization");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OrganizationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BilMstHandover>(entity =>
            {
                entity.HasKey(e => e.HandoverId)
                    .HasName("PK__BIL_MST___DB2A1F81FECB0C28");

                entity.ToTable("BIL_MST_Handover");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.HandoverType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BilMstServiceDepartment>(entity =>
            {
                entity.HasKey(e => e.ServiceDepartmentId)
                    .HasName("PK_BILL_ServiceDepartment");

                entity.ToTable("BIL_MST_ServiceDepartment");

                entity.HasIndex(e => e.ServiceDepartmentName, "uk_bil_mst_servicedepartment")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IntegrationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ServiceDepartmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDepartmentShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.BilMstServiceDepartments)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_BIL_MST_ServiceDepartment_MST_Department");
            });

            modelBuilder.Entity<BilSyncBillingAccounting>(entity =>
            {
                entity.HasKey(e => e.BillingAccountingSyncId);

                entity.ToTable("BIL_SYNC_BillingAccounting");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IncomeLedgerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceModelName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BilTempCfgbillItemPrice7sept>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BIL_TEMP_CFGBillItemPrice_7Sept");

                entity.Property(e => e.BillItemPriceId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ProcedureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BilTempItemsMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BIL_Temp_ItemsMapping");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BilTxnBillingTransaction>(entity =>
            {
                entity.HasKey(e => e.BillingTransactionId);

                entity.ToTable("BIL_TXN_BillingTransaction");

                entity.HasIndex(e => e.CreatedOn, "IX_BIL_BillingTransaction_CreatedOn");

                entity.HasIndex(e => e.FiscalYearId, "IX_TblBilTxn_FiscalYearId_InvoiceNo");

                entity.Property(e => e.AdjustmentTotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsTransactionDate).HasColumnType("datetime");

                entity.Property(e => e.InsuranceClaimedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LabTypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PackageName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDetails)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BilTxnBillingTransactions)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_TXN_BillingTransaction_EMP_Employee");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.BilTxnBillingTransactions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_TXN_BillingTransaction_PAT_Patient");

                entity.HasOne(d => d.Settlement)
                    .WithMany(p => p.BilTxnBillingTransactions)
                    .HasForeignKey(d => d.SettlementId)
                    .HasConstraintName("FK_BIL_TXN_BillingTransaction_Settlements");
            });

            modelBuilder.Entity<BilTxnBillingTransactionItem>(entity =>
            {
                entity.HasKey(e => e.BillingTransactionItemId);

                entity.ToTable("BIL_TXN_BillingTransactionItems");

                entity.HasIndex(e => e.ProvisionalFiscalYearId, "IX_ProvisionalFY_ReceiptNo");

                entity.HasIndex(e => e.BillingTransactionId, "IX_TblBilTxnItem_BillingTransactionId");

                entity.HasIndex(e => new { e.PatientVisitId, e.ServiceDepartmentName }, "IX_TblBilTxnItem_PatientVisitIdServDeptName");

                entity.HasIndex(e => e.RequisitionId, "IX_TblBilTxnItem_RequisitonId");

                entity.HasIndex(e => e.PatientId, "indx_nc_biltxnitem_PatId");

                entity.Property(e => e.BillStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillingType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CancelRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.CounterDay).HasColumnType("date");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsTransferredToAcc).HasColumnName("IsTransferredToACC");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LabTypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PriceCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequisitionDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ServiceDepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.BillingPackage)
                    .WithMany(p => p.BilTxnBillingTransactionItems)
                    .HasForeignKey(d => d.BillingPackageId)
                    .HasConstraintName("FK_BIL_BillingTransactionItems_BIL_CFG_Packages");

                entity.HasOne(d => d.BillingTransaction)
                    .WithMany(p => p.BilTxnBillingTransactionItems)
                    .HasForeignKey(d => d.BillingTransactionId)
                    .HasConstraintName("FK_BIL_TXN_BillingTransactionItems_BIL_TXN_BillingTransaction");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BilTxnBillingTransactionItemCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_TXN_BillingTransactionItems_EMP_Employee");

                entity.HasOne(d => d.PatientVisit)
                    .WithMany(p => p.BilTxnBillingTransactionItems)
                    .HasForeignKey(d => d.PatientVisitId)
                    .HasConstraintName("FK_BIL_TXN_BillingTransactionItems_PAT_PatientVisits");

                entity.HasOne(d => d.RequestedByNavigation)
                    .WithMany(p => p.BilTxnBillingTransactionItemRequestedByNavigations)
                    .HasForeignKey(d => d.RequestedBy)
                    .HasConstraintName("FK_BIL_TXN_BillingTransactionItems_RequestedByProvider_EMP_Employee");

                entity.HasOne(d => d.ServiceDepartment)
                    .WithMany(p => p.BilTxnBillingTransactionItems)
                    .HasForeignKey(d => d.ServiceDepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_TXN_BillingTransactionItems_BIL_MST_ServiceDepartment");
            });

            modelBuilder.Entity<BilTxnCashHandover>(entity =>
            {
                entity.HasKey(e => e.HandoverTxnId);

                entity.ToTable("BIL_TXN_CashHandover");

                entity.Property(e => e.BankName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HandoverRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HandoverType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedOn).HasColumnType("datetime");

                entity.Property(e => e.VoucherDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Counter)
                    .WithMany(p => p.BilTxnCashHandovers)
                    .HasForeignKey(d => d.CounterId)
                    .HasConstraintName("FK_BIL_TXN_CashHandover_CounterId_BIL_CFG_Counter_CounterId");

                entity.HasOne(d => d.HandoverByEmp)
                    .WithMany(p => p.BilTxnCashHandovers)
                    .HasForeignKey(d => d.HandoverByEmpId)
                    .HasConstraintName("FK_BIL_TXN_CashHandover_HandoverByEmpId_EMP_Employee_EmployeeId");
            });

            modelBuilder.Entity<BilTxnDenomination>(entity =>
            {
                entity.HasKey(e => e.DenominationId)
                    .HasName("PK__BIL_TXN___22DF18E5CA08EC78");

                entity.ToTable("BIL_TXN_Denomination");

                entity.HasOne(d => d.Handover)
                    .WithMany(p => p.BilTxnDenominations)
                    .HasForeignKey(d => d.HandoverId)
                    .HasConstraintName("FK__BIL_TXN_D__Hando__31432D07");
            });

            modelBuilder.Entity<BilTxnDeposit>(entity =>
            {
                entity.HasKey(e => e.DepositId);

                entity.ToTable("BIL_TXN_Deposit");

                entity.HasIndex(e => e.PatientVisitId, "IX_TblBilDeposit_VisitId");

                entity.Property(e => e.CareOf)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepositType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsTransferTransaction).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDetails)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.PrintedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BilTxnDeposits)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_TXN_Deposit_EMP_Employee");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.BilTxnDeposits)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_TXN_Deposit_PAT_Patient");
            });

            modelBuilder.Entity<BilTxnInvoiceReturn>(entity =>
            {
                entity.HasKey(e => e.BillReturnId);

                entity.ToTable("BIL_TXN_InvoiceReturn");

                entity.Property(e => e.BillStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FiscalYear)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.HasOne(d => d.BillingTransaction)
                    .WithMany(p => p.BilTxnInvoiceReturns)
                    .HasForeignKey(d => d.BillingTransactionId)
                    .HasConstraintName("FK_BIL_TXN_InvoiceReturn_TXN_BillingTransaction");

                entity.HasOne(d => d.Counter)
                    .WithMany(p => p.BilTxnInvoiceReturns)
                    .HasForeignKey(d => d.CounterId)
                    .HasConstraintName("FK_BIL_TXN_InvoiceReturn_CFG_Counter");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BilTxnInvoiceReturns)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_TXN_InvoiceReturn_EMP_Employee");

                entity.HasOne(d => d.FiscalYearNavigation)
                    .WithMany(p => p.BilTxnInvoiceReturns)
                    .HasForeignKey(d => d.FiscalYearId)
                    .HasConstraintName("FK_BIL_TXN_InvoiceReturn_CFG_FiscalYears");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.BilTxnInvoiceReturns)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_TXN_InvoiceReturn_Pat_Patient");
            });

            modelBuilder.Entity<BilTxnInvoiceReturnItem>(entity =>
            {
                entity.HasKey(e => e.BillReturnItemId);

                entity.ToTable("BIL_TXN_InvoiceReturnItems");

                entity.Property(e => e.BillStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillingType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.LabTypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PriceCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequisitionDate).HasColumnType("datetime");

                entity.Property(e => e.RetRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VisitType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.BillReturn)
                    .WithMany(p => p.BilTxnInvoiceReturnItems)
                    .HasForeignKey(d => d.BillReturnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_TXN_InvoiceReturnItems_BIL_TXN_InvoiceReturn");

                entity.HasOne(d => d.BillingTransaction)
                    .WithMany(p => p.BilTxnInvoiceReturnItems)
                    .HasForeignKey(d => d.BillingTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_TXN_InvoiceReturnItems_TXN_BillingTransaction");

                entity.HasOne(d => d.BillingTransactionItem)
                    .WithMany(p => p.BilTxnInvoiceReturnItems)
                    .HasForeignKey(d => d.BillingTransactionItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_TXN_InvoiceReturnItems_TXN_BillingTransactionItems");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BilTxnInvoiceReturnItems)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_TXN_InvoiceReturnItems_EMP_Employee");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.BilTxnInvoiceReturnItems)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_TXN_InvoiceReturnItems_PAT_Patient");

                entity.HasOne(d => d.PatientVisit)
                    .WithMany(p => p.BilTxnInvoiceReturnItems)
                    .HasForeignKey(d => d.PatientVisitId)
                    .HasConstraintName("FK_BIL_TXN_InvoiceReturnItems_PAT_PatientVisits");

                entity.HasOne(d => d.RetCounter)
                    .WithMany(p => p.BilTxnInvoiceReturnItems)
                    .HasForeignKey(d => d.RetCounterId)
                    .HasConstraintName("FK_BIL_TXN_InvoiceReturnItems_BIL_CFG_Counter");

                entity.HasOne(d => d.ServiceDepartment)
                    .WithMany(p => p.BilTxnInvoiceReturnItems)
                    .HasForeignKey(d => d.ServiceDepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIL_TXN_InvoiceReturnItems_BIL_MST_ServiceDepartment");
            });

            modelBuilder.Entity<BilTxnSettlement>(entity =>
            {
                entity.HasKey(e => e.SettlementId);

                entity.ToTable("BIL_TXN_Settlements");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.PaymentDetails)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementDate).HasColumnType("datetime");

                entity.Property(e => e.SettlementType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CfgPrintExportSetting>(entity =>
            {
                entity.HasKey(e => e.PrintExportSettingsId)
                    .HasName("PK__CFG_Prin__B54E2B92E9DB92B7");

                entity.ToTable("CFG_PrintExportSettings");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PageHeaderText)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDescription)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.SettingName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShowEnDate).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowFilterDateRange).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowFooter).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowHeader).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowNpDate).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowOtherFilterVariables).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowPrintExportDateTime).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowUserName).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CfgPrinterSetting>(entity =>
            {
                entity.HasKey(e => e.PrinterSettingId)
                    .HasName("PK__CFG_Prin__E59A047307AE88B3");

                entity.ToTable("CFG_PrinterSettings");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FooterGapLines).HasColumnName("FooterGap_Lines");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderGapLines).HasColumnName("HeaderGap_Lines");

                entity.Property(e => e.HeightLines).HasColumnName("Height_Lines");

                entity.Property(e => e.Mh).HasColumnName("mh");

                entity.Property(e => e.Ml).HasColumnName("ml");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PrinterDisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrinterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintingType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServerFolderPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WidthLines).HasColumnName("Width_Lines");
            });

            modelBuilder.Entity<ClnActiveMedical>(entity =>
            {
                entity.HasKey(e => e.PatientProblemId)
                    .HasName("PK_PAT_PatientProblems");

                entity.ToTable("CLN_ActiveMedicals");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CurrentStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Icd10code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ICD10Code");

                entity.Property(e => e.Icd10description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ICD10Description");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OnSetDate).HasColumnType("datetime");

                entity.Property(e => e.ResolvedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Icd10codeNavigation)
                    .WithMany(p => p.ClnActiveMedicals)
                    .HasPrincipalKey(p => p.Icd10code)
                    .HasForeignKey(d => d.Icd10code)
                    .HasConstraintName("FK_PAT_PatientProblems_MST_ICD10");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ClnActiveMedicals)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientProblems_PAT_Patient");
            });

            modelBuilder.Entity<ClnAllergy>(entity =>
            {
                entity.HasKey(e => e.PatientAllergyId)
                    .HasName("PK_PAT_PatientAllergies");

                entity.ToTable("CLN_Allergies");

                entity.Property(e => e.AllergenAdvRecName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Reaction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Severity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ClnAllergies)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientAllergies_PAT_Patient");
            });

            modelBuilder.Entity<ClnDiagnosis>(entity =>
            {
                entity.HasKey(e => e.DiagnosisId)
                    .HasName("PK__CLN_Diag__0C54CC739854B5EA");

                entity.ToTable("CLN_Diagnosis");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Icd10code)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ICD10Code");

                entity.Property(e => e.Icd10description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ICD10Description");

                entity.Property(e => e.Icd10id).HasColumnName("ICD10ID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ClnEyeAblationProfile>(entity =>
            {
                entity.ToTable("CLN_EYE_Ablation_Profile");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dzpfactor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DZPFactor");

                entity.Property(e => e.IsOd).HasColumnName("IsOD");

                entity.Property(e => e.IsPtkperformed).HasColumnName("isPTKPerformed");

                entity.Property(e => e.IsSxdone).HasColumnName("isSXDone");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Profile)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClnEyeLaserDataEntry>(entity =>
            {
                entity.ToTable("CLN_EYE_Laser_DataEntry");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsOd).HasColumnName("IsOD");

                entity.Property(e => e.Profile)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Transmission)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClnEyeLasikRst>(entity =>
            {
                entity.ToTable("CLN_EYE_LasikRST");

                entity.Property(e => e.AblationDepthMicrons)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AblationDepthNotes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FlapDepthMicrons)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlapDepthNotes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsOd).HasColumnName("IsOD");

                entity.Property(e => e.PachymetryMicrons)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PachymetryNotes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PredictedRstmicrons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PredictedRSTMicrons");

                entity.Property(e => e.PredictedRstnotes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PredictedRSTNotes");
            });

            modelBuilder.Entity<ClnEyeOperationNote>(entity =>
            {
                entity.ToTable("CLN_EYE_OperationNotes");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsOd).HasColumnName("IsOD");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClnEyeOra>(entity =>
            {
                entity.ToTable("CLN_EYE_ORA");

                entity.Property(e => e.Ch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CH");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Crf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRF");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Iopcc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IOPcc");

                entity.Property(e => e.IsOd).HasColumnName("IsOD");

                entity.Property(e => e.Timepoint)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClnEyePachymetry>(entity =>
            {
                entity.ToTable("CLN_EYE_Pachymetry");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IsOd).HasColumnName("IsOD");

                entity.Property(e => e.TimepointPre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usmin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USMin");

                entity.Property(e => e.VisanteRst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VisanteRST");
            });

            modelBuilder.Entity<ClnEyePreOpPachymetry>(entity =>
            {
                entity.ToTable("CLN_EYE_PreOP_Pachymetry");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsOd).HasColumnName("IsOD");

                entity.Property(e => e.Profile)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Usmin).HasColumnName("USMin");
            });

            modelBuilder.Entity<ClnEyeRefraction>(entity =>
            {
                entity.ToTable("CLN_EYE_Refraction");

                entity.Property(e => e.Blett)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BLett");

                entity.Property(e => e.Bscva).HasColumnName("BSCVA");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Dcnv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DCNV");

                entity.Property(e => e.IsOd).HasColumnName("IsOD");

                entity.Property(e => e.Nuc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NUC");

                entity.Property(e => e.TimePoint)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ucva).HasColumnName("UCVA");

                entity.Property(e => e.Ulett)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ULett");
            });

            modelBuilder.Entity<ClnEyeScanImage>(entity =>
            {
                entity.HasKey(e => e.PatientFileId)
                    .HasName("PK__CLN_EyeS__BD1224611AE18A85");

                entity.ToTable("CLN_EyeScanImages");

                entity.HasIndex(e => e.Rowguid, "UQ__CLN_EyeS__D7A3AA55BC800205")
                    .IsUnique();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileExtention)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageFullPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid).HasColumnName("ROWGUID");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UploadedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ClnEyeSmileIncision>(entity =>
            {
                entity.ToTable("CLN_EYE_Smile_Incisions");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsOd).HasColumnName("IsOD");
            });

            modelBuilder.Entity<ClnEyeSmileSetting>(entity =>
            {
                entity.ToTable("CLN_EYE_Smile_Setting");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EnergyOffsetCap)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnergyOffsetCapSide)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnergyOffsetLent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnergyOffsetLentSide)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsOd).HasColumnName("IsOD");

                entity.Property(e => e.MinThicknessCap)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinThicknessCapSide)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinThicknessLent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinThicknessLentSide)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanDirectionCap)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanDirectionCapSide)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanDirectionLent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanDirectionLentSide)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanModeCap)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanModeCapSide)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanModeLent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanModeLentSide)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SidecutCap)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SidecutCapSide)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SidecutLent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SidecutLentSide)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpotDistanceCap)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpotDistanceCapSide)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpotDistanceLent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpotDistanceLentSide)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackDistanceCap)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackDistanceCapSide)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackDistanceLent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackDistanceLentSide)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClnEyeVisuMax>(entity =>
            {
                entity.ToTable("CLN_EYE_VisuMax");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Glass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hinge)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsOd).HasColumnName("IsOD");

                entity.Property(e => e.Sidecut)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClnEyeWavefront>(entity =>
            {
                entity.ToTable("CLN_EYE_Wavefront");

                entity.Property(e => e.Coma)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.HoRms)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HoRMS");

                entity.Property(e => e.IsOd).HasColumnName("IsOD");

                entity.Property(e => e.SphAb)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Timepoint)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClnFamilyHistory>(entity =>
            {
                entity.HasKey(e => e.FamilyProblemId)
                    .HasName("PK__CLN_Fami__FCF1CF6BC339B3FF");

                entity.ToTable("CLN_FamilyHistory");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Icd10code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ICD10Code");

                entity.Property(e => e.Icd10description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ICD10Description");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Icd10codeNavigation)
                    .WithMany(p => p.ClnFamilyHistories)
                    .HasPrincipalKey(p => p.Icd10code)
                    .HasForeignKey(d => d.Icd10code)
                    .HasConstraintName("FK_PAT_FamilyHistory_MST_ICD10");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ClnFamilyHistories)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAT_Patient__PAT_FamilyHistory");
            });

            modelBuilder.Entity<ClnHomeMedication>(entity =>
            {
                entity.HasKey(e => e.HomeMedicationId)
                    .HasName("PK_PAT_HomeMedication");

                entity.ToTable("CLN_HomeMedications");

                entity.Property(e => e.Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dose)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastTaken).HasColumnType("datetime");

                entity.Property(e => e.MedicationType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OtherMedication)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ClnHomeMedications)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_HomeMedication_PAT_Patient");
            });

            modelBuilder.Entity<ClnInputOutput>(entity =>
            {
                entity.HasKey(e => e.InputOutputId)
                    .HasName("PK_CLN_InputOutput_1");

                entity.ToTable("CLN_InputOutput");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IntakeType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OutputType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.PatientVisit)
                    .WithMany(p => p.ClnInputOutputs)
                    .HasForeignKey(d => d.PatientVisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLN_InputOutput_PAT_PatientVisits");
            });

            modelBuilder.Entity<ClnKvPatientClinicalInfo>(entity =>
            {
                entity.HasKey(e => e.InfoId)
                    .HasName("PK__CLN_KV_P__4DEC9D7A83C1B655");

                entity.ToTable("CLN_KV_PatientClinical_Info");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KeyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClnMedicationPrescription>(entity =>
            {
                entity.HasKey(e => e.MedicationPrescriptionId);

                entity.ToTable("CLN_MedicationPrescription");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dose)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DurationType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Route)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeofMedication)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ClnMedicationPrescriptions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLN_Medication_PAT_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ClnMedicationPrescriptions)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLN_MedicationPrescription_EMP_Employee");
            });

            modelBuilder.Entity<ClnMstEye>(entity =>
            {
                entity.ToTable("CLN_MST_EYE");

                entity.HasIndex(e => e.VisitId, "UQ__CLN_MST___4D3AA1DF8A330DC6")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.VisitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ClnMstFrequency>(entity =>
            {
                entity.HasKey(e => e.FrequencyId);

                entity.ToTable("CLN_MST_Frequency");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<ClnMstNoteType>(entity =>
            {
                entity.HasKey(e => e.NoteTypeId)
                    .HasName("PK__CLN_MST___28ABD52FC9C0DAD2");

                entity.ToTable("CLN_MST_NoteType");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.NoteType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ClnMstNoteTypes)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CLN_MST_N__Creat__0E5B7A2B");
            });

            modelBuilder.Entity<ClnMstPrescriptionSlip>(entity =>
            {
                entity.ToTable("CLN_MST_PrescriptionSlip");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.VisitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ClnNote>(entity =>
            {
                entity.HasKey(e => e.NotesId);

                entity.ToTable("CLN_Notes");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FollowUpUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icdselected).HasColumnName("ICDSelected");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.NoteType)
                    .WithMany(p => p.ClnNotes)
                    .HasForeignKey(d => d.NoteTypeId)
                    .HasConstraintName("FK__CLN_Notes__NoteT__0F4F9E64");

                entity.HasOne(d => d.PatientVisit)
                    .WithMany(p => p.ClnNotes)
                    .HasForeignKey(d => d.PatientVisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLN_Notes_PAT_PatientVisits");

                entity.HasOne(d => d.SecondaryDoctor)
                    .WithMany(p => p.ClnNotes)
                    .HasForeignKey(d => d.SecondaryDoctorId)
                    .HasConstraintName("FK__CLN_Notes__Secon__0A8AE947");
            });

            modelBuilder.Entity<ClnNotesEmergency>(entity =>
            {
                entity.HasKey(e => e.EmergencyNoteId)
                    .HasName("PK__CLN_Note__AED090018457A8BC");

                entity.ToTable("CLN_Notes_Emergency");

                entity.Property(e => e.BroughtBy)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BroughtIn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Disposition)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ErCourseDescription)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Icdselected).HasColumnName("ICDSelected");

                entity.Property(e => e.ModeOfArrival)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralDoctorOrHospital)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TriagedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Notes)
                    .WithMany(p => p.ClnNotesEmergencies)
                    .HasForeignKey(d => d.NotesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CLN_Notes__Notes__1D9DBDBB");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ClnNotesEmergencies)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__CLN_Notes__Patie__1E91E1F4");

                entity.HasOne(d => d.PatientVisit)
                    .WithMany(p => p.ClnNotesEmergencies)
                    .HasForeignKey(d => d.PatientVisitId)
                    .HasConstraintName("FK__CLN_Notes__Patie__1F86062D");
            });

            modelBuilder.Entity<ClnNotesFreeText>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLN_Notes_FreeText");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FreeTextId).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ClnNotesObjective>(entity =>
            {
                entity.HasKey(e => e.ObjectiveNotesId)
                    .HasName("PK__CLN_Note__2288F20F92296E76");

                entity.ToTable("CLN_Notes_Objective");

                entity.Property(e => e.Abdomen)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Chest)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Cvs)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CVS");

                entity.Property(e => e.Extremity)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Heent)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("HEENT");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Neurological)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Skin)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Notes)
                    .WithMany(p => p.ClnNotesObjectives)
                    .HasForeignKey(d => d.NotesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLN_Notes_Objective_CLN_Notes");
            });

            modelBuilder.Entity<ClnNotesPrescriptionNote>(entity =>
            {
                entity.HasKey(e => e.PrescriptionNoteId)
                    .HasName("PK_CLN_Note_PrescriptionNote");

                entity.ToTable("CLN_Notes_PrescriptionNote");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Icdremarks).HasColumnName("ICDRemarks");

                entity.Property(e => e.Icdselected).HasColumnName("ICDSelected");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ClnNotesProcedure>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLN_Notes_Procedure");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FreeText).IsUnicode(false);

                entity.Property(e => e.LinesProse).IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PatientId).HasColumnName("PatientId ");

                entity.Property(e => e.ProcedureNoteId).ValueGeneratedOnAdd();

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Site).IsUnicode(false);
            });

            modelBuilder.Entity<ClnNotesProgress>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLN_Notes_Progress");

                entity.Property(e => e.AssessmentPlan).IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Instructions).IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ObjectiveNotes).IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientId ");

                entity.Property(e => e.ProgressNoteId).ValueGeneratedOnAdd();

                entity.Property(e => e.SubjectiveNotes).IsUnicode(false);
            });

            modelBuilder.Entity<ClnNotesSubjective>(entity =>
            {
                entity.HasKey(e => e.SubjectiveNoteId);

                entity.ToTable("CLN_Notes_Subjective");

                entity.Property(e => e.ChiefComplaint)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.HistoryOfPresentingIllness)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ReviewOfSystems)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Notes)
                    .WithMany(p => p.ClnNotesSubjectives)
                    .HasForeignKey(d => d.NotesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLN_Notes_Subjective_CLN_Notes");
            });

            modelBuilder.Entity<ClnPastMedical>(entity =>
            {
                entity.HasKey(e => e.PatientProblemId)
                    .HasName("PK_PAT_PastMedical");

                entity.ToTable("CLN_PastMedicals");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CurrentStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Icd10code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ICD10Code");

                entity.Property(e => e.Icd10description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ICD10Description");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OnSetDate).HasColumnType("datetime");

                entity.Property(e => e.ResolvedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Icd10codeNavigation)
                    .WithMany(p => p.ClnPastMedicals)
                    .HasPrincipalKey(p => p.Icd10code)
                    .HasForeignKey(d => d.Icd10code)
                    .HasConstraintName("FK__PAT_Patient__MST_ICD10");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ClnPastMedicals)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAT_PastMedical__PAT_Patient");
            });

            modelBuilder.Entity<ClnPatImage>(entity =>
            {
                entity.HasKey(e => e.PatImageId);

                entity.ToTable("CLN_PAT_Images");

                entity.HasIndex(e => e.Rowguid, "UQ__CLN_PAT___D7A3AA5567EF1EDE")
                    .IsUnique();

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileExtention)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid).HasColumnName("ROWGUID");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UploadedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ClnPatientNote>(entity =>
            {
                entity.HasKey(e => e.PatientNoteId)
                    .HasName("PK__CLN_Pati__1908825687B809ED");

                entity.ToTable("CLN_PatientNotes");

                entity.Property(e => e.Addendum)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AssessmentNote)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NoteType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectiveNote)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Orders)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PlanNote)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RecordedOnDate).HasColumnType("datetime");

                entity.Property(e => e.SubjectiveNote)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.PatientVisit)
                    .WithMany(p => p.ClnPatientNotes)
                    .HasForeignKey(d => d.PatientVisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLN_PatientNotes_PAT_PatientVisit");
            });

            modelBuilder.Entity<ClnPatientVisitNote>(entity =>
            {
                entity.HasKey(e => e.PatientVisitNoteId);

                entity.ToTable("CLN_PatientVisit_Notes");

                entity.Property(e => e.Abdomen)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Chest)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ChiefComplaint)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Cvs)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("CVS");

                entity.Property(e => e.Diagnosis)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Extremity)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUpUnit)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FreeText)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Heent)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("HEENT");

                entity.Property(e => e.HistoryOfPresentingIllness)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.LinesProse)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Neurological)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ProsDate).HasColumnType("datetime");

                entity.Property(e => e.ProsRemarks)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewOfSystems)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Skin)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClnPatientVisitProcedure>(entity =>
            {
                entity.HasKey(e => e.PatientVisitProcedureId);

                entity.ToTable("CLN_PatientVisitProcedure");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClnPatientVital>(entity =>
            {
                entity.HasKey(e => e.PatientVitalId)
                    .HasName("PK_CLN_PatientVitals_1");

                entity.ToTable("CLN_PatientVitals");

                entity.Property(e => e.Advice).IsUnicode(false);

                entity.Property(e => e.Akriti)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Bmi).HasColumnName("BMI");

                entity.Property(e => e.BodyPart)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Bpdiastolic).HasColumnName("BPDiastolic");

                entity.Property(e => e.Bpsystolic).HasColumnName("BPSystolic");

                entity.Property(e => e.CnsConsiousness)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CNS_Consiousness");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Diagnosis).IsUnicode(false);

                entity.Property(e => e.DiagnosisType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Drik)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FreeNotes).IsUnicode(false);

                entity.Property(e => e.HeartSounds).HasMaxLength(20);

                entity.Property(e => e.HeightUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Jivha)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LungField)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mala)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Mutra)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nadi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Organomegaly)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Others)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OxygenDeliveryMethod)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaTenderness)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PA_Tenderness");

                entity.Property(e => e.Power)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Reflexes)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RespiratoryRatePerMin)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Shabda)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sparsha)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TemperatureUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VitalsTakenOn).HasColumnType("datetime");

                entity.Property(e => e.WeightUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.PatientVisit)
                    .WithMany(p => p.ClnPatientVitals)
                    .HasForeignKey(d => d.PatientVisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLN_PatientVitals_PAT_PatientVisits");
            });

            modelBuilder.Entity<ClnPrescriptionSlipAcceptance>(entity =>
            {
                entity.ToTable("CLN_PrescriptionSlip_Acceptance");

                entity.Property(e => e.AxisOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AxisOD");

                entity.Property(e => e.AxisOs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AxisOS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CylOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CylOD");

                entity.Property(e => e.CylOs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CylOS");

                entity.Property(e => e.SphOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SphOD");

                entity.Property(e => e.SphOs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SphOS");

                entity.Property(e => e.VaOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VaOD");

                entity.Property(e => e.VaOs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VaOS");
            });

            modelBuilder.Entity<ClnPrescriptionSlipAdviceDiagnosis>(entity =>
            {
                entity.ToTable("CLN_PrescriptionSlip_AdviceDiagnosis");

                entity.Property(e => e.AdviceDiagnosis)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ClnPrescriptionSlipDilate>(entity =>
            {
                entity.ToTable("CLN_PrescriptionSlip_Dilate");

                entity.Property(e => e.Cp).HasColumnName("CP");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Ctc).HasColumnName("CTC");
            });

            modelBuilder.Entity<ClnPrescriptionSlipFinalClass>(entity =>
            {
                entity.ToTable("CLN_PrescriptionSlip_FinalClass");

                entity.Property(e => e.AxisOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AxisOD");

                entity.Property(e => e.AxisOs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AxisOS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CylOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CylOD");

                entity.Property(e => e.CylOs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CylOS");

                entity.Property(e => e.SphOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SphOD");

                entity.Property(e => e.SphOs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SphOS");

                entity.Property(e => e.VaOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VaOD");

                entity.Property(e => e.VaOs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VaOS");
            });

            modelBuilder.Entity<ClnPrescriptionSlipHistory>(entity =>
            {
                entity.ToTable("CLN_PrescriptionSlip_History");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.History)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClnPrescriptionSlipIop>(entity =>
            {
                entity.ToTable("CLN_PrescriptionSlip_IOP");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Od)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OD");

                entity.Property(e => e.Os)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OS");
            });

            modelBuilder.Entity<ClnPrescriptionSlipPlup>(entity =>
            {
                entity.ToTable("CLN_PrescriptionSlip_Plup");

                entity.Property(e => e.AxisOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AxisOD");

                entity.Property(e => e.AxisOs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AxisOS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CylOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CylOD");

                entity.Property(e => e.CylOs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CylOS");

                entity.Property(e => e.SphOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SphOD");

                entity.Property(e => e.SphOs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SphOS");

                entity.Property(e => e.VaOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VaOD");

                entity.Property(e => e.VaOs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VaOS");
            });

            modelBuilder.Entity<ClnPrescriptionSlipRetinoscopy>(entity =>
            {
                entity.ToTable("CLN_PrescriptionSlip_Retinoscopy");

                entity.Property(e => e.AxisOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AxisOD");

                entity.Property(e => e.AxisOs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AxisOS");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CylOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CylOD");

                entity.Property(e => e.CylOs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CylOS");

                entity.Property(e => e.SphOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SphOD");

                entity.Property(e => e.SphOs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SphOS");

                entity.Property(e => e.VaOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VaOD");

                entity.Property(e => e.VaOs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VaOS");
            });

            modelBuilder.Entity<ClnPrescriptionSlipSchrime>(entity =>
            {
                entity.ToTable("CLN_PrescriptionSlip_Schrime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Od)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OD");

                entity.Property(e => e.Os)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OS");
            });

            modelBuilder.Entity<ClnPrescriptionSlipTbut>(entity =>
            {
                entity.ToTable("CLN_PrescriptionSlip_TBUT");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Od)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OD");

                entity.Property(e => e.Os)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OS");
            });

            modelBuilder.Entity<ClnPrescriptionSlipVaUnaided>(entity =>
            {
                entity.ToTable("CLN_PrescriptionSlip_VaUnaided");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Od)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OD");

                entity.Property(e => e.Os)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OS");
            });

            modelBuilder.Entity<ClnReferralSource>(entity =>
            {
                entity.HasKey(e => e.ReferralSourceId)
                    .HasName("PK__CLN_Refe__E425C916BD51787C");

                entity.ToTable("CLN_ReferralSource");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Others)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Tv).HasColumnName("TV");
            });

            modelBuilder.Entity<ClnSocialHistory>(entity =>
            {
                entity.HasKey(e => e.SocialHistoryId)
                    .HasName("PK_PAT_SocialHistory");

                entity.ToTable("CLN_SocialHistory");

                entity.Property(e => e.AlcoholHistory)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DrugHistory)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FamilySupport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmokingHistory)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ClnSocialHistories)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_SocialHistory_PAT_Patient");
            });

            modelBuilder.Entity<ClnSurgicalHistory>(entity =>
            {
                entity.HasKey(e => e.SurgicalHistoryId)
                    .HasName("PK_PAT_SurgicalHistory");

                entity.ToTable("CLN_SurgicalHistory");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Icd10code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ICD10Code");

                entity.Property(e => e.Icd10description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ICD10Description");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SurgeryDate).HasColumnType("datetime");

                entity.Property(e => e.SurgeryType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Icd10codeNavigation)
                    .WithMany(p => p.ClnSurgicalHistories)
                    .HasPrincipalKey(p => p.Icd10code)
                    .HasForeignKey(d => d.Icd10code)
                    .HasConstraintName("FK_PAT_SurgicalHistory_MST_ICD10");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ClnSurgicalHistories)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_SurgicalHistory_PAT_Patient");
            });

            modelBuilder.Entity<ClnTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("PK__CLN_Temp__F87ADD270CED89DB");

                entity.ToTable("CLN_Template");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoreCfgLookUp>(entity =>
            {
                entity.HasKey(e => e.LookUpId);

                entity.ToTable("CORE_CFG_LookUps");

                entity.HasIndex(e => new { e.ModuleName, e.LookUpName }, "UK_CORE_CFG_LookUps_ModuleName_LookupName")
                    .IsUnique();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LookUpName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LookupDataJson)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoreCfgParameter>(entity =>
            {
                entity.HasKey(e => e.ParameterId)
                    .HasName("PK__CORE_CFG__F80C62774F81C7BF");

                entity.ToTable("CORE_CFG_Parameters");

                entity.HasIndex(e => new { e.ParameterGroupName, e.ParameterName }, "UK_Core_CFG_Parameters")
                    .IsUnique();

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterGroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterValue).HasMaxLength(4000);

                entity.Property(e => e.ValueDataType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoreDistributedCache>(entity =>
            {
                entity.ToTable("CORE_DistributedCache");

                entity.Property(e => e.Id).HasMaxLength(449);
            });

            modelBuilder.Entity<CoreDyntmpOption>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PK_CORE_DYNTMP_QtnOptionMap");

                entity.ToTable("CORE_DYNTMP_Option");

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.CoreDyntmpOptions)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_CORE_DYNTMP_Option_CORE_DYNTMP_Question");
            });

            modelBuilder.Entity<CoreDyntmpQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId)
                    .HasName("PK_CORE_DYNTMP_Question_1");

                entity.ToTable("CORE_DYNTMP_Question");

                entity.HasIndex(e => new { e.Text, e.ParentQtnId }, "IX_CORE_DYNTMP_Question")
                    .IsUnique();

                entity.Property(e => e.DisplaySeq).HasDefaultValueSql("((100))");

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Qnair)
                    .WithMany(p => p.CoreDyntmpQuestions)
                    .HasForeignKey(d => d.QnairId)
                    .HasConstraintName("FK_CORE_DYNTMP_Question_CORE_DYNTMP_Questionnaire");
            });

            modelBuilder.Entity<CoreDyntmpQuestionnaire>(entity =>
            {
                entity.HasKey(e => e.QnairId);

                entity.ToTable("CORE_DYNTMP_Questionnaire");

                entity.HasIndex(e => e.Text, "IX_CORE_DYNTMP_Questionnaire")
                    .IsUnique();

                entity.Property(e => e.DisplaySeq).HasDefaultValueSql("((100))");

                entity.Property(e => e.Text)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.CoreDyntmpQuestionnaires)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_CORE_DYNTMP_Questionnaire_CORE_DYNTMP_Template");
            });

            modelBuilder.Entity<CoreDyntmpTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("CORE_DYNTMP_Template");

                entity.HasIndex(e => e.Code, "IX_CORE_DYNTMP_Template")
                    .IsUnique();

                entity.Property(e => e.TemplateId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoreLookupDetail>(entity =>
            {
                entity.ToTable("CORE_LookupDetail");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoreNotification>(entity =>
            {
                entity.HasKey(e => e.NotificationId)
                    .HasName("PK_Notification");

                entity.ToTable("CORE_Notification");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsArchived).HasDefaultValueSql("((0))");

                entity.Property(e => e.NotificationDetails)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Notification_Details");

                entity.Property(e => e.NotificationModuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Notification_ModuleName");

                entity.Property(e => e.NotificationTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Notification_Title");

                entity.Property(e => e.ParentTableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubModuleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Sub_ModuleName");
            });

            modelBuilder.Entity<CssdTxnItemTransaction>(entity =>
            {
                entity.HasKey(e => e.CssdTxnId);

                entity.ToTable("CSSD_TXN_ItemTransaction");

                entity.Property(e => e.CreatedOn).HasPrecision(3);

                entity.Property(e => e.CssdStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisinfectantName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DisinfectedOn).HasPrecision(3);

                entity.Property(e => e.DisinfectionRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DispatchRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DispatchedOn).HasPrecision(3);

                entity.Property(e => e.RequestRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedOn).HasPrecision(3);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CssdTxnItemTransactionCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CSSD_TXN_ItemTransaction_CreatedBy_EMP_Emoloyee");

                entity.HasOne(d => d.DisinfectedByNavigation)
                    .WithMany(p => p.CssdTxnItemTransactionDisinfectedByNavigations)
                    .HasForeignKey(d => d.DisinfectedBy)
                    .HasConstraintName("FK_CSSD_TXN_ItemTransaction_DisinfectedBy_EMP_Emoloyee");

                entity.HasOne(d => d.DispatchedByNavigation)
                    .WithMany(p => p.CssdTxnItemTransactionDispatchedByNavigations)
                    .HasForeignKey(d => d.DispatchedBy)
                    .HasConstraintName("FK_CSSD_TXN_ItemTransaction_DispatchedBy_EMP_Emoloyee");

                entity.HasOne(d => d.FixedAssetStock)
                    .WithMany(p => p.CssdTxnItemTransactions)
                    .HasForeignKey(d => d.FixedAssetStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CSSD_TXN_ItemTransaction_INV_TXN_FixedAssetStock");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.CssdTxnItemTransactions)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CSSD_TXN_ItemTransaction_INV_MST_Item");

                entity.HasOne(d => d.RequestedByNavigation)
                    .WithMany(p => p.CssdTxnItemTransactionRequestedByNavigations)
                    .HasForeignKey(d => d.RequestedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CSSD_TXN_ItemTransaction_RequestedBy_EMP_Emoloyee");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.CssdTxnItemTransactions)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CSSD_TXN_ItemTransaction_PHRM_MST_Store");
            });

            modelBuilder.Entity<DanpheAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId);

                entity.ToTable("DanpheAudit");

                entity.Property(e => e.InsertedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DanpheLogInInformation>(entity =>
            {
                entity.HasKey(e => e.InformationId)
                    .HasName("PK_LogInInformationId");

                entity.ToTable("DanpheLogInInformation");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DocTxnVisitSummary>(entity =>
            {
                entity.HasKey(e => e.VisitSummaryId);

                entity.ToTable("DOC_TXN_VisitSummary");

                entity.Property(e => e.Answer).IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmpEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__EMP_Employee");

                entity.ToTable("EMP_Employee");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DateOfJoining).HasColumnType("datetime");

                entity.Property(e => e.DriverLicenseNo).HasMaxLength(40);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HealthProfessionalCertificationNo).HasMaxLength(40);

                entity.Property(e => e.ImageFullPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LabSignature).HasMaxLength(500);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LongSignature).HasMaxLength(1000);

                entity.Property(e => e.Lpno)
                    .HasMaxLength(50)
                    .HasColumnName("LPNo");

                entity.Property(e => e.MedCertificationNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NursingCertificationNo).HasMaxLength(40);

                entity.Property(e => e.OfficeHour)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pannumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PANNumber");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RadiologySignature).HasMaxLength(500);

                entity.Property(e => e.RoomNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SignatoryImageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Signature).HasMaxLength(1000);

                entity.Property(e => e.Tdspercent).HasColumnName("TDSPercent");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmpEmployees)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__EMP_Emplo__Depar__24285DB4");

                entity.HasOne(d => d.EmployeeRole)
                    .WithMany(p => p.EmpEmployees)
                    .HasForeignKey(d => d.EmployeeRoleId)
                    .HasConstraintName("FK_EMP_Employee_EMP_EmployeeRole");

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.EmpEmployees)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .HasConstraintName("FK_EMP_Employee_EMP_EmployeeType");
            });

            modelBuilder.Entity<EmpEmployeePreference>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMP_EmployeePreferences");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PreferenceId).ValueGeneratedOnAdd();

                entity.Property(e => e.PreferenceName).HasMaxLength(50);

                entity.Property(e => e.PreferenceValue).HasColumnType("xml");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("fk_EMP_EmployeePreferences_EMP_EmployeeTable");

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMP_EmployeePreferences_EMP_Employee");
            });

            modelBuilder.Entity<EmpEmployeeRole>(entity =>
            {
                entity.HasKey(e => e.EmployeeRoleId);

                entity.ToTable("EMP_EmployeeRole");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeRoleName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmpEmployeeType>(entity =>
            {
                entity.HasKey(e => e.EmployeeTypeId);

                entity.ToTable("EMP_EmployeeType");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeTypeName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeInfoModel>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK_dbo.EmployeeInfoModels");
            });

            modelBuilder.Entity<EngNepaliDateMapped>(entity =>
            {
                entity.HasKey(e => e.DateMapNum)
                    .HasName("DateMapNumber");

                entity.ToTable("EngNepaliDateMapped");
            });

            modelBuilder.Entity<ErDischargeSummary>(entity =>
            {
                entity.ToTable("ER_DischargeSummary");

                entity.Property(e => e.ErdischargeSummaryId).HasColumnName("ERDischargeSummaryId");

                entity.Property(e => e.AdviceOnDischarge).IsUnicode(false);

                entity.Property(e => e.ChiefComplaints).IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DischargeType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Investigations)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalOfficer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OnExamination).IsUnicode(false);

                entity.Property(e => e.ProvisionalDiagnosis)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentInEr)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentInER");
            });

            modelBuilder.Entity<ErFileUpload>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_ER_FileId");

                entity.ToTable("ER_FileUploads");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ErpatientId).HasColumnName("ERPatientId");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Erpatient)
                    .WithMany(p => p.ErFileUploads)
                    .HasForeignKey(d => d.ErpatientId)
                    .HasConstraintName("FK_ER_File_ER_Patient");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ErFileUploads)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_ER_File_PAT_Patient");
            });

            modelBuilder.Entity<ErModeOfArrival>(entity =>
            {
                entity.HasKey(e => e.ModeOfArrivalId)
                    .HasName("PK_ModeOfArrival");

                entity.ToTable("ER_ModeOfArrival");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModeOfArrivalName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ErPatient>(entity =>
            {
                entity.ToTable("ER_Patient");

                entity.Property(e => e.ErpatientId).HasColumnName("ERPatientId");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Age)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CareOfPerson)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CareOfPersonContactNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Case)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionOnArrival)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.ErdischargeSummaryId).HasColumnName("ERDischargeSummaryId");

                entity.Property(e => e.ErpatientNumber).HasColumnName("ERPatientNumber");

                entity.Property(e => e.Erstatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ERStatus");

                entity.Property(e => e.FinalizedOn).HasColumnType("datetime");

                entity.Property(e => e.FinalizedRemarks)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.FinalizedStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OldPatientId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReferredTo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TriageCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TriagedOn).HasColumnType("datetime");

                entity.Property(e => e.VisitDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.ModeOfArrivalNavigation)
                    .WithMany(p => p.ErPatients)
                    .HasForeignKey(d => d.ModeOfArrival)
                    .HasConstraintName("FK_ER_Pat_ModeOfArrival");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ErPatients)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_ER_PATIENT_PAT_PATIENT");

                entity.HasOne(d => d.PatientVisit)
                    .WithMany(p => p.ErPatients)
                    .HasForeignKey(d => d.PatientVisitId)
                    .HasConstraintName("FK_ER_PATIENTVISIT_PAT_PATIENTVISIT");
            });

            modelBuilder.Entity<ErPatientCase>(entity =>
            {
                entity.HasKey(e => e.PatientCaseId)
                    .HasName("PK_ERPatient_Case");

                entity.ToTable("ER_Patient_Cases");

                entity.Property(e => e.BitingAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BitingAnimalName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BitingAnimalOthers)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BitingSiteOthers)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateTimeOfBite).HasColumnType("datetime");

                entity.Property(e => e.ErpatientId).HasColumnName("ERPatientId");

                entity.Property(e => e.FirstAidOthers)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OtherCaseDetails)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Erpatient)
                    .WithMany(p => p.ErPatientCases)
                    .HasForeignKey(d => d.ErpatientId)
                    .HasConstraintName("FK_Case_ERPatient");
            });

            modelBuilder.Entity<FrcDesignation>(entity =>
            {
                entity.HasKey(e => e.DesignationId)
                    .HasName("PK__FRC_Desi__BABD60DE18691DD7");

                entity.ToTable("FRC_Designation");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DesignationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrcFractionCalculation>(entity =>
            {
                entity.HasKey(e => e.FractionCalculationId)
                    .HasName("PK__FRC_Frac__6B6A1FBE62C69167");

                entity.ToTable("FRC_FractionCalculation");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FinalAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FinalPercent).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.InitialPercent).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BillTxnItem)
                    .WithMany(p => p.FrcFractionCalculations)
                    .HasForeignKey(d => d.BillTxnItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FRC_Fract__BillT__76226739");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.FrcFractionCalculations)
                    .HasForeignKey(d => d.DesignationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FRC_Fract__Desig__77168B72");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.FrcFractionCalculations)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FRC_Fract__Docto__780AAFAB");

                entity.HasOne(d => d.PercentSetting)
                    .WithMany(p => p.FrcFractionCalculations)
                    .HasForeignKey(d => d.PercentSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FRC_Fract__Perce__78FED3E4");
            });

            modelBuilder.Entity<FrcPercentSetting>(entity =>
            {
                entity.HasKey(e => e.PercentSettingId)
                    .HasName("PK__FRC_Perc__E6FB66E850F9BFA6");

                entity.ToTable("FRC_PercentSetting");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DoctorPercent).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.HospitalPercent).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.BillItemPrice)
                    .WithMany(p => p.FrcPercentSettings)
                    .HasForeignKey(d => d.BillItemPriceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FRC_Perce__BillI__7251D655");
            });

            modelBuilder.Entity<GovtInsuranceItem>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DepartmentName).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.IntegrationName).HasMaxLength(255);

                entity.Property(e => e.ItemName).HasMaxLength(255);

                entity.Property(e => e.ServiceDepartmentName).HasMaxLength(255);
            });

            modelBuilder.Entity<IcdDiseaseGroup>(entity =>
            {
                entity.HasKey(e => e.DiseaseGroupId)
                    .HasName("PK__ICD_Dise__1AFF73796E00509D");

                entity.ToTable("ICD_DiseaseGroup");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiseaseGroupName)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Icdcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ICDCode");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.IcdDiseaseGroups)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ICD_Disea__Creat__2BD6CE79");

                entity.HasOne(d => d.ReportingGroup)
                    .WithMany(p => p.IcdDiseaseGroups)
                    .HasForeignKey(d => d.ReportingGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ICD_Disea__Repor__2AE2AA40");
            });

            modelBuilder.Entity<IcdReportingGroup>(entity =>
            {
                entity.HasKey(e => e.ReportingGroupId)
                    .HasName("PK__ICD_Repo__F2B73E8E726288B2");

                entity.ToTable("ICD_ReportingGroup");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.GroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReportingGroupName)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.IcdReportingGroups)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ICD_Repor__Creat__28063D95");
            });

            modelBuilder.Entity<InctvBillItemsProfileMap>(entity =>
            {
                entity.HasKey(e => e.BillItemProfileMapId);

                entity.ToTable("INCTV_BillItems_Profile_Map");

                entity.Property(e => e.BillingTypesApplicable)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.BillItemPrice)
                    .WithMany(p => p.InctvBillItemsProfileMaps)
                    .HasForeignKey(d => d.BillItemPriceId)
                    .HasConstraintName("FK_INCTV_BillItems_Profile_Map_BIL_CFG_BillItemPrice");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.InctvBillItemsProfileMaps)
                    .HasForeignKey(d => d.ProfileId)
                    .HasConstraintName("FK_INCTV_BillItems_Profile_Map_INCTV_MST_Profile");
            });

            modelBuilder.Entity<InctvCfgItemGroupDistribution>(entity =>
            {
                entity.HasKey(e => e.ItemGroupDistributionId);

                entity.ToTable("INCTV_CFG_ItemGroupDistribution");

                entity.HasIndex(e => new { e.BillItemPriceId, e.EmployeeBillItemsMapId, e.DistributeToEmployeeId }, "UK_INCTV_ItemGroupDistribution")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IncentiveType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InctvCfgItemGroupDistributions)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INCTV_CFG_ItemGroupDistribution_EMP_EMployee");

                entity.HasOne(d => d.EmployeeBillItemsMap)
                    .WithMany(p => p.InctvCfgItemGroupDistributions)
                    .HasForeignKey(d => d.EmployeeBillItemsMapId)
                    .HasConstraintName("FK_INCTV_CFG_ItemGroupDistribution_INCTV_MAP_EmployeeBillItemsMap");
            });

            modelBuilder.Entity<InctvEmployeeIncentiveInfo>(entity =>
            {
                entity.HasKey(e => e.EmployeeIncentiveInfoId);

                entity.ToTable("INCTV_EmployeeIncentiveInfo");

                entity.HasIndex(e => e.EmployeeId, "UK_INCTV_EmployeeIncentiveInfo_EmployeeId")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Tdspercent).HasColumnName("TDSPercent");
            });

            modelBuilder.Entity<InctvMapEmployeeBillItemsMap>(entity =>
            {
                entity.HasKey(e => e.EmployeeBillItemsMapId);

                entity.ToTable("INCTV_MAP_EmployeeBillItemsMap");

                entity.Property(e => e.BillingTypesApplicable)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.BillItemPrice)
                    .WithMany(p => p.InctvMapEmployeeBillItemsMaps)
                    .HasForeignKey(d => d.BillItemPriceId)
                    .HasConstraintName("FK_INCTV_BillItems_Employee_Map_BIL_CFG_BillItemPrice");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.InctvMapEmployeeBillItemsMaps)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_INCTV_BillItems_Employee_Map_EMP_EMployee");
            });

            modelBuilder.Entity<InctvMstProfile>(entity =>
            {
                entity.HasKey(e => e.ProfileId);

                entity.ToTable("INCTV_MST_Profile");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ProfileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Tdspercentage)
                    .HasColumnName("TDSPercentage")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.PriceCategory)
                    .WithMany(p => p.InctvMstProfiles)
                    .HasForeignKey(d => d.PriceCategoryId)
                    .HasConstraintName("FK_INCTV_MST_Profile_INCTV_MST_PriceCategory");
            });

            modelBuilder.Entity<InctvTxnIncentiveFractionItem>(entity =>
            {
                entity.HasKey(e => e.InctvTxnItemId)
                    .HasName("PK_INCTV_TXN_IncentiveFractionItems");

                entity.ToTable("INCTV_TXN_IncentiveFractionItem");

                entity.HasIndex(e => e.BillingTransactionItemId, "IX_INCTV_TXN_IncentiveFractionItem_BillingTransactionItemId");

                entity.HasIndex(e => e.IncentiveReceiverId, "IX_INCTV_TXN_IncentiveFractionItem_IncentiveReceiverId");

                entity.HasIndex(e => new { e.BillingTransactionItemId, e.IncentiveReceiverId, e.IncentiveType, e.IsReturnTxn }, "UK_IncentiveFractionItems")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IncentiveReceiverName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IncentiveType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNoFormatted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsReturnTxn).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PriceCategory)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tdsamount).HasColumnName("TDSAmount");

                entity.Property(e => e.Tdspercentage).HasColumnName("TDSPercentage");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<InctvTxnPaymentInfo>(entity =>
            {
                entity.HasKey(e => e.PaymentInfoId)
                    .HasName("PK__INCTV_TX__8902EF8FDF6790B3");

                entity.ToTable("INCTV_TXN_PaymentInfo");

                entity.Property(e => e.AccountingPostedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.Tdsamount).HasColumnName("TDSAmount");

                entity.Property(e => e.VoucherNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<InsCfgInsuranceProvider>(entity =>
            {
                entity.HasKey(e => e.InsuranceProviderId);

                entity.ToTable("INS_CFG_InsuranceProviders");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceProviderName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<InsInsuranceBalanceAmountHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("PK_INS_InsuranceBalanceAmounHistory");

                entity.ToTable("INS_InsuranceBalanceAmount_History");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.PreviousAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InsInsuranceBalanceAmountHistories)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INS_InsuranceBalanceAmounHistory_EMP_Employee");
            });

            modelBuilder.Entity<InsTxnPatientInsurancePackage>(entity =>
            {
                entity.HasKey(e => e.PatientInsurancePackageId);

                entity.ToTable("INS_TXN_PatientInsurancePackages");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCompleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<InvAssetConditionCheckList>(entity =>
            {
                entity.HasKey(e => e.AssetConditionCheckListId)
                    .HasName("PK__INV_Asse__D1F1450F064782DC");

                entity.ToTable("INV_AssetConditionCheckList");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvAssetConditionCheckListCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__INV_Asset__Creat__75AFC7F2");

                entity.HasOne(d => d.FixedAssetStock)
                    .WithMany(p => p.InvAssetConditionCheckLists)
                    .HasForeignKey(d => d.FixedAssetStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INV_Asset__Fixed__74BBA3B9");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InvAssetConditionCheckListModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__INV_Asset__Modif__76A3EC2B");
            });

            modelBuilder.Entity<InvAssetContractFileInfo>(entity =>
            {
                entity.HasKey(e => e.AssetContractId)
                    .HasName("PK__INV_Asse__68A9D4847FF90D86");

                entity.ToTable("INV_AssetContractFileInfo");

                entity.Property(e => e.ContractFileName).HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FileExtention).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvAssetContractFileInfoCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__INV_Asset__Creat__6C265DB8");

                entity.HasOne(d => d.FixedAssetStock)
                    .WithMany(p => p.InvAssetContractFileInfos)
                    .HasForeignKey(d => d.FixedAssetStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INV_Asset__Fixed__6B32397F");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InvAssetContractFileInfoModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__INV_Asset__Modif__6D1A81F1");
            });

            modelBuilder.Entity<InvAssetFaultHistory>(entity =>
            {
                entity.HasKey(e => e.FaultHistoryId)
                    .HasName("PK__INV_Asse__79589083047070E1");

                entity.ToTable("INV_AssetFaultHistory");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FaultDate).HasColumnType("datetime");

                entity.Property(e => e.FaultDescription).HasMaxLength(500);

                entity.Property(e => e.FaultResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.FaultResolvedRemarks).HasMaxLength(500);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvAssetFaultHistoryCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__INV_Asset__Creat__7A747D0F");

                entity.HasOne(d => d.FixedAssetStock)
                    .WithMany(p => p.InvAssetFaultHistories)
                    .HasForeignKey(d => d.FixedAssetStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INV_Asset__Fixed__798058D6");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InvAssetFaultHistoryModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__INV_Asset__Modif__7B68A148");
            });

            modelBuilder.Entity<InvAssetInsurance>(entity =>
            {
                entity.HasKey(e => e.AssetInsurannceId)
                    .HasName("PK__INV_Asse__E173C4F6CA800365");

                entity.ToTable("INV_AssetInsurance");

                entity.Property(e => e.ComprehensiveInsurance).HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.InsuranceEndDate).HasColumnType("datetime");

                entity.Property(e => e.InsuranceStartDate).HasColumnType("datetime");

                entity.Property(e => e.InsuredValue).HasMaxLength(250);

                entity.Property(e => e.Insurer).HasMaxLength(250);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PolicyNumber).HasMaxLength(250);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvAssetInsuranceCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__INV_Asset__Creat__70EB12D5");

                entity.HasOne(d => d.FixedAssetStock)
                    .WithMany(p => p.InvAssetInsurances)
                    .HasForeignKey(d => d.FixedAssetStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INV_Asset__Fixed__6FF6EE9C");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InvAssetInsuranceModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__INV_Asset__Modif__71DF370E");
            });

            modelBuilder.Entity<InvAssetLocationHistory>(entity =>
            {
                entity.HasKey(e => e.AssetsLocationHistoryId)
                    .HasName("PK__INV_Asse__7D6C1B931B26A45D");

                entity.ToTable("INV_AssetLocationHistory");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.OldLocation).HasMaxLength(250);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvAssetLocationHistories)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INV_Asset__Creat__6855CCD4");

                entity.HasOne(d => d.FixedAssetStock)
                    .WithMany(p => p.InvAssetLocationHistories)
                    .HasForeignKey(d => d.FixedAssetStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INV_Asset__Fixed__6761A89B");
            });

            modelBuilder.Entity<InvAssetServiceHistory>(entity =>
            {
                entity.HasKey(e => e.AssetServiceId)
                    .HasName("PK__INV_Asse__1ED44CCF4AA9C78B");

                entity.ToTable("INV_AssetServiceHistory");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ServiceCompleteDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceCompleteRemarks).HasMaxLength(4000);

                entity.Property(e => e.ServiceDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceRemarks).HasMaxLength(4000);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvAssetServiceHistoryCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__INV_Asset__Creat__0F6F99F5");

                entity.HasOne(d => d.FixedAssetStock)
                    .WithMany(p => p.InvAssetServiceHistories)
                    .HasForeignKey(d => d.FixedAssetStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INV_Asset__Fixed__0E7B75BC");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InvAssetServiceHistoryModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__INV_Asset__Modif__1063BE2E");
            });

            modelBuilder.Entity<InvCfgFiscalYear>(entity =>
            {
                entity.HasKey(e => e.FiscalYearId)
                    .HasName("PK_INV_CFG_FiscalYear");

                entity.ToTable("INV_CFG_FiscalYears");

                entity.HasIndex(e => e.FiscalYearName, "UK_INV_CFG_FiscalYear")
                    .IsUnique();

                entity.Property(e => e.ClosedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FiscalYearName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NpFiscalYearName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<InvFiscalYearStock>(entity =>
            {
                entity.HasKey(e => e.FiscalYrStockId);

                entity.ToTable("INV_FiscalYearStock");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.GritemId).HasColumnName("GRItemId");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Price).HasColumnType("decimal(16, 4)");

                entity.HasOne(d => d.FiscalYear)
                    .WithMany(p => p.InvFiscalYearStocks)
                    .HasForeignKey(d => d.FiscalYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_FiscalYearStock_INV_CFG_FiscalYear");
            });

            modelBuilder.Entity<InvMstAccountHead>(entity =>
            {
                entity.HasKey(e => e.AccountHeadId)
                    .HasName("PK__INV_MST___0F830A99C8453823");

                entity.ToTable("INV_MST_AccountHead");

                entity.Property(e => e.AccountHeadName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvMstAccountHeads)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_MST_ItemUsage_Emp_Employee");
            });

            modelBuilder.Entity<InvMstAssetCategory>(entity =>
            {
                entity.HasKey(e => e.AssetCategoryId)
                    .HasName("PK__INV_MST___C381F47D4BB89420");

                entity.ToTable("INV_MST_AssetCategory");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvMstAssetCategoryCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__INV_MST_A__Creat__05E62FBB");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InvMstAssetCategoryModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__INV_MST_A__Modif__06DA53F4");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.InvMstAssetCategories)
                    .HasForeignKey(d => d.SubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INV_MST_A__SubCa__04F20B82");
            });

            modelBuilder.Entity<InvMstAssetDepreciationMethod>(entity =>
            {
                entity.HasKey(e => e.AssetDeprnMethodId)
                    .HasName("PK__INV_MST___EF0785309B3FA00D");

                entity.ToTable("INV_MST_AssetDepreciationMethod");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Method).HasMaxLength(250);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvMstAssetDepreciationMethods)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__INV_MST_A__Creat__09B6C09F");
            });

            modelBuilder.Entity<InvMstAssetLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK__INV_MST___E7FEA497A3E06206");

                entity.ToTable("INV_MST_AssetLocation");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LocationDetails).HasMaxLength(500);

                entity.Property(e => e.LocationName).HasMaxLength(500);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber).HasMaxLength(500);
            });

            modelBuilder.Entity<InvMstCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("INV_MST_Company");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddress).HasMaxLength(200);

                entity.Property(e => e.ContactNo).HasMaxLength(20);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvMstCompanies)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_INV_MST_Company_CreatedBy_EMP_Employee_EmployeeId");
            });

            modelBuilder.Entity<InvMstCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyId)
                    .HasName("PK__INV_MST___14470B10764F9E3E");

                entity.ToTable("INV_MST_Currency");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvMstDonation>(entity =>
            {
                entity.HasKey(e => e.DonationId)
                    .HasName("PK__INV_MST___C5082EFB85F79850");

                entity.ToTable("INV_MST_Donation");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Donation).HasMaxLength(500);

                entity.Property(e => e.DonationDetails).HasMaxLength(500);

                entity.Property(e => e.DonationPersonName).HasMaxLength(500);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber).HasMaxLength(500);
            });

            modelBuilder.Entity<InvMstItem>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__INV_MST___727E838B6E2F4BD2");

                entity.ToTable("INV_MST_Item");

                entity.HasIndex(e => new { e.ItemName, e.ItemCategoryId }, "UQ_INV_MST_Item_ItemName_ItemCategoryId")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Hsncode)
                    .HasMaxLength(500)
                    .HasColumnName("HSNCODE");

                entity.Property(e => e.IsVatapplicable).HasColumnName("IsVATApplicable");

                entity.Property(e => e.ItemName).HasMaxLength(200);

                entity.Property(e => e.ItemType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Mssno)
                    .HasMaxLength(500)
                    .HasColumnName("MSSNO");

                entity.Property(e => e.StandardRate).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VAT");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvMstItems)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_MST_Item_Emp_Employee");

                entity.HasOne(d => d.ItemCategory)
                    .WithMany(p => p.InvMstItems)
                    .HasForeignKey(d => d.ItemCategoryId)
                    .HasConstraintName("FK_INV_MST_Item_INV_MST_ItemCategory");

                entity.HasOne(d => d.MaintenanceOwnerRole)
                    .WithMany(p => p.InvMstItems)
                    .HasForeignKey(d => d.MaintenanceOwnerRoleId)
                    .HasConstraintName("FK_INV_MST_Item_MaintenanceOwnerRoleId_RBAC_Role");

                entity.HasOne(d => d.PackagingType)
                    .WithMany(p => p.InvMstItems)
                    .HasForeignKey(d => d.PackagingTypeId)
                    .HasConstraintName("FK_INV_MST_Item_INV_MST_PackagingType");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.InvMstItems)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_INV_MST_Item_PHRM_MST_Store");

                entity.HasOne(d => d.UnitOfMeasurement)
                    .WithMany(p => p.InvMstItems)
                    .HasForeignKey(d => d.UnitOfMeasurementId)
                    .HasConstraintName("FK_INV_MST_Item_INV_MST_UOM");
            });

            modelBuilder.Entity<InvMstItemCategory>(entity =>
            {
                entity.HasKey(e => e.ItemCategoryId)
                    .HasName("PK__INV_MST___C24A292573CF2B36");

                entity.ToTable("INV_MST_ItemCategory");

                entity.Property(e => e.CategoryCode).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvMstItemCategories)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_MST_ItemCategory_Emp_Employee");
            });

            modelBuilder.Entity<InvMstItemSubCategory>(entity =>
            {
                entity.HasKey(e => e.SubCategoryId)
                    .HasName("PK__INV_MST___26BE5B1903CE00B5");

                entity.ToTable("INV_MST_ItemSubCategory");

                entity.HasIndex(e => e.Code, "UQ__INV_MST___A25C5AA7DC94E5D2")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubCategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvMstPackagingType>(entity =>
            {
                entity.HasKey(e => e.PackagingTypeId)
                    .HasName("PK__INV_MST___00C89861E2537739");

                entity.ToTable("INV_MST_PackagingType");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PackagingTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvMstPackagingTypes)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_MST_PackagingType_Emp_Employee");
            });

            modelBuilder.Entity<InvMstStock>(entity =>
            {
                entity.HasKey(e => e.StockId);

                entity.ToTable("INV_MST_Stock");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedOn).HasPrecision(3);

                entity.Property(e => e.ExpiryDate).HasPrecision(3);

                entity.Property(e => e.ModifiedOn).HasPrecision(3);

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Specification).HasMaxLength(500);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvMstStockCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvMstStocks)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_MST_Stock_INV_MST_Item");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InvMstStockModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<InvMstTerm>(entity =>
            {
                entity.HasKey(e => e.TermsId);

                entity.ToTable("INV_MST_Terms");

                entity.Property(e => e.TermsId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Terms)
                    .WithOne(p => p.InvMstTerm)
                    .HasForeignKey<InvMstTerm>(d => d.TermsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_MST_Terms_EMP_Employee");
            });

            modelBuilder.Entity<InvMstUnitOfMeasurement>(entity =>
            {
                entity.HasKey(e => e.Uomid);

                entity.ToTable("INV_MST_UnitOfMeasurement");

                entity.Property(e => e.Uomid).HasColumnName("UOMId");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Uomname)
                    .HasMaxLength(50)
                    .HasColumnName("UOMName");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvMstUnitOfMeasurements)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_MST_UnitOfMeasurement_Emp_Employee");
            });

            modelBuilder.Entity<InvMstVendor>(entity =>
            {
                entity.HasKey(e => e.VendorId)
                    .HasName("PK_Mst_SupplierMaster");

                entity.ToTable("INV_MST_Vendor");

                entity.Property(e => e.CompanyPosition)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPosition2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddress).HasMaxLength(200);

                entity.Property(e => e.ContactNo).HasMaxLength(20);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DefaultItemJson)
                    .IsUnicode(false)
                    .HasColumnName("DefaultItemJSON");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.GovtRegDate).HasColumnType("date");

                entity.Property(e => e.IsTdsapplicable).HasColumnName("IsTDSApplicable");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PanNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sarfno)
                    .HasMaxLength(200)
                    .HasColumnName("SARFNo");

                entity.Property(e => e.VendorCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName).HasMaxLength(400);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvMstVendors)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_MST_Vendor_Emp_Employee");

                entity.HasOne(d => d.DefaultCurrency)
                    .WithMany(p => p.InvMstVendors)
                    .HasForeignKey(d => d.DefaultCurrencyId)
                    .HasConstraintName("FK_INV_MST_Vendor_INV_MST_Currency");
            });

            modelBuilder.Entity<InvQuotation>(entity =>
            {
                entity.HasKey(e => e.QuotationId)
                    .HasName("PK_INV_QuotationItems");

                entity.ToTable("INV_Quotation");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IssuedDate).HasPrecision(3);

                entity.Property(e => e.RfqgroupId).HasColumnName("RFQGroupId");

                entity.Property(e => e.Status).HasMaxLength(150);

                entity.Property(e => e.VendorName).HasMaxLength(150);
            });

            modelBuilder.Entity<InvQuotationItem>(entity =>
            {
                entity.HasKey(e => e.QuotationItemId)
                    .HasName("PK_INV_RequestForQuotation_1");

                entity.ToTable("INV_QuotationItems");

                entity.Property(e => e.ItemName).HasMaxLength(150);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.UpLoadedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<InvQuotationUploadedFile>(entity =>
            {
                entity.HasKey(e => e.QuotationUploadedFileId);

                entity.ToTable("INV_QuotationUploadedFiles");

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.FileExtention).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(300);

                entity.Property(e => e.FileType).HasMaxLength(300);

                entity.Property(e => e.Rowguid).HasColumnName("ROWGUID");

                entity.Property(e => e.UpLoadedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<InvRequestForQuotation>(entity =>
            {
                entity.HasKey(e => e.ReqForQuotationId);

                entity.ToTable("INV_RequestForQuotation");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.RequestedBy).HasMaxLength(50);

                entity.Property(e => e.RequestedCloseOn).HasColumnType("datetime");

                entity.Property(e => e.RequestedOn).HasColumnType("datetime");

                entity.Property(e => e.RfqgroupId).HasColumnName("RFQGroupId");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.InvRequestForQuotations)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INV_Reque__Store__161C9784");
            });

            modelBuilder.Entity<InvRequestForQuotationItem>(entity =>
            {
                entity.HasKey(e => e.ReqForQuotationItemId);

                entity.ToTable("INV_RequestForQuotationItems");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ItemName).HasMaxLength(300);
            });

            modelBuilder.Entity<InvRequestForQuotationVendor>(entity =>
            {
                entity.HasKey(e => e.ReqForQuotationVendorId)
                    .HasName("PK__INV_Requ__23A16A4341F17EC3");

                entity.ToTable("INV_RequestForQuotationVendors");

                entity.Property(e => e.CreatedOn).HasPrecision(3);

                entity.HasOne(d => d.ReqForQuotation)
                    .WithMany(p => p.InvRequestForQuotationVendors)
                    .HasForeignKey(d => d.ReqForQuotationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_RequestForQuotationVendors_INV_RequestForQuotation");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.InvRequestForQuotationVendors)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_RequestForQuotationVendors_INV_MST_Vendor");
            });

            modelBuilder.Entity<InvTempItemPriceWithVat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INV_Temp_ItemPriceWithVAT");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Vatamount).HasColumnName("VATAmount");

                entity.Property(e => e.Vatpercent).HasColumnName("VATPercent");
            });

            modelBuilder.Entity<InvTempStockMigrationCmh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INV_Temp_Stock_Migration_CMH");

                entity.Property(e => e.AccountHead).HasMaxLength(100);

                entity.Property(e => e.Category).HasMaxLength(200);

                entity.Property(e => e.ItemName).HasMaxLength(200);

                entity.Property(e => e.PackagingTypeName).HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("decimal(13, 3)");
            });

            modelBuilder.Entity<InvTempTxnNewStockTxn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INV_TEMP_TXN_NewStockTxn");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.InOut)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsTransferredToAcc).HasColumnName("IsTransferredToACC");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Price).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.StockTxnId).ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvTxnAssetDepreciation>(entity =>
            {
                entity.HasKey(e => e.AssetDepreciationId)
                    .HasName("PK__INV_TXN___B5910C4D6B57631C");

                entity.ToTable("INV_TXN_AssetDepreciation");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DepreciationAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvTxnAssetDepreciationCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__INV_TXN_A__Creat__01217A9E");

                entity.HasOne(d => d.FixedAssetStock)
                    .WithMany(p => p.InvTxnAssetDepreciations)
                    .HasForeignKey(d => d.FixedAssetStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INV_TXN_A__Fixed__002D5665");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InvTxnAssetDepreciationModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__INV_TXN_A__Modif__02159ED7");
            });

            modelBuilder.Entity<InvTxnDispatchItem>(entity =>
            {
                entity.HasKey(e => e.DispatchItemsId)
                    .HasName("PK__INV_TXN___77C34E51414551A7");

                entity.ToTable("INV_TXN_DispatchItems");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DispatchedDate).HasPrecision(3);

                entity.Property(e => e.ItemRemarks).HasMaxLength(500);

                entity.Property(e => e.MatIssueDate).HasColumnType("datetime");

                entity.Property(e => e.MatIssueTo).HasMaxLength(200);

                entity.Property(e => e.ReceivedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedOn).HasColumnType("datetime");

                entity.Property(e => e.ReceivedRemarks).HasMaxLength(500);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.StoreId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.RequisitionItem)
                    .WithMany(p => p.InvTxnDispatchItems)
                    .HasForeignKey(d => d.RequisitionItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_TXN_DispatchItems_INV_TXN_RequisitionItems");

                entity.HasOne(d => d.SourceStore)
                    .WithMany(p => p.InvTxnDispatchItemSourceStores)
                    .HasForeignKey(d => d.SourceStoreId)
                    .HasConstraintName("FK_INV_TXN_DispatchItems_SourceStoreId_PHRM_MST_Store");

                entity.HasOne(d => d.TargetStore)
                    .WithMany(p => p.InvTxnDispatchItemTargetStores)
                    .HasForeignKey(d => d.TargetStoreId)
                    .HasConstraintName("FK_INV_TXN_DispatchItems_TargetStoreId_PHRM_MST_Store");
            });

            modelBuilder.Entity<InvTxnFixedAssetDispatch>(entity =>
            {
                entity.HasKey(e => e.DispatchId);

                entity.ToTable("INV_TXN_FixedAssetDispatch");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ReceivedBy)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");
            });

            modelBuilder.Entity<InvTxnFixedAssetDispatchItem>(entity =>
            {
                entity.HasKey(e => e.DispatchItemId);

                entity.ToTable("INV_TXN_FixedAssetDispatchItems");

                entity.Property(e => e.BarCodeNumber).HasMaxLength(255);

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ItemName).HasMaxLength(200);

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");
            });

            modelBuilder.Entity<InvTxnFixedAssetRequisition>(entity =>
            {
                entity.HasKey(e => e.RequisitionId);

                entity.ToTable("INV_TXN_FixedAssetRequisition");

                entity.Property(e => e.CancelRemarks).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsCancel).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.RequisitionDate).HasColumnType("datetime");

                entity.Property(e => e.RequisitionStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvTxnFixedAssetRequisitions)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_TXN_FixedAssetRequisition_Emp_Employee");
            });

            modelBuilder.Entity<InvTxnFixedAssetRequisitionItem>(entity =>
            {
                entity.HasKey(e => e.RequisitionItemId);

                entity.ToTable("INV_TXN_FixedAssetRequisitionItems");

                entity.Property(e => e.CancelOn).HasColumnType("datetime");

                entity.Property(e => e.CancelRemarks).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.RequisitionItemStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvTxnFixedAssetRequisitionItems)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_TXN_FixedAssetRequisitionItems_Emp_Employee");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvTxnFixedAssetRequisitionItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_INV_TXN_FixedAssetRequisitionItems_INV_MST_Item");

                entity.HasOne(d => d.Requisition)
                    .WithMany(p => p.InvTxnFixedAssetRequisitionItems)
                    .HasForeignKey(d => d.RequisitionId)
                    .HasConstraintName("FK_INV_TXN_FixedAssetRequisitionItems_FixedAssetRequisition_ID");
            });

            modelBuilder.Entity<InvTxnFixedAssetReturn>(entity =>
            {
                entity.HasKey(e => e.ReturnId);

                entity.ToTable("INV_TXN_FixedAssetReturn");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvTxnFixedAssetReturns)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_TXN_FixedAssetReturn_CreatedBy_EMP_Employee_EmployeeId");
            });

            modelBuilder.Entity<InvTxnFixedAssetReturnItem>(entity =>
            {
                entity.HasKey(e => e.ReturnItemId);

                entity.ToTable("INV_TXN_FixedAssetReturnItems");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvTxnFixedAssetReturnItems)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_TXN_FixedAssetReturnItems_Emp_Employee");

                entity.HasOne(d => d.FixedAssetStock)
                    .WithMany(p => p.InvTxnFixedAssetReturnItems)
                    .HasForeignKey(d => d.FixedAssetStockId)
                    .HasConstraintName("Fk_INV_TXN_FixedAssetReturnItems_INV_TXN_FixedAssetStock");

                entity.HasOne(d => d.Return)
                    .WithMany(p => p.InvTxnFixedAssetReturnItems)
                    .HasForeignKey(d => d.ReturnId)
                    .HasConstraintName("Fk_INV_TXN_FixedAssetReturnItems_INV_TXN_FixedAssetReturn");
            });

            modelBuilder.Entity<InvTxnFixedAssetStock>(entity =>
            {
                entity.HasKey(e => e.FixedAssetStockId)
                    .HasName("PK__INV_TXN___FFEB34927A5BF5F2");

                entity.ToTable("INV_TXN_FixedAssetStock");

                entity.Property(e => e.AssetsLocation).HasMaxLength(250);

                entity.Property(e => e.BarCodeNumber).HasMaxLength(250);

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuildingBlockNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.CcAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CcCharge).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CssdStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DamagedRemarks).HasMaxLength(500);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Floors)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InstallationDate).HasColumnType("datetime");

                entity.Property(e => e.ItemRate).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.ManufactureDate).HasColumnType("datetime");

                entity.Property(e => e.ModelNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.OtherCharge).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Performance).HasMaxLength(250);

                entity.Property(e => e.RoomNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RoomPosition)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ScrapCancelRemarks).HasMaxLength(2000);

                entity.Property(e => e.ScrapRemarks).HasMaxLength(2000);

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StockSpecification).HasMaxLength(500);

                entity.Property(e => e.UndamagedRemarks).HasMaxLength(500);

                entity.Property(e => e.Vat).HasColumnName("VAT");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VATAmount");

                entity.Property(e => e.WarrantyExpiryDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvTxnFixedAssetStocks)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INV_TXN_F__Creat__629CF37E");

                entity.HasOne(d => d.GoodsReceiptItem)
                    .WithMany(p => p.InvTxnFixedAssetStocks)
                    .HasForeignKey(d => d.GoodsReceiptItemId)
                    .HasConstraintName("FK__INV_TXN_F__Goods__64853BF0");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvTxnFixedAssetStocks)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INV_TXN_F__ItemI__639117B7");
            });

            modelBuilder.Entity<InvTxnGoodsReceipt>(entity =>
            {
                entity.HasKey(e => e.GoodsReceiptId)
                    .HasName("PK__INV_Good__F8D12B8CD465E120");

                entity.ToTable("INV_TXN_GoodsReceipt");

                entity.Property(e => e.GoodsReceiptId).HasColumnName("GoodsReceiptID");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CancelRemarks).HasMaxLength(1000);

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.CarriageFreightCharge).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.CcCharge).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GoodsArrivalDate).HasColumnType("datetime");

                entity.Property(e => e.GoodsReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.GoodsReceiptNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Grcategory)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GRCategory");

                entity.Property(e => e.GrgroupId).HasColumnName("GRGroupId");

                entity.Property(e => e.Grstatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GRStatus");

                entity.Property(e => e.Imirdate)
                    .HasColumnType("datetime")
                    .HasColumnName("IMIRDate");

                entity.Property(e => e.Imirno).HasColumnName("IMIRNo");

                entity.Property(e => e.InsuranceCharge).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.IsTransferredToAcc).HasColumnName("IsTransferredToACC");

                entity.Property(e => e.MaterialCoaDate).HasColumnType("datetime");

                entity.Property(e => e.MaterialCoaNo).HasMaxLength(500);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OrderDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherCharge).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.OtherCharges).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.PackingCharge).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ReceivedOn).HasColumnType("datetime");

                entity.Property(e => e.ReceivedRemarks).HasMaxLength(500);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Tdsamount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TDSAmount");

                entity.Property(e => e.Tdsrate)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TDSRate");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalWithTds)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("TotalWithTDS");

                entity.Property(e => e.TransportCourierCharge).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vattotal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("VATTotal");

                entity.Property(e => e.VendorBillDate).HasPrecision(3);

                entity.Property(e => e.VerifierIds)
                    .HasMaxLength(199)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvTxnGoodsReceipts)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_MST_GoodsReceipt_Emp_Employee");

                entity.HasOne(d => d.Donation)
                    .WithMany(p => p.InvTxnGoodsReceipts)
                    .HasForeignKey(d => d.DonationId)
                    .HasConstraintName("FK__INV_TXN_G__Donat__1157E267");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.InvTxnGoodsReceipts)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("FK_INV_TXN_GoodsReceipt_INV_TXN_PurchaseOrder");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.InvTxnGoodsReceipts)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INV_TXN_G__Store__1528734B");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.InvTxnGoodsReceipts)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_INV_TXN_GoodsReceipt_INV_MST_Vendor");
            });

            modelBuilder.Entity<InvTxnGoodsReceiptItem>(entity =>
            {
                entity.HasKey(e => e.GoodsReceiptItemId);

                entity.ToTable("INV_TXN_GoodsReceiptItems");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BatchNO");

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.CcAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CcCharge).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.GritemDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GRItemDate");

                entity.Property(e => e.GritemSpecification)
                    .HasMaxLength(500)
                    .HasColumnName("GRItemSpecification");

                entity.Property(e => e.IdentificationLabel).HasMaxLength(500);

                entity.Property(e => e.IsSamplingLabel).HasMaxLength(500);

                entity.Property(e => e.IsTransferredToAcc).HasColumnName("IsTransferredToACC");

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemRate).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.ManufactureDate).HasColumnType("datetime");

                entity.Property(e => e.MaterialNo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("MaterialNO");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.OtherCharge).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.SamplingBoxes).HasMaxLength(500);

                entity.Property(e => e.SamplingDate).HasColumnType("datetime");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vat).HasColumnName("VAT");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VATAmount");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvTxnGoodsReceiptItems)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_TXN_GoodsReceiptItems_Emp_Employee");

                entity.HasOne(d => d.GoodsReceipt)
                    .WithMany(p => p.InvTxnGoodsReceiptItems)
                    .HasForeignKey(d => d.GoodsReceiptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_TXN_GoodsReceiptItems_INV_TXN_GoodsReceipt");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvTxnGoodsReceiptItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_INV_TXN_GoodsReceiptItems_INV_MST_Item");
            });

            modelBuilder.Entity<InvTxnPurchaseOrder>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderId);

                entity.ToTable("INV_TXN_PurchaseOrder");

                entity.Property(e => e.CancelRemarks).HasMaxLength(500);

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.ContactPersonEmail).HasMaxLength(1000);

                entity.Property(e => e.ContactPersonName).HasMaxLength(1000);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryDate).HasPrecision(3);

                entity.Property(e => e.InvoicingAddress).HasMaxLength(1000);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PerformanceInvoiceNo).HasMaxLength(200);

                entity.Property(e => e.PoDate).HasColumnType("datetime");

                entity.Property(e => e.Pocategory)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("POCategory");

                entity.Property(e => e.PogroupId).HasColumnName("POGroupId");

                entity.Property(e => e.Ponumber).HasColumnName("PONumber");

                entity.Property(e => e.Poremark)
                    .HasMaxLength(500)
                    .HasColumnName("PORemark");

                entity.Property(e => e.Postatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("POStatus");

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VAT");

                entity.Property(e => e.VerifierIds)
                    .HasMaxLength(199)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvTxnPurchaseOrders)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_TXN_PurchaseOrder_Emp_Employee");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.InvTxnPurchaseOrders)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_INV_TXN_PurchaseOrder_INV_MST_Currency");

                entity.HasOne(d => d.InvoiceHeader)
                    .WithMany(p => p.InvTxnPurchaseOrders)
                    .HasForeignKey(d => d.InvoiceHeaderId)
                    .HasConstraintName("FK__INV_TXN_P__Invoi__03A8E18E");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.InvTxnPurchaseOrders)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INV_TXN_P__Store__14344F12");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.InvTxnPurchaseOrders)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_INV_TXN_PurchaseOrder_INV_MST_Vendor");
            });

            modelBuilder.Entity<InvTxnPurchaseOrderItem>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderItemId);

                entity.ToTable("INV_TXN_PurchaseOrderItems");

                entity.Property(e => e.AuthorizedOn).HasColumnType("datetime");

                entity.Property(e => e.AuthorizedRemark).HasMaxLength(500);

                entity.Property(e => e.CancelRemarks).HasMaxLength(500);

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PoitemSpecification)
                    .HasMaxLength(500)
                    .HasColumnName("POItemSpecification");

                entity.Property(e => e.PoitemStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("POItemStatus");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.StandardRate).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VATAmount");

                entity.Property(e => e.VendorItemCode).HasMaxLength(50);

                entity.HasOne(d => d.AuthorizedByNavigation)
                    .WithMany(p => p.InvTxnPurchaseOrderItemAuthorizedByNavigations)
                    .HasForeignKey(d => d.AuthorizedBy)
                    .HasConstraintName("FK_INV_TXN_PurchaseOrderItems_Emp_Employee_AuthorizeBy");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvTxnPurchaseOrderItemCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_TXN_PurchaseOrderItems_Emp_Employee");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvTxnPurchaseOrderItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_INV_TXN_PurchaseOrderItems_INV_MST_Item");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.InvTxnPurchaseOrderItems)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("FK_INV_TXN_PurchaseOrderItems_INV_TXN_PurchaseOrder");
            });

            modelBuilder.Entity<InvTxnPurchaseRequest>(entity =>
            {
                entity.HasKey(e => e.PurchaseRequestId);

                entity.ToTable("INV_TXN_PurchaseRequest");

                entity.Property(e => e.CancelRemarks).HasMaxLength(500);

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsPocreated).HasColumnName("IsPOCreated");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Prcategory)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PRCategory");

                entity.Property(e => e.PrgroupId).HasColumnName("PRGroupId");

                entity.Property(e => e.Prnumber).HasColumnName("PRNumber");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RequestStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.InvTxnPurchaseRequests)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_TXN_purchase_request_StoreId");
            });

            modelBuilder.Entity<InvTxnPurchaseRequestItem>(entity =>
            {
                entity.HasKey(e => e.PurchaseRequestItemId);

                entity.ToTable("INV_TXN_PurchaseRequestItems");

                entity.Property(e => e.CancelRemarks).HasMaxLength(500);

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.QuantityVerifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.RequestItemStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SupplyRequiredBefore).HasMaxLength(500);

                entity.HasOne(d => d.PurchaseRequest)
                    .WithMany(p => p.InvTxnPurchaseRequestItems)
                    .HasForeignKey(d => d.PurchaseRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_TXN_PurchaseRequestItems_PurchaseRequest");
            });

            modelBuilder.Entity<InvTxnRequisition>(entity =>
            {
                entity.HasKey(e => e.RequisitionId)
                    .HasName("PK_INV_TXN_RequisitionHeader");

                entity.ToTable("INV_TXN_Requisition");

                entity.Property(e => e.CancelRemarks).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsCancel).HasDefaultValueSql("((0))");

                entity.Property(e => e.MatIssueDate).HasColumnType("datetime");

                entity.Property(e => e.MatIssueTo).HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.RequestFromStoreId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RequisitionDate).HasColumnType("datetime");

                entity.Property(e => e.RequisitionStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvTxnRequisitions)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_TXN_Requisition_Emp_Employee");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.InvTxnRequisitions)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_INV_TXN_Requisition_MST_Department");

                entity.HasOne(d => d.Verification)
                    .WithMany(p => p.InvTxnRequisitions)
                    .HasForeignKey(d => d.VerificationId)
                    .HasConstraintName("FK_INV_TXN_Verification_TXN_Verification");
            });

            modelBuilder.Entity<InvTxnRequisitionForPo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INV_TXN_RequisitionForPO");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsApproved).HasColumnName("isApproved");

                entity.Property(e => e.IsPocreated).HasColumnName("isPOCreated");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RequisitionId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<InvTxnRequisitionItem>(entity =>
            {
                entity.HasKey(e => e.RequisitionItemId)
                    .HasName("PK_INV_TXN_RequestedItems");

                entity.ToTable("INV_TXN_RequisitionItems");

                entity.Property(e => e.AuthorizedOn).HasColumnType("datetime");

                entity.Property(e => e.AuthorizedRemark).HasMaxLength(500);

                entity.Property(e => e.CancelOn).HasColumnType("datetime");

                entity.Property(e => e.CancelRemarks).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FirstWeekQty).HasMaxLength(100);

                entity.Property(e => e.FourthWeekQty).HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MatIssueDate).HasColumnType("datetime");

                entity.Property(e => e.MatIssueTo).HasMaxLength(500);

                entity.Property(e => e.Mindate)
                    .HasColumnType("datetime")
                    .HasColumnName("MINDate");

                entity.Property(e => e.Minno)
                    .HasMaxLength(100)
                    .HasColumnName("MINNo");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Mssno)
                    .HasMaxLength(500)
                    .HasColumnName("MSSNO");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.RequisitionItemStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SecondWeekQty).HasMaxLength(100);

                entity.Property(e => e.ThirdWeekQty).HasMaxLength(100);

                entity.HasOne(d => d.AuthorizedByNavigation)
                    .WithMany(p => p.InvTxnRequisitionItemAuthorizedByNavigations)
                    .HasForeignKey(d => d.AuthorizedBy)
                    .HasConstraintName("FK_INV_TXN_RequestedItems_AuthorizedBy_Emp_Employee_EmployeeId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvTxnRequisitionItemCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_TXN_RequestedItems_Emp_Employee");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvTxnRequisitionItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_INV_TXN_RequestedItems_INV_MST_Item");

                entity.HasOne(d => d.Requisition)
                    .WithMany(p => p.InvTxnRequisitionItems)
                    .HasForeignKey(d => d.RequisitionId)
                    .HasConstraintName("FK_INV_TXN_RequestedItems_INV_TXN_Requisition");
            });

            modelBuilder.Entity<InvTxnRequisitionItemsForPo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INV_TXN_RequisitionItemsForPO");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.RequisitionItemId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<InvTxnReturnToVendor>(entity =>
            {
                entity.HasKey(e => e.ReturnToVendorId)
                    .HasName("PK__INV_TXN___05DF2033B64FEE45");

                entity.ToTable("INV_TXN_ReturnToVendor");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vattotal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("VATTotal");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvTxnReturnToVendors)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_TXN_ReturnToVendor_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.InvTxnReturnToVendors)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_returnTovendor_Phrm_mst_store_storeId");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.InvTxnReturnToVendors)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_INV_TXN_ReturnToVendor_VendorId_INV_MST_Vendor_VendorId");
            });

            modelBuilder.Entity<InvTxnReturnToVendorItem>(entity =>
            {
                entity.HasKey(e => e.ReturnToVendorItemId)
                    .HasName("PK__INV_TXN___91F2E30FCC7812F3");

                entity.ToTable("INV_TXN_ReturnToVendorItems");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsTransferredToAcc).HasColumnName("IsTransferredToACC");

                entity.Property(e => e.ItemRate).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.ReturnType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VAT");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvTxnReturnToVendorItems)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_TXN_ReturnToVendorItems_Emp_Employee");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvTxnReturnToVendorItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("Fk_INV_TXN_ReturnToVendorItems_INV_MST_Item");

                entity.HasOne(d => d.ReturnToVendor)
                    .WithMany(p => p.InvTxnReturnToVendorItems)
                    .HasForeignKey(d => d.ReturnToVendorId)
                    .HasConstraintName("FK__INV_TXN_R__Retur__00CC74E3");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.InvTxnReturnToVendorItems)
                    .HasForeignKey(d => d.StockId)
                    .HasConstraintName("INV_TXN_ReturnToVendorItems_INV_MST_Stock");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.InvTxnReturnToVendorItems)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("Fk_INV_TXN_ReturnToVendorItems_INV_MST_Vendor");
            });

            modelBuilder.Entity<InvTxnStock>(entity =>
            {
                entity.HasKey(e => e.StockId)
                    .HasName("PK_INV_TXN_NewStock");

                entity.ToTable("INV_TXN_Stock");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BatchNO");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Price).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.StockSpecification).HasMaxLength(500);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.InvTxnStocks)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_TXN_Stock_PHRM_MST_Store");
            });

            modelBuilder.Entity<InvTxnStockTransaction>(entity =>
            {
                entity.HasKey(e => e.StockTransactionId)
                    .HasName("PK__INV_TXN___DBFF6DB8E51FCFD6");

                entity.ToTable("INV_TXN_StockTransaction");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CostPrice).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasPrecision(3);

                entity.Property(e => e.InOut)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsTransferredToAcc).HasColumnName("IsTransferredToACC");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.InvTxnStockTransactions)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_INV_TXN_StockTransaction_PHRM_MST_Store");

                entity.HasOne(d => d.StoreStock)
                    .WithMany(p => p.InvTxnStockTransactions)
                    .HasForeignKey(d => d.StoreStockId)
                    .HasConstraintName("FK_INV_TXN_StockTransaction_INV_TXN_StoreStock");
            });

            modelBuilder.Entity<InvTxnStoreStock>(entity =>
            {
                entity.HasKey(e => e.StoreStockId);

                entity.ToTable("INV_TXN_StoreStock");

                entity.Property(e => e.SellingPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnConfirmedQtyIn).HasColumnName("UnConfirmedQty_In");

                entity.Property(e => e.UnConfirmedQtyOut).HasColumnName("UnConfirmedQty_Out");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvTxnStoreStocks)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_INV_TXN_StoreStock_INV_MST_Item");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.InvTxnStoreStocks)
                    .HasForeignKey(d => d.StockId)
                    .HasConstraintName("FK_INV_TXN_StoreStock_INV_MST_Stock");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.InvTxnStoreStocks)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_INV_TXN_StoreStock_PHRM_MST_Store");
            });

            modelBuilder.Entity<InvTxnWriteOffItem>(entity =>
            {
                entity.HasKey(e => e.WriteOffId)
                    .HasName("PK__INV_TXN___63345CEB4C589B93");

                entity.ToTable("INV_TXN_WriteOffItems");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BatchNO");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsTransferredToAcc).HasColumnName("IsTransferredToACC");

                entity.Property(e => e.ItemRate).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.WriteOffDate).HasColumnType("datetime");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvTxnWriteOffItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_INV_TXN_WriteOffItems_INV_MST_Item");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.InvTxnWriteOffItems)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WriteOffItems_Phrm_mst_store_storeId");
            });

            modelBuilder.Entity<IrdLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("IRD_Log");

                entity.Property(e => e.BillType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage).IsUnicode(false);

                entity.Property(e => e.JsonData).IsUnicode(false);

                entity.Property(e => e.ResponseMessage)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UrlInfo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabBarCode>(entity =>
            {
                entity.HasKey(e => e.BarCodeNumber)
                    .HasName("PK_LabBarCodeNumber");

                entity.ToTable("LAB_BarCode");

                entity.Property(e => e.BarCodeNumber).ValueGeneratedNever();

                entity.Property(e => e.BarCodeId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<LabGovReportMapping>(entity =>
            {
                entity.HasKey(e => e.ReportMapId)
                    .HasName("PK_MapID_Lab_Gov_TestReport");

                entity.ToTable("Lab_Gov_Report_Mapping");

                entity.Property(e => e.ComponentName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PositiveIndicator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ReportItem)
                    .WithMany(p => p.LabGovReportMappings)
                    .HasForeignKey(d => d.ReportItemId)
                    .HasConstraintName("FK_LAB_Gov_ReportMapping_Gov_Report_Items");
            });

            modelBuilder.Entity<LabLabTest>(entity =>
            {
                entity.HasKey(e => e.LabTestId);

                entity.ToTable("LAB_LabTests");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Interpretation)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LabTestCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LabTestName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LabTestSpecimen)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LabTestSpecimenSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LabTestSynonym)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Loinc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOINC");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NegativeResultText)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReportTemplateId).HasColumnName("ReportTemplateID");

                entity.Property(e => e.ReportingName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RunNumberType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ReportTemplate)
                    .WithMany(p => p.LabLabTests)
                    .HasForeignKey(d => d.ReportTemplateId)
                    .HasConstraintName("FK_LAB_Tests_Lab_Report_Template");
            });

            modelBuilder.Entity<LabLabTestsWithCorrectedCategory>(entity =>
            {
                entity.HasKey(e => e.LabTestWithCategoryId);

                entity.ToTable("LAB_LabTestsWithCorrectedCategory");

                entity.Property(e => e.Category).HasMaxLength(2000);

                entity.Property(e => e.CorrectedCategory).HasMaxLength(2000);

                entity.Property(e => e.LabTestName).HasMaxLength(2000);
            });

            modelBuilder.Entity<LabLisComponentMap>(entity =>
            {
                entity.HasKey(e => e.LiscomponentMapId);

                entity.ToTable("LAB_LIS_ComponentMap");

                entity.Property(e => e.LiscomponentMapId).HasColumnName("LISComponentMapId");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LiscomponentId).HasColumnName("LISComponentId");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.LabLisComponentMaps)
                    .HasForeignKey(d => d.ComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LAB_LIS_ComponentMap_LAB_MST_Component");
            });

            modelBuilder.Entity<LabLisSyncedComponentDetail>(entity =>
            {
                entity.HasKey(e => e.LiscomponentResultId)
                    .HasName("PK_LAB_LIS_ComponentResult");

                entity.ToTable("LAB_LIS_SyncedComponent_Detail");

                entity.Property(e => e.LiscomponentResultId).HasColumnName("LISComponentResultId");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<LabMapTestComponent>(entity =>
            {
                entity.HasKey(e => e.ComponentMapId)
                    .HasName("PK_ComponentMapId");

                entity.ToTable("Lab_MAP_TestComponents");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.LabMapTestComponents)
                    .HasForeignKey(d => d.ComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LAB_MST_COMPONENTS_MAPTESTCOMPONENT");

                entity.HasOne(d => d.LabTest)
                    .WithMany(p => p.LabMapTestComponents)
                    .HasForeignKey(d => d.LabTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LAB_TEST_MAPTESTCOMPONENT");
            });

            modelBuilder.Entity<LabMstComponent>(entity =>
            {
                entity.HasKey(e => e.ComponentId)
                    .HasName("PK_ComponentId");

                entity.ToTable("Lab_MST_Components");

                entity.Property(e => e.ChildRange)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ComponentName)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ControlType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FemaleRange)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MaleRange)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Method)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Range)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RangeDescription).HasMaxLength(1000);

                entity.Property(e => e.Unit)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValueLookup)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ValueType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabMstGovReportItem>(entity =>
            {
                entity.HasKey(e => e.ReportItemId)
                    .HasName("PK_ItemId_Of_TestName_In_Lab_GovReport");

                entity.ToTable("Lab_Mst_Gov_Report_Items");

                entity.HasIndex(e => e.TestName, "Unique_Gov_Lab_ReportItem_Name")
                    .IsUnique();

                entity.HasIndex(e => e.SerialNumber, "Unique_Gov_Lab_ReportItem_SerialNumber")
                    .IsUnique();

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InnerTestGroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabMstLabVendor>(entity =>
            {
                entity.HasKey(e => e.LabVendorId)
                    .HasName("PK_LabVendors");

                entity.ToTable("Lab_MST_LabVendors");

                entity.Property(e => e.ContactAddress).HasMaxLength(200);

                entity.Property(e => e.ContactNo).HasMaxLength(20);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabMstRunNumberSetting>(entity =>
            {
                entity.HasKey(e => e.RunNumberFormatId)
                    .HasName("RunNumberFormatID");

                entity.ToTable("Lab_MST_RunNumberSettings");

                entity.Property(e => e.FormatInitialPart)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FormatLastPart)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FormatSeparator)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RunNumberFormatName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RunNumberType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartingLetter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VisitType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabMstTestSpeciman>(entity =>
            {
                entity.HasKey(e => e.SpecimenId)
                    .HasName("PK_SpecimenId");

                entity.ToTable("LAB_MST_TestSpecimen");

                entity.HasIndex(e => e.SpecimenName, "UniqueSpecimenName")
                    .IsUnique();

                entity.Property(e => e.SpecimenName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabReportTemplate>(entity =>
            {
                entity.HasKey(e => e.ReportTemplateId)
                    .HasName("PK_LAB_ReportTemplate");

                entity.ToTable("Lab_ReportTemplate");

                entity.HasIndex(e => e.ReportTemplateShortName, "UK_LAB_ReportTemplate_TemplateSName")
                    .IsUnique();

                entity.Property(e => e.ReportTemplateId).HasColumnName("ReportTemplateID");

                entity.Property(e => e.ColSettingsJson)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("ColSettingsJSON");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FooterText)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderText)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NegativeTemplateFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportTemplateName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReportTemplateShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateHtml).HasColumnName("TemplateHTML");

                entity.Property(e => e.TemplateType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabSm>(entity =>
            {
                entity.HasKey(e => e.SmsId)
                    .HasName("PK_LAB_SMS_Id");

                entity.ToTable("LAB_Sms");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabTestCategory>(entity =>
            {
                entity.HasKey(e => e.TestCategoryId)
                    .HasName("LabTestCategoryId");

                entity.ToTable("LAB_TestCategory");

                entity.HasIndex(e => e.TestCategoryName, "uniqueCategory")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.TestCategoryName).HasMaxLength(200);
            });

            modelBuilder.Entity<LabTestRequisition>(entity =>
            {
                entity.HasKey(e => e.RequisitionId);

                entity.ToTable("LAB_TestRequisition");

                entity.Property(e => e.BillCancelledOn).HasColumnType("datetime");

                entity.Property(e => e.BillingStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CovidFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Diagnosis)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleFileIdForCovid)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsFileUploadedToTeleMedicine).HasDefaultValueSql("((0))");

                entity.Property(e => e.LabTestName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LabTestSpecimen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LabTestSpecimenSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LabTypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Loinc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOINC");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OrderDateTime).HasColumnType("datetime");

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequisitionRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ResultAddedOn).HasColumnType("datetime");

                entity.Property(e => e.RunNumberType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SampleCodeFormatted)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SampleCollectedOnDateTime).HasColumnType("datetime");

                entity.Property(e => e.SampleCreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UploadedOn).HasColumnType("datetime");

                entity.Property(e => e.UploadedOnToTeleMedicine).HasColumnType("datetime");

                entity.Property(e => e.Urgency)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedOn).HasColumnType("datetime");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WardName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.BarCodeNumberNavigation)
                    .WithMany(p => p.LabTestRequisitions)
                    .HasForeignKey(d => d.BarCodeNumber)
                    .HasConstraintName("FK_LAB_TESTREQUISITION_LAB_BARCODE");

                entity.HasOne(d => d.DiagnosisNavigation)
                    .WithMany(p => p.LabTestRequisitions)
                    .HasForeignKey(d => d.DiagnosisId)
                    .HasConstraintName("FK_LAB_TestRequisition_CLN_Disgnosis");

                entity.HasOne(d => d.LabTest)
                    .WithMany(p => p.LabTestRequisitions)
                    .HasForeignKey(d => d.LabTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LAB_TestRequisition_LAB_LabTests");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.LabTestRequisitions)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_LAB_TestRequisition_PAT_Patient");

                entity.HasOne(d => d.PatientVisit)
                    .WithMany(p => p.LabTestRequisitions)
                    .HasForeignKey(d => d.PatientVisitId)
                    .HasConstraintName("FK_LAB_TestRequisition_PAT_PatientVisits");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.LabTestRequisitions)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("FK_LAB_TestRequisition_EMP_Employee");
            });

            modelBuilder.Entity<LabTxnLabReport>(entity =>
            {
                entity.HasKey(e => e.LabReportId);

                entity.ToTable("LAB_TXN_LabReports");

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("('0')");

                entity.Property(e => e.PrintedOn).HasColumnType("datetime");

                entity.Property(e => e.ReceivingDate).HasColumnType("datetime");

                entity.Property(e => e.ReferredByDr)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportingDate).HasColumnType("datetime");

                entity.Property(e => e.Signatories).IsUnicode(false);
            });

            modelBuilder.Entity<LabTxnTestComponentResult>(entity =>
            {
                entity.HasKey(e => e.TestComponentResultId);

                entity.ToTable("LAB_TXN_TestComponentResult");

                entity.Property(e => e.AbnormalType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComponentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Method)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NegativeResultText)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Range)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.RangeDescription)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LabTest)
                    .WithMany(p => p.LabTxnTestComponentResults)
                    .HasForeignKey(d => d.LabTestId)
                    .HasConstraintName("FK_LAB_TXN_TestComponentResult_LAB_LabTests");

                entity.HasOne(d => d.Requisition)
                    .WithMany(p => p.LabTxnTestComponentResults)
                    .HasForeignKey(d => d.RequisitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LAB_TXN_TestComponentResult_LAB_TestRequisition");
            });

            modelBuilder.Entity<MatFileUpload>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_MAT_FileId");

                entity.ToTable("MAT_FileUploads");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.MaternityPatient)
                    .WithMany(p => p.MatFileUploads)
                    .HasForeignKey(d => d.MaternityPatientId)
                    .HasConstraintName("FK_MAT_File_Maternity_Patient");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.MatFileUploads)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_MAT_File_PAT_Patient");
            });

            modelBuilder.Entity<MatMaternityAnc>(entity =>
            {
                entity.HasKey(e => e.MaternityAncid)
                    .HasName("PK_MaternityANCId");

                entity.ToTable("MAT_MaternityANC");

                entity.Property(e => e.MaternityAncid).HasColumnName("MaternityANCId");

                entity.Property(e => e.AncdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("ANCDateTime");

                entity.Property(e => e.Ancplace)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ANCPlace");

                entity.Property(e => e.ConditionOfAnc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ConditionOfANC");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaternityPatient)
                    .WithMany(p => p.MatMaternityAncs)
                    .HasForeignKey(d => d.MaternityPatientId)
                    .HasConstraintName("FK_MAT_ANC_Maternity_Patient");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.MatMaternityAncs)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_MAT_ANC_PAT_Patient");
            });

            modelBuilder.Entity<MatPatient>(entity =>
            {
                entity.HasKey(e => e.MaternityPatientId)
                    .HasName("PK_MaternityPatientId");

                entity.ToTable("MAT_Patient");

                entity.Property(e => e.Complications)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ConcludedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.HusbandName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastMenstrualPeriod).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Obshistory)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OBSHistory");

                entity.Property(e => e.PlaceOfDelivery)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Presentation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.MatPatients)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MAT_Patient_PAT_Patient");
            });

            modelBuilder.Entity<MatRegister>(entity =>
            {
                entity.HasKey(e => e.MaternityRegisterId)
                    .HasName("PK_MaternityRegisterId");

                entity.ToTable("MAT_Register");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OutcomeOfBaby)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OutcomeOfMother)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaternityPatient)
                    .WithMany(p => p.MatRegisters)
                    .HasForeignKey(d => d.MaternityPatientId)
                    .HasConstraintName("FK_MAT_Register_Maternity_Patient");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.MatRegisters)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_MAT_Register_PAT_Patient");
            });

            modelBuilder.Entity<MatTxnPatientPayment>(entity =>
            {
                entity.HasKey(e => e.PatientPaymentId);

                entity.ToTable("MAT_TXN_PatientPayments");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MatTxnPatientPayments)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MAT_TXN_PatientPayments_EMP_Employee");

                entity.HasOne(d => d.FiscalYear)
                    .WithMany(p => p.MatTxnPatientPayments)
                    .HasForeignKey(d => d.FiscalYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MAT_TXN_PatientPayments_BIL_CFG_FiscalYears");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.MatTxnPatientPayments)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MAT_TXN_PatientPayments_PAT_Patient");
            });

            modelBuilder.Entity<MrMstOperationType>(entity =>
            {
                entity.HasKey(e => e.OperationId)
                    .HasName("PK_OperationId");

                entity.ToTable("MR_MST_OperationType");

                entity.HasIndex(e => e.OperationName, "UniqueOperationName")
                    .IsUnique();

                entity.Property(e => e.OperationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MrRecordSummary>(entity =>
            {
                entity.HasKey(e => e.MedicalRecordId)
                    .HasName("PK_MR_RecordSummaryID");

                entity.ToTable("MR_RecordSummary");

                entity.Property(e => e.BloodLostUnit)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FileNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.GestationalUnit)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Icdcode).HasColumnName("ICDCode");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.ReferredDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(300);
            });

            modelBuilder.Entity<MrTxnInpatientDiagnosis>(entity =>
            {
                entity.HasKey(e => e.DiagnosisId)
                    .HasName("PK__MR_TXN_I__0C54CC73AA9B03DB");

                entity.ToTable("MR_TXN_Inpatient_Diagnosis");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Icd10code)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ICD10Code");

                entity.Property(e => e.Icd10id).HasColumnName("ICD10ID");

                entity.Property(e => e.Icd10name)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ICD10Name");

                entity.Property(e => e.ModifiedBy).HasColumnType("datetime");

                entity.HasOne(d => d.Icd10)
                    .WithMany(p => p.MrTxnInpatientDiagnoses)
                    .HasForeignKey(d => d.Icd10id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MR_TXN_In__ICD10__7DDAF99F");

                entity.HasOne(d => d.MedicalRecord)
                    .WithMany(p => p.MrTxnInpatientDiagnoses)
                    .HasForeignKey(d => d.MedicalRecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MR_TXN_In__Medic__7CE6D566");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.MrTxnInpatientDiagnoses)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MR_TXN_In__Patie__7AFE8CF4");

                entity.HasOne(d => d.PatientVisit)
                    .WithMany(p => p.MrTxnInpatientDiagnoses)
                    .HasForeignKey(d => d.PatientVisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MR_TXN_In__Patie__7BF2B12D");
            });

            modelBuilder.Entity<MrTxnOutpatientFinalDiagnosis>(entity =>
            {
                entity.HasKey(e => e.FinalDiagnosisId)
                    .HasName("PK__MR_TXN_O__9691C4615EEA3947");

                entity.ToTable("MR_TXN_Outpatient_FinalDiagnosis");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Icd10id).HasColumnName("ICD10ID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MrTxnOutpatientFinalDiagnosisCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MR_TXN_Ou__Creat__3377F041");

                entity.HasOne(d => d.Icd10)
                    .WithMany(p => p.MrTxnOutpatientFinalDiagnoses)
                    .HasForeignKey(d => d.Icd10id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MR_TXN_Ou__ICD10__3283CC08");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.MrTxnOutpatientFinalDiagnosisModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__MR_TXN_Ou__Modif__346C147A");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.MrTxnOutpatientFinalDiagnoses)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MR_TXN_Ou__Patie__309B8396");

                entity.HasOne(d => d.PatientVisit)
                    .WithMany(p => p.MrTxnOutpatientFinalDiagnoses)
                    .HasForeignKey(d => d.PatientVisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MR_TXN_Ou__Patie__318FA7CF");
            });

            modelBuilder.Entity<MstBank>(entity =>
            {
                entity.HasKey(e => e.BankId)
                    .HasName("PK__MST_Bank__AA08CB139F26960C");

                entity.ToTable("MST_Bank");

                entity.Property(e => e.BankName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BankShortName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK__MST_Coun__10D1609F66C8CE38");

                entity.ToTable("MST_Country");

                entity.HasIndex(e => e.CountryName, "UK_CountryName")
                    .IsUnique();

                entity.HasIndex(e => e.CountryShortName, "UK_CountryShortName")
                    .IsUnique();

                entity.Property(e => e.CountryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CountryShortName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountrySubDivisionType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Isdcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ISDCode");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstCountrySubDivision>(entity =>
            {
                entity.HasKey(e => e.CountrySubDivisionId)
                    .HasName("PK_CountrySubDivision");

                entity.ToTable("MST_CountrySubDivision");

                entity.Property(e => e.CountrySubDivisionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountrySubDivisionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MapAreaCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.MstCountrySubDivisions)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MST_CountrySubDivision_MST_Country");
            });

            modelBuilder.Entity<MstDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("MST_Department");

                entity.HasIndex(e => e.DepartmentName, "UK_MSTDepartment_Name")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NoticeText).HasMaxLength(4000);

                entity.Property(e => e.RoomNumber).HasMaxLength(20);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MstDepartmentCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_MST_Department_CreatedBy_EMP_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.MstDepartmentModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_MST_Department_ModifiedBy_EMP_Employee");

                entity.HasOne(d => d.ParentDepartment)
                    .WithMany(p => p.InverseParentDepartment)
                    .HasForeignKey(d => d.ParentDepartmentId)
                    .HasConstraintName("FK_MST_Department_FK_MST_Departmnet");
            });

            modelBuilder.Entity<MstEthnicGroup>(entity =>
            {
                entity.HasKey(e => e.EthnicGroupId)
                    .HasName("PK__MST_Ethn__9E22DDF09484443C");

                entity.ToTable("MST_EthnicGroup");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EthnicGroup).HasMaxLength(500);
            });

            modelBuilder.Entity<MstGovFreeServiceCategory>(entity =>
            {
                entity.HasKey(e => e.FreeServiceId);

                entity.ToTable("MST_Gov_FreeServiceCategory");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FreeServiceName).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstIcd10>(entity =>
            {
                entity.HasKey(e => e.Icd10id);

                entity.ToTable("MST_ICD10");

                entity.HasIndex(e => e.Icd10code, "UQ__MST_ICD1__1712921F0838A1D3")
                    .IsUnique();

                entity.HasIndex(e => e.Icd10code, "UQ__MST_ICD1__1712921F23B705E8")
                    .IsUnique();

                entity.HasIndex(e => e.Icd10code, "UQ__MST_ICD1__1712921F7B2BBD45")
                    .IsUnique();

                entity.Property(e => e.Icd10id).HasColumnName("ICD10ID");

                entity.Property(e => e.Icd10code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ICD10Code");

                entity.Property(e => e.Icd10description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ICD10Description");

                entity.Property(e => e.Icd10longDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("ICD10LongDescription");

                entity.Property(e => e.IcdshortCode)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("ICDShortCode");

                entity.HasOne(d => d.DiseaseGroup)
                    .WithMany(p => p.MstIcd10s)
                    .HasForeignKey(d => d.DiseaseGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MST_ICD10__Disea__2CCAF2B2");
            });

            modelBuilder.Entity<MstInvoiceHeader>(entity =>
            {
                entity.HasKey(e => e.InvoiceHeaderId)
                    .HasName("PK__MST_Invo__26E54BE2EDE66CA1");

                entity.ToTable("MST_InvoiceHeaders");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dda)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DDA");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LogoFileExtention)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogoFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Module)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PAN");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstLabType>(entity =>
            {
                entity.HasKey(e => e.LabTypeId)
                    .HasName("PK__MST_LabT__07D90D3ECBBB30D8");

                entity.ToTable("MST_LabTypes");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LabTypeName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstLoinc>(entity =>
            {
                entity.HasKey(e => e.LoincId)
                    .HasName("PK__MST_LOIN__7C966FE9B1BB15A3");

                entity.ToTable("MST_LOINC");

                entity.Property(e => e.LoincId).HasColumnName("LoincID");

                entity.Property(e => e.Component)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LoincCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LongName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstMapStoreVerification>(entity =>
            {
                entity.HasKey(e => e.StoreVerificationMapId)
                    .HasName("PK__MST_MAP___35C592AEF17EFE5E");

                entity.ToTable("MST_MAP_StoreVerification");

                entity.HasIndex(e => e.StoreVerificationMapId, "UK_MST_MAP_StoreVerification")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.MstMapStoreVerifications)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MST_MAP_StoreVerification_PHRM_MST_Store");
            });

            modelBuilder.Entity<MstMunicipality>(entity =>
            {
                entity.HasKey(e => e.MunicipalityId)
                    .HasName("PK__MST_Muni__009B60D5C1EF1AE8");

                entity.ToTable("MST_Municipality");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.MunicipalityName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.MstMunicipalities)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MST_Munic__Count__7D1BDF90");

                entity.HasOne(d => d.CountrySubDivision)
                    .WithMany(p => p.MstMunicipalities)
                    .HasForeignKey(d => d.CountrySubDivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MST_Munic__Count__7E1003C9");
            });

            modelBuilder.Entity<MstReaction>(entity =>
            {
                entity.HasKey(e => e.ReactionId);

                entity.ToTable("MST_Reactions");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ReactionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReactionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstRptDynamicReportName>(entity =>
            {
                entity.HasKey(e => e.DynamicReportId);

                entity.ToTable("MST_RPT_DynamicReportName");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDescription)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ReportName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UsedInSpname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("UsedIn_SPName");
            });

            modelBuilder.Entity<MstRptDynamicReportingItem>(entity =>
            {
                entity.HasKey(e => e.ReportingItemsId);

                entity.ToTable("MST_RPT_DynamicReportingItems");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ReportingItemName).HasMaxLength(150);

                entity.Property(e => e.RptCountUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DynamicReport)
                    .WithMany(p => p.MstRptDynamicReportingItems)
                    .HasForeignKey(d => d.DynamicReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_reportingItems_dynamicReportId");
            });

            modelBuilder.Entity<MstTax>(entity =>
            {
                entity.HasKey(e => e.TaxId);

                entity.ToTable("MST_Tax");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TaxLabel)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TaxName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstemailSendDetail>(entity =>
            {
                entity.HasKey(e => e.SendId)
                    .HasName("SendId");

                entity.ToTable("MSTEmailSendDetail");

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SendOn).HasColumnType("datetime");

                entity.Property(e => e.SendToEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NephHemodialysisRecord>(entity =>
            {
                entity.HasKey(e => e.HemodialysisRecordId)
                    .HasName("PK_HemodialysisRecord");

                entity.ToTable("NEPH_HemodialysisRecord");

                entity.Property(e => e.BloodTransBagNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("BloodTrans_BagNo");

                entity.Property(e => e.BloodTransBloodGroup)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("BloodTrans_BloodGroup");

                entity.Property(e => e.BloodTransCollectionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("BloodTrans_CollectionDate");

                entity.Property(e => e.BloodTransExpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("BloodTrans_ExpDate");

                entity.Property(e => e.BloodTransNextBt).HasColumnName("BloodTrans_NextBT");

                entity.Property(e => e.BloodTransToday)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("BloodTrans_Today");

                entity.Property(e => e.CheckedByName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ChiefComplaint)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CommentsDrugs)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("Comments_Drugs");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CurrentHdDate).HasColumnType("datetime");

                entity.Property(e => e.Diagnosis)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HdNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsSubmittedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NextHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NextHD");

                entity.Property(e => e.OnExaminationChest)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OnExamination_Chest");

                entity.Property(e => e.OnExaminationCvs)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OnExamination_CVS");

                entity.Property(e => e.OnExaminationIctercus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OnExamination_Ictercus");

                entity.Property(e => e.OnExaminationJvp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OnExamination_JVP");

                entity.Property(e => e.OnExaminationLymphnode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OnExamination_Lymphnode");

                entity.Property(e => e.OnExaminationOthers)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OnExamination_Others");

                entity.Property(e => e.OnExaminationPa)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OnExamination_PA");

                entity.Property(e => e.OnExaminationPallor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OnExamination_Pallor");

                entity.Property(e => e.OnExaminationRash)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OnExamination_Rash");

                entity.Property(e => e.OnExaminationSpo2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OnExamination_SPo2");

                entity.Property(e => e.PostDialysisAssesment)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PtSentToHome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PtSentToHospital)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Schedule)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SignatoryName1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SignatoryName_1");

                entity.Property(e => e.SignatoryName2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SignatoryName_2");

                entity.Property(e => e.TotalBloodVolume)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalFluidRemoved)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalHeparinSaline)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TotalHeparin_Saline");

                entity.Property(e => e.TreatmentDataBloodSugar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_BloodSugar");

                entity.Property(e => e.TreatmentDataHbPcV)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_Hb_PcV");

                entity.Property(e => e.TreatmentDataInitials)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_Initials");

                entity.Property(e => e.TreatmentDataMachineConductivity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_Machine_Conductivity");

                entity.Property(e => e.TreatmentDataMachineMachineCheck)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_Machine_MachineCheck");

                entity.Property(e => e.TreatmentDataMachineNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_MachineNo");

                entity.Property(e => e.TreatmentDataMachineTemperature)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_Machine_Temperature");

                entity.Property(e => e.TreatmentDataPostLab)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_PostLab");

                entity.Property(e => e.TreatmentDataPostPulse)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_PostPulse");

                entity.Property(e => e.TreatmentDataPostSitBp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_PostSitBp");

                entity.Property(e => e.TreatmentDataPostStandBp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_PostStandBp");

                entity.Property(e => e.TreatmentDataPostTemperature)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_PostTemperature");

                entity.Property(e => e.TreatmentDataPostWeight)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_PostWeight");

                entity.Property(e => e.TreatmentDataPreLab)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_PreLab");

                entity.Property(e => e.TreatmentDataPrePulse)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_PrePulse");

                entity.Property(e => e.TreatmentDataPreSitBp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_PreSitBp");

                entity.Property(e => e.TreatmentDataPreStandBp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_PreStandBp");

                entity.Property(e => e.TreatmentDataPreTemperature)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_PreTemperature");

                entity.Property(e => e.TreatmentDataPreWeight)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_PreWeight");

                entity.Property(e => e.TreatmentDataTimeOff)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_TimeOff");

                entity.Property(e => e.TreatmentDataTimeOffBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_TimeOff_By");

                entity.Property(e => e.TreatmentDataTimeOn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_TimeOn");

                entity.Property(e => e.TreatmentDataTimeOnBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_TimeOn_By");

                entity.Property(e => e.TreatmentDataUfGoal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentData_UfGoal");

                entity.Property(e => e.TreatmentOrderBlood)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentOrder_Blood");

                entity.Property(e => e.TreatmentOrderBloodTransfusion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentOrder_BloodTransfusion");

                entity.Property(e => e.TreatmentOrderDialysisFlow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentOrder_DialysisFlow");

                entity.Property(e => e.TreatmentOrderDryWeight)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentOrder_DryWeight");

                entity.Property(e => e.TreatmentOrderHeparineSalineBolus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentOrder_HeparineSaline_Bolus");

                entity.Property(e => e.TreatmentOrderHeparineSalineCirculation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentOrder_HeparineSaline_Circulation");

                entity.Property(e => e.TreatmentOrderHeparineSalineContinuous)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentOrder_HeparineSaline_Continuous");

                entity.Property(e => e.TreatmentOrderTimeInMin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentOrder_TimeInMin");

                entity.Property(e => e.TreatmentOrderUsedNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TreatmentOrder_UsedNo");

                entity.Property(e => e.VascularAccessAvf).HasColumnName("VascularAccess_AVF");

                entity.Property(e => e.VascularAccessFemoralCatheter).HasColumnName("VascularAccess_FemoralCatheter");

                entity.Property(e => e.VascularAccessJugular).HasColumnName("VascularAccess_Jugular");

                entity.Property(e => e.VascularAccessPermCath).HasColumnName("VascularAccess_PermCath");

                entity.Property(e => e.VascularAccessSubclavian).HasColumnName("VascularAccess_Subclavian");

                entity.Property(e => e.VerifiedByName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WeightDifference)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewItemHam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NewItemHAMS");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName).IsUnicode(false);

                entity.Property(e => e.SN).HasColumnName("S/N");

                entity.Property(e => e.ServDept)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Oppatient>(entity =>
            {
                entity.ToTable("OPPatients");

                entity.Property(e => e.OppatientId).HasColumnName("OPPatientId");

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.District)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsEmrpatient)
                    .HasColumnName("IsEMRPatient")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Taluka)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VillageCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OtTxnBookingDetail>(entity =>
            {
                entity.HasKey(e => e.OtbookingId)
                    .HasName("PK__OT_TXN_B__9D6DF0CE22190BEE");

                entity.ToTable("OT_TXN_BookingDetails");

                entity.Property(e => e.OtbookingId).HasColumnName("OTBookingId");

                entity.Property(e => e.AnesthesiaType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BookedForDate).HasColumnType("datetime");

                entity.Property(e => e.CancellationRemarks)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.ConsentFormPath)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Diagnosis)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PacformPath)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("PACFormPath");

                entity.Property(e => e.ProcedureType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.SurgeryType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.OtTxnBookingDetails)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_Patient_PatientId");

                entity.HasOne(d => d.PatientVisit)
                    .WithMany(p => p.OtTxnBookingDetails)
                    .HasForeignKey(d => d.PatientVisitId)
                    .HasConstraintName("FK_PAT_PatientVisits_PatientVisitId");
            });

            modelBuilder.Entity<OtTxnCheckListInfo>(entity =>
            {
                entity.HasKey(e => e.CheckListId)
                    .HasName("PK_CheckListId");

                entity.ToTable("OT_TXN_CheckListInfo");

                entity.Property(e => e.ChekListItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Itemdetails)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.OtbookingId).HasColumnName("OTBookingId");

                entity.HasOne(d => d.Otbooking)
                    .WithMany(p => p.OtTxnCheckListInfos)
                    .HasForeignKey(d => d.OtbookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OT_TXN_BookingDetails_BookingId");
            });

            modelBuilder.Entity<OtTxnOtTeamsInfo>(entity =>
            {
                entity.HasKey(e => e.OtteamId)
                    .HasName("PK__OT_TXN_O__593E046A7EBAF37A");

                entity.ToTable("OT_TXN_OtTeamsInfo");

                entity.Property(e => e.OtteamId).HasColumnName("OTTeamId");

                entity.Property(e => e.OtbookingId).HasColumnName("OTBookingId");

                entity.Property(e => e.RoleType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.OtTxnOtTeamsInfos)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.Otbooking)
                    .WithMany(p => p.OtTxnOtTeamsInfos)
                    .HasForeignKey(d => d.OtbookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OT_BookingDetails_BookingId");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.OtTxnOtTeamsInfos)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OT_Teams_PatientId");

                entity.HasOne(d => d.PatientVisit)
                    .WithMany(p => p.OtTxnOtTeamsInfos)
                    .HasForeignKey(d => d.PatientVisitId)
                    .HasConstraintName("FK_OT_Teams_PatientVisitId");
            });

            modelBuilder.Entity<OtTxnSummary>(entity =>
            {
                entity.HasKey(e => e.OtsummaryId)
                    .HasName("PK__OT_TXN_S__AB1761D18B4AC5F0");

                entity.ToTable("OT_TXN_Summary");

                entity.Property(e => e.OtsummaryId).HasColumnName("OTSummaryId");

                entity.Property(e => e.Anesthesia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OtbookingId).HasColumnName("OTBookingId");

                entity.Property(e => e.Otcharge).HasColumnName("OTCharge");

                entity.Property(e => e.Otdescription)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("OTDescription");

                entity.Property(e => e.OtteamId).HasColumnName("OTTeamId");

                entity.Property(e => e.PostOperationDiagnosis)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.PreOperationDiagnosis)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureOfNurse)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.HasOne(d => d.Otbooking)
                    .WithMany(p => p.OtTxnSummaries)
                    .HasForeignKey(d => d.OtbookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OT_TXN_BookingDetails_OTBookingId");
            });

            modelBuilder.Entity<PatAppointment>(entity =>
            {
                entity.HasKey(e => e.AppointmentId);

                entity.ToTable("PAT_Appointment");

                entity.Property(e => e.Age)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDate).HasColumnType("datetime");

                entity.Property(e => e.AppointmentStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.CancelledRemarks).HasMaxLength(500);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PatAppointments)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PAT_Appointment_EMP_Employee");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatAppointments)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_PAT_Appointment_PAT_Patient");
            });

            modelBuilder.Entity<PatCfgMembershipType>(entity =>
            {
                entity.HasKey(e => e.MembershipTypeId);

                entity.ToTable("PAT_CFG_MembershipType");

                entity.HasIndex(e => new { e.MembershipTypeName, e.CommunityName }, "UK_Membership_Community")
                    .IsUnique();

                entity.Property(e => e.CommunityName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MembershipTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PatCfgMembershipTypeCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_CFG_MembershipType_CreatedBy_EMP_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PatCfgMembershipTypeModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_PAT_CFG_MembershipType_ModifiedBy_EMP_Employee");
            });

            modelBuilder.Entity<PatHealthCardInfo>(entity =>
            {
                entity.HasKey(e => e.PatHealthCardId);

                entity.ToTable("PAT_HealthCardInfo");

                entity.Property(e => e.BillingDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.InfoOnCardJson)
                    .HasMaxLength(4000)
                    .HasColumnName("InfoOnCardJSON");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatHealthCardInfos)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_HealthCardInfo_PAT_Patient");
            });

            modelBuilder.Entity<PatNeighbourhoodCardDetail>(entity =>
            {
                entity.HasKey(e => e.NeighbourhoodCardId)
                    .HasName("PK_NeighbourhoodCardId");

                entity.ToTable("PAT_NeighbourhoodCardDetail");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PatientCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatPatient>(entity =>
            {
                entity.HasKey(e => e.PatientId);

                entity.ToTable("PAT_Patient");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Age)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClinicCardNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Empi)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("EMPI");

                entity.Property(e => e.EmployerInfo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EthnicGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdcardNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDCardNumber");

                entity.Property(e => e.IdcardType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDCardType");

                entity.Property(e => e.InsHasInsurance).HasColumnName("Ins_HasInsurance");

                entity.Property(e => e.InsInsuranceBalance).HasColumnName("Ins_InsuranceBalance");

                entity.Property(e => e.InsLatestClaimCode).HasColumnName("Ins_LatestClaimCode");

                entity.Property(e => e.InsNshiNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ins_NshiNumber");

                entity.Property(e => e.IsOutdoorPat).HasDefaultValueSql("((1))");

                entity.Property(e => e.LandLineNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lpno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LPNo");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.MotherName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassportNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientNameLocal).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousLastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Race)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SsuIsActive).HasColumnName("SSU_IsActive");

                entity.HasOne(d => d.MembershipType)
                    .WithMany(p => p.PatPatients)
                    .HasForeignKey(d => d.MembershipTypeId)
                    .HasConstraintName("FK_Pat_Patients_MembershipType");
            });

            modelBuilder.Entity<PatPatientAddress>(entity =>
            {
                entity.HasKey(e => e.PatientAddressId);

                entity.ToTable("PAT_PatientAddress");

                entity.Property(e => e.AddressType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Street1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Street2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.PatPatientAddresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_PAT_PatientAddress_MST_Country");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatPatientAddresses)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientAddress_PAT_Patient");
            });

            modelBuilder.Entity<PatPatientFile>(entity =>
            {
                entity.HasKey(e => e.PatientFileId);

                entity.ToTable("PAT_PatientFiles");

                entity.HasIndex(e => e.Rowguid, "UQ__PAT_Pati__D7A3AA55F0F539DA")
                    .IsUnique();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileExtention)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageFullPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid).HasColumnName("ROWGUID");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UploadedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<PatPatientGurantorInfo>(entity =>
            {
                entity.HasKey(e => e.PatientId);

                entity.ToTable("PAT_PatientGurantorInfo");

                entity.Property(e => e.PatientId).ValueGeneratedNever();

                entity.Property(e => e.GuarantorCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorDateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.GuarantorGender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorPhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorStreet1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorStreet2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorZipcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GuarantorZIPCode");

                entity.Property(e => e.PatientGurantorInfo).ValueGeneratedOnAdd();

                entity.Property(e => e.PatientRelationship)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithOne(p => p.PatPatientGurantorInfo)
                    .HasForeignKey<PatPatientGurantorInfo>(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientGurantorInfo_PAT_Patient");
            });

            modelBuilder.Entity<PatPatientInsuranceInfo>(entity =>
            {
                entity.HasKey(e => e.PatientInsuranceInfoId);

                entity.ToTable("PAT_PatientInsuranceInfo");

                entity.HasIndex(e => e.PatientId, "IX_TblPatInsuranceInfo_PatientId");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Imiscode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IMISCode");

                entity.Property(e => e.InsFamilyHeadName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Ins_FamilyHeadName");

                entity.Property(e => e.InsFamilyHeadNshi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ins_FamilyHeadNshi");

                entity.Property(e => e.InsHasInsurance).HasColumnName("Ins_HasInsurance");

                entity.Property(e => e.InsInsuranceBalance).HasColumnName("Ins_InsuranceBalance");

                entity.Property(e => e.InsInsuranceProviderId).HasColumnName("Ins_InsuranceProviderId");

                entity.Property(e => e.InsIsFamilyHead).HasColumnName("Ins_IsFamilyHead");

                entity.Property(e => e.InsIsFirstServicePoint).HasColumnName("Ins_IsFirstServicePoint");

                entity.Property(e => e.InsNshiNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ins_NshiNumber");

                entity.Property(e => e.InsuranceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.SubscriberDob)
                    .HasColumnType("datetime")
                    .HasColumnName("SubscriberDOB");

                entity.Property(e => e.SubscriberFirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubscriberGender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubscriberIdcardNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SubscriberIDCardNumber");

                entity.Property(e => e.SubscriberIdcardType).HasColumnName("SubscriberIDCardType");

                entity.Property(e => e.SubscriberLastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.InsuranceProvider)
                    .WithMany(p => p.PatPatientInsuranceInfos)
                    .HasForeignKey(d => d.InsuranceProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAT_Patie__Insur__7FABD173");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatPatientInsuranceInfos)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientInsuranceInfo_PAT_Patient");
            });

            modelBuilder.Entity<PatPatientKinOrEmergencyContact>(entity =>
            {
                entity.HasKey(e => e.PatientKinOrEmergencyContactId);

                entity.ToTable("PAT_PatientKinOrEmergencyContacts");

                entity.Property(e => e.KinComment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.KinContactType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.KinFirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.KinLastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.KinPhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RelationShip)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatPatientKinOrEmergencyContacts)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientKinOrEmergencyContacts_PAT_Patient");
            });

            modelBuilder.Entity<PatPatientMembership>(entity =>
            {
                entity.HasKey(e => e.PatientMembershipId);

                entity.ToTable("PAT_PatientMembership");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PatPatientMembershipCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientMembership_CreatedBy_EMP_Employee");

                entity.HasOne(d => d.MembershipType)
                    .WithMany(p => p.PatPatientMemberships)
                    .HasForeignKey(d => d.MembershipTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientMembership_PAT_CFG_MembershipType");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PatPatientMembershipModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_PAT_PatientMembership_ModifiedBy_EMP_Employee");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatPatientMemberships)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientMembership_PAT_Patient");
            });

            modelBuilder.Entity<PatPatientVisit>(entity =>
            {
                entity.HasKey(e => e.PatientVisitId);

                entity.ToTable("PAT_PatientVisits");

                entity.HasIndex(e => new { e.InsHasInsurance, e.VisitDate }, "IX_TblVisit_HasInsurance_VisitDate");

                entity.HasIndex(e => e.PatientId, "IX_TblVisit_PatientId");

                entity.HasIndex(e => e.ClaimCode, "IX_TblVisits_ClaimCode");

                entity.Property(e => e.AppointmentType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillingStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.ConcludeDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.InsHasInsurance).HasColumnName("Ins_HasInsurance");

                entity.Property(e => e.IsVisitContinued).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QueueStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReferredByProvider)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.VisitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VisitDate).HasColumnType("datetime");

                entity.Property(e => e.VisitStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VisitType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PatPatientVisits)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Pat_PatientVisits_CreatedBy_EMP_Employee");

                entity.HasOne(d => d.ParentVisit)
                    .WithMany(p => p.InverseParentVisit)
                    .HasForeignKey(d => d.ParentVisitId)
                    .HasConstraintName("FK_PAT_PatientVisits_Self");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatPatientVisits)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAT_PatientVisits_PAT_Patient");
            });

            modelBuilder.Entity<PatSsuInformation>(entity =>
            {
                entity.HasKey(e => e.SsuInfoId)
                    .HasName("PK__PAT_SSU___96920B58DDB287F6");

                entity.ToTable("PAT_SSU_Information");

                entity.Property(e => e.SsuInfoId).HasColumnName("SSU_InfoId");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IncomeSource)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PatFamilyFinancialStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TargetGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TgCertificateNo)
                    .HasMaxLength(255)
                    .HasColumnName("TG_CertificateNo");

                entity.Property(e => e.TgCertificateType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TG_CertificateType");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatSsuInformations)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAT_SSU_I__Patie__2D350706");
            });

            modelBuilder.Entity<PhrmBilTransaction>(entity =>
            {
                entity.HasKey(e => e.BilTransactionId)
                    .HasName("PK_PHRM_Bil_Transaction");

                entity.ToTable("PHRM_BIL_Transaction");

                entity.Property(e => e.AmountFromDeposit).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.BilStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VATAmount");

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");

                entity.HasOne(d => d.Counter)
                    .WithMany(p => p.PhrmBilTransactions)
                    .HasForeignKey(d => d.CounterId)
                    .HasConstraintName("FK_PHRM_BIL_Transaction_CounterId_PHRM_MST_Counter_CounterId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmBilTransactions)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_BIL_Transaction_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PhrmBilTransactions)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_PHRM_BIL_Transaction_PatientId_PAT_Patient_PatientId");
            });

            modelBuilder.Entity<PhrmBilTransactionItem>(entity =>
            {
                entity.HasKey(e => e.BilTransactionItemId)
                    .HasName("PK_PHRM_Bil_TransactionItems");

                entity.ToTable("PHRM_BIL_TransactionItem");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPrice).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SellingPrice).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VATAmount");

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");

                entity.HasOne(d => d.BilTransaction)
                    .WithMany(p => p.PhrmBilTransactionItems)
                    .HasForeignKey(d => d.BilTransactionId)
                    .HasConstraintName("FK_PHRM_BIL_TransactionItem_BilTransactionId_PHRM_BIL_Transaction_BilTransactionId");

                entity.HasOne(d => d.Counter)
                    .WithMany(p => p.PhrmBilTransactionItems)
                    .HasForeignKey(d => d.CounterId)
                    .HasConstraintName("FK_PHRM_BIL_TransactionItem_CounterId_PHRM_MST_Counter_CounterId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmBilTransactionItems)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_BIL_TransactionItem_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PhrmBilTransactionItems)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_PHRM_BIL_TransactionItem_PatientId_PAT_Patient_PatientId");
            });

            modelBuilder.Entity<PhrmCfgFiscalYear>(entity =>
            {
                entity.HasKey(e => e.FiscalYearId)
                    .HasName("PK_PHRM_CFG_FiscalYear");

                entity.ToTable("PHRM_CFG_FiscalYears");

                entity.HasIndex(e => e.FiscalYearName, "UK_PHRM_CFG_FiscalYear")
                    .IsUnique();

                entity.Property(e => e.ClosedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FiscalYearName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NpFiscalYearName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PhrmDeposit>(entity =>
            {
                entity.HasKey(e => e.DepositId);

                entity.ToTable("PHRM_Deposit");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DepositType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDetails).IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PhrmDeposits)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_Deposit_PHRM_MST_Store");
            });

            modelBuilder.Entity<PhrmDispensaryStock>(entity =>
            {
                entity.HasKey(e => e.StockId);

                entity.ToTable("PHRM_DispensaryStock");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<PhrmExpiryDateBatchNoHistory>(entity =>
            {
                entity.HasKey(e => e.PhrmexpBatchHistoryId)
                    .HasName("PK_Phrm_Exp_Batch_History");

                entity.ToTable("PHRM_ExpiryDate_BatchNo_History");

                entity.Property(e => e.PhrmexpBatchHistoryId).HasColumnName("PHRMExpBatchHistoryId");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.OldBatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OldExpiryDate).HasColumnType("datetime");

                entity.HasOne(d => d.StoreStock)
                    .WithMany(p => p.PhrmExpiryDateBatchNoHistories)
                    .HasForeignKey(d => d.StoreStockId)
                    .HasConstraintName("FK_Phrm_Exp_Batch_History_StoreStockId_PHRM_StoreStock_StoreStockId");
            });

            modelBuilder.Entity<PhrmFiscalYearStock>(entity =>
            {
                entity.HasKey(e => e.FiscalYearStockId);

                entity.ToTable("PHRM_FiscalYearStock");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedOn).HasPrecision(3);

                entity.Property(e => e.ExpiryDate).HasPrecision(3);

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmFiscalYearStocks)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_FiscalYearStock_EMP_Employee");

                entity.HasOne(d => d.FiscalYear)
                    .WithMany(p => p.PhrmFiscalYearStocks)
                    .HasForeignKey(d => d.FiscalYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_FiscalYearStock_PHRM_CFG_FiscalYears");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PhrmFiscalYearStocks)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_FiscalYearStock_PHRM_MST_Item");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.PhrmFiscalYearStocks)
                    .HasForeignKey(d => d.StockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_FiscalYearStock_PHRM_TXN_Stock");
            });

            modelBuilder.Entity<PhrmGoodsReceipt>(entity =>
            {
                entity.HasKey(e => e.GoodReceiptId);

                entity.ToTable("PHRM_GoodsReceipt");

                entity.Property(e => e.Adjustment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CancelOn).HasPrecision(3);

                entity.Property(e => e.CancelRemarks).HasMaxLength(200);

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.GoodReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsItemDiscountApplicable).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPacking).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTransferredToAcc).HasColumnName("IsTransferredToACC");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.SupplierBillDate).HasPrecision(3);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VATAmount");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmGoodsReceipts)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_GoodsReceipt_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PhrmGoodsReceipts)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("FK_PHRM_GoodsReceipt_PurchaseOrderId_PHRM_PurchaseOrder_PurchaseOrderId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PhrmGoodsReceipts)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_PHRM_GoodsReceipt_SupplierId_PHRM_MST_Supplier_SupplierId");
            });

            modelBuilder.Entity<PhrmGoodsReceiptItem>(entity =>
            {
                entity.HasKey(e => e.GoodReceiptItemId);

                entity.ToTable("PHRM_GoodsReceiptItems");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cccharge).HasColumnName("CCCharge");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.GrPerItemDisAmt).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.GrPerItemVatamt)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("GrPerItemVATAmt");

                entity.Property(e => e.GrTotalDisAmt).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.GritemPrice)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("GRItemPrice");

                entity.Property(e => e.IsItemDiscountApplicable).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPacking).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTransferredToAcc).HasColumnName("IsTransferredToACC");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.SellingPrice).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.StripMrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("StripMRP");

                entity.Property(e => e.StripRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Uomname)
                    .HasMaxLength(100)
                    .HasColumnName("UOMName");

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmGoodsReceiptItems)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_GoodsReceiptItems_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.GoodReceipt)
                    .WithMany(p => p.PhrmGoodsReceiptItems)
                    .HasForeignKey(d => d.GoodReceiptId)
                    .HasConstraintName("FK_PHRM_GoodsReceiptItems_GoodreceiptId_PHRM_GoodsReceipt_GoodReceiptId");

                entity.HasOne(d => d.StoreStock)
                    .WithMany(p => p.PhrmGoodsReceiptItems)
                    .HasForeignKey(d => d.StoreStockId)
                    .HasConstraintName("PHRM_GoodsReceiptItems_PHRM_TXN_StoreStock");
            });

            modelBuilder.Entity<PhrmHistoryItem>(entity =>
            {
                entity.HasKey(e => e.HistoryItemId);

                entity.ToTable("PHRM_History_Item");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsVatapplicable).HasColumnName("IsVATApplicable");

                entity.Property(e => e.ItemCode).HasMaxLength(100);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SellingPrice).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.StandardPrice).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Uomid).HasColumnName("UOMId");

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PhrmHistoryItems)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_PHRM_History_Item_CompanyId_PHRM_MST_Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmHistoryItems)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_History_Item_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.PhrmHistoryItems)
                    .HasForeignKey(d => d.ItemTypeId)
                    .HasConstraintName("FK_PHRM_History_Item_ItemTypeId_PHRM_MST_ItemType_ItemTypeId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PhrmHistoryItems)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_PHRM_History_Item_SupplierId_PHRM_MST_Supplier_SupplierId");

                entity.HasOne(d => d.Uom)
                    .WithMany(p => p.PhrmHistoryItems)
                    .HasForeignKey(d => d.Uomid)
                    .HasConstraintName("FK_PHRM_History_Item_UOMId_PHRM_MST_UnitOfMeasurement_UOMId");
            });

            modelBuilder.Entity<PhrmHistoryStockBatchExpiry>(entity =>
            {
                entity.HasKey(e => e.PhrmstockBatchExpiryHistoryId)
                    .HasName("PHRM_StockHistory_BatchExpiry");

                entity.ToTable("PHRM_History_StockBatchExpiry");

                entity.Property(e => e.PhrmstockBatchExpiryHistoryId).HasColumnName("PHRMStockBatchExpiryHistoryId");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasPrecision(3);

                entity.Property(e => e.ExpiryDate).HasPrecision(3);

                entity.Property(e => e.StartDate).HasPrecision(3);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmHistoryStockBatchExpiries)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PHRM_History_StockBatchExpiry_EMP_Employee");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.PhrmHistoryStockBatchExpiries)
                    .HasForeignKey(d => d.StockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PHRM_History_StockBatchExpiry_PHRM_MST_Stock");
            });

            modelBuilder.Entity<PhrmHistoryStockMrp>(entity =>
            {
                entity.HasKey(e => e.PhrmstockMrphistoryId)
                    .HasName("PHRM_StockHistory_MRP");

                entity.ToTable("PHRM_History_StockMRP");

                entity.Property(e => e.PhrmstockMrphistoryId).HasColumnName("PHRMStockMRPHistoryId");

                entity.Property(e => e.EndDate).HasPrecision(3);

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.StartDate).HasPrecision(3);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmHistoryStockMrps)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PHRM_History_StockMRP_EMP_Employee");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.PhrmHistoryStockMrps)
                    .HasForeignKey(d => d.StockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PHRM_History_StockMRP_PHRM_MST_Stock");
            });

            modelBuilder.Entity<PhrmMapGenericDosaseNfreq>(entity =>
            {
                entity.HasKey(e => e.GenericDosageMapId);

                entity.ToTable("PHRM_MAP_GenericDosaseNFreq");

                entity.Property(e => e.Dosage)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FreqInWords)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GenericName)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PhrmMstCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_PHRM_Category");

                entity.ToTable("PHRM_MST_Category");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmMstCategories)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_MST_Category_CreatedBy_EMP_Employee_EmployeeId");
            });

            modelBuilder.Entity<PhrmMstCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("PHRM_MST_Company");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddress).HasMaxLength(200);

                entity.Property(e => e.ContactNo).HasMaxLength(20);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmMstCompanies)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_MST_Company_CreatedBy_EMP_Employee_EmployeeId");
            });

            modelBuilder.Entity<PhrmMstCounter>(entity =>
            {
                entity.HasKey(e => e.CounterId);

                entity.ToTable("PHRM_MST_Counter");

                entity.Property(e => e.BeginningDate).HasColumnType("datetime");

                entity.Property(e => e.ClosingDate).HasColumnType("datetime");

                entity.Property(e => e.CounterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CounterType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmMstCounters)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_MST_Counter_StoerId_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PhrmMstCounters)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_PHRM_MST_Counter_StoerId_PHRM_MST_Store_StoreId");
            });

            modelBuilder.Entity<PhrmMstCreditOrganization>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PHRM_MST_Credit_Organization");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OrganizationId).ValueGeneratedOnAdd();

                entity.Property(e => e.OrganizationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PhrmMstDispensary>(entity =>
            {
                entity.HasKey(e => e.DispensaryId)
                    .HasName("PK__PHRM_MST__88BDA5683032E1D9");

                entity.ToTable("PHRM_MST_Dispensary");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DispensaryDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DispensaryLabel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PhrmMstGeneric>(entity =>
            {
                entity.HasKey(e => e.GenericId);

                entity.ToTable("PHRM_MST_Generic");

                entity.Property(e => e.Counseling).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.GeneralCategory).HasMaxLength(200);

                entity.Property(e => e.GenericName).HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.TherapeuticCategory).HasMaxLength(200);
            });

            modelBuilder.Entity<PhrmMstItem>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK_PHRM_Mst_Item");

                entity.ToTable("PHRM_MST_Item");

                entity.Property(e => e.Abccategory)
                    .HasMaxLength(100)
                    .HasColumnName("ABCCategory");

                entity.Property(e => e.Cccharge).HasColumnName("CCCharge");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dosage)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GovtInsurancePrice).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.IsVatapplicable).HasColumnName("IsVATApplicable");

                entity.Property(e => e.ItemCode).HasMaxLength(100);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PurchaseVatpercentage).HasColumnName("PurchaseVATPercentage");

                entity.Property(e => e.SalesVatpercentage).HasColumnName("SalesVATPercentage");

                entity.Property(e => e.Uomid).HasColumnName("UOMId");

                entity.Property(e => e.Ved)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VED");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PhrmMstItems)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_PHRM_MST_Item_CompanyId_PHRM_MST_Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmMstItemCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_MST_Item_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.Generic)
                    .WithMany(p => p.PhrmMstItems)
                    .HasForeignKey(d => d.GenericId)
                    .HasConstraintName("FK_PHRM_MST_Item_MST_Generic");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.PhrmMstItems)
                    .HasForeignKey(d => d.ItemTypeId)
                    .HasConstraintName("FK_PHRM_MST_Item_ItemTypeId_PHRM_MST_ItemType_ItemTypeId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PhrmMstItemModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_PHRM_MST_Item_ModifiedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.PackingType)
                    .WithMany(p => p.PhrmMstItems)
                    .HasForeignKey(d => d.PackingTypeId)
                    .HasConstraintName("FK__PHRM_MST___Packi__633C11FC");

                entity.HasOne(d => d.Uom)
                    .WithMany(p => p.PhrmMstItems)
                    .HasForeignKey(d => d.Uomid)
                    .HasConstraintName("FK_PHRM_MST_Item_UOMId_PHRM_MST_UnitOfMeasurement_UOMId");
            });

            modelBuilder.Entity<PhrmMstItemType>(entity =>
            {
                entity.HasKey(e => e.ItemTypeId);

                entity.ToTable("PHRM_MST_ItemType");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PhrmMstItemTypes)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_PHRM_MST_ItemType_CategoryId_PHRM_MST_Category_CategoryId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmMstItemTypes)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_MST_ItemType_CreatedBy_EMP_Employee_EmployeeId");
            });

            modelBuilder.Entity<PhrmMstPackingType>(entity =>
            {
                entity.HasKey(e => e.PackingTypeId)
                    .HasName("PK__PHRM_MST__54E6175F32ACABEF");

                entity.ToTable("PHRM_MST_PackingType");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PackingName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PhrmMstRack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PHRM_MST_Rack");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.RackId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__PHRM_MST___Creat__11757BF3");
            });

            modelBuilder.Entity<PhrmMstSalesCategory>(entity =>
            {
                entity.HasKey(e => e.SalesCategoryId)
                    .HasName("PK__PHRM_MST__07F9C5B418EAC7A5");

                entity.ToTable("PHRM_MST_SalesCategory");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PhrmMstStock>(entity =>
            {
                entity.HasKey(e => e.StockId);

                entity.ToTable("PHRM_MST_Stock");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasPrecision(3);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MRP");

                entity.HasOne(d => d.Barcode)
                    .WithMany(p => p.PhrmMstStocks)
                    .HasForeignKey(d => d.BarcodeId)
                    .HasConstraintName("FK_PHRM_MST_Stock_PHRM_MST_StockBarcode");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmMstStockCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PhrmMstStocks)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_MST_Stock_PHRM_MST_Item");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PhrmMstStockModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<PhrmMstStockBarcode>(entity =>
            {
                entity.HasKey(e => e.BarcodeId)
                    .HasName("PK__PHRM_MST__21916CA87F11C039");

                entity.ToTable("PHRM_MST_StockBarcode");

                entity.Property(e => e.BarcodeId).ValueGeneratedNever();

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasPrecision(3);

                entity.Property(e => e.ExpiryDate).HasPrecision(3);

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MRP");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PhrmMstStockBarcodes)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_MST_StockBarcode_PHRM_MST_Item");
            });

            modelBuilder.Entity<PhrmMstStore>(entity =>
            {
                entity.HasKey(e => e.StoreId);

                entity.ToTable("PHRM_MST_Store");

                entity.HasIndex(e => e.Name, "UC_PHRM_MST_STORE_StoreName")
                    .IsUnique();

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AvailablePaymentModesJson)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("AvailablePaymentModesJSON");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DefaultPaymentMode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.InvGrgroupId).HasColumnName("INV_GRGroupId");

                entity.Property(e => e.InvPogroupId).HasColumnName("INV_POGroupId");

                entity.Property(e => e.InvPrgroupId).HasColumnName("INV_PRGroupId");

                entity.Property(e => e.InvReceiptDisplayName)
                    .HasMaxLength(100)
                    .HasColumnName("INV_ReceiptDisplayName");

                entity.Property(e => e.InvReceiptNoCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("INV_ReceiptNoCode");

                entity.Property(e => e.InvReqDisGroupId).HasColumnName("INV_ReqDisGroupId");

                entity.Property(e => e.InvRfqgroupId).HasColumnName("INV_RFQGroupId");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PanNo).HasMaxLength(100);

                entity.Property(e => e.PermissionId).HasDefaultValueSql("((0))");

                entity.Property(e => e.StoreDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StoreLabel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmMstStores)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_MST_Store_CreatedBy_EMP_Employee_EmployeeId");
            });

            modelBuilder.Entity<PhrmMstSupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.ToTable("PHRM_MST_Supplier");

                entity.Property(e => e.AdditionalContactInformation)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddress).HasMaxLength(200);

                entity.Property(e => e.ContactNo).HasMaxLength(20);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DDA");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Pannumber)
                    .HasMaxLength(50)
                    .HasColumnName("PANNumber");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmMstSuppliers)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_MST_Supplier_CreatedBy_EMP_Employee_EmployeeId");
            });

            modelBuilder.Entity<PhrmMstTax>(entity =>
            {
                entity.HasKey(e => e.Taxid);

                entity.ToTable("PHRM_MST_TAX");

                entity.Property(e => e.Taxid).HasColumnName("TAXId");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Taxname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TAXName");

                entity.Property(e => e.Taxpercentage).HasColumnName("TAXPercentage");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmMstTaxes)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_MST_TAX_CreatedBy_EMP_Employee_EmployeeId");
            });

            modelBuilder.Entity<PhrmMstUnitOfMeasurement>(entity =>
            {
                entity.HasKey(e => e.Uomid);

                entity.ToTable("PHRM_MST_UnitOfMeasurement");

                entity.Property(e => e.Uomid).HasColumnName("UOMId");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Uomname)
                    .HasMaxLength(100)
                    .HasColumnName("UOMName");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmMstUnitOfMeasurements)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_MST_UnitOfMeasurement_CreatedBy_EMP_Employee_EmployeeId");
            });

            modelBuilder.Entity<PhrmNarcoticSaleRecord>(entity =>
            {
                entity.HasKey(e => e.NarcoticRecordId)
                    .HasName("PK__PHRM_Nar__441C3D951AEDE751");

                entity.ToTable("PHRM_NarcoticSaleRecord");

                entity.Property(e => e.Batch)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImgUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nmcnumber)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NMCNumber");
            });

            modelBuilder.Entity<PhrmPrescription>(entity =>
            {
                entity.HasKey(e => e.PrescriptionId);

                entity.ToTable("PHRM_Prescription");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.PrescriptionStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderFullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmPrescriptionCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_Prescription_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PhrmPrescriptions)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_PHRM_Prescription_PatientId_PAT_Patient_PatientId");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.PhrmPrescriptionProviders)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("FK_PHRM_Prescription_ProviderId_EMP_Employee_EmployeeId");
            });

            modelBuilder.Entity<PhrmPrescriptionItem>(entity =>
            {
                entity.HasKey(e => e.PrescriptionItemId);

                entity.ToTable("PHRM_PrescriptionItems");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dosage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmPrescriptionItems)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_PrescriptionItems_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.Diagnosis)
                    .WithMany(p => p.PhrmPrescriptionItems)
                    .HasForeignKey(d => d.DiagnosisId)
                    .HasConstraintName("FK_PHRM_PrescriptionItems_CLN_Disgnosis");
            });

            modelBuilder.Entity<PhrmPurchaseOrder>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderId);

                entity.ToTable("PHRM_PurchaseOrder");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasPrecision(3);

                entity.Property(e => e.Podate)
                    .HasColumnType("datetime")
                    .HasColumnName("PODate");

                entity.Property(e => e.Postatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("POStatus");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.Subtotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VATAmount");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmPurchaseOrders)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_Purchaseorder_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.FiscalYear)
                    .WithMany(p => p.PhrmPurchaseOrders)
                    .HasForeignKey(d => d.FiscalYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PHRM_PurchaseOrder_PHRM_CFG_FiscalYears");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PhrmPurchaseOrders)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_PHRM_PurchaseOrder_SupplierId_PHRM_MST_Supplier_SupplierId");
            });

            modelBuilder.Entity<PhrmPurchaseOrderItem>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderItemId);

                entity.ToTable("PHRM_PurchaseOrderItems");

                entity.Property(e => e.AuthorizedOn).HasColumnType("datetime");

                entity.Property(e => e.AuthorizedRemark).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasPrecision(3);

                entity.Property(e => e.PoitemStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("POItemStatus");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.StandaredPrice).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VATAmount");

                entity.HasOne(d => d.AuthorizedByNavigation)
                    .WithMany(p => p.PhrmPurchaseOrderItemAuthorizedByNavigations)
                    .HasForeignKey(d => d.AuthorizedBy)
                    .HasConstraintName("FK_PHRM_PurchaseOrderItems_AuthorizedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmPurchaseOrderItemCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_PurchaseOrderItems_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PhrmPurchaseOrderItems)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("FK_PHRM_PurchaseOrderItems_PurchaseOrderId_PHRM_PurchaseOrder_PurchaseOrderId");
            });

            modelBuilder.Entity<PhrmRequisition>(entity =>
            {
                entity.HasKey(e => e.RequisitionId);

                entity.ToTable("PHRM_Requisition");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ReferenceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Comman seperated id of table PHRM_SaleItems");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PhrmRequisitions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_Requisition_PAT_Patient");
            });

            modelBuilder.Entity<PhrmRequisitionItem>(entity =>
            {
                entity.HasKey(e => e.RequisitionItemId);

                entity.ToTable("PHRM_RequisitionItems");

                entity.HasOne(d => d.Requisition)
                    .WithMany(p => p.PhrmRequisitionItems)
                    .HasForeignKey(d => d.RequisitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_RequisitionItems_PHRM_Requisition");
            });

            modelBuilder.Entity<PhrmReturnToSupplier>(entity =>
            {
                entity.HasKey(e => e.ReturnToSupplierId)
                    .HasName("PK_PHRM_ReturnToSupplier_1");

                entity.ToTable("PHRM_ReturnToSupplier");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreditNoteId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.IsTransferredToAcc).HasColumnName("IsTransferredToACC");

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VATAmount");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmReturnToSuppliers)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_ReturnToSupplier_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.GoodReceipt)
                    .WithMany(p => p.PhrmReturnToSuppliers)
                    .HasForeignKey(d => d.GoodReceiptId)
                    .HasConstraintName("FK_PHRM_ReturnToSupplier_GoodReceiptId_PHRM_GoodsReceipt_GoodReceiptId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PhrmReturnToSuppliers)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_ReturnToSupplier_SupplierId_PHRM_MST_Supplier_SupplierId");
            });

            modelBuilder.Entity<PhrmReturnToSupplierItem>(entity =>
            {
                entity.HasKey(e => e.ReturnToSupplierItemId);

                entity.ToTable("PHRM_ReturnToSupplierItems");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiscountedAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.FreeAmount).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.FreeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemPrice).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.OldItemPrice).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.ReturnRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmReturnToSupplierItems)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_ReturnToSupplierItems_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.GoodReceiptItem)
                    .WithMany(p => p.PhrmReturnToSupplierItems)
                    .HasForeignKey(d => d.GoodReceiptItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_ReturnToSupplierItems_GoodReceiptItemId_PHRM_GoodsReceiptItems_GoodReceiptItemId");

                entity.HasOne(d => d.ReturnToSupplier)
                    .WithMany(p => p.PhrmReturnToSupplierItems)
                    .HasForeignKey(d => d.ReturnToSupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_ReturnToSupplierItems_ReturnToSupplierId_PHRM_ReturnToSupplier_ReturnToSupplierId");
            });

            modelBuilder.Entity<PhrmSaleItem>(entity =>
            {
                entity.HasKey(e => e.SaleItemId);

                entity.ToTable("PHRM_SaleItems");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ManufactureDate).HasColumnType("datetime");

                entity.Property(e => e.SellingPrice).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Uomname)
                    .HasMaxLength(100)
                    .HasColumnName("UOMName");

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmSaleItems)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_SaleItems_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PhrmSaleItems)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_PHRM_SaleItems_PatientId_PAT_Patient_PatientId");

                entity.HasOne(d => d.PrescriptionItems)
                    .WithMany(p => p.PhrmSaleItems)
                    .HasForeignKey(d => d.PrescriptionItemsId)
                    .HasConstraintName("FK_PHRM_SaleItems_PrescriptionItemsId_PHRM_PrescriptionItems_PrescriptionItemsId");
            });

            modelBuilder.Entity<PhrmSaleItemsReturn>(entity =>
            {
                entity.HasKey(e => e.SaleItemReturnId);

                entity.ToTable("PHRM_SaleItemsReturn");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.ReturnRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SellingPrice).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmSaleItemsReturns)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_SaleItemsReturn_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PhrmSaleItemsReturns)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_PHRM_SaleItemsReturn_PatientId_PAT_Patient_PatientId");

                entity.HasOne(d => d.SaleItem)
                    .WithMany(p => p.PhrmSaleItemsReturns)
                    .HasForeignKey(d => d.SaleItemId)
                    .HasConstraintName("FK_PHRM_SaleItemsReturn_SaleItemId_PHRM_SaleItems_SaleItemId");
            });

            modelBuilder.Entity<PhrmStock>(entity =>
            {
                entity.HasKey(e => e.StockId);

                entity.ToTable("PHRM_Stock");

                entity.Property(e => e.BatchNo).IsUnicode(false);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Mrp).HasColumnName("MRP");
            });

            modelBuilder.Entity<PhrmStockManage>(entity =>
            {
                entity.HasKey(e => e.StockManageId);

                entity.ToTable("PHRM_StockManage");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.InOut)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Price).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmStockManages)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_StockManage_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.StockTxnItem)
                    .WithMany(p => p.PhrmStockManages)
                    .HasForeignKey(d => d.StockTxnItemId)
                    .HasConstraintName("FK_PHRM_StockManage_StockTxnItemId_PHRM_StockTxnItems_StockTxnItemId");
            });

            modelBuilder.Entity<PhrmStockTxnItem>(entity =>
            {
                entity.HasKey(e => e.StockTxnItemId);

                entity.ToTable("PHRM_StockTxnItems");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cccharge).HasColumnName("CCCharge");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.InOut)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsTransferredToAcc).HasColumnName("IsTransferredToACC");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReferenceItemCreatedOn).HasColumnType("datetime");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmStockTxnItems)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_StockTxnItems_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.GoodsReceiptItem)
                    .WithMany(p => p.PhrmStockTxnItems)
                    .HasForeignKey(d => d.GoodsReceiptItemId)
                    .HasConstraintName("FK_PHRM_StockTxnItems_GoodsReceiptItemId_PHRM_GoodsReceiptItems_GoodsReceiptItemId");
            });

            modelBuilder.Entity<PhrmStockTxnItemsMrphistory>(entity =>
            {
                entity.HasKey(e => e.PhrmstockTxnItemMrphistoryId);

                entity.ToTable("PHRM_StockTxnItems_MRPHistory");

                entity.Property(e => e.PhrmstockTxnItemMrphistoryId).HasColumnName("PHRMStockTxnItemMRPHistoryId");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.OldMrp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("oldMRP");

                entity.Property(e => e.PhrmstockTxnItemId).HasColumnName("PHRMStockTxnItemId");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.StoreStock)
                    .WithMany(p => p.PhrmStockTxnItemsMrphistories)
                    .HasForeignKey(d => d.StoreStockId)
                    .HasConstraintName("FK_PHRM_StockTxnItems_MRPHistory_StoreStockId_PHRM_StoreStock_StoreStockId");
            });

            modelBuilder.Entity<PhrmStoreDispatchItem>(entity =>
            {
                entity.HasKey(e => e.DispatchItemsId)
                    .HasName("PK__PHRM_Sto__77C34E516771FEB9");

                entity.ToTable("PHRM_StoreDispatchItems");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DispatchedDate).HasPrecision(3);

                entity.Property(e => e.ExpiryDate).HasPrecision(3);

                entity.Property(e => e.ItemRemarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.ReceivedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedOn).HasPrecision(3);

                entity.Property(e => e.ReceivedRemarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Requisition)
                    .WithMany(p => p.PhrmStoreDispatchItems)
                    .HasForeignKey(d => d.RequisitionId)
                    .HasConstraintName("FK_PHRM_StoreDispatchedItems_PHRM_StoreRequisition");

                entity.HasOne(d => d.SourceStore)
                    .WithMany(p => p.PhrmStoreDispatchItemSourceStores)
                    .HasForeignKey(d => d.SourceStoreId)
                    .HasConstraintName("FK_PHRM_StoreDispatchItems_SourceStoreId_PHRM_MST_Store");

                entity.HasOne(d => d.TargetStore)
                    .WithMany(p => p.PhrmStoreDispatchItemTargetStores)
                    .HasForeignKey(d => d.TargetStoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_StoreDispatchItems_TargetStoreId_PHRM_MST_Store");
            });

            modelBuilder.Entity<PhrmStoreRequisition>(entity =>
            {
                entity.HasKey(e => e.RequisitionId)
                    .HasName("PK__PHRM_Sto__C347822F887294C5");

                entity.ToTable("PHRM_StoreRequisition");

                entity.Property(e => e.ApprovedOn).HasPrecision(3);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.RequisitionDate).HasColumnType("datetime");

                entity.Property(e => e.RequisitionStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.FiscalYear)
                    .WithMany(p => p.PhrmStoreRequisitions)
                    .HasForeignKey(d => d.FiscalYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PHRM_StoreRequisition_PHRM_CFG_FiscalYears");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PhrmStoreRequisitions)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_StoreRequisition_PHRM_MST_Store");
            });

            modelBuilder.Entity<PhrmStoreRequisitionItem>(entity =>
            {
                entity.HasKey(e => e.RequisitionItemId)
                    .HasName("PK__PHRM_Sto__8E7AAC997C0B7C4C");

                entity.ToTable("PHRM_StoreRequisitionItems");

                entity.Property(e => e.AuthorizedOn).HasColumnType("datetime");

                entity.Property(e => e.AuthorizedRemark).HasMaxLength(500);

                entity.Property(e => e.CancelRemarks).HasMaxLength(400);

                entity.Property(e => e.CancelledOn).HasPrecision(3);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasColumnType("text");

                entity.Property(e => e.RequisitionItemStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PhrmStoreStock>(entity =>
            {
                entity.HasKey(e => e.StoreStockId);

                entity.ToTable("PHRM_StoreStock");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cccharge).HasColumnName("CCCharge");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.InOut)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReferenceItemCreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.StoreName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");
            });

            modelBuilder.Entity<PhrmTxnDispensaryStock>(entity =>
            {
                entity.HasKey(e => e.DispensaryStockId);

                entity.ToTable("PHRM_TXN_DispensaryStock");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedOn).HasPrecision(3);

                entity.Property(e => e.ExpiryDate).HasPrecision(3);

                entity.Property(e => e.ModifiedOn).HasPrecision(3);

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MRP");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmTxnDispensaryStockCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_DispensaryStock_EMP_Employee");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PhrmTxnDispensaryStocks)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_DispensaryStock_PHRM_MST_Item");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PhrmTxnDispensaryStockModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_PHRM_TXN_DispensaryStock_ModifiedBy_EMP_Employee");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.PhrmTxnDispensaryStocks)
                    .HasForeignKey(d => d.StockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_DispensaryStock_PHRM_TXN_Stock");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PhrmTxnDispensaryStocks)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_DispensaryStock_PHRM_MST_Store");
            });

            modelBuilder.Entity<PhrmTxnDispensaryStockTransaction>(entity =>
            {
                entity.HasKey(e => e.DispensaryStockTransactionId);

                entity.ToTable("PHRM_TXN_DispensaryStockTransaction");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedOn).HasPrecision(3);

                entity.Property(e => e.ExpiryDate).HasPrecision(3);

                entity.Property(e => e.InOut)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasPrecision(3);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmTxnDispensaryStockTransactions)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_DispensaryStockTransaction_EMP_Employee");

                entity.HasOne(d => d.FiscalYear)
                    .WithMany(p => p.PhrmTxnDispensaryStockTransactions)
                    .HasForeignKey(d => d.FiscalYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_DispensaryStockTransaction_PHRM_CFG_FiscalYears");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PhrmTxnDispensaryStockTransactions)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_DispensaryStockTransaction_PHRM_MST_Item");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.PhrmTxnDispensaryStockTransactions)
                    .HasForeignKey(d => d.StockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_DispensaryStockTransaction_PHRM_TXN_Stock");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PhrmTxnDispensaryStockTransactions)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_DispensaryStockTransaction_PHRM_MST_Store");
            });

            modelBuilder.Entity<PhrmTxnInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.ToTable("PHRM_TXN_Invoice");

                entity.Property(e => e.Adjustment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BilStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Change).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.CreditDate).HasColumnType("datetime");

                entity.Property(e => e.DepositDeductAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.IsTransferredToAcc).HasColumnName("IsTransferredToACC");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Tender).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VATAmount");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmTxnInvoices)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_TXN_Invoice_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PhrmTxnInvoices)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_PHRM_TXN_Invoice_PatientId_PAT_Patient_Patientid");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PhrmTxnInvoices)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_Invoice_PHRM_MST_Store");
            });

            modelBuilder.Entity<PhrmTxnInvoiceItem>(entity =>
            {
                entity.HasKey(e => e.InvoiceItemId);

                entity.ToTable("PHRM_TXN_InvoiceItems");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.BilItemStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.GenericName).HasMaxLength(200);

                entity.Property(e => e.GrItemPrice).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.PerItemDisAmt).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Price).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalDisAmt).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VATAmount");

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PhrmTxnInvoiceItems)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_PHRM_MST_Company_CompanyId_PHRM_MST_Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmTxnInvoiceItems)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_TXN_InvoiceItems_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.PhrmTxnInvoiceItems)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_PHRM_TXN_InvoiceItems_InvoiceId_PHRM_TXN_Invoice_InvoiceId");
            });

            modelBuilder.Entity<PhrmTxnInvoiceReturn>(entity =>
            {
                entity.HasKey(e => e.InvoiceReturnId)
                    .HasName("PKPHRM_TXN_InvoiceReturn");

                entity.ToTable("PHRM_TXN_InvoiceReturn");

                entity.Property(e => e.Adjustment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Change).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreditNoteId).HasColumnName("CreditNoteID");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.IsTransferredToAcc).HasColumnName("IsTransferredToACC");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceInvoiceDate).HasPrecision(3);

                entity.Property(e => e.ReferenceInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Tender).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VATAmount");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmTxnInvoiceReturns)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_TXN_InvoiceReturn_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.PhrmTxnInvoiceReturns)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_PHRM_TXN_InvoiceReturn_InvoiceId_PHRM_TXN_Invoice_InvoiceId");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PhrmTxnInvoiceReturns)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_InvoiceReturn_PHRM_MST_Store");
            });

            modelBuilder.Entity<PhrmTxnInvoiceReturnItem>(entity =>
            {
                entity.HasKey(e => e.InvoiceReturnItemId);

                entity.ToTable("PHRM_TXN_InvoiceReturnItems");

                entity.Property(e => e.BatchNo).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.IsTransferredToAcc).HasColumnName("IsTransferredToACC");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.PerItemDisAmt).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Price).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalDisAmt).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmTxnInvoiceReturnItems)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_PHRM_TXN_InvoiceItems_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.PhrmTxnInvoiceReturnItems)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_PHRM_TXN_InvoiceReturnItems_InvoiceId_PHRM_TXN_Invoice_InvoiceId");

                entity.HasOne(d => d.InvoiceItem)
                    .WithMany(p => p.PhrmTxnInvoiceReturnItems)
                    .HasForeignKey(d => d.InvoiceItemId)
                    .HasConstraintName("FK_PHRM_TXN_InvoiceReturnItems_InvoiceItemId_PHRM_TXN_InvoiceItems_InvoiceItemId");

                entity.HasOne(d => d.InvoiceReturn)
                    .WithMany(p => p.PhrmTxnInvoiceReturnItems)
                    .HasForeignKey(d => d.InvoiceReturnId)
                    .HasConstraintName("FK_PHRM_TXN_InvoiceReturnItems_InvoiceReturnId_PHRM_TXN_InvoiceReturn_InvoiceReturnId");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PhrmTxnInvoiceReturnItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_PHRM_TXN_InvoiceReturnItems_ItemId_PHRM_MST_Item_ItemId");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PhrmTxnInvoiceReturnItems)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_InvoiceReturnItems_PHRM_MST_Store");
            });

            modelBuilder.Entity<PhrmTxnSettlement>(entity =>
            {
                entity.HasKey(e => e.SettlementId);

                entity.ToTable("PHRM_TXN_Settlement");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.PaymentDetails)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementDate).HasColumnType("datetime");

                entity.Property(e => e.SettlementType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PhrmTxnSettlements)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_Settlement_PAT_Patient");
            });

            modelBuilder.Entity<PhrmTxnStock>(entity =>
            {
                entity.HasKey(e => e.StockId);

                entity.ToTable("PHRM_TXN_Stock");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedOn).HasPrecision(3);

                entity.Property(e => e.ExpiryDate).HasPrecision(3);

                entity.Property(e => e.ModifiedOn).HasPrecision(3);

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MRP");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmTxnStockCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_Stock_EMP_Employee");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PhrmTxnStocks)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_Stock_PHRM_MST_Item");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PhrmTxnStockModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_PHRM_TXN_Stock_ModifiedBy_EMP_Employee");
            });

            modelBuilder.Entity<PhrmTxnStockTransaction>(entity =>
            {
                entity.HasKey(e => e.StockTransactionId);

                entity.ToTable("PHRM_TXN_StockTransaction");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedOn).HasPrecision(3);

                entity.Property(e => e.ExpiryDate).HasPrecision(3);

                entity.Property(e => e.InOut)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasPrecision(3);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmTxnStockTransactions)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_StockTransaction_EMP_Employee");

                entity.HasOne(d => d.FiscalYear)
                    .WithMany(p => p.PhrmTxnStockTransactions)
                    .HasForeignKey(d => d.FiscalYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_StockTransaction_PHRM_CFG_FiscalYears");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PhrmTxnStockTransactions)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_StockTransaction_PHRM_MST_Item");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.PhrmTxnStockTransactions)
                    .HasForeignKey(d => d.StockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_StockTransaction_PHRM_MST_Stock");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PhrmTxnStockTransactions)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_PHRM_TXN_StockTransaction_PHRM_MST_Store");

                entity.HasOne(d => d.StoreStock)
                    .WithMany(p => p.PhrmTxnStockTransactions)
                    .HasForeignKey(d => d.StoreStockId)
                    .HasConstraintName("FK_PHRM_TXN_StockTransaction_PHRM_TXN_StoreStock");
            });

            modelBuilder.Entity<PhrmTxnStoreStock>(entity =>
            {
                entity.HasKey(e => e.StoreStockId);

                entity.ToTable("PHRM_TXN_StoreStock");

                entity.Property(e => e.UnConfirmedQtyIn).HasColumnName("UnConfirmedQty_In");

                entity.Property(e => e.UnConfirmedQtyOut).HasColumnName("UnConfirmedQty_Out");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PhrmTxnStoreStocks)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_PHRM_TXN_StoreStock_PHRM_MST_Item");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.PhrmTxnStoreStocks)
                    .HasForeignKey(d => d.StockId)
                    .HasConstraintName("FK_PHRM_TXN_StoreStock_PHRM_MST_Stock");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PhrmTxnStoreStocks)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_PHRM_TXN_StoreStock_PHRM_MST_Store");
            });

            modelBuilder.Entity<PhrmTxnSupplierLedger>(entity =>
            {
                entity.HasKey(e => e.LedgerId)
                    .HasName("PK__PHRM_TXN__AE70E0CF92A5CFB0");

                entity.ToTable("PHRM_TXN_SupplierLedger");

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedOn).HasPrecision(3);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ModifiedOn).HasPrecision(3);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PhrmTxnSupplierLedgers)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_SupplierLedger_PHRM_MST_Supplier");
            });

            modelBuilder.Entity<PhrmTxnSupplierLedgerTransaction>(entity =>
            {
                entity.HasKey(e => e.LedgerTransactionId)
                    .HasName("PK__PHRM_TXN__F2590091D059238B");

                entity.ToTable("PHRM_TXN_SupplierLedgerTransaction");

                entity.Property(e => e.CreatedOn).HasPrecision(3);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.FiscalYear)
                    .WithMany(p => p.PhrmTxnSupplierLedgerTransactions)
                    .HasForeignKey(d => d.FiscalYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_SupplierLedgerTransaction_PHRM_CFG_FiscalYears");

                entity.HasOne(d => d.Ledger)
                    .WithMany(p => p.PhrmTxnSupplierLedgerTransactions)
                    .HasForeignKey(d => d.LedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_SupplierLedgerTransaction_PHRM_TXN_SupplierLedger");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PhrmTxnSupplierLedgerTransactions)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_TXN_SupplierLedgerTransaction_PHRM_MST_Supplier");
            });

            modelBuilder.Entity<PhrmWriteOff>(entity =>
            {
                entity.HasKey(e => e.WriteOffId);

                entity.ToTable("PHRM_WriteOff");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.IsTransferredToAcc).HasColumnName("IsTransferredToACC");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VATAmount");

                entity.Property(e => e.WriteOffDate).HasColumnType("datetime");

                entity.Property(e => e.WriteOffRemark).HasMaxLength(500);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmWriteOffs)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_WriteOff_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PhrmWriteOffs)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_PHRM_WriteOff_PHRM_MST_Store");
            });

            modelBuilder.Entity<PhrmWriteOffItem>(entity =>
            {
                entity.HasKey(e => e.WriteOffItemId);

                entity.ToTable("PHRM_WriteOffItems");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.ItemPrice).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Vatpercentage)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("VATPercentage");

                entity.Property(e => e.WriteOffItemRemark).HasMaxLength(500);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhrmWriteOffItems)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_WriteOffItems_CreatedBy_EMP_Employee_EmployeeId");

                entity.HasOne(d => d.WriteOff)
                    .WithMany(p => p.PhrmWriteOffItems)
                    .HasForeignKey(d => d.WriteOffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHRM_WriteOffItems_WriteOffId_PHRM_WriteOff_WriteOffId");
            });

            modelBuilder.Entity<ProllAttendanceDailyTimeRecord>(entity =>
            {
                entity.ToTable("PROLL_AttendanceDailyTimeRecord");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeName).HasMaxLength(350);

                entity.Property(e => e.RecordDateTime).HasMaxLength(350);
            });

            modelBuilder.Entity<ProllDailyMuster>(entity =>
            {
                entity.HasKey(e => e.DailyMusterId)
                    .HasName("PK_PAY_DailyMuster");

                entity.ToTable("PROLL_DailyMuster");

                entity.Property(e => e.AttStatus).HasMaxLength(50);

                entity.Property(e => e.ColorCode).HasMaxLength(50);

                entity.Property(e => e.HoursInDay).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<ProllEmpLeave>(entity =>
            {
                entity.HasKey(e => e.EmpLeaveId);

                entity.ToTable("PROLL_EmpLeave");

                entity.Property(e => e.ApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.LeaveStatus)
                    .HasMaxLength(50)
                    .HasComment("Shows leave status of the employee like pending, cancel, approved, approvedCancel");
            });

            modelBuilder.Entity<ProllMstHoliday>(entity =>
            {
                entity.HasKey(e => e.HolidayId);

                entity.ToTable("PROLL_MST_Holidays");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<ProllMstLeaveCategory>(entity =>
            {
                entity.HasKey(e => e.LeaveCategoryId);

                entity.ToTable("PROLL_MST_LeaveCategory");

                entity.Property(e => e.CategoryCode).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.LeaveCategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<ProllMstLeaveRule>(entity =>
            {
                entity.HasKey(e => e.LeaveRuleId)
                    .HasName("PK_PROLL_MST_Leave");

                entity.ToTable("PROLL_MST_LeaveRules");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProllMstWeekendHoliday>(entity =>
            {
                entity.HasKey(e => e.WeekendHolidayId);

                entity.ToTable("PROLL_MST_WeekendHolidays");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DayName).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<RadCfgReportTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("PK_MST_Template");

                entity.ToTable("RAD_CFG_ReportTemplates");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FooterNote).HasMaxLength(2000);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateCode).HasMaxLength(50);

                entity.Property(e => e.TemplateHtml).HasColumnName("TemplateHTML");

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RadMstFilmType>(entity =>
            {
                entity.HasKey(e => e.FilmTypeId)
                    .HasName("PK__RAD_MST___51F8A59E392C77B6");

                entity.ToTable("RAD_MST_FilmType");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FilmType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FilmTypeDisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<RadMstImagingItem>(entity =>
            {
                entity.HasKey(e => e.ImagingItemId)
                    .HasName("PK__RAD_MST___274A183F3E88F63C");

                entity.ToTable("RAD_MST_ImagingItem");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ImagingItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsValidForReporting)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ProcedureCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.RadMstImagingItemCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_RAD_MST_ImagingItem_CreatedBy_EMP_Employee");

                entity.HasOne(d => d.ImagingType)
                    .WithMany(p => p.RadMstImagingItems)
                    .HasForeignKey(d => d.ImagingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MST_ImagingItem_MST_ImagingType");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.RadMstImagingItemModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_RAD_MST_ImagingItem__ModifiedBy_EMP_Employee");
            });

            modelBuilder.Entity<RadMstImagingType>(entity =>
            {
                entity.HasKey(e => e.ImagingTypeId)
                    .HasName("PK__RAD_MST___0877397C97248B51");

                entity.ToTable("RAD_MST_ImagingType");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ImagingTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ProcedureCoding)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.RadMstImagingTypeCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_RAD_MST_ImagingType_CreatedBy_EMP_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.RadMstImagingTypeModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_RAD_MST_ImagingType_ModifiedBy_EMP_Employee");
            });

            modelBuilder.Entity<RadPatientImagingReport>(entity =>
            {
                entity.HasKey(e => e.ImagingReportId)
                    .HasName("PK__RAD_Pati__61C0455E7F259BA3");

                entity.ToTable("RAD_PatientImagingReport");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ImageFullPath)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName).IsUnicode(false);

                entity.Property(e => e.ImagingItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImagingTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Indication).IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientStudyId).IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RadiologyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Signatories).HasMaxLength(4000);

                entity.HasOne(d => d.ImagingItem)
                    .WithMany(p => p.RadPatientImagingReports)
                    .HasForeignKey(d => d.ImagingItemId)
                    .HasConstraintName("FK_RAD_PatientImagingReport_MST_ImagingItem");

                entity.HasOne(d => d.ImagingRequisition)
                    .WithMany(p => p.RadPatientImagingReports)
                    .HasForeignKey(d => d.ImagingRequisitionId)
                    .HasConstraintName("FK_RAD_PatientImagingReport_RAD_PatientImagingRequest");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.RadPatientImagingReports)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_RAD_PatientImagingReport_PAT_Patient");

                entity.HasOne(d => d.PatientVisit)
                    .WithMany(p => p.RadPatientImagingReports)
                    .HasForeignKey(d => d.PatientVisitId)
                    .HasConstraintName("FK_RAD_PatientImagingReport_PAT_PatientVisits");
            });

            modelBuilder.Entity<RadPatientImagingRequisition>(entity =>
            {
                entity.HasKey(e => e.ImagingRequisitionId)
                    .HasName("PK__RAD_Pati__77DD8919B66A6532");

                entity.ToTable("RAD_PatientImagingRequisition");

                entity.Property(e => e.BillCancelledOn).HasColumnType("datetime");

                entity.Property(e => e.BillingStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ImagingDate).HasColumnType("datetime");

                entity.Property(e => e.ImagingItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImagingTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("('TRUE')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.RequisitionRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ScanRemarks)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ScannedOn).HasColumnType("datetime");

                entity.Property(e => e.Urgency)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WardName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Diagnosis)
                    .WithMany(p => p.RadPatientImagingRequisitions)
                    .HasForeignKey(d => d.DiagnosisId)
                    .HasConstraintName("FK_RAD_PatientImagingRequisition_CLN_Disgnosis");

                entity.HasOne(d => d.ImagingItem)
                    .WithMany(p => p.RadPatientImagingRequisitions)
                    .HasForeignKey(d => d.ImagingItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAD_PatientImagingRequest_MST_Item");

                entity.HasOne(d => d.PatientVisit)
                    .WithMany(p => p.RadPatientImagingRequisitions)
                    .HasForeignKey(d => d.PatientVisitId)
                    .HasConstraintName("FK_RAD_PatientImagingRequest_PAT_PatientVisits");
            });

            modelBuilder.Entity<RadReportingDoctor>(entity =>
            {
                entity.HasKey(e => e.ReportingDoctorId)
                    .HasName("PK__RAD_Repo__71F598747835F354");

                entity.ToTable("RAD_ReportingDoctors");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DoctorSignatureJson)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DoctorSignatureJSON");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.RadReportingDoctorCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_RAD_ReportingDoctors_CreatedBy_EMP_Employee");

                entity.HasOne(d => d.ImagingType)
                    .WithMany(p => p.RadReportingDoctors)
                    .HasForeignKey(d => d.ImagingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAD_ReportingDoctors_ImagingType_RAD_MST_ImagingType");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.RadReportingDoctorModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_RAD_ReportingDoctors_ModifiedBy_EMP_Employee");
            });

            modelBuilder.Entity<RbacApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__RBAC_App__C93A4C99F974DFA4");

                entity.ToTable("RBAC_Application");

                entity.HasIndex(e => e.ApplicationCode, "UK_Rbac_Application")
                    .IsUnique();

                entity.HasIndex(e => e.ApplicationName, "UK_Rbac_Application_Name")
                    .IsUnique();

                entity.Property(e => e.ApplicationCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<RbacMapRolePermission>(entity =>
            {
                entity.HasKey(e => e.RolePermissionMapId)
                    .HasName("PK__RBAC_MAP__38EC190266760DF7");

                entity.ToTable("RBAC_MAP_RolePermission");

                entity.HasIndex(e => new { e.RoleId, e.PermissionId }, "UK_RBAC_MAP_RolePermission")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.RbacMapRolePermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_RBAC_MAP_RolePermission_RBAC_Permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RbacMapRolePermissions)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RBAC_MAP_RolePermission_RBAC_Role");
            });

            modelBuilder.Entity<RbacMapUserRole>(entity =>
            {
                entity.HasKey(e => e.UserRoleMapId)
                    .HasName("PK__RBAC_MAP__D0684571D666C6A0");

                entity.ToTable("RBAC_MAP_UserRole");

                entity.HasIndex(e => new { e.UserId, e.RoleId }, "UK_RBAC_MAP_UserRole")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RbacMapUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RBAC_MAP_UserRole_RBAC_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RbacMapUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_RBAC_MAP_UserRole_RBAC_User");
            });

            modelBuilder.Entity<RbacPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionId);

                entity.ToTable("RBAC_Permission");

                entity.HasIndex(e => new { e.ApplicationId, e.PermissionName }, "UK_RBAC_Permission")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PermissionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.RbacPermissions)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_RBAC_Permission_RBAC_Application");
            });

            modelBuilder.Entity<RbacRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("RBAC_Role");

                entity.HasIndex(e => new { e.ApplicationId, e.RoleName }, "UK_RBAC_Role")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSysAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RoleDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('custom')");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.RbacRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK__RBAC_Role__Appli__0ABD916C");

                entity.HasOne(d => d.DefaultRoute)
                    .WithMany(p => p.RbacRoles)
                    .HasForeignKey(d => d.DefaultRouteId)
                    .HasConstraintName("FK_RBAC_Role_Rbac_RouteConfig");
            });

            modelBuilder.Entity<RbacRouteConfig>(entity =>
            {
                entity.HasKey(e => e.RouteId);

                entity.ToTable("RBAC_RouteConfig");

                entity.HasIndex(e => e.UrlFullPath, "UK_RBAC_RouteConfig")
                    .IsUnique();

                entity.Property(e => e.Css)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RouteDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RouteName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RouterLink)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrlFullPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.RbacRouteConfigs)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_RBAC_RouteConfig_RBAC_Permission");
            });

            modelBuilder.Entity<RbacUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__RBAC_Use__1788CC4CBD1007FE");

                entity.ToTable("RBAC_User");

                entity.HasIndex(e => e.EmployeeId, "UK_RBAC_EmployeeId")
                    .IsUnique();

                entity.HasIndex(e => e.UserName, "UK_RBAC_User")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UK_RBAC_User_Email")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithOne(p => p.RbacUser)
                    .HasForeignKey<RbacUser>(d => d.EmployeeId)
                    .HasConstraintName("FK_RBAC_User_EMP_Employee");
            });

            modelBuilder.Entity<ResetVoucherNo207677>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ResetVoucherNo207677");

                entity.Property(e => e.NewVoucherNumber).HasMaxLength(255);

                entity.Property(e => e.Str)
                    .HasMaxLength(255)
                    .HasColumnName("str");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherNumber).HasMaxLength(255);
            });

            modelBuilder.Entity<SchEmpDayWiseAvailability>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SCH_EmpDayWiseAvailability");

                entity.Property(e => e.DayName).HasMaxLength(10);

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_SCH_EmpDayWiseAvailability_EMP_Employee");
            });

            modelBuilder.Entity<SchEmployeeSchedule>(entity =>
            {
                entity.HasKey(e => e.EmployeeSchid);

                entity.ToTable("SCH_EmployeeSchedules");

                entity.Property(e => e.EmployeeSchid).HasColumnName("EmployeeSCHId");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DayName).HasMaxLength(10);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SchEmployeeSchedules)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_SCH_EmployeeSchedules_EMP_Employee");
            });

            modelBuilder.Entity<SchEmployeeShift>(entity =>
            {
                entity.HasKey(e => e.EmpShiftId);

                entity.ToTable("SCH_EmployeeShifts");

                entity.Property(e => e.EmpShiftId).ValueGeneratedNever();

                entity.Property(e => e.ShiftName).HasMaxLength(10);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SchEmployeeShifts)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_SCH_EmployeeShifts_EMP_Employee");
            });

            modelBuilder.Entity<SchMapEmployeeShift>(entity =>
            {
                entity.HasKey(e => e.EmployeeShiftMapId);

                entity.ToTable("SCH_MAP_EmployeeShift");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SchMapEmployeeShifts)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_SCH_MAP_EmployeeShift_EMP_Employee");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.SchMapEmployeeShifts)
                    .HasForeignKey(d => d.ShiftId)
                    .HasConstraintName("FK_SCH_MAP_EmployeeShift_SCH_MST_Shifts");
            });

            modelBuilder.Entity<SchMstShift>(entity =>
            {
                entity.HasKey(e => e.ShiftId);

                entity.ToTable("SCH_MST_Shifts");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ShiftName).HasMaxLength(50);
            });

            modelBuilder.Entity<ServiceDepartmentMstIntegrationName>(entity =>
            {
                entity.HasKey(e => e.IntegrationNameId);

                entity.ToTable("ServiceDepartment_MST_IntegrationName");

                entity.Property(e => e.IntegrationNameId).HasColumnName("IntegrationNameID");

                entity.Property(e => e.IntegrationName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblBillItemTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_BillItem_Temp");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDepartmentName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Temp10>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp10");

                entity.Property(e => e.Parameter)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterValue)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempLabNewPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_LabNewPrice");

                entity.Property(e => e.Department)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.SrvDeptName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempRange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempRange");

                entity.Property(e => e.Value)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<TxnEmpCashTransaction>(entity =>
            {
                entity.HasKey(e => e.CashTxnId)
                    .HasName("PK_TXN_EmpCashTransactions");

                entity.ToTable("TXN_EmpCashTransaction");

                entity.Property(e => e.CounterId).HasColumnName("CounterID");

                entity.Property(e => e.Description)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TxnEmpCashTransactions)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TXN_EmpCashTransactions_EMP_EMployee");
            });

            modelBuilder.Entity<TxnEmpDueAmount>(entity =>
            {
                entity.HasKey(e => e.EmployeeDueId)
                    .HasName("PK_TXN_EmpDueAmounts");

                entity.ToTable("TXN_EmpDueAmount");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TxnEmpDueAmounts)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TXN_EmpDueAmount_EMP_EMployee");
            });

            modelBuilder.Entity<TxnPrintInformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TXN_PrintInformation");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintId).ValueGeneratedOnAdd();

                entity.Property(e => e.PrintedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TxnSm>(entity =>
            {
                entity.HasKey(e => e.SmsId)
                    .HasName("PK__TXN_Sms__A3EF2EDF95A7DE1B");

                entity.ToTable("TXN_Sms");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.SmsInformation)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TxnVerification>(entity =>
            {
                entity.HasKey(e => e.VerificationId)
                    .HasName("PK__TXN_Veri__306D490706397967");

                entity.ToTable("TXN_Verification");

                entity.Property(e => e.CurrentVerificationLevelCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentVerificationId).HasDefaultValueSql("((0))");

                entity.Property(e => e.VerificationRemarks)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.VerificationStatus).HasMaxLength(50);

                entity.Property(e => e.VerifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ParentVerification)
                    .WithMany(p => p.InverseParentVerification)
                    .HasForeignKey(d => d.ParentVerificationId)
                    .HasConstraintName("FK_ParentVerificationId");
            });

            modelBuilder.Entity<UpdatedBillItemPriceTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UpdatedBillItemPriceTable");

                entity.Property(e => e.BillitemId).HasColumnName("billitemId");

                entity.Property(e => e.Department).HasMaxLength(250);

                entity.Property(e => e.Itemname).HasMaxLength(250);
            });

            modelBuilder.Entity<VaccPatientVaccineDetail>(entity =>
            {
                entity.HasKey(e => e.PatientVaccineId)
                    .HasName("PK_Patient_VaccineId");

                entity.ToTable("VACC_PatientVaccineDetail");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VaccineDate).HasColumnType("datetime");

                entity.HasOne(d => d.Vaccine)
                    .WithMany(p => p.VaccPatientVaccineDetails)
                    .HasForeignKey(d => d.VaccineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VACC_Patient_VaccineDetail_VACC_Vaccine");
            });

            modelBuilder.Entity<VaccVaccine>(entity =>
            {
                entity.HasKey(e => e.VaccineId)
                    .HasName("PK_VaccineId");

                entity.ToTable("VACC_Vaccines");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.VaccineName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwBilTxnItemsInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_BIL_TxnItemsInfo");

                entity.Property(e => e.BillStatus)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BillingDate).HasColumnType("date");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwBilTxnItemsInfoIncomeSegregation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_BIL_TxnItemsInfo_Income_Segregation");

                entity.Property(e => e.BillStatus)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BillingDate).HasColumnType("date");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwBilTxnItemsInfoWithDateSeparation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_BIL_TxnItemsInfoWithDateSeparation");

                entity.Property(e => e.BillStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillingType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CancelRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledDate).HasColumnType("date");

                entity.Property(e => e.CounterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.CreditDate).HasColumnType("date");

                entity.Property(e => e.InvoiceCreatedDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.InvoicePaidDate).HasColumnType("date");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaidDate).HasColumnType("date");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.ProvisionalDate).HasColumnType("date");

                entity.Property(e => e.ReturnDate).HasColumnType("date");

                entity.Property(e => e.ReturnRemarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VisitType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwBilTxnItemsInfoWithDateSeparationIncomeSegregation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_BIL_TxnItemsInfoWithDateSeparation_Income_Segregation");

                entity.Property(e => e.BillingType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CancelRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledDate).HasColumnType("date");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.CreditDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaidDate).HasColumnType("date");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.ProvisionalDate).HasColumnType("date");

                entity.Property(e => e.ReturnDate).HasColumnType("date");

                entity.Property(e => e.ReturnRemarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwBilTxnItemsInfoWithDateSeparationMisReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_BIL_TxnItemsInfoWithDateSeparation_MIS_Report");

                entity.Property(e => e.BillingType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CancelRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledDate).HasColumnType("date");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.CreditDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaidDate).HasColumnType("date");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.ProvisionalDate).HasColumnType("date");

                entity.Property(e => e.ReturnDate).HasColumnType("date");

                entity.Property(e => e.ReturnRemarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WardConsumption>(entity =>
            {
                entity.HasKey(e => e.ConsumptionId);

                entity.ToTable("WARD_Consumption");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");
            });

            modelBuilder.Entity<WardDispatch>(entity =>
            {
                entity.HasKey(e => e.DispatchId);

                entity.ToTable("WARD_Dispatch");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ReceivedBy)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");
            });

            modelBuilder.Entity<WardDispatchItem>(entity =>
            {
                entity.HasKey(e => e.DispatchItemId);

                entity.ToTable("WARD_DispatchItems");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(16, 4)");
            });

            modelBuilder.Entity<WardInformationModel>(entity =>
            {
                entity.HasKey(e => e.WardName)
                    .HasName("PK_dbo.WardInformationModels");

                entity.Property(e => e.WardName).HasMaxLength(128);
            });

            modelBuilder.Entity<WardInternalConsumption>(entity =>
            {
                entity.HasKey(e => e.ConsumptionId)
                    .HasName("PK__WARD_Int__E3A1C417CB5E9CED");

                entity.ToTable("WARD_InternalConsumption");

                entity.Property(e => e.ConsumedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WardInternalConsumptionItem>(entity =>
            {
                entity.HasKey(e => e.ConsumptionItemId)
                    .HasName("PK__WARD_Int__8230444CCB0558CE");

                entity.ToTable("WARD_InternalConsumptionItems");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Mrp).HasColumnName("MRP");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WardInvConsumption>(entity =>
            {
                entity.HasKey(e => e.ConsumptionId);

                entity.ToTable("WARD_INV_Consumption");

                entity.Property(e => e.ConsumptionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ConsumptionReceipt)
                    .WithMany(p => p.WardInvConsumptions)
                    .HasForeignKey(d => d.ConsumptionReceiptId)
                    .HasConstraintName("FK_WARD_INV_Consumption_WARD_INV_ConsumptionReceipt");
            });

            modelBuilder.Entity<WardInvConsumptionReceipt>(entity =>
            {
                entity.HasKey(e => e.ConsumptionReceiptId);

                entity.ToTable("WARD_INV_ConsumptionReceipt");

                entity.Property(e => e.ConsumptionDate).HasPrecision(3);

                entity.Property(e => e.CreatedOn).HasPrecision(3);

                entity.Property(e => e.ModifiedOn).HasPrecision(3);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.WardInvConsumptionReceiptCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WARD_INV_ConsumptionReceipt_CreatedBy_EMP_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.WardInvConsumptionReceiptModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_WARD_INV_ConsumptionReceipt_ModifiedBy_EMP_Employee");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.WardInvConsumptionReceipts)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WARD_INV_ConsumptionReceipt_PAT_PatientId");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.WardInvConsumptionReceipts)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WARD_INV_ConsumptionReceipt_PHRM_MST_Store");
            });

            modelBuilder.Entity<WardInvStock>(entity =>
            {
                entity.HasKey(e => e.StockId)
                    .HasName("PK_WARD_INV_NewStock");

                entity.ToTable("WARD_INV_Stock");

                entity.Property(e => e.BatchNo).IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Price).HasColumnType("decimal(16, 4)");

                entity.HasOne(d => d.Substore)
                    .WithMany(p => p.WardInvStocks)
                    .HasForeignKey(d => d.SubstoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WARD_INV_Stock_SubstoreId_PHRM_MST_Store");
            });

            modelBuilder.Entity<WardInvTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK_WARD_INV_NewStockTxn");

                entity.ToTable("WARD_INV_Transaction");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.InOut)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Price).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.ReceivedBy)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Substore)
                    .WithMany(p => p.WardInvTransactions)
                    .HasForeignKey(d => d.SubstoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WARD_INV_Transaction_SubstoreId_PHRM_MST_Store");
            });

            modelBuilder.Entity<WardRequisition>(entity =>
            {
                entity.HasKey(e => e.RequisitionId);

                entity.ToTable("WARD_Requisition");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.ReferenceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WardRequisitionItem>(entity =>
            {
                entity.HasKey(e => e.RequisitionItemId);

                entity.ToTable("WARD_RequisitionItems");
            });

            modelBuilder.Entity<WardStock>(entity =>
            {
                entity.HasKey(e => e.StockId);

                entity.ToTable("WARD_Stock");

                entity.Property(e => e.BatchNo).IsUnicode(false);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Mrp).HasColumnName("MRP");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.StockType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WardTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__WARD_Tra__55433A6B70E681CC");

                entity.ToTable("WARD_Transaction");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.InOut)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewWardId).HasColumnName("newWardId");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReceivedBy)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.WardTransactions)
                    .HasForeignKey(d => d.StockId)
                    .HasConstraintName("FK__WARD_Tran__Stock__65EBFF70");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
