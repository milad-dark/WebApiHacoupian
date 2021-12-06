using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class MainContext : DbContext
    {
        public MainContext()
        {
        }

        public MainContext(DbContextOptions<MainContext> options)
            : base(options)
        {
        }

        #region DbSet
        public virtual DbSet<AspstateTempApplication> AspstateTempApplications { get; set; }
        public virtual DbSet<AspstateTempSession> AspstateTempSessions { get; set; }
        public virtual DbSet<TblAbility> TblAbilities { get; set; }
        public virtual DbSet<TblAbsenceLicense> TblAbsenceLicenses { get; set; }
        public virtual DbSet<TblAbsenceLicenseRequest> TblAbsenceLicenseRequests { get; set; }
        public virtual DbSet<TblAbsenceLicenseRequestAttachment> TblAbsenceLicenseRequestAttachments { get; set; }
        public virtual DbSet<TblAbsenceLicenseRequestDetail> TblAbsenceLicenseRequestDetails { get; set; }
        public virtual DbSet<TblAccountInfo> TblAccountInfos { get; set; }
        public virtual DbSet<TblAsset> TblAssets { get; set; }
        public virtual DbSet<TblAssetCumulativeDepreciation> TblAssetCumulativeDepreciations { get; set; }
        public virtual DbSet<TblAssetGood> TblAssetGoods { get; set; }
        public virtual DbSet<TblAssetGoodFormula> TblAssetGoodFormulas { get; set; }
        public virtual DbSet<TblAssetGroup> TblAssetGroups { get; set; }
        public virtual DbSet<TblAssetMethod> TblAssetMethods { get; set; }
        public virtual DbSet<TblAssetOutType> TblAssetOutTypes { get; set; }
        public virtual DbSet<TblAttachment> TblAttachments { get; set; }
        public virtual DbSet<TblAttachmentType> TblAttachmentTypes { get; set; }
        public virtual DbSet<TblBank> TblBanks { get; set; }
        public virtual DbSet<TblBankAccountType> TblBankAccountTypes { get; set; }
        public virtual DbSet<TblBankBranch> TblBankBranches { get; set; }
        public virtual DbSet<TblBankBranchAccount> TblBankBranchAccounts { get; set; }
        public virtual DbSet<TblBeginPeriod> TblBeginPeriods { get; set; }
        public virtual DbSet<TblBlog> TblBlogs { get; set; }
        public virtual DbSet<TblBlogAttachment> TblBlogAttachments { get; set; }
        public virtual DbSet<TblBlogCategory> TblBlogCategories { get; set; }
        public virtual DbSet<TblBlogGoal> TblBlogGoals { get; set; }
        public virtual DbSet<TblBlogLike> TblBlogLikes { get; set; }
        public virtual DbSet<TblBlogTag> TblBlogTags { get; set; }
        public virtual DbSet<TblBpmn> TblBpmns { get; set; }
        public virtual DbSet<TblBrand> TblBrands { get; set; }
        public virtual DbSet<TblBudget> TblBudgets { get; set; }
        public virtual DbSet<TblBudgetItem> TblBudgetItems { get; set; }
        public virtual DbSet<TblBudgetItemDetail> TblBudgetItemDetails { get; set; }
        public virtual DbSet<TblCalendarArchive> TblCalendarArchives { get; set; }
        public virtual DbSet<TblCallHistory> TblCallHistories { get; set; }
        public virtual DbSet<TblCallStatus> TblCallStatuses { get; set; }
        public virtual DbSet<TblCataloge> TblCataloges { get; set; }
        public virtual DbSet<TblCatalogeItem> TblCatalogeItems { get; set; }
        public virtual DbSet<TblCategory> TblCategories { get; set; }
        public virtual DbSet<TblCattering> TblCatterings { get; set; }
        public virtual DbSet<TblCatteringItem> TblCatteringItems { get; set; }
        public virtual DbSet<TblCertificate> TblCertificates { get; set; }
        public virtual DbSet<TblChannel> TblChannels { get; set; }
        public virtual DbSet<TblChat> TblChats { get; set; }
        public virtual DbSet<TblCheque> TblCheques { get; set; }
        public virtual DbSet<TblChequeTemplate> TblChequeTemplates { get; set; }
        public virtual DbSet<TblCity> TblCities { get; set; }
        public virtual DbSet<TblCodingPattern> TblCodingPatterns { get; set; }
        public virtual DbSet<TblCodingPatternKey> TblCodingPatternKeys { get; set; }
        public virtual DbSet<TblCodingPatternValue> TblCodingPatternValues { get; set; }
        public virtual DbSet<TblCodingPatternValueType> TblCodingPatternValueTypes { get; set; }
        public virtual DbSet<TblComment> TblComments { get; set; }
        public virtual DbSet<TblCommentLike> TblCommentLikes { get; set; }
        public virtual DbSet<TblCompany> TblCompanies { get; set; }
        public virtual DbSet<TblCompanyCharge> TblCompanyCharges { get; set; }
        public virtual DbSet<TblCompanyPerson> TblCompanyPeople { get; set; }
        public virtual DbSet<TblCompanyPhone> TblCompanyPhones { get; set; }
        public virtual DbSet<TblCompanyPlace> TblCompanyPlaces { get; set; }
        public virtual DbSet<TblCompetency> TblCompetencies { get; set; }
        public virtual DbSet<TblCompetencyItem> TblCompetencyItems { get; set; }
        public virtual DbSet<TblCompetencyItemFactor> TblCompetencyItemFactors { get; set; }
        public virtual DbSet<TblCompetencyItemFactorBehaviour> TblCompetencyItemFactorBehaviours { get; set; }
        public virtual DbSet<TblComputer> TblComputers { get; set; }
        public virtual DbSet<TblComputerHardware> TblComputerHardwares { get; set; }
        public virtual DbSet<TblComputerNetwork> TblComputerNetworks { get; set; }
        public virtual DbSet<TblComputerSoftware> TblComputerSoftwares { get; set; }
        public virtual DbSet<TblContractType> TblContractTypes { get; set; }
        public virtual DbSet<TblCorrection> TblCorrections { get; set; }
        public virtual DbSet<TblCost> TblCosts { get; set; }
        public virtual DbSet<TblCostFactor> TblCostFactors { get; set; }
        public virtual DbSet<TblCountry> TblCountries { get; set; }
        public virtual DbSet<TblCourse> TblCourses { get; set; }
        public virtual DbSet<TblCourseAudience> TblCourseAudiences { get; set; }
        public virtual DbSet<TblCourseDay> TblCourseDays { get; set; }
        public virtual DbSet<TblCourseName> TblCourseNames { get; set; }
        public virtual DbSet<TblCustomerCareDefect> TblCustomerCareDefects { get; set; }
        public virtual DbSet<TblCustomerCareSheet> TblCustomerCareSheets { get; set; }
        public virtual DbSet<TblCustomerCareSheetItem> TblCustomerCareSheetItems { get; set; }
        public virtual DbSet<TblCustomerCareSheetItemDefect> TblCustomerCareSheetItemDefects { get; set; }
        public virtual DbSet<TblCustomerCareSheetItemTracking> TblCustomerCareSheetItemTrackings { get; set; }
        public virtual DbSet<TblCustomerCareSheetItemTrackingType> TblCustomerCareSheetItemTrackingTypes { get; set; }
        public virtual DbSet<TblDefaultText> TblDefaultTexts { get; set; }
        public virtual DbSet<TblDepartmentGoal> TblDepartmentGoals { get; set; }
        public virtual DbSet<TblDiscountType> TblDiscountTypes { get; set; }
        public virtual DbSet<TblDistrict> TblDistricts { get; set; }
        public virtual DbSet<TblDraftOrder> TblDraftOrders { get; set; }
        public virtual DbSet<TblDraftOrderAttachment> TblDraftOrderAttachments { get; set; }
        public virtual DbSet<TblDraftOrderItem> TblDraftOrderItems { get; set; }
        public virtual DbSet<TblDraftOrderItemDiscountPercentage> TblDraftOrderItemDiscountPercentages { get; set; }
        public virtual DbSet<TblDraftOrderSafeReceiptPayment> TblDraftOrderSafeReceiptPayments { get; set; }
        public virtual DbSet<TblDraftOrderType> TblDraftOrderTypes { get; set; }
        public virtual DbSet<TblDraftType> TblDraftTypes { get; set; }
        public virtual DbSet<TblEffectiveType> TblEffectiveTypes { get; set; }
        public virtual DbSet<TblEmployeeAttendance> TblEmployeeAttendances { get; set; }
        public virtual DbSet<TblEmployemntStatus> TblEmployemntStatuses { get; set; }
        public virtual DbSet<TblEmployment> TblEmployments { get; set; }
        public virtual DbSet<TblEmploymentFactor> TblEmploymentFactors { get; set; }
        public virtual DbSet<TblEmploymentKey> TblEmploymentKeys { get; set; }
        public virtual DbSet<TblEmploymentRequest> TblEmploymentRequests { get; set; }
        public virtual DbSet<TblEmploymentRequestChannel> TblEmploymentRequestChannels { get; set; }
        public virtual DbSet<TblEmploymentRequestReason> TblEmploymentRequestReasons { get; set; }
        public virtual DbSet<TblEmploymentType> TblEmploymentTypes { get; set; }
        public virtual DbSet<TblEvaluationGoal> TblEvaluationGoals { get; set; }
        public virtual DbSet<TblEvaluationGoalProject> TblEvaluationGoalProjects { get; set; }
        public virtual DbSet<TblEvaluationPeriod> TblEvaluationPeriods { get; set; }
        public virtual DbSet<TblEvaluationPeriodCalendar> TblEvaluationPeriodCalendars { get; set; }
        public virtual DbSet<TblEvent> TblEvents { get; set; }
        public virtual DbSet<TblEventPlaceType> TblEventPlaceTypes { get; set; }
        public virtual DbSet<TblEvidence> TblEvidences { get; set; }
        public virtual DbSet<TblEvidenceItem> TblEvidenceItems { get; set; }
        public virtual DbSet<TblEvidenceItemCurrency> TblEvidenceItemCurrencies { get; set; }
        public virtual DbSet<TblEvidenceType> TblEvidenceTypes { get; set; }
        public virtual DbSet<TblExchange> TblExchanges { get; set; }
        public virtual DbSet<TblExport> TblExports { get; set; }
        public virtual DbSet<TblExportType> TblExportTypes { get; set; }
        public virtual DbSet<TblFamily> TblFamilies { get; set; }
        public virtual DbSet<TblFeedback> TblFeedbacks { get; set; }
        public virtual DbSet<TblFieldOfStudy> TblFieldOfStudies { get; set; }
        public virtual DbSet<TblFinancialCycle> TblFinancialCycles { get; set; }
        public virtual DbSet<TblFinishedGoodAlbum> TblFinishedGoodAlbums { get; set; }
        public virtual DbSet<TblFinishedGoodAlbumDesign> TblFinishedGoodAlbumDesigns { get; set; }
        public virtual DbSet<TblFinishedGoodAlbumDistribution> TblFinishedGoodAlbumDistributions { get; set; }
        public virtual DbSet<TblFinishedGoodAlbumPermission> TblFinishedGoodAlbumPermissions { get; set; }
        public virtual DbSet<TblFinishedGoodAlbumPricing> TblFinishedGoodAlbumPricings { get; set; }
        public virtual DbSet<TblFinishedGoodAlbumRawMaterialProduct> TblFinishedGoodAlbumRawMaterialProducts { get; set; }
        public virtual DbSet<TblFinishedGoodAppliedPricing> TblFinishedGoodAppliedPricings { get; set; }
        public virtual DbSet<TblFinishedGoodBeginPeriod> TblFinishedGoodBeginPeriods { get; set; }
        public virtual DbSet<TblFinishedGoodExtraInfo> TblFinishedGoodExtraInfos { get; set; }
        public virtual DbSet<TblFinishedGoodPricingResult> TblFinishedGoodPricingResults { get; set; }
        public virtual DbSet<TblFinishedGoodProduct> TblFinishedGoodProducts { get; set; }
        public virtual DbSet<TblFinishedGoodProductFusingLabel> TblFinishedGoodProductFusingLabels { get; set; }
        public virtual DbSet<TblFinishedGoodProductGallery> TblFinishedGoodProductGalleries { get; set; }
        public virtual DbSet<TblFinishedGoodProductTranslation> TblFinishedGoodProductTranslations { get; set; }
        public virtual DbSet<TblFinishedGoodProductionLabel> TblFinishedGoodProductionLabels { get; set; }
        public virtual DbSet<TblFinishedGoodProductionLabelComposition> TblFinishedGoodProductionLabelCompositions { get; set; }
        public virtual DbSet<TblFinishedGoodReportTemporaryTable> TblFinishedGoodReportTemporaryTables { get; set; }
        public virtual DbSet<TblFinishedGoodStockSheet> TblFinishedGoodStockSheets { get; set; }
        public virtual DbSet<TblFinishedGoodStockSheetItem> TblFinishedGoodStockSheetItems { get; set; }
        public virtual DbSet<TblFinishedGoodStockSheetSubType> TblFinishedGoodStockSheetSubTypes { get; set; }
        public virtual DbSet<TblFinishedGoodStockSheetType> TblFinishedGoodStockSheetTypes { get; set; }
        public virtual DbSet<TblFir> TblFirs { get; set; }
        public virtual DbSet<TblFloatLedger> TblFloatLedgers { get; set; }
        public virtual DbSet<TblFloatLedgerItem> TblFloatLedgerItems { get; set; }
        public virtual DbSet<TblForm> TblForms { get; set; }
        public virtual DbSet<TblFormField> TblFormFields { get; set; }
        public virtual DbSet<TblFormFieldDefault> TblFormFieldDefaults { get; set; }
        public virtual DbSet<TblFormFieldType> TblFormFieldTypes { get; set; }
        public virtual DbSet<TblFormFieldValue> TblFormFieldValues { get; set; }
        public virtual DbSet<TblFormalDay> TblFormalDays { get; set; }
        public virtual DbSet<TblFormalDayName> TblFormalDayNames { get; set; }
        public virtual DbSet<TblFormula> TblFormulas { get; set; }
        public virtual DbSet<TblFormulaDetail> TblFormulaDetails { get; set; }
        public virtual DbSet<TblFormulaGroup> TblFormulaGroups { get; set; }
        public virtual DbSet<TblFormulaHeader> TblFormulaHeaders { get; set; }
        public virtual DbSet<TblGoal> TblGoals { get; set; }
        public virtual DbSet<TblGroup> TblGroups { get; set; }
        public virtual DbSet<TblHardware> TblHardwares { get; set; }
        public virtual DbSet<TblHardwareVersion> TblHardwareVersions { get; set; }
        public virtual DbSet<TblHistory> TblHistories { get; set; }
        public virtual DbSet<TblHistoryOperation> TblHistoryOperations { get; set; }
        public virtual DbSet<TblHistoryOperationType> TblHistoryOperationTypes { get; set; }
        public virtual DbSet<TblHouseType> TblHouseTypes { get; set; }
        public virtual DbSet<TblImprest> TblImprests { get; set; }
        public virtual DbSet<TblInitializedType> TblInitializedTypes { get; set; }
        public virtual DbSet<TblInsuranceBranch> TblInsuranceBranches { get; set; }
        public virtual DbSet<TblInsuranceJob> TblInsuranceJobs { get; set; }
        public virtual DbSet<TblInsuranceType> TblInsuranceTypes { get; set; }
        public virtual DbSet<TblInterest> TblInterests { get; set; }
        public virtual DbSet<TblInvoiceMaster> TblInvoiceMasters { get; set; }
        public virtual DbSet<TblInvoiceMasterAttachment> TblInvoiceMasterAttachments { get; set; }
        public virtual DbSet<TblInvoiceMasterDiscount> TblInvoiceMasterDiscounts { get; set; }
        public virtual DbSet<TblInvoiceMasterPayment> TblInvoiceMasterPayments { get; set; }
        public virtual DbSet<TblInvoiceMasterPermission> TblInvoiceMasterPermissions { get; set; }
        public virtual DbSet<TblInvoiceMasterPoint> TblInvoiceMasterPoints { get; set; }
        public virtual DbSet<TblInvoiceMasterPointRange> TblInvoiceMasterPointRanges { get; set; }
        public virtual DbSet<TblInvoiceMasterPointRangeDetail> TblInvoiceMasterPointRangeDetails { get; set; }
        public virtual DbSet<TblInvoiceMasterPrepayment> TblInvoiceMasterPrepayments { get; set; }
        public virtual DbSet<TblInvoiceMasterRemain> TblInvoiceMasterRemains { get; set; }
        public virtual DbSet<TblInvoiceMasterType> TblInvoiceMasterTypes { get; set; }
        public virtual DbSet<TblInvoiceMoreInfo> TblInvoiceMoreInfos { get; set; }
        public virtual DbSet<TblInvoiceSlave> TblInvoiceSlaves { get; set; }
        public virtual DbSet<TblInvoiceStatus> TblInvoiceStatuses { get; set; }
        public virtual DbSet<TblInvoiceType> TblInvoiceTypes { get; set; }
        public virtual DbSet<TblIspcontract> TblIspcontracts { get; set; }
        public virtual DbSet<TblJob> TblJobs { get; set; }
        public virtual DbSet<TblJobAbility> TblJobAbilities { get; set; }
        public virtual DbSet<TblJobCompetency> TblJobCompetencies { get; set; }
        public virtual DbSet<TblJobCourse> TblJobCourses { get; set; }
        public virtual DbSet<TblJobDescription> TblJobDescriptions { get; set; }
        public virtual DbSet<TblJobEducation> TblJobEducations { get; set; }
        public virtual DbSet<TblJobEvaluation> TblJobEvaluations { get; set; }
        public virtual DbSet<TblJobGoal> TblJobGoals { get; set; }
        public virtual DbSet<TblJobGroup> TblJobGroups { get; set; }
        public virtual DbSet<TblJobInterest> TblJobInterests { get; set; }
        public virtual DbSet<TblJobKnowledge> TblJobKnowledges { get; set; }
        public virtual DbSet<TblJobModel> TblJobModels { get; set; }
        public virtual DbSet<TblJobModelFactor> TblJobModelFactors { get; set; }
        public virtual DbSet<TblJobModelFactorPrefered> TblJobModelFactorPrefereds { get; set; }
        public virtual DbSet<TblJobPsychology> TblJobPsychologies { get; set; }
        public virtual DbSet<TblJobResponsibility> TblJobResponsibilities { get; set; }
        public virtual DbSet<TblJobSkill> TblJobSkills { get; set; }
        public virtual DbSet<TblJobSoftware> TblJobSoftwares { get; set; }
        public virtual DbSet<TblJobWorkCondition> TblJobWorkConditions { get; set; }
        public virtual DbSet<TblKnowledge> TblKnowledges { get; set; }
        public virtual DbSet<TblLedger> TblLedgers { get; set; }
        public virtual DbSet<TblLedgerInfo> TblLedgerInfos { get; set; }
        public virtual DbSet<TblLedgerLevel> TblLedgerLevels { get; set; }
        public virtual DbSet<TblLetter> TblLetters { get; set; }
        public virtual DbSet<TblLetterType> TblLetterTypes { get; set; }
        public virtual DbSet<TblLicense> TblLicenses { get; set; }
        public virtual DbSet<TblLifeStatus> TblLifeStatuses { get; set; }
        public virtual DbSet<TblLifeStatusType> TblLifeStatusTypes { get; set; }
        public virtual DbSet<TblLoan> TblLoans { get; set; }
        public virtual DbSet<TblLoanPayment> TblLoanPayments { get; set; }
        public virtual DbSet<TblLoanType> TblLoanTypes { get; set; }
        public virtual DbSet<TblLogMaster> TblLogMasters { get; set; }
        public virtual DbSet<TblLogSlave> TblLogSlaves { get; set; }
        public virtual DbSet<TblLogicalProperty> TblLogicalProperties { get; set; }
        public virtual DbSet<TblMarriageStatus> TblMarriageStatuses { get; set; }
        public virtual DbSet<TblMeal> TblMeals { get; set; }
        public virtual DbSet<TblMeasurement> TblMeasurements { get; set; }
        public virtual DbSet<TblMenu> TblMenus { get; set; }
        public virtual DbSet<TblMilitaryService> TblMilitaryServices { get; set; }
        public virtual DbSet<TblMonthlyReport> TblMonthlyReports { get; set; }
        public virtual DbSet<TblNetworkUsage> TblNetworkUsages { get; set; }
        public virtual DbSet<TblNews> TblNews { get; set; }
        public virtual DbSet<TblNewsPhoto> TblNewsPhotos { get; set; }
        public virtual DbSet<TblOrderDetail> TblOrderDetails { get; set; }
        public virtual DbSet<TblOrderDetailDevelopment> TblOrderDetailDevelopments { get; set; }
        public virtual DbSet<TblOrderDetailProgram> TblOrderDetailPrograms { get; set; }
        public virtual DbSet<TblOrderHeader> TblOrderHeaders { get; set; }
        public virtual DbSet<TblOrderHeaderAttachment> TblOrderHeaderAttachments { get; set; }
        public virtual DbSet<TblOrderHeaderMoreInfo> TblOrderHeaderMoreInfos { get; set; }
        public virtual DbSet<TblOrderHeaderOwner> TblOrderHeaderOwners { get; set; }
        public virtual DbSet<TblOrganizationChart> TblOrganizationCharts { get; set; }
        public virtual DbSet<TblOrganizationChartKey> TblOrganizationChartKeys { get; set; }
        public virtual DbSet<TblPaymentType> TblPaymentTypes { get; set; }
        public virtual DbSet<TblPayrollAttachment> TblPayrollAttachments { get; set; }
        public virtual DbSet<TblPayrollFactor> TblPayrollFactors { get; set; }
        public virtual DbSet<TblPayrollKey> TblPayrollKeys { get; set; }
        public virtual DbSet<TblPermission> TblPermissions { get; set; }
        public virtual DbSet<TblPerson> TblPeople { get; set; }
        public virtual DbSet<TblPersonCertificate> TblPersonCertificates { get; set; }
        public virtual DbSet<TblPersonCharge> TblPersonCharges { get; set; }
        public virtual DbSet<TblPersonDevice> TblPersonDevices { get; set; }
        public virtual DbSet<TblPersonEmploymentRequest> TblPersonEmploymentRequests { get; set; }
        public virtual DbSet<TblPersonEvaluation> TblPersonEvaluations { get; set; }
        public virtual DbSet<TblPersonEvaluationProjectTask> TblPersonEvaluationProjectTasks { get; set; }
        public virtual DbSet<TblPersonGroup> TblPersonGroups { get; set; }
        public virtual DbSet<TblPersonInterest> TblPersonInterests { get; set; }
        public virtual DbSet<TblPersonInterview> TblPersonInterviews { get; set; }
        public virtual DbSet<TblPersonMeal> TblPersonMeals { get; set; }
        public virtual DbSet<TblPersonNote> TblPersonNotes { get; set; }
        public virtual DbSet<TblPersonPermission> TblPersonPermissions { get; set; }
        public virtual DbSet<TblPersonRole> TblPersonRoles { get; set; }
        public virtual DbSet<TblPersonSkill> TblPersonSkills { get; set; }
        public virtual DbSet<TblPersonSystem> TblPersonSystems { get; set; }
        public virtual DbSet<TblPersonType> TblPersonTypes { get; set; }
        public virtual DbSet<TblPersonVisitedUrl> TblPersonVisitedUrls { get; set; }
        public virtual DbSet<TblPhone> TblPhones { get; set; }
        public virtual DbSet<TblPhoneType> TblPhoneTypes { get; set; }
        public virtual DbSet<TblPlace> TblPlaces { get; set; }
        public virtual DbSet<TblPlaceType> TblPlaceTypes { get; set; }
        public virtual DbSet<TblPlaceTypeFinishedGoodCapacity> TblPlaceTypeFinishedGoodCapacities { get; set; }
        public virtual DbSet<TblPlaceTypeImage> TblPlaceTypeImages { get; set; }
        public virtual DbSet<TblPlan> TblPlans { get; set; }
        public virtual DbSet<TblPo> TblPos { get; set; }
        public virtual DbSet<TblPointType> TblPointTypes { get; set; }
        public virtual DbSet<TblPollProductQuality> TblPollProductQualities { get; set; }
        public virtual DbSet<TblPollServiceQuality> TblPollServiceQualities { get; set; }
        public virtual DbSet<TblPost> TblPosts { get; set; }
        public virtual DbSet<TblPrepaymentType> TblPrepaymentTypes { get; set; }
        public virtual DbSet<TblPriority> TblPriorities { get; set; }
        public virtual DbSet<TblProcess> TblProcesses { get; set; }
        public virtual DbSet<TblProcessingResult> TblProcessingResults { get; set; }
        public virtual DbSet<TblProcessingResultFactor> TblProcessingResultFactors { get; set; }
        public virtual DbSet<TblProduct> TblProducts { get; set; }
        public virtual DbSet<TblProductAlbum> TblProductAlbums { get; set; }
        public virtual DbSet<TblProductAlbumCategory> TblProductAlbumCategories { get; set; }
        public virtual DbSet<TblProductAlbumDetail> TblProductAlbumDetails { get; set; }
        public virtual DbSet<TblProductAlbumDistribution> TblProductAlbumDistributions { get; set; }
        public virtual DbSet<TblProductAlbumHeader> TblProductAlbumHeaders { get; set; }
        public virtual DbSet<TblProductAlbumMoreInfo> TblProductAlbumMoreInfos { get; set; }
        public virtual DbSet<TblProductGallery> TblProductGalleries { get; set; }
        public virtual DbSet<TblProductionOrder> TblProductionOrders { get; set; }
        public virtual DbSet<TblProductionOrderAttachment> TblProductionOrderAttachments { get; set; }
        public virtual DbSet<TblProductionOrderFinishedGoodProduct> TblProductionOrderFinishedGoodProducts { get; set; }
        public virtual DbSet<TblProductionOrderMoreInfo> TblProductionOrderMoreInfos { get; set; }
        public virtual DbSet<TblProductionOrderRawMaterialProduct> TblProductionOrderRawMaterialProducts { get; set; }
        public virtual DbSet<TblProductionOrderRawMaterialProductsDetail> TblProductionOrderRawMaterialProductsDetails { get; set; }
        public virtual DbSet<TblProductionOrderRawMaterialProductsDevelopment> TblProductionOrderRawMaterialProductsDevelopments { get; set; }
        public virtual DbSet<TblProductionOrderRawMaterialProductsProgram> TblProductionOrderRawMaterialProductsPrograms { get; set; }
        public virtual DbSet<TblProductionOrderTracking> TblProductionOrderTrackings { get; set; }
        public virtual DbSet<TblProductionOrderTrackingType> TblProductionOrderTrackingTypes { get; set; }
        public virtual DbSet<TblProject> TblProjects { get; set; }
        public virtual DbSet<TblProjectTask> TblProjectTasks { get; set; }
        public virtual DbSet<TblProjectTaskAttachment> TblProjectTaskAttachments { get; set; }
        public virtual DbSet<TblProjectTaskChat> TblProjectTaskChats { get; set; }
        public virtual DbSet<TblProjectTaskRecipient> TblProjectTaskRecipients { get; set; }
        public virtual DbSet<TblProjectTaskTag> TblProjectTaskTags { get; set; }
        public virtual DbSet<TblProvince> TblProvinces { get; set; }
        public virtual DbSet<TblPsychologyType> TblPsychologyTypes { get; set; }
        public virtual DbSet<TblRawMaterialAlbum> TblRawMaterialAlbums { get; set; }
        public virtual DbSet<TblRawMaterialAlbumDesign> TblRawMaterialAlbumDesigns { get; set; }
        public virtual DbSet<TblRawMaterialAlbumDistribution> TblRawMaterialAlbumDistributions { get; set; }
        public virtual DbSet<TblRawMaterialBeginPeriod> TblRawMaterialBeginPeriods { get; set; }
        public virtual DbSet<TblRawMaterialProduct> TblRawMaterialProducts { get; set; }
        public virtual DbSet<TblRawMaterialProductComposition> TblRawMaterialProductCompositions { get; set; }
        public virtual DbSet<TblRawMaterialProductCompositionType> TblRawMaterialProductCompositionTypes { get; set; }
        public virtual DbSet<TblRawMaterialProductDevelopment> TblRawMaterialProductDevelopments { get; set; }
        public virtual DbSet<TblRawMaterialProductDevelopmentType> TblRawMaterialProductDevelopmentTypes { get; set; }
        public virtual DbSet<TblRawMaterialProductGallery> TblRawMaterialProductGalleries { get; set; }
        public virtual DbSet<TblRawMaterialProductProgram> TblRawMaterialProductPrograms { get; set; }
        public virtual DbSet<TblRawMaterialProductProgramParameter> TblRawMaterialProductProgramParameters { get; set; }
        public virtual DbSet<TblRawMaterialProductProgramType> TblRawMaterialProductProgramTypes { get; set; }
        public virtual DbSet<TblRawMaterialStockSheet> TblRawMaterialStockSheets { get; set; }
        public virtual DbSet<TblRawMaterialStockSheetItem> TblRawMaterialStockSheetItems { get; set; }
        public virtual DbSet<TblRawMaterialStockSheetSubType> TblRawMaterialStockSheetSubTypes { get; set; }
        public virtual DbSet<TblRawMaterialStockSheetType> TblRawMaterialStockSheetTypes { get; set; }
        public virtual DbSet<TblReason> TblReasons { get; set; }
        public virtual DbSet<TblRegistrarType> TblRegistrarTypes { get; set; }
        public virtual DbSet<TblRelationType> TblRelationTypes { get; set; }
        public virtual DbSet<TblReligion> TblReligions { get; set; }
        public virtual DbSet<TblRemainType> TblRemainTypes { get; set; }
        public virtual DbSet<TblReportDetail> TblReportDetails { get; set; }
        public virtual DbSet<TblReportDetailItem> TblReportDetailItems { get; set; }
        public virtual DbSet<TblReportDetailItemYear> TblReportDetailItemYears { get; set; }
        public virtual DbSet<TblReportHeader> TblReportHeaders { get; set; }
        public virtual DbSet<TblReportType> TblReportTypes { get; set; }
        public virtual DbSet<TblResponsibility> TblResponsibilities { get; set; }
        public virtual DbSet<TblResponsibilityTask> TblResponsibilityTasks { get; set; }
        public virtual DbSet<TblRole> TblRoles { get; set; }
        public virtual DbSet<TblRolePermision> TblRolePermisions { get; set; }
        public virtual DbSet<TblRoleTypesMatrix> TblRoleTypesMatrices { get; set; }
        public virtual DbSet<TblSafe> TblSaves { get; set; }
        public virtual DbSet<TblSafeReceiptPayment> TblSafeReceiptPayments { get; set; }
        public virtual DbSet<TblSafeReceiptPaymentCash> TblSafeReceiptPaymentCashes { get; set; }
        public virtual DbSet<TblSafeReceiptPaymentCashBeginPeriod> TblSafeReceiptPaymentCashBeginPeriods { get; set; }
        public virtual DbSet<TblSafeReceiptPaymentCashEndOfDayOperation> TblSafeReceiptPaymentCashEndOfDayOperations { get; set; }
        public virtual DbSet<TblSafeReceiptPaymentCheque> TblSafeReceiptPaymentCheques { get; set; }
        public virtual DbSet<TblSafeReceiptPaymentChequeExpenditure> TblSafeReceiptPaymentChequeExpenditures { get; set; }
        public virtual DbSet<TblSafeReceiptPaymentPo> TblSafeReceiptPaymentPos { get; set; }
        public virtual DbSet<TblSafeReceiptPaymentPromissoryNote> TblSafeReceiptPaymentPromissoryNotes { get; set; }
        public virtual DbSet<TblSafeReceiptPaymentSettleTransfer> TblSafeReceiptPaymentSettleTransfers { get; set; }
        public virtual DbSet<TblSafeReceiptPaymentType> TblSafeReceiptPaymentTypes { get; set; }
        public virtual DbSet<TblSeasonReportDetail> TblSeasonReportDetails { get; set; }
        public virtual DbSet<TblSeasonReportHeader> TblSeasonReportHeaders { get; set; }
        public virtual DbSet<TblService> TblServices { get; set; }
        public virtual DbSet<TblServiceAttendance> TblServiceAttendances { get; set; }
        public virtual DbSet<TblServiceEmployee> TblServiceEmployees { get; set; }
        public virtual DbSet<TblShiftDay> TblShiftDays { get; set; }
        public virtual DbSet<TblShiftDayName> TblShiftDayNames { get; set; }
        public virtual DbSet<TblShiftEmployee> TblShiftEmployees { get; set; }
        public virtual DbSet<TblSkill> TblSkills { get; set; }
        public virtual DbSet<TblSm> TblSms { get; set; }
        public virtual DbSet<TblSmstype> TblSmstypes { get; set; }
        public virtual DbSet<TblSoftware> TblSoftwares { get; set; }
        public virtual DbSet<TblSoftwareType> TblSoftwareTypes { get; set; }
        public virtual DbSet<TblSoftwareVersion> TblSoftwareVersions { get; set; }
        public virtual DbSet<TblStockSheet> TblStockSheets { get; set; }
        public virtual DbSet<TblStockSheetItem> TblStockSheetItems { get; set; }
        public virtual DbSet<TblStockSheetSubType> TblStockSheetSubTypes { get; set; }
        public virtual DbSet<TblStockSheetType> TblStockSheetTypes { get; set; }
        public virtual DbSet<TblStorePlan> TblStorePlans { get; set; }
        public virtual DbSet<TblTag> TblTags { get; set; }
        public virtual DbSet<TblTaskStatus> TblTaskStatuses { get; set; }
        public virtual DbSet<TblTaskType> TblTaskTypes { get; set; }
        public virtual DbSet<TblTaxBranch> TblTaxBranches { get; set; }
        public virtual DbSet<TblTaxBranchSummary> TblTaxBranchSummaries { get; set; }
        public virtual DbSet<TblTaxInfo> TblTaxInfos { get; set; }
        public virtual DbSet<TblTaxPercent> TblTaxPercents { get; set; }
        public virtual DbSet<TblTimeKeeping> TblTimeKeepings { get; set; }
        public virtual DbSet<TblUniqueInfo> TblUniqueInfos { get; set; }
        public virtual DbSet<TblUserRight> TblUserRights { get; set; }
        public virtual DbSet<TblVehicleType> TblVehicleTypes { get; set; }
        public virtual DbSet<TblWhQ> TblWhQs { get; set; }
        public virtual DbSet<TblWorkCondition> TblWorkConditions { get; set; }
        public virtual DbSet<TblWorkDay> TblWorkDays { get; set; }
        public virtual DbSet<TblWorkDayName> TblWorkDayNames { get; set; }
        public virtual DbSet<TblWorkOperation> TblWorkOperations { get; set; }
        public virtual DbSet<TblWorkPlaceSituation> TblWorkPlaceSituations { get; set; }
        public virtual DbSet<TempAsso> TempAssos { get; set; }
        public virtual DbSet<TempFullAccountCode> TempFullAccountCodes { get; set; }
        public virtual DbSet<TempMember> TempMembers { get; set; }
        public virtual DbSet<TempTable1> TempTable1s { get; set; }
        public virtual DbSet<ViewEmploymentAll> ViewEmploymentAlls { get; set; }
        public virtual DbSet<ViewEmploymentAllFactor> ViewEmploymentAllFactors { get; set; }
        public virtual DbSet<ViewEmploymentAllStaff> ViewEmploymentAllStaffs { get; set; }
        public virtual DbSet<ViewInvoiceDiscount> ViewInvoiceDiscounts { get; set; }
        public virtual DbSet<ViewInvoiceMaster> ViewInvoiceMasters { get; set; }
        public virtual DbSet<ViewInvoiceMasterDiscount> ViewInvoiceMasterDiscounts { get; set; }
        public virtual DbSet<ViewInvoiceMasterPointRange> ViewInvoiceMasterPointRanges { get; set; }
        public virtual DbSet<ViewInvoiceSlave> ViewInvoiceSlaves { get; set; }
        public virtual DbSet<ViewPerson> ViewPeople { get; set; }
        public virtual DbSet<ViewPersonAllStaff> ViewPersonAllStaffs { get; set; }
        public virtual DbSet<ViewPersonVisitedUrl> ViewPersonVisitedUrls { get; set; }
        public virtual DbSet<ViewPost> ViewPosts { get; set; }
        public virtual DbSet<ViewRoleTypeMatrix> ViewRoleTypeMatrices { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<AspstateTempApplication>(entity =>
            {
                entity.HasKey(e => e.AppId)
                    .HasName("PK__ASPState__8E2CF7F9FAE81345");

                entity.ToTable("ASPStateTempApplications");

                entity.HasIndex(e => e.AppName, "Index_AppName")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.AppId).ValueGeneratedNever();

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasMaxLength(280)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AspstateTempSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK__ASPState__C9F49290F28994E6");

                entity.ToTable("ASPStateTempSessions");

                entity.HasIndex(e => e.Expires, "Index_Expires")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.SessionId).HasMaxLength(88);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Expires).HasColumnType("datetime");

                entity.Property(e => e.LockDate).HasColumnType("datetime");

                entity.Property(e => e.LockDateLocal).HasColumnType("datetime");

                entity.Property(e => e.SessionItemLong).HasColumnType("image");

                entity.Property(e => e.SessionItemShort).HasMaxLength(7000);
            });

            modelBuilder.Entity<TblAbility>(entity =>
            {
                entity.ToTable("Tbl_Ability");

                entity.HasComment("جدولی برای نمایش اطلاعات توانایی");

                entity.Property(e => e.Id).HasComment("شناسه توانایی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد توانایی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");
            });

            modelBuilder.Entity<TblAbsenceLicense>(entity =>
            {
                entity.ToTable("Tbl_AbsenceLicense");

                entity.HasComment("جدولی برای نمایش اطلاعات مرخصی");

                entity.HasIndex(e => new { e.TblPersonId, e.StartDate, e.EndDate, e.IsSent, e.IsDeleted }, "SecondIndex")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblPersonId, e.TblLicenseId, e.IsDeleted, e.Status, e.StartDate, e.EndDate }, "_dta_index_Tbl_AbsenceLicense_29_57155349__K2_K3_K14_K11_K4_K5_1_6_7_8_9_10_12_13")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.EndDate, e.TblPersonId, e.IsDeleted, e.StartDate, e.Id, e.StartTime, e.EndTime }, "_dta_index_Tbl_AbsenceLicense_29_57155349__K5_K2_K14_K4_K1_K6_K7")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه مرخصی");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح مرخصی");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاريخ اتمام مرخصی");

                entity.Property(e => e.EndTime).HasComment("ساعت اتمام مرخصی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف مرخصی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول مرخصی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول مرخصی");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاريخ شروع مرخصی");

                entity.Property(e => e.StartTime).HasComment("ساعت شروع مرخصی");

                entity.Property(e => e.Status).HasComment("وضعیت مرخصی");

                entity.Property(e => e.TblLicenseId)
                    .HasColumnName("Tbl_License_Id")
                    .HasComment("آی دی نوع مرخصی از جدول مرخصی ها");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.Property(e => e.Used).HasComment("میزان مرخصی استفاده شده");

                entity.HasOne(d => d.TblLicense)
                    .WithMany(p => p.TblAbsenceLicenses)
                    .HasForeignKey(d => d.TblLicenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_AbsenceLicense_Tbl_License");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblAbsenceLicenses)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_AbsenceLicense_Tbl_Person");
            });

            modelBuilder.Entity<TblAbsenceLicenseRequest>(entity =>
            {
                entity.ToTable("Tbl_AbsenceLicenseRequest");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف مرخصی");

                entity.Property(e => e.FromDateTime).HasColumnType("datetime");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول مرخصی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول مرخصی");

                entity.Property(e => e.IssueDateTime).HasColumnType("datetime");

                entity.Property(e => e.Status).HasComment("وضعیت مرخصی");

                entity.Property(e => e.TblLicenceId).HasColumnName("Tbl_Licence_Id");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.Property(e => e.ToDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.TblLicence)
                    .WithMany(p => p.TblAbsenceLicenseRequests)
                    .HasForeignKey(d => d.TblLicenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_AbsenceLicenseRequestDetail_Tbl_License");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblAbsenceLicenseRequests)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_AbsenceLicenseRequestDetail_Tbl_Person");
            });

            modelBuilder.Entity<TblAbsenceLicenseRequestAttachment>(entity =>
            {
                entity.ToTable("Tbl_AbsenceLicenseRequestAttachment");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblAbsenceLicenseRequestId).HasColumnName("Tbl_AbsenceLicenseRequest_Id");

                entity.HasOne(d => d.TblAbsenceLicenseRequest)
                    .WithMany(p => p.TblAbsenceLicenseRequestAttachments)
                    .HasForeignKey(d => d.TblAbsenceLicenseRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_AbsenceLicenseRequestAttachment_Tbl_AbsenceLicenseRequest");
            });

            modelBuilder.Entity<TblAbsenceLicenseRequestDetail>(entity =>
            {
                entity.ToTable("Tbl_AbsenceLicenseRequestDetail");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول بانک");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول بانک");

                entity.Property(e => e.TblAbsenceLicenseRequestId).HasColumnName("Tbl_AbsenceLicenseRequest_Id");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.HasOne(d => d.TblAbsenceLicenseRequest)
                    .WithMany(p => p.TblAbsenceLicenseRequestDetails)
                    .HasForeignKey(d => d.TblAbsenceLicenseRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_AbsenceLicenseRequestDetail_Tbl_AbsenceLicenseRequestDetail");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblAbsenceLicenseRequestDetails)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_AbsenceLicenseRequestDetail_Tbl_Person1");
            });

            modelBuilder.Entity<TblAccountInfo>(entity =>
            {
                entity.ToTable("Tbl_AccountInfo");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UniqueInfoValue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblAsset>(entity =>
            {
                entity.ToTable("Tbl_Asset");

                entity.HasComment("جدولی برای نمایش اطلاعات دارایی");

                entity.HasIndex(e => new { e.TblAssetGoodId, e.TblPlaceTypeId, e.TblAssetOutTypeId, e.InvoiceDate, e.IsDeleted }, "NonClusteredIndex-20181017-122742")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه دارایی");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد حساب در جدول دارایی");

                entity.Property(e => e.AssetCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد دارایی");

                entity.Property(e => e.AssetName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام دارایی");

                entity.Property(e => e.Count).HasComment("تعداد دارایی");

                entity.Property(e => e.CumulativeDepreciation).HasComment("استهلاک انباشته دارایی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف دارایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.InvoiceDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ فاکتور دارایی");

                entity.Property(e => e.InvoiceNumber).HasComment("شماره فاکتور دارایی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول دارایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول دارایی");

                entity.Property(e => e.Number).HasComment("شماره دارایی");

                entity.Property(e => e.Price).HasComment("قیمت دارایی");

                entity.Property(e => e.SalvageDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ اسقاطی");

                entity.Property(e => e.SalvageNumber).HasComment("شماره اسقاطی");

                entity.Property(e => e.SalvagePrice).HasComment("قیمت اسقاطی");

                entity.Property(e => e.Status).HasComment("وضعیت دارایی");

                entity.Property(e => e.TblAssetGoodId)
                    .HasColumnName("Tbl_AssetGood_Id")
                    .HasComment("آی دی اموال از جدول اموال");

                entity.Property(e => e.TblAssetOutTypeId).HasColumnName("Tbl_AssetOutType_Id");

                entity.Property(e => e.TblPlaceTypeId)
                    .HasColumnName("Tbl_PlaceType_Id")
                    .HasComment("آدی نوع مکان از جدول نوع مکان");

                entity.HasOne(d => d.TblAssetGood)
                    .WithMany(p => p.TblAssets)
                    .HasForeignKey(d => d.TblAssetGoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Asset_Tbl_AssetGood");

                entity.HasOne(d => d.TblAssetOutType)
                    .WithMany(p => p.TblAssets)
                    .HasForeignKey(d => d.TblAssetOutTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Asset_Tbl_AssetOutType");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblAssets)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Asset_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblAssetCumulativeDepreciation>(entity =>
            {
                entity.ToTable("Tbl_AssetCumulativeDepreciation");

                entity.HasComment("جدولی برای نمایش اطلاعات استهلاک انباشته دارایی");

                entity.HasIndex(e => new { e.TblAssetId, e.ProcessDate, e.IsDeleted }, "NonClusteredIndex-20181017-122813")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه استهلاک انباشته");

                entity.Property(e => e.CumulativeDepreciation).HasComment("استهلاک انباشته");

                entity.Property(e => e.CurrentDepreciation).HasComment("استهلاک فعلی  ");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف استهلاک انباشته");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول استهلاک انباشته");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول استهلاک انباشته");

                entity.Property(e => e.ProcessDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پردازش");

                entity.Property(e => e.RemainedDepreciation).HasComment("استهلاک باقی مانده");

                entity.Property(e => e.Status).HasComment("وضعیت استهلاک انباشته");

                entity.Property(e => e.TblAssetId)
                    .HasColumnName("Tbl_Asset_Id")
                    .HasComment("آی دی دارایی از جدول دارایی");

                entity.HasOne(d => d.TblAsset)
                    .WithMany(p => p.TblAssetCumulativeDepreciations)
                    .HasForeignKey(d => d.TblAssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_AssetCumulativeDepreciation_Tbl_AssetCumulativeDepreciation");
            });

            modelBuilder.Entity<TblAssetGood>(entity =>
            {
                entity.ToTable("Tbl_AssetGood");

                entity.HasComment("جدولی برای نمایش اطلاعات اموال");

                entity.HasIndex(e => new { e.TblAssetGroupId, e.IsDeleted }, "NonClusteredIndex-20181017-122834");

                entity.Property(e => e.Id).HasComment("شناسه اموال");

                entity.Property(e => e.Code).HasComment("کد گروه اموال");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف اموال");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اموال");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اموال");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام گروه امو ال");

                entity.Property(e => e.Status).HasComment("وضعیت اموال");

                entity.Property(e => e.TblAssetGroupId)
                    .HasColumnName("Tbl_AssetGroup_Id")
                    .HasComment("آی دی گروه اموال از جدول گروه اموال");

                entity.HasOne(d => d.TblAssetGroup)
                    .WithMany(p => p.TblAssetGoods)
                    .HasForeignKey(d => d.TblAssetGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_AssetGood_Tbl_AssetGroup");
            });

            modelBuilder.Entity<TblAssetGoodFormula>(entity =>
            {
                entity.ToTable("Tbl_AssetGoodFormula");

                entity.HasIndex(e => new { e.TblAssetGoodId, e.TblAssetMethodId, e.IsDeleted, e.FromDate, e.ToDate }, "NonClusteredIndex-20181017-122848")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه توانایی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع اموال");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.SalvageYears).HasComment("سال اسقاطی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.TblAssetGoodId)
                    .HasColumnName("Tbl_AssetGood_Id")
                    .HasComment("کد توانایی");

                entity.Property(e => e.TblAssetMethodId)
                    .HasColumnName("Tbl_AssetMethod_Id")
                    .HasComment("نوع استهلاک اموال");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان اموال");

                entity.HasOne(d => d.TblAssetGood)
                    .WithMany(p => p.TblAssetGoodFormulas)
                    .HasForeignKey(d => d.TblAssetGoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_AssetGoodFormula_Tbl_AssetGood");

                entity.HasOne(d => d.TblAssetMethod)
                    .WithMany(p => p.TblAssetGoodFormulas)
                    .HasForeignKey(d => d.TblAssetMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_AssetGoodFormula_Tbl_AssetMethod");
            });

            modelBuilder.Entity<TblAssetGroup>(entity =>
            {
                entity.ToTable("Tbl_AssetGroup");

                entity.HasComment("جدولی برای نمایش اطلاعات گروه اموال");

                entity.HasIndex(e => new { e.TblCompanyId, e.IsDeleted }, "NonClusteredIndex-20181017-122922")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه گروه دارایی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد گروه اموال");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف گروه اموال");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول گروه اموال");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول  گروه اموال");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام گروه اموال");

                entity.Property(e => e.Status).HasComment("وضعیت گروه اموال");

                entity.Property(e => e.TblCompanyId).HasColumnName("Tbl_Company_Id");

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblAssetGroups)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_AssetGroup_Tbl_Company");
            });

            modelBuilder.Entity<TblAssetMethod>(entity =>
            {
                entity.ToTable("Tbl_AssetMethod");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد توانایی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");
            });

            modelBuilder.Entity<TblAssetOutType>(entity =>
            {
                entity.ToTable("Tbl_AssetOutType");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف دارایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول دارایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول دارایی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("وضعیت دارایی");
            });

            modelBuilder.Entity<TblAttachment>(entity =>
            {
                entity.ToTable("Tbl_Attachment");

                entity.HasComment("جدولی برای نمایش اطلاعات ضمیمه");

                entity.HasIndex(e => new { e.Id, e.TblPersonId, e.TblAttachmentTypeId, e.IsDeleted }, "Attachment")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه ضمیمه");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasComment("فایل های ضمیمه شده");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("توصیف فایل های ضمیمه شده");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasComment("نام فایل های ضمیمه شده");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول ضمیمه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول ضمیمه");

                entity.Property(e => e.Status).HasComment("وضعیت فایل های ضمیمه شده");

                entity.Property(e => e.TblAttachmentTypeId)
                    .HasColumnName("Tbl_AttachmentType_Id")
                    .HasComment("آی دی نوع ضمیمه از جدول نوع ضمیمه");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.HasOne(d => d.TblAttachmentType)
                    .WithMany(p => p.TblAttachments)
                    .HasForeignKey(d => d.TblAttachmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Attachment_Tbl_AttachmentType");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblAttachments)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Attachment_Tbl_Person");
            });

            modelBuilder.Entity<TblAttachmentType>(entity =>
            {
                entity.ToTable("Tbl_AttachmentType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع ضمیمه");

                entity.Property(e => e.Id).HasComment("شناسه نوع ضمیمه");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع ضمیمه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع ضمیمه");

                entity.Property(e => e.Guid).HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع ضمیمه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع ضمیمه");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع ضمیمه");

                entity.Property(e => e.Status).HasComment("توصیف نوع ضمیمه");
            });

            modelBuilder.Entity<TblBank>(entity =>
            {
                entity.ToTable("Tbl_Bank");

                entity.HasComment("جدولی برای نمایش اطلاعات بانک");

                entity.Property(e => e.Id).HasComment("شناسه بانک");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد بانک");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف بانک");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول بانک");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول بانک");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام بانک");

                entity.Property(e => e.Status).HasComment("وضعیت بانک");
            });

            modelBuilder.Entity<TblBankAccountType>(entity =>
            {
                entity.ToTable("Tbl_BankAccountType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع حساب بانکی");

                entity.Property(e => e.Id).HasComment("شناسه نوع حساب بانکی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد  نوع حساب بانکی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع حساب بانکی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.HasCheque).HasComment("بیان اطلاعات دسته چک در جدول نوع حساب بانکی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع حساب بانکی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع حساب بانکی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع حساب بانکی");

                entity.Property(e => e.Status).HasComment("وضعیت نوع حساب بانکی");
            });

            modelBuilder.Entity<TblBankBranch>(entity =>
            {
                entity.ToTable("Tbl_BankBranch");

                entity.HasComment("جدولی برای نمایش اطلاعات شعب بانک");

                entity.HasIndex(e => new { e.TblBankId, e.IsDeleted }, "NonClusteredIndex-20161218-170417")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه شعب بانک");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد شعب بانک");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف شعب بانک");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول شعب بانک");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول شعب بانک");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام شعب بانک");

                entity.Property(e => e.Status).HasComment("وضعیت شعب بانک");

                entity.Property(e => e.TblBankId)
                    .HasColumnName("Tbl_Bank_Id")
                    .HasComment("آی دی بانک از جدول بانک");

                entity.HasOne(d => d.TblBank)
                    .WithMany(p => p.TblBankBranches)
                    .HasForeignKey(d => d.TblBankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BankBranch_Tbl_Bank");
            });

            modelBuilder.Entity<TblBankBranchAccount>(entity =>
            {
                entity.ToTable("Tbl_BankBranchAccount");

                entity.HasComment("جدولی برای نمایش اطلاعات حساب های موجود در شعب بانکی");

                entity.HasIndex(e => new { e.TblBankBranchId, e.TblPersonId, e.IsDeleted }, "NonClusteredIndex-20161218-163211")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد حساب موجود در شعب بانکی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف حساب موجود در شعب بانک");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول حساب موجود در شعب بانک");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول حساب موجود در شعب بانک ");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام حساب موجود در شعب بانکی");

                entity.Property(e => e.Status).HasComment("وضعیت حساب موجود در شعب بانک");

                entity.Property(e => e.TblBankAccountTypeId)
                    .HasColumnName("Tbl_BankAccountType_Id")
                    .HasComment("آی دی نوع حساب بانکی از جدول نوع حساب بانکی");

                entity.Property(e => e.TblBankBranchId)
                    .HasColumnName("Tbl_BankBranch_Id")
                    .HasComment("آی دی شعبه بانک از جدول شعبه بانک");

                entity.Property(e => e.TblCompanyId)
                    .HasColumnName("Tbl_Company_Id")
                    .HasComment("بیان اطلاعات حساب شرکت در جدول حساب های موجود در شعب بانکی");

                entity.Property(e => e.TblExchangeId)
                    .HasColumnName("Tbl_Exchange_Id")
                    .HasComment("آی دی تبادل ارز از جدول تبادل ارز");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شحص از جدول اشخاص");

                entity.HasOne(d => d.TblBankAccountType)
                    .WithMany(p => p.TblBankBranchAccounts)
                    .HasForeignKey(d => d.TblBankAccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BankBranchAccount_Tbl_BankAccountType");

                entity.HasOne(d => d.TblBankBranch)
                    .WithMany(p => p.TblBankBranchAccounts)
                    .HasForeignKey(d => d.TblBankBranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BankBranchAccount_Tbl_BankBranch");

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblBankBranchAccounts)
                    .HasForeignKey(d => d.TblCompanyId)
                    .HasConstraintName("FK_Tbl_BankBranchAccount_Tbl_Company");

                entity.HasOne(d => d.TblExchange)
                    .WithMany(p => p.TblBankBranchAccounts)
                    .HasForeignKey(d => d.TblExchangeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BankBranchAccount_Tbl_Exchange");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblBankBranchAccounts)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BankBranchAccount_Tbl_Person");
            });

            modelBuilder.Entity<TblBeginPeriod>(entity =>
            {
                entity.ToTable("Tbl_BeginPeriod");

                entity.HasComment("جدولی برای نمایش اطلاعات شروع دوره");

                entity.Property(e => e.Id).HasComment("شناسایی شروع دوره");

                entity.Property(e => e.Count).HasComment("تعداد شروع دوره");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع دوره");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف شروع دوره");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول شروع دوره");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در چدول شروع دوره");

                entity.Property(e => e.Price).HasComment("قیمت شروع دوره");

                entity.Property(e => e.Status).HasComment("وضعیت شروع دوره");

                entity.Property(e => e.TblPlaceTypeId).HasColumnName("Tbl_PlaceType_Id");

                entity.Property(e => e.TblProductId)
                    .HasColumnName("Tbl_Product_Id")
                    .HasComment("آی دی محصول از جدول محصول");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblBeginPeriods)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BeginPeriod_Tbl_PlaceType");

                entity.HasOne(d => d.TblProduct)
                    .WithMany(p => p.TblBeginPeriods)
                    .HasForeignKey(d => d.TblProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BeginPeriod_Tbl_BeginPeriod");
            });

            modelBuilder.Entity<TblBlog>(entity =>
            {
                entity.ToTable("Tbl_Blog");

                entity.HasComment("جدول بلاگ(هاکوپدیا)");

                entity.HasIndex(e => new { e.IsDeleted, e.Id }, "_dta_index_Tbl_Blog_16_1170975398__K18_K1_2_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه بلاگ");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasComment("محتوا بلاگ");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نوع محتوا بلاگ");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("تاریخ انتشار بلاگ");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("شرح بلاگ");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasComment("نام تصویر بلاگ");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصربفرد بین المللی");

                entity.Property(e => e.Image).HasComment("تصویر شاخص بلاگ");

                entity.Property(e => e.IsDeleted).HasComment("حذف شده؟");

                entity.Property(e => e.IsSent).HasComment("ارسال شده؟");

                entity.Property(e => e.LastReview)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RunSchedule)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("وضعیت بلاگ");

                entity.Property(e => e.TblPersonIdAsAuthor)
                    .HasColumnName("Tbl_Person_IdAsAuthor")
                    .HasComment("شناسه نویسنده");

                entity.Property(e => e.Time).HasComment("زمان انتشار بلاگ");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("عنوان بلاگ");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasComment("آدرس بلاگ");

                entity.HasOne(d => d.TblPersonIdAsAuthorNavigation)
                    .WithMany(p => p.TblBlogs)
                    .HasForeignKey(d => d.TblPersonIdAsAuthor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Blog_Tbl_Person");
            });

            modelBuilder.Entity<TblBlogAttachment>(entity =>
            {
                entity.ToTable("Tbl_BlogAttachment");

                entity.Property(e => e.ContentType).HasMaxLength(50);

                entity.Property(e => e.Explanation).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblBlogId).HasColumnName("Tbl_Blog_Id");

                entity.HasOne(d => d.TblBlog)
                    .WithMany(p => p.TblBlogAttachments)
                    .HasForeignKey(d => d.TblBlogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BlogAttachment_Tbl_Blog");
            });

            modelBuilder.Entity<TblBlogCategory>(entity =>
            {
                entity.ToTable("Tbl_BlogCategory");

                entity.HasComment("جدولی برای نمایش دسته‌بند ی ها در هر بلاگ");

                entity.Property(e => e.Id).HasComment("شناسه ");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرج دسته‌بندی‌ در بلاگ");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصربفرد بین المللی");

                entity.Property(e => e.IsDeleted).HasComment("حذف شده؟");

                entity.Property(e => e.IsSent).HasComment("ارسال شده؟");

                entity.Property(e => e.Status).HasComment("وضعیت دسته‌بندی در بلاگ");

                entity.Property(e => e.TblBlogId)
                    .HasColumnName("Tbl_Blog_Id")
                    .HasComment("شناسه بلاگ در جدول بلاگ");

                entity.Property(e => e.TblCategoryId)
                    .HasColumnName("Tbl_Category_Id")
                    .HasComment("شناسه دسته‌بندی‌ها در جدول دسته‌بندی");

                entity.HasOne(d => d.TblBlog)
                    .WithMany(p => p.TblBlogCategories)
                    .HasForeignKey(d => d.TblBlogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BlogCategory_Tbl_Blog");

                entity.HasOne(d => d.TblCategory)
                    .WithMany(p => p.TblBlogCategories)
                    .HasForeignKey(d => d.TblCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BlogCategory_Tbl_Category");
            });

            modelBuilder.Entity<TblBlogGoal>(entity =>
            {
                entity.ToTable("Tbl_BlogGoal");

                entity.Property(e => e.Explanation).HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblBlogId).HasColumnName("Tbl_Blog_Id");

                entity.Property(e => e.TblGoalId).HasColumnName("Tbl_Goal_Id");

                entity.HasOne(d => d.TblBlog)
                    .WithMany(p => p.TblBlogGoals)
                    .HasForeignKey(d => d.TblBlogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BlogGoal_Tbl_Blog");

                entity.HasOne(d => d.TblGoal)
                    .WithMany(p => p.TblBlogGoals)
                    .HasForeignKey(d => d.TblGoalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BlogGoal_Tbl_Goal");
            });

            modelBuilder.Entity<TblBlogLike>(entity =>
            {
                entity.ToTable("Tbl_BlogLike");

                entity.Property(e => e.Explanation).HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblBlogId).HasColumnName("Tbl_Blog_Id");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.HasOne(d => d.TblBlog)
                    .WithMany(p => p.TblBlogLikes)
                    .HasForeignKey(d => d.TblBlogId)
                    .HasConstraintName("FK_Tbl_BlogLike_Tbl_Blog");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblBlogLikes)
                    .HasForeignKey(d => d.TblPersonId)
                    .HasConstraintName("FK_Tbl_BlogLike_Tbl_Person");
            });

            modelBuilder.Entity<TblBlogTag>(entity =>
            {
                entity.ToTable("Tbl_BlogTag");

                entity.HasComment("جدول برای نمایش برچسب های موجود در بلاگ ها");

                entity.Property(e => e.Id).HasComment("شناسه برچسب در بلاگ");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح برچسب در بلاگ");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصربفرد بین المللی");

                entity.Property(e => e.IsDeleted).HasComment("حذف شده؟");

                entity.Property(e => e.IsSent).HasComment("ارسال شده؟");

                entity.Property(e => e.Status).HasComment("وضعیت برچسب در بلاگ");

                entity.Property(e => e.TblBlogId)
                    .HasColumnName("Tbl_Blog_Id")
                    .HasComment("شناسه بلاگ در جدول بلاگ");

                entity.Property(e => e.TblTagId)
                    .HasColumnName("Tbl_Tag_Id")
                    .HasComment("شناسه برچسب در جدول برچسب");

                entity.HasOne(d => d.TblBlog)
                    .WithMany(p => p.TblBlogTags)
                    .HasForeignKey(d => d.TblBlogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BlogTag_Tbl_BlogTag");

                entity.HasOne(d => d.TblTag)
                    .WithMany(p => p.TblBlogTags)
                    .HasForeignKey(d => d.TblTagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BlogTag_Tbl_Tag");
            });

            modelBuilder.Entity<TblBpmn>(entity =>
            {
                entity.ToTable("Tbl_BPMN");

                entity.Property(e => e.Attachment).IsRequired();

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDeleted");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblBpmns)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BPMN_Tbl_Person");
            });

            modelBuilder.Entity<TblBrand>(entity =>
            {
                entity.ToTable("Tbl_Brand");

                entity.HasComment("جدولی برای نمایش اطلاعات برند");

                entity.Property(e => e.Id).HasComment("شناسه برند");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد برند");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف برند");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول برند");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول برند");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام برند");

                entity.Property(e => e.Status).HasComment("وضعیت برند");
            });

            modelBuilder.Entity<TblBudget>(entity =>
            {
                entity.ToTable("Tbl_Budget");

                entity.HasComment("جدولی برای نمایش اطلاعات بودجه");

                entity.Property(e => e.Id).HasComment("شناسه بودجه");

                entity.Property(e => e.BudgetMethod).HasComment("روش بودجه گذاری");

                entity.Property(e => e.BudgetNo).HasComment("شماره بودجه");

                entity.Property(e => e.BudgetType).HasComment("نوع بودجه");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ بودجه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف بودجه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول بودجه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول بودجه");

                entity.Property(e => e.RegistrationType).HasComment("نوع ثبت نام");

                entity.Property(e => e.Status).HasComment("وضعیت بودجه");
            });

            modelBuilder.Entity<TblBudgetItem>(entity =>
            {
                entity.ToTable("Tbl_BudgetItem");

                entity.HasComment("جدولی برای نمایش اطلاعات آیتم های موجود در بودجه");

                entity.Property(e => e.Id).HasComment("شناسه آیتم های موجود در بودجه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف بودجه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول بودجه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول بودجه");

                entity.Property(e => e.Status).HasComment("وضعیت بودجه");

                entity.Property(e => e.TblBudgetId)
                    .HasColumnName("Tbl_Budget_Id")
                    .HasComment("آی دی بودجه از جدول بودجه");

                entity.Property(e => e.TblLedgerId)
                    .HasColumnName("Tbl_Ledger_Id")
                    .HasComment("آی دی حساب از جدول حساب");

                entity.HasOne(d => d.TblBudget)
                    .WithMany(p => p.TblBudgetItems)
                    .HasForeignKey(d => d.TblBudgetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BudgetItem_Tbl_Budget");

                entity.HasOne(d => d.TblLedger)
                    .WithMany(p => p.TblBudgetItems)
                    .HasForeignKey(d => d.TblLedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BudgetItem_Tbl_Ledger");
            });

            modelBuilder.Entity<TblBudgetItemDetail>(entity =>
            {
                entity.ToTable("Tbl_BudgetItemDetail");

                entity.HasComment("جدولی برای نمایش اطلاعات جزئیات آیتم های بودجه");

                entity.Property(e => e.Id).HasComment("شناسه جزئیات آیتم های بودجه");

                entity.Property(e => e.CurrentBudget).HasComment("بودجه فعلی");

                entity.Property(e => e.EstimateBudget).HasComment("برآورد بودجه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف جزئیات آیتم های بودجه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول جزئیات آیتم های بودجه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول جزئیات آیتم های بودجه");

                entity.Property(e => e.Month).HasComment("ماه جزئیات آیتم های بودجه");

                entity.Property(e => e.Status).HasComment("وضعیت جزئیات آیتم های بودجه");

                entity.Property(e => e.TblBudgetItemId)
                    .HasColumnName("Tbl_BudgetItem_Id")
                    .HasComment("آی دی آیتم بودجه از جدول آیتم بودجه");

                entity.HasOne(d => d.TblBudgetItem)
                    .WithMany(p => p.TblBudgetItemDetails)
                    .HasForeignKey(d => d.TblBudgetItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_BudgetItemDetail_Tbl_BudgetItem");
            });

            modelBuilder.Entity<TblCalendarArchive>(entity =>
            {
                entity.ToTable("Tbl_CalendarArchive");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GregorianDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.PersianDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblCallHistory>(entity =>
            {
                entity.ToTable("Tbl_CallHistory");

                entity.HasIndex(e => new { e.TblPersonIdAsToPerson, e.TblPersonIdAsFromPerson, e.IsDeleted, e.FromNumber, e.ToNumber, e.TblCallStatusId }, "_dta_index_Tbl_CallHistory_16_1559168800__K3_K2_K17_K5_K6_K4_1_7_8_9_10_11_12_13_14_15_16")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FromNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TblCallStatusId).HasColumnName("Tbl_CallStatus_Id");

                entity.Property(e => e.TblPersonIdAsFromPerson).HasColumnName("Tbl_Person_IdAsFromPerson");

                entity.Property(e => e.TblPersonIdAsToPerson).HasColumnName("Tbl_Person_IdAsToPerson");

                entity.Property(e => e.ToNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TblCallStatus)
                    .WithMany(p => p.TblCallHistories)
                    .HasForeignKey(d => d.TblCallStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CallHistory_Tbl_CallStatus");

                entity.HasOne(d => d.TblPersonIdAsFromPersonNavigation)
                    .WithMany(p => p.TblCallHistoryTblPersonIdAsFromPersonNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsFromPerson)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CallHistory_Tbl_Person");

                entity.HasOne(d => d.TblPersonIdAsToPersonNavigation)
                    .WithMany(p => p.TblCallHistoryTblPersonIdAsToPersonNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsToPerson)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CallHistory_Tbl_Person1");
            });

            modelBuilder.Entity<TblCallStatus>(entity =>
            {
                entity.ToTable("Tbl_CallStatus");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblCataloge>(entity =>
            {
                entity.ToTable("Tbl_Cataloge");

                entity.HasComment("جدولی برای نمایش اطلاعات کاتالوگ");

                entity.Property(e => e.Id).HasComment("شناسه کاتالوگ");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد کاتالوگ");

                entity.Property(e => e.CoverImage)
                    .IsRequired()
                    .HasComment("تصویر روی جلد");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف کاتالوگ");

                entity.Property(e => e.GregorianYear).HasComment("سال میلادی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول کاتالوگ");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول کاتالوگ");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام کاتالوگ");

                entity.Property(e => e.PersianYear).HasComment("سال فارسی");

                entity.Property(e => e.RatingCount).HasComment("تعداد ارزیابی");

                entity.Property(e => e.RatingValue).HasComment("ارزش ارزیابی");

                entity.Property(e => e.Season).HasComment("فصل کاتالوگ");

                entity.Property(e => e.Status).HasComment("وضعیت کاتالوگ");
            });

            modelBuilder.Entity<TblCatalogeItem>(entity =>
            {
                entity.ToTable("Tbl_CatalogeItem");

                entity.HasComment("جدولی برای نمایش اطلاعات آیتم کاتالوگ");

                entity.Property(e => e.Id).HasComment("شناسه آیتم کاتالوگ");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف ارزیابی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasComment("عکس کاتالوگ");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول آیتم کاتالوگ");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول آیتم کاتالوگ");

                entity.Property(e => e.Order).HasComment("سفارش کاتالوگ");

                entity.Property(e => e.RatingCount).HasComment("تعداد ارزیابی");

                entity.Property(e => e.RatingValue).HasComment("مقدار ارزیابی");

                entity.Property(e => e.Status).HasComment("وضعیت ارزیابی");

                entity.Property(e => e.TblCatalogeId)
                    .HasColumnName("Tbl_Cataloge_Id")
                    .HasComment("آی دی کاتالوگ از جدول کاتالوگ");

                entity.HasOne(d => d.TblCataloge)
                    .WithMany(p => p.TblCatalogeItems)
                    .HasForeignKey(d => d.TblCatalogeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CatalogeItem_Tbl_Cataloge");
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.ToTable("Tbl_Category");

                entity.HasComment("جدول دسته بندی ها ");

                entity.Property(e => e.Id).HasComment("شناسه دسته");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد دسته");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح دسته");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصربفرد بین المللی");

                entity.Property(e => e.IsDeleted).HasComment("حذف شده؟");

                entity.Property(e => e.IsSent).HasComment("ارسال شده؟");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام دسته");

                entity.Property(e => e.Status).HasComment("وضعیت دسته");
            });

            modelBuilder.Entity<TblCattering>(entity =>
            {
                entity.ToTable("Tbl_Cattering");

                entity.HasComment("جدولی برای نمایش اطلاعات آشپزخانه ");

                entity.Property(e => e.Id).HasComment("شناسه آشپزخانه");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد آشپرخانه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف آشپزخانه");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع آشپزخانه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول آشپزخانه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول آشپزخانه");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام آشپزخانه");

                entity.Property(e => e.Status).HasComment("وضعیت آشپزخانه");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان آشپزخانه");
            });

            modelBuilder.Entity<TblCatteringItem>(entity =>
            {
                entity.ToTable("Tbl_CatteringItem");

                entity.HasComment("جدولی برای نمایش اطلاعات آیتم های آشپزخانه");

                entity.Property(e => e.Id).HasComment("شناسه آیتم آشپزخانه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف آیتم آشپزخانه");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع آیتم آشپزخانه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول آیتم آشپزخانه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول آیتم آشپزخانه");

                entity.Property(e => e.Status).HasComment("وضعیت آیتم آشپزخانه");

                entity.Property(e => e.TblCatteringId)
                    .HasColumnName("Tbl_Cattering_Id")
                    .HasComment("آی دی آشپزخانه از جدول آشپزخانه");

                entity.Property(e => e.TblMealId)
                    .HasColumnName("Tbl_Meal_Id")
                    .HasComment("آی دی وعده غذایی از جدول وعده غذایی");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان آیتم آشپزخانه");

                entity.HasOne(d => d.TblCattering)
                    .WithMany(p => p.TblCatteringItems)
                    .HasForeignKey(d => d.TblCatteringId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CatteringItem_Tbl_Cattering");

                entity.HasOne(d => d.TblMeal)
                    .WithMany(p => p.TblCatteringItems)
                    .HasForeignKey(d => d.TblMealId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CatteringItem_Tbl_Meal");
            });

            modelBuilder.Entity<TblCertificate>(entity =>
            {
                entity.ToTable("Tbl_Certificate");

                entity.HasComment("جدولی برای نمایش اطلاعات مدرک");

                entity.Property(e => e.Id).HasComment("شناسه مدرک");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد مدرک");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف مدرک");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول مدرک");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول مدرک");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام مدرک");

                entity.Property(e => e.Status).HasComment("وضعیت مدرک");
            });

            modelBuilder.Entity<TblChannel>(entity =>
            {
                entity.ToTable("Tbl_Channel");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblChat>(entity =>
            {
                entity.ToTable("Tbl_Chat");

                entity.Property(e => e.Attachment).IsRequired();

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.TblPersonIdAsFrom).HasColumnName("Tbl_Person_IdAsFrom");

                entity.Property(e => e.TblPersonIdAsTo).HasColumnName("Tbl_Person_IdAsTo");

                entity.HasOne(d => d.TblPersonIdAsFromNavigation)
                    .WithMany(p => p.TblChatTblPersonIdAsFromNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsFrom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Chat_Tbl_Person");

                entity.HasOne(d => d.TblPersonIdAsToNavigation)
                    .WithMany(p => p.TblChatTblPersonIdAsToNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Chat_Tbl_Person1");
            });

            modelBuilder.Entity<TblCheque>(entity =>
            {
                entity.ToTable("Tbl_Cheque");

                entity.HasComment("جدولی برای نمایش اطلاعات چک");

                entity.Property(e => e.Id).HasComment("شناسه چک");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد چک");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ چک");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف چک");

                entity.Property(e => e.FromSerialNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شروع شماره سریال");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول چک");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول چک");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام چک");

                entity.Property(e => e.Status).HasComment("وضعیت چک");

                entity.Property(e => e.TblBankBranchAccountId)
                    .HasColumnName("Tbl_BankBranchAccount_Id")
                    .HasComment("آی دی حساب شعبه بانکی از جدول حساب شعبه بانکی  ");

                entity.Property(e => e.TblChequeTemplateId)
                    .HasColumnName("Tbl_ChequeTemplate_Id")
                    .HasComment("آی دی قالب چک از جدول قالب چک");

                entity.Property(e => e.ToSerialNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("پایان شماره سریال");

                entity.HasOne(d => d.TblBankBranchAccount)
                    .WithMany(p => p.TblCheques)
                    .HasForeignKey(d => d.TblBankBranchAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Cheque_Tbl_BankBranchAccount");

                entity.HasOne(d => d.TblChequeTemplate)
                    .WithMany(p => p.TblCheques)
                    .HasForeignKey(d => d.TblChequeTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Cheque_Tbl_ChequeTemplate");
            });

            modelBuilder.Entity<TblChequeTemplate>(entity =>
            {
                entity.ToTable("Tbl_ChequeTemplate");

                entity.HasComment("جدولی برای نمایش اطلاعات قالب چک");

                entity.Property(e => e.Id).HasComment("شناسه قالب چک");

                entity.Property(e => e.AmountDigitLeft).HasComment("فاصله مبلغ به حروف از چپ");

                entity.Property(e => e.AmountDigitLength).HasComment("طول فیلد مبلغ به حروف");

                entity.Property(e => e.AmountDigitTop).HasComment("فاصله مبلغ به حروف از بالا");

                entity.Property(e => e.AmountLetterLeft).HasComment("فاصله فیلد در وجه از چپ");

                entity.Property(e => e.AmountLetterLength).HasComment("طول فیلد مبلغ به حروف");

                entity.Property(e => e.AmountLetterTop).HasComment("فاصله فیلد در وجه از بالا");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد قالب چک");

                entity.Property(e => e.DateDigitLeft).HasComment("فاصله تاریخ از سمت چپ");

                entity.Property(e => e.DateDigitLength).HasComment("طول فیلد تاریخ ");

                entity.Property(e => e.DateDigitTop).HasComment("فاصله تاریخ از بالا");

                entity.Property(e => e.DateLetterLeft).HasComment("فاصله مبلغ به عدد از چپ");

                entity.Property(e => e.DateLetterLength).HasComment("طول فیلد مبلغ ");

                entity.Property(e => e.DateLetterTop).HasComment("فاصله مبلغ به عدد از بالا");

                entity.Property(e => e.DraftedToLeft).HasComment("فاصله فیلد بابت از چپ");

                entity.Property(e => e.DraftedToLength).HasComment("طول فیلد بابت");

                entity.Property(e => e.DraftedToTop).HasComment("فاصله فیلد بابت از بالا");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف قالب چک");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول قالب چک");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول قالب چک");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام قالب چک");

                entity.Property(e => e.PaymentToLeft).HasComment("فاصله پرداخت به از چپ");

                entity.Property(e => e.PaymentToLength).HasComment("طول فیلد پرداخت به");

                entity.Property(e => e.PaymentToTop).HasComment("فاصله پرداخت به از بالا");

                entity.Property(e => e.Status).HasComment("وضعیت قالب چک");
            });

            modelBuilder.Entity<TblCity>(entity =>
            {
                entity.ToTable("Tbl_City");

                entity.HasComment("جدولی برای نمایش اطلاعات شهر");

                entity.Property(e => e.Id).HasComment("شناسه شهر");

                entity.Property(e => e.CityCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد شهر");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام شهر");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف شهر");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول شهر");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول شهر");

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("وضعیت شهر");

                entity.Property(e => e.TblProvinceId)
                    .HasColumnName("Tbl_Province_Id")
                    .HasComment("آی دی استان از جدول استان");

                entity.HasOne(d => d.TblProvince)
                    .WithMany(p => p.TblCities)
                    .HasForeignKey(d => d.TblProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_City_Tbl_Province");
            });

            modelBuilder.Entity<TblCodingPattern>(entity =>
            {
                entity.ToTable("Tbl_CodingPattern");

                entity.HasComment(" جدولی برای نمایش اطلاعات الگوی کدینگ");

                entity.Property(e => e.Id).HasComment("شناسه الگوی کدینگ");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد الگوی کدینگ");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف الگوی کدینگ");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول الگوی کدینگ");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول الگوی کدینگ");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام الگوی کدینگ");

                entity.Property(e => e.Status).HasComment("وضعیت الگوی کدینگ");

                entity.Property(e => e.TblCompanyId).HasColumnName("Tbl_Company_Id");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblCodingPatterns)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CodingPattern_Tbl_Company");
            });

            modelBuilder.Entity<TblCodingPatternKey>(entity =>
            {
                entity.ToTable("Tbl_CodingPatternKey");

                entity.Property(e => e.Id).HasComment("شناسه الگوی کدینگ");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد الگوی کدینگ");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف الگوی کدینگ");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول الگوی کدینگ");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول الگوی کدینگ");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام الگوی کدینگ");

                entity.Property(e => e.Status).HasComment("وضعیت الگوی کدینگ");

                entity.Property(e => e.TblCodingPatternId).HasColumnName("Tbl_CodingPattern_Id");

                entity.HasOne(d => d.TblCodingPattern)
                    .WithMany(p => p.TblCodingPatternKeys)
                    .HasForeignKey(d => d.TblCodingPatternId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CodingPatternKey_Tbl_CodingPattern");
            });

            modelBuilder.Entity<TblCodingPatternValue>(entity =>
            {
                entity.ToTable("Tbl_CodingPatternValue");

                entity.HasIndex(e => new { e.TblCodingPatternValueTypeId, e.IsDeleted }, "NonClusteredIndex-20200503-194313");

                entity.HasIndex(e => new { e.TblCodingPatternValueTypeId, e.ParentId, e.Explanation, e.Status, e.Guid, e.IsSent, e.IsDeleted }, "NonClusteredIndex-20200504-075502");

                entity.HasIndex(e => new { e.TblCodingPatternValueTypeId, e.IsDeleted, e.ParentId }, "NonClusteredIndex-20200504-183413");

                entity.Property(e => e.Id).HasComment("شناسه الگوی کدینگ");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف الگوی کدینگ");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول الگوی کدینگ");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول الگوی کدینگ");

                entity.Property(e => e.Status).HasComment("وضعیت الگوی کدینگ");

                entity.Property(e => e.TblCodingPatternValueTypeId).HasColumnName("Tbl_CodingPatternValueType_Id");

                entity.HasOne(d => d.TblCodingPatternValueType)
                    .WithMany(p => p.TblCodingPatternValues)
                    .HasForeignKey(d => d.TblCodingPatternValueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CodingPatternValue_Tbl_CodingPatternValueType");
            });

            modelBuilder.Entity<TblCodingPatternValueType>(entity =>
            {
                entity.ToTable("Tbl_CodingPatternValueType");

                entity.HasIndex(e => new { e.TblCodingPatternKeyId, e.Code, e.Name, e.Explanation, e.Status, e.Guid, e.IsSent, e.IsDeleted }, "NonClusteredIndex-20200504-075431");

                entity.HasIndex(e => new { e.Code, e.TblCodingPatternKeyId }, "NonClusteredIndex-20200504-181822");

                entity.HasIndex(e => new { e.TblCodingPatternKeyId, e.Code, e.IsDeleted }, "NonClusteredIndex-20200504-182157");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TblCodingPatternKeyId).HasColumnName("Tbl_CodingPatternKey_Id");
            });

            modelBuilder.Entity<TblComment>(entity =>
            {
                entity.ToTable("Tbl_Comment");

                entity.HasComment("جدول دیدگاه ها(هاکوپدیا)");

                entity.Property(e => e.Id).HasComment("شناسه دیدگاه");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("تاریخ ارسال دیدگاه");

                entity.Property(e => e.Explanation).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasComment("شناسه والد");

                entity.Property(e => e.Reply)
                    .IsRequired()
                    .HasComment("پاسخ دیدگاه");

                entity.Property(e => e.TblBlogId)
                    .HasColumnName("Tbl_Blog_Id")
                    .HasComment("شناسه بلاگ");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("شناسه پرسنل");

                entity.Property(e => e.Time).HasComment("زمان ارسال دیدگاه");

                entity.HasOne(d => d.TblBlog)
                    .WithMany(p => p.TblComments)
                    .HasForeignKey(d => d.TblBlogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Comment_Tbl_Blog");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblComments)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Comment_Tbl_Person");
            });

            modelBuilder.Entity<TblCommentLike>(entity =>
            {
                entity.ToTable("Tbl_CommentLike");

                entity.Property(e => e.Explanation).HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblCommentId).HasColumnName("Tbl_Comment_Id");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.HasOne(d => d.TblComment)
                    .WithMany(p => p.TblCommentLikes)
                    .HasForeignKey(d => d.TblCommentId)
                    .HasConstraintName("FK_Tbl_CommentLike_Tbl_Comment");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblCommentLikes)
                    .HasForeignKey(d => d.TblPersonId)
                    .HasConstraintName("FK_Tbl_CommentLike_Tbl_Person");
            });

            modelBuilder.Entity<TblCompany>(entity =>
            {
                entity.ToTable("Tbl_Company");

                entity.HasComment(" جدولی برای نمایش اطلاعات شرکت");

                entity.Property(e => e.Id).HasComment("شناسه شرکت");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasComment("کد شرکت");

                entity.Property(e => e.EconomicNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شماره اقتصادی");

                entity.Property(e => e.EnglishName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف شرکت");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول شرکت");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول شرکت");

                entity.Property(e => e.Logo)
                    .HasColumnType("image")
                    .HasComment("عکس لوگو شرکت");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام شرکت");

                entity.Property(e => e.NationalNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شناسه ملی");

                entity.Property(e => e.RegistrationNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شماره ثبت");

                entity.Property(e => e.Status).HasComment("وضعیت شرکت");
            });

            modelBuilder.Entity<TblCompanyCharge>(entity =>
            {
                entity.ToTable("Tbl_CompanyCharge");

                entity.Property(e => e.Id).HasComment("شناسه شارژ شخص");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف شارژ کارت شخص");

                entity.Property(e => e.FromAmount).HasComment("شروع مبلغ خرید شارژ کارت شخص");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع کارت شارژ شخص");

                entity.Property(e => e.FromPercent).HasComment("شروع درصد خرید شارژ کارت شخص");

                entity.Property(e => e.FromPurchase).HasComment("شروع خرید از");

                entity.Property(e => e.FromRemained).HasComment("کف باقیمانده شارژ");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول شارژ کارت شخص");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول شارژ کارت شخص");

                entity.Property(e => e.Status).HasComment("وضعیت شارژ کارت شخص");

                entity.Property(e => e.TblCompanyId)
                    .HasColumnName("Tbl_Company_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.Property(e => e.ToAmount).HasComment("پایان مبلغ خرید شارژ کارت شخص");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان شارژ  کارت شخص");

                entity.Property(e => e.ToPercent).HasComment("پایان درصد خرید شارژ کارت شخص");

                entity.Property(e => e.ToPurchase).HasComment("پایان خرید تا");

                entity.Property(e => e.ToRemained).HasComment("سقف باقیمانده شارژ");

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblCompanyCharges)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CompanyCharge_Tbl_Company");
            });

            modelBuilder.Entity<TblCompanyPerson>(entity =>
            {
                entity.ToTable("Tbl_CompanyPerson");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblCompanyId).HasColumnName("Tbl_Company_Id");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblCompanyPeople)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CompanyPerson_Tbl_Company");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblCompanyPeople)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CompanyPerson_Tbl_Person");
            });

            modelBuilder.Entity<TblCompanyPhone>(entity =>
            {
                entity.ToTable("Tbl_CompanyPhone");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TblCompanyId).HasColumnName("Tbl_Company_Id");

                entity.Property(e => e.TblPhoneTypeId).HasColumnName("Tbl_PhoneType_Id");

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblCompanyPhones)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CompanyPhone_Tbl_Company");

                entity.HasOne(d => d.TblPhoneType)
                    .WithMany(p => p.TblCompanyPhones)
                    .HasForeignKey(d => d.TblPhoneTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CompanyPhone_Tbl_PhoneType");
            });

            modelBuilder.Entity<TblCompanyPlace>(entity =>
            {
                entity.ToTable("Tbl_CompanyPlace");

                entity.Property(e => e.AddressLine).IsRequired();

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Latitude)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Longitude)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Settelment)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TblCityId).HasColumnName("Tbl_City_Id");

                entity.Property(e => e.TblCompanyId).HasColumnName("Tbl_Company_Id");

                entity.Property(e => e.TblDistrictId).HasColumnName("Tbl_District_Id");

                entity.Property(e => e.TblPlaceTypeId).HasColumnName("Tbl_PlaceType_Id");

                entity.HasOne(d => d.TblCity)
                    .WithMany(p => p.TblCompanyPlaces)
                    .HasForeignKey(d => d.TblCityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CompanyPlace_Tbl_City");

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblCompanyPlaces)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CompanyPlace_Tbl_Company");

                entity.HasOne(d => d.TblDistrict)
                    .WithMany(p => p.TblCompanyPlaces)
                    .HasForeignKey(d => d.TblDistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CompanyPlace_Tbl_District");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblCompanyPlaces)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CompanyPlace_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblCompetency>(entity =>
            {
                entity.ToTable("Tbl_Competency");

                entity.HasComment(" جدولی برای نمایش اطلاعات صلاحیت");

                entity.Property(e => e.Id).HasComment("شناسه صلاحیت");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد صلاحیت");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف صلاحیت");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول صلاحیت");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول صلاحیت");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام صلاحیت");

                entity.Property(e => e.Status).HasComment("وضعیت صلاحیت");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نوع صلاحیت");
            });

            modelBuilder.Entity<TblCompetencyItem>(entity =>
            {
                entity.ToTable("Tbl_CompetencyItem");

                entity.HasComment(" جدولی برای نمایش اطلاعات آیتم صلاحیت");

                entity.Property(e => e.Id).HasComment("شناسه آیتم صلاحیت");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد آیتم صلاحیت");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف آیتم صلاحیت");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول آیتم صلاحیت");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول آیتم صلاحیت");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام آیتم صلاحیت");

                entity.Property(e => e.PreferedValue).HasComment("مقدار ترجیح داده شده");

                entity.Property(e => e.Status).HasComment("وضعیت آیتم صلاحیت");

                entity.Property(e => e.TblCompetencyId)
                    .HasColumnName("Tbl_Competency_Id")
                    .HasComment("آی دی صلاحیت از جدول صلاحیت");

                entity.HasOne(d => d.TblCompetency)
                    .WithMany(p => p.TblCompetencyItems)
                    .HasForeignKey(d => d.TblCompetencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CompetencyItem_Tbl_Competency");
            });

            modelBuilder.Entity<TblCompetencyItemFactor>(entity =>
            {
                entity.ToTable("Tbl_CompetencyItemFactor");

                entity.HasComment(" جدولی برای نمایش اطلاعات فاکتور آیتم صلاحیت");

                entity.Property(e => e.Id).HasComment("شناسه فاکتور آیتم صلاحیت");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد فاکتور آیتم صلاحیت");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف فاکتور آیتم صلاحیت");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول فاکتور آیتم صلاحیت");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول فاکتور آیتم صلاحیت");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام فاکتور آیتم صلاحیت");

                entity.Property(e => e.PreferedValue).HasComment("مقدار ترجیح داده شده فاکتور آیتم صلاحیت");

                entity.Property(e => e.Status).HasComment("وضعیت فاکتور آیتم صلاحیت");

                entity.Property(e => e.TblCompetencyItemId)
                    .HasColumnName("Tbl_CompetencyItem_Id")
                    .HasComment("آی دی آیتم صلاحیت از جدول آیتم صلاحیت ");

                entity.HasOne(d => d.TblCompetencyItem)
                    .WithMany(p => p.TblCompetencyItemFactors)
                    .HasForeignKey(d => d.TblCompetencyItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CompetencyItemFactor_Tbl_CompetencyItem");
            });

            modelBuilder.Entity<TblCompetencyItemFactorBehaviour>(entity =>
            {
                entity.ToTable("Tbl_CompetencyItemFactorBehaviour");

                entity.HasComment(" جدولی برای نمایش اطلاعات رفتار فاکتور مورد صلاحیت");

                entity.Property(e => e.Id).HasComment("شناسه صلاحیت رفتار مورد فاکتور");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد فاکتور مورد صلاحیت ");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف رفتار فاکتور مورد صلاحیت ");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول رفتار فاکتور مورد صلاحیت");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول رفتار فاکتور مورد صلاحیت");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام فاکتور مورد صلاحیت ");

                entity.Property(e => e.PreferedValue).HasComment("مقدار ترجیح داده شده رفتار فاکتور مورد صلاحیت ");

                entity.Property(e => e.Status).HasComment("وضعیت رفتار فاکتور مورد صلاحیت ");

                entity.Property(e => e.TblCompetencyItemFactorId)
                    .HasColumnName("Tbl_CompetencyItemFactor_Id")
                    .HasComment("آی دی فاکتور مورد صلاحیت از جدول فاکتور مورد صلاحیت  ");

                entity.HasOne(d => d.TblCompetencyItemFactor)
                    .WithMany(p => p.TblCompetencyItemFactorBehaviours)
                    .HasForeignKey(d => d.TblCompetencyItemFactorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CompetencyItemFactorBehaviour_Tbl_CompetencyItemFactor");
            });

            modelBuilder.Entity<TblComputer>(entity =>
            {
                entity.ToTable("Tbl_Computer");

                entity.HasComment(" جدولی برای نمایش اطلاعات کامپیوتر");

                entity.Property(e => e.Id).HasComment("شناسه کامپیوتر");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد کامپیوتر");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف کامپیوتر");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول کامپیوتر");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول کامپیوتر");

                entity.Property(e => e.Status).HasComment("وضعیت کامپیوتر");

                entity.Property(e => e.Type).HasComment("نوع کامپیوتر");
            });

            modelBuilder.Entity<TblComputerHardware>(entity =>
            {
                entity.ToTable("Tbl_ComputerHardware");

                entity.HasComment(" جدولی برای نمایش اطلاعات سخت افزار کامپیوتر");

                entity.Property(e => e.Id).HasComment("شناسه سخت افزار");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد سخت افزار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف سخت افزار کامپیوتر");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول سخت افزار کامپیوتر");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول سخت افزار کامپیوتر");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام سخت افزار");

                entity.Property(e => e.Status).HasComment("وضعیت سخت افزار کامپیوتر");

                entity.Property(e => e.TblComputerId)
                    .HasColumnName("Tbl_Computer_Id")
                    .HasComment("آی دی کامپیوتر از جدول کامپیوتر");

                entity.Property(e => e.TblHardwareVersionId)
                    .HasColumnName("Tbl_HardwareVersion_Id")
                    .HasComment("آی دی ورژن سخت افزار از جدول ورژن سخت افزار");

                entity.HasOne(d => d.TblComputer)
                    .WithMany(p => p.TblComputerHardwares)
                    .HasForeignKey(d => d.TblComputerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ComputerHardware_Tbl_Computer");

                entity.HasOne(d => d.TblHardwareVersion)
                    .WithMany(p => p.TblComputerHardwares)
                    .HasForeignKey(d => d.TblHardwareVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ComputerHardware_Tbl_HardwareVersion");
            });

            modelBuilder.Entity<TblComputerNetwork>(entity =>
            {
                entity.ToTable("Tbl_ComputerNetwork");

                entity.HasComment("جدولی برای نمایش اطلاعات شبکه کامپیوتر");

                entity.Property(e => e.Id).HasComment("شناسه شبکه");

                entity.Property(e => e.BoxNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شماره بسته");

                entity.Property(e => e.Dns)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DNS")
                    .HasComment("دی ان اس");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف شبکه");

                entity.Property(e => e.Gateway)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("گت وی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress")
                    .HasComment("آی پی آدرس");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول شبکه کامپیوتر");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول شبکه کامپیوتر");

                entity.Property(e => e.MacAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("آدرس مک");

                entity.Property(e => e.Mask)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("مسک");

                entity.Property(e => e.NodeNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شماره نود");

                entity.Property(e => e.Status).HasComment("وضعیت شبکه");

                entity.Property(e => e.SwitchPortNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شماره پورت سوئیچ");

                entity.Property(e => e.TblComputerId)
                    .HasColumnName("Tbl_Computer_Id")
                    .HasComment("آی دی کامپیوتر از جدول کامپیوتر");

                entity.HasOne(d => d.TblComputer)
                    .WithMany(p => p.TblComputerNetworks)
                    .HasForeignKey(d => d.TblComputerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ComputerNetwork_Tbl_Computer");
            });

            modelBuilder.Entity<TblComputerSoftware>(entity =>
            {
                entity.ToTable("Tbl_ComputerSoftware");

                entity.HasComment("جدولی برای نمایش اطلاعات نرم افزار کامپیوتر");

                entity.Property(e => e.Id).HasComment("شناسه نرم افزار");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نرم افزار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نرم افزار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول نرم افزار کامپیوتر");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نرم افزار کامپیوتر");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نرم افزار");

                entity.Property(e => e.Status).HasComment("وضعیت نرم افزار");

                entity.Property(e => e.TblComputerId)
                    .HasColumnName("Tbl_Computer_Id")
                    .HasComment("آی دی کامپیوتر از جدول کامپیوتر");

                entity.Property(e => e.TblSoftwareVersionId)
                    .HasColumnName("Tbl_SoftwareVersion_Id")
                    .HasComment("آی دی ورژن نرم افزار از جدول ورژن نرم افزار");

                entity.HasOne(d => d.TblComputer)
                    .WithMany(p => p.TblComputerSoftwares)
                    .HasForeignKey(d => d.TblComputerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ComputerSoftware_Tbl_Computer");

                entity.HasOne(d => d.TblSoftwareVersion)
                    .WithMany(p => p.TblComputerSoftwares)
                    .HasForeignKey(d => d.TblSoftwareVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ComputerSoftware_Tbl_SoftwareVersion");
            });

            modelBuilder.Entity<TblContractType>(entity =>
            {
                entity.ToTable("Tbl_ContractType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع قرارداد");

                entity.Property(e => e.Id).HasComment("شناسه نوع قرارداد");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع قرارداد");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع قرارداد");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول نوع قرارداد");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع قرارداد");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع قرارداد");

                entity.Property(e => e.Status).HasComment("وضعیت نوع قرارداد");
            });

            modelBuilder.Entity<TblCorrection>(entity =>
            {
                entity.ToTable("Tbl_Correction");

                entity.HasComment("جدولی برای نمایش اطلاعات اصلاحی ها");

                entity.HasIndex(e => new { e.TblPersonId, e.TblLicenseId, e.Date, e.IsDeleted }, "NonClusteredIndex-20161218-170305")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه اصلاحی\r\n");

                entity.Property(e => e.Amount).HasComment("میزان اصلاحی");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("تاریخ اصلاحی");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح اصلاحی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف اصلاحی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول اصلاحی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اصلاحی");

                entity.Property(e => e.Status).HasComment("وضعیت اصلاحی");

                entity.Property(e => e.TblLicenseId)
                    .HasColumnName("Tbl_License_Id")
                    .HasComment("آی دی مجوز مرخصی از جدول مرخصی ها");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.Property(e => e.Type).HasComment("نوع اصلاحی");

                entity.HasOne(d => d.TblLicense)
                    .WithMany(p => p.TblCorrections)
                    .HasForeignKey(d => d.TblLicenseId)
                    .HasConstraintName("FK_Tbl_Correction_Tbl_License");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblCorrections)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Correction_Tbl_Person");
            });

            modelBuilder.Entity<TblCost>(entity =>
            {
                entity.ToTable("Tbl_Costs");

                entity.Property(e => e.Bank).HasDefaultValueSql("((0))");

                entity.Property(e => e.CashDraft).HasDefaultValueSql("((0))");

                entity.Property(e => e.CheckDraft).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cost).HasDefaultValueSql("((0))");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Explanation)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.InsertDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSent).HasDefaultValueSql("((1))");

                entity.Property(e => e.Maskancard)
                    .HasColumnName("maskancard")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MeliCheck).HasDefaultValueSql("((0))");

                entity.Property(e => e.Parsiancard).HasDefaultValueSql("((0))");

                entity.Property(e => e.PersoanlCheque).HasDefaultValueSql("((0))");

                entity.Property(e => e.Receipt).HasDefaultValueSql("((0))");

                entity.Property(e => e.SaderatCheck).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TblInvoiceRegistrarId).HasColumnName("Tbl_InvoiceRegistrar_Id");

                entity.Property(e => e.Time).HasDefaultValueSql("('00:00:00')");

                entity.HasOne(d => d.TblInvoiceRegistrar)
                    .WithMany(p => p.TblCosts)
                    .HasForeignKey(d => d.TblInvoiceRegistrarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Costs_Tbl_RegistrarType");
            });

            modelBuilder.Entity<TblCostFactor>(entity =>
            {
                entity.ToTable("Tbl_CostFactor");

                entity.HasComment("جدولی برای نمایش اطلاعات عوامل هزینه");

                entity.Property(e => e.Id).HasComment("شناسه عوامل هزینه");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد حساب عوامل هزینه");

                entity.Property(e => e.AccountDeduction).HasComment("تخفیف حساب عوامل هزینه");

                entity.Property(e => e.AccountType).HasComment("نوع حساب عوامل هزینه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("توصیف عوامل هزینه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصربه فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول عوامل هزینه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول عوامل هزینه");

                entity.Property(e => e.Status).HasComment("وضعیت عوامل هزینه");

                entity.Property(e => e.TblPlaceTypeId)
                    .HasColumnName("Tbl_PlaceType_Id")
                    .HasComment("آی دی نوع مکان از جدول نوع مکان");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblCostFactors)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .HasConstraintName("FK_Tbl_CostFactor_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblCountry>(entity =>
            {
                entity.ToTable("Tbl_Country");

                entity.HasComment("جدولی برای نمایش اطلاعات کشور");

                entity.Property(e => e.Id).HasComment("شناسه کشور");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد کشور");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام کشور");

                entity.Property(e => e.EnglishName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف کشور");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول کشور");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول کشور");

                entity.Property(e => e.Status).HasComment("وضعیت کشور");
            });

            modelBuilder.Entity<TblCourse>(entity =>
            {
                entity.ToTable("Tbl_Course");

                entity.HasComment("جدولی برای نمایش اطلاعات دوره ");

                entity.Property(e => e.Id).HasComment("شناسه دوره");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد دوره");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف دوره");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول دوره");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول دوره");

                entity.Property(e => e.Status).HasComment("وضعیت دوره");

                entity.Property(e => e.TblCourseNameId)
                    .HasColumnName("Tbl_CourseName_Id")
                    .HasComment("آی دی نام دوره از جدول نام دوره");

                entity.Property(e => e.TblGoalId).HasColumnName("Tbl_Goal_Id");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.Property(e => e.TblPlaceTypeId)
                    .HasColumnName("Tbl_PlaceType_Id")
                    .HasComment("آی دی واحد سازمانی از جدول واحد سازمانی");

                entity.HasOne(d => d.TblCourseName)
                    .WithMany(p => p.TblCourses)
                    .HasForeignKey(d => d.TblCourseNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Course_Tbl_CourseName");

                entity.HasOne(d => d.TblGoal)
                    .WithMany(p => p.TblCourses)
                    .HasForeignKey(d => d.TblGoalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Course_Tbl_Goal");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblCourses)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Course_Tbl_Person");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblCourses)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Course_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblCourseAudience>(entity =>
            {
                entity.ToTable("Tbl_CourseAudience");

                entity.HasComment("جدولی برای نمایش اطلاعات دوره های حاضر");

                entity.Property(e => e.Id).HasComment("شناسه دوره های حاضر");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("توصیف دوره های حاضر");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول دوره های حاضر");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول دوره های حاضر");

                entity.Property(e => e.Score)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("امتیاز دوره های حاضر");

                entity.Property(e => e.Status).HasComment("وضعیت دوره های حاضر");

                entity.Property(e => e.TblCourseId)
                    .HasColumnName("Tbl_Course_Id")
                    .HasComment("آی دی دوره آموزشی از جدول دوره های آموزشی");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.HasOne(d => d.TblCourse)
                    .WithMany(p => p.TblCourseAudiences)
                    .HasForeignKey(d => d.TblCourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CourseAudience_Tbl_Course");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblCourseAudiences)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CourseAudience_Tbl_Person");
            });

            modelBuilder.Entity<TblCourseDay>(entity =>
            {
                entity.ToTable("Tbl_CourseDays");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblCourseId).HasColumnName("Tbl_Course_Id");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.TblCourse)
                    .WithMany(p => p.TblCourseDays)
                    .HasForeignKey(d => d.TblCourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CourseDays_Tbl_Course");
            });

            modelBuilder.Entity<TblCourseName>(entity =>
            {
                entity.ToTable("Tbl_CourseName");

                entity.HasComment("جدولی برای نمایش اطلاعات نام دوره ها");

                entity.Property(e => e.Id).HasComment("شناسه نام دوره");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نام دوره ");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نام دوره ");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول متن نام دوره ");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نام دوره ");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام دوره ");

                entity.Property(e => e.Status).HasComment("وضعیت نام دوره");
            });

            modelBuilder.Entity<TblCustomerCareDefect>(entity =>
            {
                entity.ToTable("Tbl_CustomerCareDefect");

                entity.HasIndex(e => new { e.Code, e.IsDeleted }, "NonClusteredIndex-20190810-125656")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblCustomerCareSheet>(entity =>
            {
                entity.ToTable("Tbl_CustomerCareSheet");

                entity.HasIndex(e => new { e.TblPersonId, e.TblPlaceTypeId, e.Number, e.Date, e.IsDeleted }, "NonClusteredIndex-20190810-125626")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.Property(e => e.TblPlaceTypeId).HasColumnName("Tbl_PlaceType_Id");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblCustomerCareSheets)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerCareSheet_Tbl_Person");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblCustomerCareSheets)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerCareSheet_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblCustomerCareSheetItem>(entity =>
            {
                entity.ToTable("Tbl_CustomerCareSheetItem");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblCustomerCareSheetId).HasColumnName("Tbl_CustomerCareSheet_Id");

                entity.Property(e => e.TblInvoiceSlaveId).HasColumnName("Tbl_InvoiceSlave_Id");

                entity.HasOne(d => d.TblCustomerCareSheet)
                    .WithMany(p => p.TblCustomerCareSheetItems)
                    .HasForeignKey(d => d.TblCustomerCareSheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerCareSheetItem_Tbl_CustomerCareSheet1");

                entity.HasOne(d => d.TblInvoiceSlave)
                    .WithMany(p => p.TblCustomerCareSheetItems)
                    .HasForeignKey(d => d.TblInvoiceSlaveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerCareSheetItem_Tbl_InvoiceSlave");
            });

            modelBuilder.Entity<TblCustomerCareSheetItemDefect>(entity =>
            {
                entity.ToTable("Tbl_CustomerCareSheetItemDefect");

                entity.HasIndex(e => new { e.TblCustomerCareSheetItemId, e.TblCustomerCareDefectId, e.TblPersonId, e.TblPlaceTypeId, e.IsDeleted }, "NonClusteredIndex-20190810-125722");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblCustomerCareDefectId).HasColumnName("Tbl_CustomerCareDefect_Id");

                entity.Property(e => e.TblCustomerCareSheetItemId).HasColumnName("Tbl_CustomerCareSheetItem_Id");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.Property(e => e.TblPlaceTypeId).HasColumnName("Tbl_PlaceType_Id");

                entity.HasOne(d => d.TblCustomerCareDefect)
                    .WithMany(p => p.TblCustomerCareSheetItemDefects)
                    .HasForeignKey(d => d.TblCustomerCareDefectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerCareSheetItemDefect_Tbl_CustomerCareDefect");

                entity.HasOne(d => d.TblCustomerCareSheetItem)
                    .WithMany(p => p.TblCustomerCareSheetItemDefects)
                    .HasForeignKey(d => d.TblCustomerCareSheetItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerCareSheetItemDefect_Tbl_CustomerCareSheetItem");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblCustomerCareSheetItemDefects)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerCareSheetItemDefect_Tbl_Person");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblCustomerCareSheetItemDefects)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerCareSheetItemDefect_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblCustomerCareSheetItemTracking>(entity =>
            {
                entity.ToTable("Tbl_CustomerCareSheetItemTracking");

                entity.HasIndex(e => new { e.TblCustomerCareSheetItemId, e.TblCustomerCareSheetItemTrackingTypeId, e.TblCustomerCareSheetItemTrackingTypeAsResultId, e.TblDraftId, e.TblPlaceTypeAsIssuerId, e.TblPlaceTypeAsReceiverId, e.TblPersonAsIssuerId, e.TblPersonAsReceiverId, e.IssueDate, e.IsDeleted }, "NonClusteredIndex-20190810-125750")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.DetermineDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DeterminerNote)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.IssueDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IssuerNote)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TblCustomerCareSheetItemId).HasColumnName("Tbl_CustomerCareSheetItem_Id");

                entity.Property(e => e.TblCustomerCareSheetItemTrackingTypeAsResultId).HasColumnName("Tbl_CustomerCareSheetItemTrackingTypeAsResult_Id");

                entity.Property(e => e.TblCustomerCareSheetItemTrackingTypeId).HasColumnName("Tbl_CustomerCareSheetItemTrackingType_Id");

                entity.Property(e => e.TblDraftId).HasColumnName("Tbl_Draft_Id");

                entity.Property(e => e.TblPersonAsIssuerId).HasColumnName("Tbl_PersonAsIssuer_Id");

                entity.Property(e => e.TblPersonAsReceiverId).HasColumnName("Tbl_PersonAsReceiver_Id");

                entity.Property(e => e.TblPlaceTypeAsIssuerId).HasColumnName("Tbl_PlaceTypeAsIssuer_Id");

                entity.Property(e => e.TblPlaceTypeAsReceiverId).HasColumnName("Tbl_PlaceTypeAsReceiver_Id");

                entity.HasOne(d => d.TblCustomerCareSheetItem)
                    .WithMany(p => p.TblCustomerCareSheetItemTrackings)
                    .HasForeignKey(d => d.TblCustomerCareSheetItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerCareSheetItemTracking_Tbl_CustomerCareSheetItem");

                entity.HasOne(d => d.TblCustomerCareSheetItemTrackingTypeAsResult)
                    .WithMany(p => p.TblCustomerCareSheetItemTrackingTblCustomerCareSheetItemTrackingTypeAsResults)
                    .HasForeignKey(d => d.TblCustomerCareSheetItemTrackingTypeAsResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerCareSheetItemTracking_Tbl_CustomerCareSheetItemTrackingType1");

                entity.HasOne(d => d.TblCustomerCareSheetItemTrackingType)
                    .WithMany(p => p.TblCustomerCareSheetItemTrackingTblCustomerCareSheetItemTrackingTypes)
                    .HasForeignKey(d => d.TblCustomerCareSheetItemTrackingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerCareSheetItemTracking_Tbl_CustomerCareSheetItemTrackingType");

                entity.HasOne(d => d.TblPersonAsIssuer)
                    .WithMany(p => p.TblCustomerCareSheetItemTrackingTblPersonAsIssuers)
                    .HasForeignKey(d => d.TblPersonAsIssuerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerCareSheetItemTracking_Tbl_Person");

                entity.HasOne(d => d.TblPersonAsReceiver)
                    .WithMany(p => p.TblCustomerCareSheetItemTrackingTblPersonAsReceivers)
                    .HasForeignKey(d => d.TblPersonAsReceiverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerCareSheetItemTracking_Tbl_Person1");

                entity.HasOne(d => d.TblPlaceTypeAsIssuer)
                    .WithMany(p => p.TblCustomerCareSheetItemTrackingTblPlaceTypeAsIssuers)
                    .HasForeignKey(d => d.TblPlaceTypeAsIssuerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerCareSheetItemTracking_Tbl_PlaceType");

                entity.HasOne(d => d.TblPlaceTypeAsReceiver)
                    .WithMany(p => p.TblCustomerCareSheetItemTrackingTblPlaceTypeAsReceivers)
                    .HasForeignKey(d => d.TblPlaceTypeAsReceiverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_CustomerCareSheetItemTracking_Tbl_PlaceType1");
            });

            modelBuilder.Entity<TblCustomerCareSheetItemTrackingType>(entity =>
            {
                entity.ToTable("Tbl_CustomerCareSheetItemTrackingType");

                entity.HasIndex(e => new { e.Code, e.IsDeleted }, "NonClusteredIndex-20190810-125818")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultMessageText)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblDefaultText>(entity =>
            {
                entity.ToTable("Tbl_DefaultText");

                entity.HasComment("جدولی برای نمایش اطلاعات متن پیش فرض");

                entity.Property(e => e.Id).HasComment("شناسه متن پیش فرض");

                entity.Property(e => e.DefaultTextCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد متن پیش فرض");

                entity.Property(e => e.DefaultTextName)
                    .IsRequired()
                    .HasComment("نام متن پیش فرض");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف متن پیش فرض");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول متن پیش فرض");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول متن پیش فرض");

                entity.Property(e => e.Status).HasComment("وضعیت متن پیش فرض");
            });

            modelBuilder.Entity<TblDepartmentGoal>(entity =>
            {
                entity.ToTable("Tbl_DepartmentGoal");

                entity.HasComment("جدولی برای نمایش اطلاعات اهداف دوره آموزشی");

                entity.Property(e => e.Id).HasComment("شناسه هدف دوره آموزشی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف دوره آموزشی");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ  شروع دوره آموزشی");

                entity.Property(e => e.Goal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح هدف دوره آموزشی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول هدف دوره آموزشی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول هدف دوره آموزشی");

                entity.Property(e => e.MaximumScore).HasComment("بیشترین امتیاز دوره آموزشی");

                entity.Property(e => e.MeasurementUnit).HasComment("اندازه گیری واحد دوره آموزشی");

                entity.Property(e => e.MinimumScore).HasComment("کمترین امتیاز  دوره آموزشی");

                entity.Property(e => e.Score).HasComment("امتیازمکتسبه دوره آموزشی");

                entity.Property(e => e.Status).HasComment("وضعیت دوره آموزشی");

                entity.Property(e => e.TblPlaceTypeId)
                    .HasColumnName("Tbl_PlaceType_Id")
                    .HasComment("آی دی واحد سازمانی از جدول واحد سازمانی");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان دوره آموزشی");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblDepartmentGoals)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DepartmentGoal_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblDiscountType>(entity =>
            {
                entity.ToTable("Tbl_DiscountType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع تخفیف");

                entity.Property(e => e.Id).HasComment("شناسه جدول - کلید اصلی - افزایشی تکی");

                entity.Property(e => e.DiscountTypeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("کد نوع تخفیف که ارتباطات و سینک نمودن اطلاعات و کد سیستمی شناسایی تخفیف با این کد صورت میگیرد");

                entity.Property(e => e.DiscountTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع تخفیف که جهت شناسایی نوع تخفیف برای کاربر با این نام صورت میگیرد");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع تخفیف");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع تخفیف");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع تخفیف");

                entity.Property(e => e.Status).HasComment("وضعیت نوع تخفیف");
            });

            modelBuilder.Entity<TblDistrict>(entity =>
            {
                entity.ToTable("Tbl_District");

                entity.Property(e => e.DistrictCode).HasMaxLength(50);

                entity.Property(e => e.DistrictName).HasMaxLength(50);

                entity.Property(e => e.Explanation).HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.TblCityId).HasColumnName("Tbl_City_Id");

                entity.HasOne(d => d.TblCity)
                    .WithMany(p => p.TblDistricts)
                    .HasForeignKey(d => d.TblCityId)
                    .HasConstraintName("FK_Tbl_District_Tbl_City");
            });

            modelBuilder.Entity<TblDraftOrder>(entity =>
            {
                entity.ToTable("Tbl_DraftOrder");

                entity.HasComment("جدول هدر درخواست حواله");

                entity.HasIndex(e => new { e.TblDraftOrderTypeId, e.TblCompanyIdAsIssuer, e.TblInvoiceStatusId, e.Number, e.Date, e.IsDeleted }, "NonClusteredIndex-20191113-155034")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ ثبت درخواست حواله");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasComment("توضیحات");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Number).HasComment("شماره درخواست حواله");

                entity.Property(e => e.ParentId).HasComment("شناسه والد");

                entity.Property(e => e.PrintDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ چاپ درخواست");

                entity.Property(e => e.TblCompanyIdAsIssuer)
                    .HasColumnName("Tbl_Company_IdAsIssuer")
                    .HasComment("شناسه شرکت صادرکننده");

                entity.Property(e => e.TblCompanyIdAsReceiver)
                    .HasColumnName("Tbl_Company_IdAsReceiver")
                    .HasComment("شناسه شرکت دریافت کننده");

                entity.Property(e => e.TblDiscountTypeId)
                    .HasColumnName("Tbl_DiscountType_Id")
                    .HasComment("شناسه نوع تخفیف");

                entity.Property(e => e.TblDraftOrderTypeId)
                    .HasColumnName("Tbl_DraftOrderType_Id")
                    .HasComment("شناسه نوع برگه حواله");

                entity.Property(e => e.TblInvoiceStatusId).HasColumnName("Tbl_InvoiceStatus_Id");

                entity.Property(e => e.TblPersonIdAsIssuer)
                    .HasColumnName("Tbl_Person_IdAsIssuer")
                    .HasComment("شناسه شخص صادرکننده");

                entity.Property(e => e.TblPersonIdAsReceiver)
                    .HasColumnName("Tbl_Person_IdAsReceiver")
                    .HasComment("شناسه شخص دریافت کننده");

                entity.Property(e => e.TblPlaceTypeIdAsIssuer)
                    .HasColumnName("Tbl_PlaceType_IdAsIssuer")
                    .HasComment("شناسه نوع مکان صادرکننده");

                entity.Property(e => e.TblPlaceTypeIdAsReceiver)
                    .HasColumnName("Tbl_PlaceType_IdAsReceiver")
                    .HasComment("شناسه نوع مکان دریافت کننده");

                entity.Property(e => e.TblRemainTypeId)
                    .HasColumnName("Tbl_RemainType_Id")
                    .HasComment("شناسه نوع مانده");

                entity.Property(e => e.Time)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("زمان ثبت درخواست حواله");

                entity.HasOne(d => d.TblCompanyIdAsIssuerNavigation)
                    .WithMany(p => p.TblDraftOrderTblCompanyIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsIssuer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DraftOrder_Tbl_Company");

                entity.HasOne(d => d.TblCompanyIdAsReceiverNavigation)
                    .WithMany(p => p.TblDraftOrderTblCompanyIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsReceiver)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DraftOrder_Tbl_Company1");

                entity.HasOne(d => d.TblDiscountType)
                    .WithMany(p => p.TblDraftOrders)
                    .HasForeignKey(d => d.TblDiscountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DraftOrder_Tbl_DiscountType");

                entity.HasOne(d => d.TblDraftOrderType)
                    .WithMany(p => p.TblDraftOrders)
                    .HasForeignKey(d => d.TblDraftOrderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DraftOrder_Tbl_DraftOrderType");

                entity.HasOne(d => d.TblInvoiceStatus)
                    .WithMany(p => p.TblDraftOrders)
                    .HasForeignKey(d => d.TblInvoiceStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DraftOrder_Tbl_InvoiceStatus");

                entity.HasOne(d => d.TblPersonIdAsIssuerNavigation)
                    .WithMany(p => p.TblDraftOrderTblPersonIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsIssuer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DraftOrder_Tbl_Person");

                entity.HasOne(d => d.TblPersonIdAsReceiverNavigation)
                    .WithMany(p => p.TblDraftOrderTblPersonIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsReceiver)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DraftOrder_Tbl_Person1");

                entity.HasOne(d => d.TblPlaceTypeIdAsIssuerNavigation)
                    .WithMany(p => p.TblDraftOrderTblPlaceTypeIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblPlaceTypeIdAsIssuer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DraftOrder_Tbl_PlaceType");

                entity.HasOne(d => d.TblPlaceTypeIdAsReceiverNavigation)
                    .WithMany(p => p.TblDraftOrderTblPlaceTypeIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblPlaceTypeIdAsReceiver)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DraftOrder_Tbl_PlaceType1");

                entity.HasOne(d => d.TblRemainType)
                    .WithMany(p => p.TblDraftOrders)
                    .HasForeignKey(d => d.TblRemainTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DraftOrder_Tbl_RemainType");
            });

            modelBuilder.Entity<TblDraftOrderAttachment>(entity =>
            {
                entity.ToTable("Tbl_DraftOrderAttachment");

                entity.HasComment("جدول ضمیمه درخواست حواله");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ReferenceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReferenceType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TblDraftOrderId).HasColumnName("Tbl_DraftOrder_Id");

                entity.HasOne(d => d.TblDraftOrder)
                    .WithMany(p => p.TblDraftOrderAttachments)
                    .HasForeignKey(d => d.TblDraftOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DraftOrderAttachment_Tbl_DraftOrder");
            });

            modelBuilder.Entity<TblDraftOrderItem>(entity =>
            {
                entity.ToTable("Tbl_DraftOrderItem");

                entity.HasComment("جدول اقلام درخواست حواله");

                entity.HasIndex(e => new { e.TblDraftOrderId, e.TblDraftTypeId, e.TblInvoiceStatusId, e.FromSerialNo, e.ToSerialNo, e.ParentId, e.UsedDate, e.IsDeleted }, "NonClusteredIndex-20191113-155213")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("بارکد حواله");

                entity.Property(e => e.Count).HasComment("تعداد حواله");

                entity.Property(e => e.DiscountPercent).HasComment("درصد تخفیف");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FromSerialNo).HasComment("شماره حواله از");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.NameAmount).HasComment("مبلغ اسمی");

                entity.Property(e => e.ParentId).HasComment("شناسه والد");

                entity.Property(e => e.PrintDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ چاپ");

                entity.Property(e => e.PureAmount).HasComment("مبلغ خالص");

                entity.Property(e => e.TblDraftOrderId)
                    .HasColumnName("Tbl_DraftOrder_Id")
                    .HasComment("شناسه هدر درخواست حواله");

                entity.Property(e => e.TblDraftTypeId)
                    .HasColumnName("Tbl_DraftType_Id")
                    .HasComment("شناسه نوع حواله");

                entity.Property(e => e.TblInvoiceStatusId).HasColumnName("Tbl_InvoiceStatus_Id");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("شناسه شخصی که اسمش روی حواله قرار میگیرد");

                entity.Property(e => e.ToSerialNo).HasComment("شماره حواله تا");

                entity.Property(e => e.UsedDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ مصرف حواله");

                entity.Property(e => e.ValidDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ اعتبار حواله");

                entity.HasOne(d => d.TblDraftOrder)
                    .WithMany(p => p.TblDraftOrderItems)
                    .HasForeignKey(d => d.TblDraftOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DraftOrderItem_Tbl_DraftOrder");

                entity.HasOne(d => d.TblDraftType)
                    .WithMany(p => p.TblDraftOrderItems)
                    .HasForeignKey(d => d.TblDraftTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DraftOrderItem_Tbl_DraftType");

                entity.HasOne(d => d.TblInvoiceStatus)
                    .WithMany(p => p.TblDraftOrderItems)
                    .HasForeignKey(d => d.TblInvoiceStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DraftOrderItem_Tbl_InvoiceStatus");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblDraftOrderItems)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DraftOrderItem_Tbl_Person");
            });

            modelBuilder.Entity<TblDraftOrderItemDiscountPercentage>(entity =>
            {
                entity.ToTable("Tbl_DraftOrderItemDiscountPercentage");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");
            });

            modelBuilder.Entity<TblDraftOrderSafeReceiptPayment>(entity =>
            {
                entity.ToTable("Tbl_DraftOrderSafeReceiptPayment");

                entity.HasComment("جدول نوع پرداختی حوله");

                entity.HasIndex(e => new { e.TblDraftOrderId, e.TblSafeReceiptPaymentId, e.IsDeleted }, "NonClusteredIndex-20191113-155349")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblDraftOrderId).HasColumnName("Tbl_DraftOrder_Id");

                entity.Property(e => e.TblSafeReceiptPaymentId).HasColumnName("Tbl_SafeReceiptPayment_Id");

                entity.HasOne(d => d.TblDraftOrder)
                    .WithMany(p => p.TblDraftOrderSafeReceiptPayments)
                    .HasForeignKey(d => d.TblDraftOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_DraftOrderSafeReceiptPaymentType_Tbl_DraftOrder");

                entity.HasOne(d => d.TblSafeReceiptPayment)
                    .WithMany(p => p.TblDraftOrderSafeReceiptPayments)
                    .HasForeignKey(d => d.TblSafeReceiptPaymentId)
                    .HasConstraintName("FK_Tbl_DraftOrderSafeReceiptPaymentType_Tbl_SafeReceiptPayment");
            });

            modelBuilder.Entity<TblDraftOrderType>(entity =>
            {
                entity.ToTable("Tbl_DraftOrderType");

                entity.HasComment("جدول نوع تاییدیه حواله");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblDraftType>(entity =>
            {
                entity.ToTable("Tbl_DraftType");

                entity.HasComment("نوع حواله");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblEffectiveType>(entity =>
            {
                entity.ToTable("Tbl_EffectiveType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع تاثیر");

                entity.Property(e => e.Id).HasComment("شناسه نوع نوع موثر");

                entity.Property(e => e.EffectiveTypeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("کد نوع تاثیر");

                entity.Property(e => e.EffectiveTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع تاثیر");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع تاثیر");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع تاثیر");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع تاثیر");

                entity.Property(e => e.Status).HasComment("وضعیت نوع تاثیر");
            });

            modelBuilder.Entity<TblEmployeeAttendance>(entity =>
            {
                entity.ToTable("Tbl_EmployeeAttendance");

                entity.HasIndex(e => new { e.TblPersonId, e.TblWorkDayId, e.IsDeleted }, "NonClusteredIndex-20200526-152338");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.Property(e => e.TblWorkDayId).HasColumnName("Tbl_WorkDay_Id");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblEmployeeAttendances)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EmployeeAttendance_Tbl_Person2");

                entity.HasOne(d => d.TblWorkDay)
                    .WithMany(p => p.TblEmployeeAttendances)
                    .HasForeignKey(d => d.TblWorkDayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EmployeeAttendance_Tbl_WorkDay1");
            });

            modelBuilder.Entity<TblEmployemntStatus>(entity =>
            {
                entity.ToTable("Tbl_EmployemntStatus");

                entity.HasComment("جدولی برای نمایش اطلاعات وضعیت استخدام");

                entity.Property(e => e.Id).HasComment("شناسه وضعیت استخدام");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("کد وضعیت استخدام");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف وضعیت استخدام");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول وضعیت استخدام");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول وضعیت استخدام");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("نام وضعیت استخدام");

                entity.Property(e => e.Status).HasComment("وضعیت استخدام");
            });

            modelBuilder.Entity<TblEmployment>(entity =>
            {
                entity.ToTable("Tbl_Employment");

                entity.HasComment("جدولی برای نمایش اطلاعات استخدام");

                entity.HasIndex(e => new { e.TblCompanyId, e.ToDate, e.IsDeleted, e.ResignationDate, e.FromDate, e.TblPersonId }, "_dta_index_Tbl_Employment_16_969210653__K3_K21_K36_K28_K20_K2")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblPlaceTypeId, e.TblCompanyId, e.ToDate, e.IsDeleted, e.ResignationDate, e.FromDate, e.TblPersonId }, "_dta_index_Tbl_Employment_29_1083255014__K16_K3_K21_K36_K28_K20_K2")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.ToDate, e.TblPersonId, e.TblCompanyId, e.IsDeleted, e.FromDate, e.ResignationDate, e.TblPlaceTypeId }, "_dta_index_Tbl_Employment_29_1083255014__K21_K2_K3_K36_K20_K28_K16_1")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblPersonId, e.IsDeleted, e.FromDate, e.ToDate, e.ResignationDate }, "_dta_index_Tbl_Employment_29_1083255014__K2_K36_K20_K21_K28_1_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_19_22_23_24_25_26_27_29_")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblPersonId, e.TblCompanyId, e.FromDate, e.ToDate, e.IsDeleted, e.ResignationDate }, "_dta_index_Tbl_Employment_29_1083255014__K2_K3_K20_K21_K36_K28")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.IsDeleted, e.TblPersonId, e.TblCompanyId, e.ToDate, e.ResignationDate, e.FromDate }, "_dta_index_Tbl_Employment_29_1083255014__K36_K2_K3_K21_K28_K20_1_13_14_18_22_23_24")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblCompanyId, e.ToDate, e.IsDeleted, e.FromDate, e.ResignationDate, e.TblPersonId, e.TblPlaceTypeId }, "_dta_index_Tbl_Employment_29_1083255014__K3_K21_K36_K20_K28_K2_K16_1")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblCompanyId, e.ToDate, e.IsDeleted, e.ResignationDate, e.FromDate, e.TblPostId, e.TblPersonId, e.TblPlaceTypeId }, "_dta_index_Tbl_Employment_29_1083255014__K3_K21_K36_K28_K20_K13_K2_K16")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه استخدام");

                entity.Property(e => e.ContractNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("شماره قرارداد");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف استخدام");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.InsuranceNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شماره بیمه");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول استخدام");

                entity.Property(e => e.IsInInsurance).HasComment("بیان اطلاعات مشمول بیمه در جدول استخدام");

                entity.Property(e => e.IsInTax).HasComment("بیان اطلاعات مشمول مالیات در جدول استخدام");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول استخدام");

                entity.Property(e => e.JobCode).HasComment("کد شغل");

                entity.Property(e => e.JobGroup).HasComment("گروه های شغلی");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("عنوان شغلی");

                entity.Property(e => e.PostTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("عنوان سمت");

                entity.Property(e => e.ResignationDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ استعفای");

                entity.Property(e => e.ResignationReason)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("دلیل استعفای");

                entity.Property(e => e.SentenceDescription)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasComment("توصیف حکم");

                entity.Property(e => e.SentenceTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("عنوان حکم");

                entity.Property(e => e.Status).HasComment("وضعیت استخدام");

                entity.Property(e => e.TblCompanyId)
                    .HasColumnName("Tbl_Company_Id")
                    .HasComment("آی دی شرکت از جدول شرکت");

                entity.Property(e => e.TblContractTypeId)
                    .HasColumnName("Tbl_ContractType_Id")
                    .HasComment("آی دی نوع قرارداد از جدول نوع قرارداد");

                entity.Property(e => e.TblEmploymentStatusId)
                    .HasColumnName("Tbl_EmploymentStatus_Id")
                    .HasComment("آی دی وضعیت استخدام از جدول وضعیت استخدام");

                entity.Property(e => e.TblEmploymentTypeId)
                    .HasColumnName("Tbl_EmploymentType_Id")
                    .HasComment("آی دی نوع استخدام از جدول نوع استخدام");

                entity.Property(e => e.TblFormulaId)
                    .HasColumnName("Tbl_Formula_Id")
                    .HasComment("آی دی فرمول از جدول فرمول");

                entity.Property(e => e.TblHouseTypeId)
                    .HasColumnName("Tbl_HouseType_Id")
                    .HasComment("آی دی نوع خانه از جدول نوع خانه");

                entity.Property(e => e.TblInsuranceBranchId)
                    .HasColumnName("Tbl_InsuranceBranch_Id")
                    .HasComment("آی دی شعبه بیمه از جدول شعبه بیمه");

                entity.Property(e => e.TblInsuranceJobId)
                    .HasColumnName("Tbl_InsuranceJob_Id")
                    .HasComment("آی دی شغل بیمه از جدول مشاغل");

                entity.Property(e => e.TblInsuranceTypeId)
                    .HasColumnName("Tbl_InsuranceType_Id")
                    .HasComment("آی دی نوع بیمه از جدول نوع بیمه");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل از جدول اشغال");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول شخص");

                entity.Property(e => e.TblPlaceTypeId)
                    .HasColumnName("Tbl_PlaceType_Id")
                    .HasComment("آی دی محل خدمت از جدول محلها");

                entity.Property(e => e.TblPostId)
                    .HasColumnName("Tbl_Post_Id")
                    .HasComment("آی دی پست سازمانی از جدول پستها");

                entity.Property(e => e.TblTaxBranchId)
                    .HasColumnName("Tbl_TaxBranch_Id")
                    .HasComment("آی دی شعبه مالیاتی از جدول شعب مالیات");

                entity.Property(e => e.TblVehicleTypeId)
                    .HasColumnName("Tbl_VehicleType_Id")
                    .HasComment("آی دی نوع وسیله نقلیه  از جدول نوع وسیله نقلیه");

                entity.Property(e => e.TblWorkPlaceSituationId)
                    .HasColumnName("Tbl_WorkPlaceSituation_Id")
                    .HasComment("آی دی وضعیت محل کار از جدول وضعیت محل کار");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان");

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblEmployments)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Employment_Tbl_Company");

                entity.HasOne(d => d.TblContractType)
                    .WithMany(p => p.TblEmployments)
                    .HasForeignKey(d => d.TblContractTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Employment_Tbl_ContractType");

                entity.HasOne(d => d.TblEmploymentStatus)
                    .WithMany(p => p.TblEmployments)
                    .HasForeignKey(d => d.TblEmploymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Employment_Tbl_EmployemntStatus");

                entity.HasOne(d => d.TblEmploymentType)
                    .WithMany(p => p.TblEmployments)
                    .HasForeignKey(d => d.TblEmploymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Employment_Tbl_EmploymentType");

                entity.HasOne(d => d.TblFormula)
                    .WithMany(p => p.TblEmployments)
                    .HasForeignKey(d => d.TblFormulaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Employment_Tbl_Formula");

                entity.HasOne(d => d.TblHouseType)
                    .WithMany(p => p.TblEmployments)
                    .HasForeignKey(d => d.TblHouseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Employment_Tbl_HouseType");

                entity.HasOne(d => d.TblInsuranceBranch)
                    .WithMany(p => p.TblEmployments)
                    .HasForeignKey(d => d.TblInsuranceBranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Employment_Tbl_InsuranceBranch");

                entity.HasOne(d => d.TblInsuranceJob)
                    .WithMany(p => p.TblEmployments)
                    .HasForeignKey(d => d.TblInsuranceJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Employment_Tbl_InsuranceJob");

                entity.HasOne(d => d.TblInsuranceType)
                    .WithMany(p => p.TblEmployments)
                    .HasForeignKey(d => d.TblInsuranceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Employment_Tbl_InsuranceType");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblEmployments)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Employment_Tbl_Job");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblEmployments)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Employment_Tbl_Person");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblEmployments)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Employment_Tbl_PlaceType");

                entity.HasOne(d => d.TblPost)
                    .WithMany(p => p.TblEmployments)
                    .HasForeignKey(d => d.TblPostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Employment_Tbl_Post");

                entity.HasOne(d => d.TblTaxBranch)
                    .WithMany(p => p.TblEmployments)
                    .HasForeignKey(d => d.TblTaxBranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Employment_Tbl_TaxBranch");

                entity.HasOne(d => d.TblVehicleType)
                    .WithMany(p => p.TblEmployments)
                    .HasForeignKey(d => d.TblVehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Employment_Tbl_VehicleType");

                entity.HasOne(d => d.TblWorkPlaceSituation)
                    .WithMany(p => p.TblEmployments)
                    .HasForeignKey(d => d.TblWorkPlaceSituationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Employment_Tbl_WorkPlaceSituation");
            });

            modelBuilder.Entity<TblEmploymentFactor>(entity =>
            {
                entity.ToTable("Tbl_EmploymentFactors");

                entity.HasComment("جدولی برای نمایش اطلاعات عوامل استخدام");

                entity.HasIndex(e => new { e.TblEmployementId, e.IsDeleted }, "_dta_index_Tbl_EmploymentFactors_29_62011352__K2_K9_1_3_4_5_6_7_8")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه عوامل استخدام");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف عوامل استخدام");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول عوامل استخدام");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول عوامل استخدام");

                entity.Property(e => e.KeyValue).HasComment("مقدار کلید انتخابی عوامل استخدام");

                entity.Property(e => e.Status).HasComment("وضعیت عوامل استخدام");

                entity.Property(e => e.TblEmployementId)
                    .HasColumnName("Tbl_Employement_Id")
                    .HasComment("آی دی استخدام از جدول استخدام");

                entity.Property(e => e.TblEmploymentKeyId)
                    .HasColumnName("Tbl_EmploymentKey_Id")
                    .HasComment("آی دی عامل محاسباتی از جدول عامل محاسباتی ");

                entity.HasOne(d => d.TblEmployement)
                    .WithMany(p => p.TblEmploymentFactors)
                    .HasForeignKey(d => d.TblEmployementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EmployementFactors_Tbl_Employment");

                entity.HasOne(d => d.TblEmploymentKey)
                    .WithMany(p => p.TblEmploymentFactors)
                    .HasForeignKey(d => d.TblEmploymentKeyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EmploymentFactors_Tbl_EmploymentFactors");
            });

            modelBuilder.Entity<TblEmploymentKey>(entity =>
            {
                entity.ToTable("Tbl_EmploymentKey");

                entity.HasComment("جدولی برای نمایش اطلاعات عوامل محاسباتی");

                entity.Property(e => e.Id).HasComment("شناسه عامل محاسباتی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد عامل محاسباتی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف عوامل محاسباتی");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع عوامل محاسباتی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول عوامل محاسباتی");

                entity.Property(e => e.IsInInsurance).HasComment("بیان اطلاعات مشمول بیمه در جدول عوامل محاسباتی");

                entity.Property(e => e.IsInTax).HasComment("بیان اطلاعات مشمول مالیات در جدول عوامل محاسباتی");

                entity.Property(e => e.IsSalary).HasComment("بیان اطلاعات حقوق در جدول عوامل محاسباتی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول عوامل محاسباتی");

                entity.Property(e => e.KeyGroup)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("گروه عامل محاسباتی");

                entity.Property(e => e.KeyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام عامل محاسباتی");

                entity.Property(e => e.KeyValue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("مقدار عامل محاسباتی");

                entity.Property(e => e.ParentId).HasComment("شناسه والد عوامل محاسباتی");

                entity.Property(e => e.Priority).HasComment("اولویت عوامل محاسباتی");

                entity.Property(e => e.Status).HasComment("وضعیت عامل محاسباتی");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان عوامل محاسباتی");
            });

            modelBuilder.Entity<TblEmploymentRequest>(entity =>
            {
                entity.ToTable("Tbl_EmploymentRequest");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Hrcomment)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("HRComment");

                entity.Property(e => e.Hrstatus).HasColumnName("HRStatus");

                entity.Property(e => e.IssuerComment)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.RequestDeadline)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TbLPlaceTypeId).HasColumnName("TbL_PlaceType_Id");

                entity.Property(e => e.TbLProvinceId).HasColumnName("TbL_Province_Id");

                entity.Property(e => e.TblCityId).HasColumnName("Tbl_City_Id");

                entity.Property(e => e.TblJobId).HasColumnName("Tbl_Job_Id");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.HasOne(d => d.TbLPlaceType)
                    .WithMany(p => p.TblEmploymentRequests)
                    .HasForeignKey(d => d.TbLPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EmploymentRequest_Tbl_PlaceType");

                entity.HasOne(d => d.TbLProvince)
                    .WithMany(p => p.TblEmploymentRequests)
                    .HasForeignKey(d => d.TbLProvinceId)
                    .HasConstraintName("FK_Tbl_EmploymentRequest_Tbl_Province");

                entity.HasOne(d => d.TblCity)
                    .WithMany(p => p.TblEmploymentRequests)
                    .HasForeignKey(d => d.TblCityId)
                    .HasConstraintName("FK_Tbl_EmploymentRequest_Tbl_City");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblEmploymentRequests)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EmploymentRequest_Tbl_Job");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblEmploymentRequests)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EmploymentRequest_Tbl_Person");
            });

            modelBuilder.Entity<TblEmploymentRequestChannel>(entity =>
            {
                entity.ToTable("Tbl_EmploymentRequestChannel");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblChannelId).HasColumnName("Tbl_Channel_Id");

                entity.Property(e => e.TblEmploymentRequestId).HasColumnName("Tbl_EmploymentRequest_Id");

                entity.HasOne(d => d.TblChannel)
                    .WithMany(p => p.TblEmploymentRequestChannels)
                    .HasForeignKey(d => d.TblChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EmploymentChannel_Tbl_Channel");

                entity.HasOne(d => d.TblEmploymentRequest)
                    .WithMany(p => p.TblEmploymentRequestChannels)
                    .HasForeignKey(d => d.TblEmploymentRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EmploymentChannel_Tbl_EmploymentRequest");
            });

            modelBuilder.Entity<TblEmploymentRequestReason>(entity =>
            {
                entity.ToTable("Tbl_EmploymentRequestReason");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblEmploymentRequestId).HasColumnName("Tbl_EmploymentRequest_Id");

                entity.Property(e => e.TblReasonId).HasColumnName("Tbl_Reason_Id");

                entity.HasOne(d => d.TblEmploymentRequest)
                    .WithMany(p => p.TblEmploymentRequestReasons)
                    .HasForeignKey(d => d.TblEmploymentRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EmploymetRequestReason_Tbl_EmploymetRequestReason");

                entity.HasOne(d => d.TblReason)
                    .WithMany(p => p.TblEmploymentRequestReasons)
                    .HasForeignKey(d => d.TblReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EmploymetRequestReason_Tbl_Reason");
            });

            modelBuilder.Entity<TblEmploymentType>(entity =>
            {
                entity.ToTable("Tbl_EmploymentType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع استخدام");

                entity.Property(e => e.Id).HasComment("شناسه نوع استخدام");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع استخدام");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع استخدام");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول نوع استخدام");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع استخدام");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نوع استخدام");

                entity.Property(e => e.Status).HasComment("وضعیت نوع استخدام");
            });

            modelBuilder.Entity<TblEvaluationGoal>(entity =>
            {
                entity.ToTable("Tbl_EvaluationGoal");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف سنجش");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول سنجش");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول سنجش");

                entity.Property(e => e.Status).HasComment("وضعیت سنجش");

                entity.Property(e => e.TblEvaluationPeriodId).HasColumnName("Tbl_EvaluationPeriod_Id");

                entity.Property(e => e.TblGoalId).HasColumnName("Tbl_Goal_Id");

                entity.Property(e => e.TblMeasurementId).HasColumnName("Tbl_Measurement_Id");

                entity.HasOne(d => d.TblEvaluationPeriod)
                    .WithMany(p => p.TblEvaluationGoals)
                    .HasForeignKey(d => d.TblEvaluationPeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EvaluationGoal_Tbl_EvaluationPeriod");

                entity.HasOne(d => d.TblGoal)
                    .WithMany(p => p.TblEvaluationGoals)
                    .HasForeignKey(d => d.TblGoalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EvaluationGoal_Tbl_Goal");

                entity.HasOne(d => d.TblMeasurement)
                    .WithMany(p => p.TblEvaluationGoals)
                    .HasForeignKey(d => d.TblMeasurementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EvaluationGoal_Tbl_Measurement");
            });

            modelBuilder.Entity<TblEvaluationGoalProject>(entity =>
            {
                entity.ToTable("Tbl_EvaluationGoalProject");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblEvaluationGoalId).HasColumnName("Tbl_EvaluationGoal_Id");

                entity.Property(e => e.TblProjectId).HasColumnName("Tbl_Project_Id");

                entity.HasOne(d => d.TblEvaluationGoal)
                    .WithMany(p => p.TblEvaluationGoalProjects)
                    .HasForeignKey(d => d.TblEvaluationGoalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EvaluationGoalProject_Tbl_EvaluationGoal");

                entity.HasOne(d => d.TblProject)
                    .WithMany(p => p.TblEvaluationGoalProjects)
                    .HasForeignKey(d => d.TblProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EvaluationGoalProject_Tbl_Project");
            });

            modelBuilder.Entity<TblEvaluationPeriod>(entity =>
            {
                entity.ToTable("Tbl_EvaluationPeriod");

                entity.HasComment("جدولی برای نمایش اطلاعات دوره ارزیابی");

                entity.Property(e => e.Id).HasComment("شناسه دوره ارزیابی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف دوره ارزیابی");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع دوره ارزیابی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول دوره ارزیابی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول دوره ارزیابی");

                entity.Property(e => e.MaximumScore).HasComment("بیشترین امتیاز ارزیابی");

                entity.Property(e => e.MinimumScore).HasComment("کمترین امتیاز ارزیابی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("وضعیت دوره ارزیابی");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان دوره ارزیابی");
            });

            modelBuilder.Entity<TblEvaluationPeriodCalendar>(entity =>
            {
                entity.ToTable("Tbl_EvaluationPeriodCalendar");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblEvaluationPeriodId).HasColumnName("Tbl_EvaluationPeriod_Id");

                entity.Property(e => e.TblWorkDayNameId).HasColumnName("Tbl_WorkDayName_Id");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.TblEvaluationPeriod)
                    .WithMany(p => p.TblEvaluationPeriodCalendars)
                    .HasForeignKey(d => d.TblEvaluationPeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EvaluationPeriodCalendar_Tbl_EvaluationPeriod");

                entity.HasOne(d => d.TblWorkDayName)
                    .WithMany(p => p.TblEvaluationPeriodCalendars)
                    .HasForeignKey(d => d.TblWorkDayNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EvaluationPeriodCalendar_Tbl_WorkDayName");
            });

            modelBuilder.Entity<TblEvent>(entity =>
            {
                entity.ToTable("Tbl_Event");

                entity.Property(e => e.EventCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblDiscountTypeId).HasColumnName("Tbl_DiscountType_Id");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.TblDiscountType)
                    .WithMany(p => p.TblEvents)
                    .HasForeignKey(d => d.TblDiscountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Event_Tbl_DiscountType1");
            });

            modelBuilder.Entity<TblEventPlaceType>(entity =>
            {
                entity.ToTable("Tbl_EventPlaceType");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblEventId).HasColumnName("Tbl_Event_Id");

                entity.Property(e => e.TblPlaceTypeId).HasColumnName("Tbl_PlaceType_Id");

                entity.HasOne(d => d.TblEvent)
                    .WithMany(p => p.TblEventPlaceTypes)
                    .HasForeignKey(d => d.TblEventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EventPlaceType_Tbl_Event");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblEventPlaceTypes)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EventPlaceType_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblEvidence>(entity =>
            {
                entity.ToTable("Tbl_Evidence");

                entity.HasComment("جدولی برای نمایش اطلاعات سند حسابداری");

                entity.Property(e => e.Id).HasComment("شناسه سند حسابداری");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("شرح سند حسابداری");

                entity.Property(e => e.EvidenceDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ سند حسابداری");

                entity.Property(e => e.EvidenceNo).HasComment("شماره سند حسابداری");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف سند حسابداری");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsActive).HasComment("بیان اطلاعات فعال بودن یا نبودن در جدول سند حسابداری");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول سند حسابداری");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول سند حسابداری");

                entity.Property(e => e.ReferenceNo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("شماره منبع");

                entity.Property(e => e.RefferalNo).HasComment("شماره ارجاع");

                entity.Property(e => e.Status).HasComment("وضعیت سند حسابداری");

                entity.Property(e => e.SubSystem).HasComment("زیر سیستم سند حسابداری");

                entity.Property(e => e.SubSystemInfo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("اطلاعات زیر سیستم  سند حسابداری");

                entity.Property(e => e.TblEvidenceTypeId)
                    .HasColumnName("Tbl_EvidenceType_Id")
                    .HasComment("نوع سند حسابداری");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("شناسه کاربری");

                entity.HasOne(d => d.TblEvidenceType)
                    .WithMany(p => p.TblEvidences)
                    .HasForeignKey(d => d.TblEvidenceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Evidence_Tbl_EvidenceType");
            });

            modelBuilder.Entity<TblEvidenceItem>(entity =>
            {
                entity.ToTable("Tbl_EvidenceItem");

                entity.HasComment("جدولی برای نمایش اطلاعات آیتم های موجود در سند حسابداری");

                entity.Property(e => e.Id).HasComment("شناسه آیتم های موجود در آیتم سند حسابداری");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد حساب");

                entity.Property(e => e.Amount).HasComment("مبلغ آیتم موجود در سند حسابداری");

                entity.Property(e => e.BatchNumber).HasComment("شماره سریال");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توضیح آیتم موجود در سند حسابداری");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح آیتم موجود در سند حسابداری");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف آیتم موجود در سند حسابداری");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDebit).HasComment("بیان اطلاعات بدهی است در جدول آیتم موجود در سند حسابداری");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول آیتم موجود در سند حسابداری");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول آیتم موجود در سند حسابداری");

                entity.Property(e => e.Quantity).HasComment("مقدار آیتم موجود در سند حسابداری");

                entity.Property(e => e.Status).HasComment("وضعیت آیتم موجود در سند حسابداری");

                entity.Property(e => e.TblEvidenceId)
                    .HasColumnName("Tbl_Evidence_Id")
                    .HasComment("آی دی سند حسابداری از جدول سند حسابداری");

                entity.Property(e => e.TblLedgerId)
                    .HasColumnName("Tbl_Ledger_Id")
                    .HasComment("آی دی حساب از جدول حساب");

                entity.HasOne(d => d.TblEvidence)
                    .WithMany(p => p.TblEvidenceItems)
                    .HasForeignKey(d => d.TblEvidenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EvidenceItem_Tbl_Evidence");

                entity.HasOne(d => d.TblLedger)
                    .WithMany(p => p.TblEvidenceItems)
                    .HasForeignKey(d => d.TblLedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EvidenceItem_Tbl_Ledger");
            });

            modelBuilder.Entity<TblEvidenceItemCurrency>(entity =>
            {
                entity.ToTable("Tbl_EvidenceItemCurrency");

                entity.HasComment("جدولی برای نمایش اطلاعات اسناد ارزی مرتبط با آرتیکل های سند حسابداری");

                entity.Property(e => e.Id).HasComment("شناسه اسناد ارزی مرتبط با آرتیکل های سند حسابداری");

                entity.Property(e => e.Amount).HasComment("مبلغ اسناد ارزی مرتبط با آرتیکل های سند حسابداری");

                entity.Property(e => e.Currency).HasComment("اسناد ارزی مرتبط با آرتیکل های سند حسابداری");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح اسناد ارزی مرتبط با آرتیکل های سند حسابداری");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف اسناد ارزی مرتبط با آرتیکل های سند حسابداری");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول اسناد ارزی مرتبط با آرتیکل های سند حسابداری");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اسناد ارزی مرتبط با آرتیکل های سند حسابداری");

                entity.Property(e => e.Quantity).HasComment("مقدار اسناد ارزی مرتبط با آرتیکل های سند حسابداری");

                entity.Property(e => e.Status).HasComment("وضعیت اسناد ارزی مرتبط با آرتیکل های سند حسابداری");

                entity.Property(e => e.SubsystemReferenceId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شناسه زیر سیستم های اسناد ارزی مرتبط با آرتیکل های سند حسابداری");

                entity.Property(e => e.TblEvidenceItemId)
                    .HasColumnName("Tbl_EvidenceItem_Id")
                    .HasComment("آی دی آرتیکل های سند حسابداری در جدول آرتیکل های سند حسابداری");

                entity.Property(e => e.Unit).HasComment("واحد ارز اسناد ارزی مرتبط با آرتیکل های سند حسابداری");

                entity.HasOne(d => d.TblEvidenceItem)
                    .WithMany(p => p.TblEvidenceItemCurrencies)
                    .HasForeignKey(d => d.TblEvidenceItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_EvidenceItemCurrency_Tbl_EvidenceItem");
            });

            modelBuilder.Entity<TblEvidenceType>(entity =>
            {
                entity.ToTable("Tbl_EvidenceType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع سند حسابداری");

                entity.Property(e => e.Id).HasComment("شناسه نوع سند حسابداری");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع سند حسابداری");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع سند حسابداری");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع سند حسابداری");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع سند حسابداری");

                entity.Property(e => e.Status).HasComment("وضعیت نوع سند حسابداری");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("عنوان سند حسابداری");
            });

            modelBuilder.Entity<TblExchange>(entity =>
            {
                entity.ToTable("Tbl_Exchange");

                entity.HasComment("جدولی برای نمایش اطلاعات ارز");

                entity.Property(e => e.Id).HasComment("شناسه ارز");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد ارز");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف ارز");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول ارز");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول ارز");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام ارز");

                entity.Property(e => e.Status).HasComment("وضعیت ارز");
            });

            modelBuilder.Entity<TblExport>(entity =>
            {
                entity.ToTable("Tbl_Export");

                entity.HasComment("جدولی برای نمایش اطلاعات صدور");

                entity.HasIndex(e => new { e.Id, e.TblPersonId, e.TblExportTypeId }, "Export")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه صدور");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف صدور");

                entity.Property(e => e.ExportDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ صدور");

                entity.Property(e => e.ExportNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("شماره صدور");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول صدور");

                entity.Property(e => e.IsEnabled).HasComment("بیان اطلاعات فعال بودن یا نبودن در جدول صدور");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول صدور");

                entity.Property(e => e.Status).HasComment("وضعیت صدور");

                entity.Property(e => e.TblExportTypeId)
                    .HasColumnName("Tbl_ExportType_Id")
                    .HasComment("آی دی نوع صدور از جدول نوع صدور");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.HasOne(d => d.TblExportType)
                    .WithMany(p => p.TblExports)
                    .HasForeignKey(d => d.TblExportTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Export_Tbl_ExportType");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblExports)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Export_Tbl_Person");
            });

            modelBuilder.Entity<TblExportType>(entity =>
            {
                entity.ToTable("Tbl_ExportType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع صدور");

                entity.HasIndex(e => new { e.Id, e.Code }, "ExportType")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه نوع صدور");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع صدور");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع صدور");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول نوع صدور");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع صدور");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع صدور");

                entity.Property(e => e.Status).HasComment("وضعیت نوع صدور");
            });

            modelBuilder.Entity<TblFamily>(entity =>
            {
                entity.ToTable("Tbl_Family");

                entity.HasComment("جدولی برای نمایش اطلاعات خانواده");

                entity.Property(e => e.Id).HasComment("شناسه خانواده");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف خانواده");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.HasInsurance).HasComment("بیان اطلاعات تحت تکفل بیمه از جدول خانواده");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول خانواده");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول خانواده");

                entity.Property(e => e.Status).HasComment("وضعیت خانواده");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول شخص");

                entity.Property(e => e.TblPersonIdAsFamily)
                    .HasColumnName("Tbl_Person_IdAsFamily")
                    .HasComment("آی دی فرد نسبت خانوادگی دار از جدول اشخاص");

                entity.Property(e => e.TblRelationTypeId)
                    .HasColumnName("Tbl_RelationType_Id")
                    .HasComment("آی دی نوع نسبت خانوادگی از نوع ارتباطات");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblFamilyTblPeople)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Family_Tbl_Person");

                entity.HasOne(d => d.TblPersonIdAsFamilyNavigation)
                    .WithMany(p => p.TblFamilyTblPersonIdAsFamilyNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsFamily)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Family_Tbl_Person1");

                entity.HasOne(d => d.TblRelationType)
                    .WithMany(p => p.TblFamilies)
                    .HasForeignKey(d => d.TblRelationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Family_Tbl_RelationType");
            });

            modelBuilder.Entity<TblFeedback>(entity =>
            {
                entity.ToTable("Tbl_Feedback");

                entity.HasComment("جدولی برای نمایش اطلاعات بازخورد");

                entity.Property(e => e.Id).HasComment("شناسه بازخورد");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasComment("بدنه بازخورد");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("توصیف بازخورد");

                entity.Property(e => e.From)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شروع بازخورد");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول بازخورد");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول بازخورد");

                entity.Property(e => e.RecieveDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasComment("وضعیت بازخورد");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("موضوع بازخورد");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("عنوان بازخورد");

                entity.Property(e => e.To)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("پایان بازخورد");
            });

            modelBuilder.Entity<TblFieldOfStudy>(entity =>
            {
                entity.ToTable("Tbl_FieldOfStudy");

                entity.HasComment(" جدولی برای نمایش اطلاعات رشته تحصیلی    ");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("شناسه رشته تحصیلی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف رشته تحصیلی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول رشته تحصیلی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول رشته تحصیلی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasComment("نام رشته تحصیلی");

                entity.Property(e => e.Status).HasComment("وضعیت رشته تحصیلی");
            });

            modelBuilder.Entity<TblFinancialCycle>(entity =>
            {
                entity.ToTable("Tbl_FinancialCycle");

                entity.HasComment(" جدولی برای نمایش اطلاعات يک دوره مالي    ");

                entity.Property(e => e.Id).HasComment("شناسه یک دوره مالی");

                entity.Property(e => e.Cycle)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("دوره گردش مالی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف یک دوره مالی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول یک دوره مالی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول یک دوره مالی");

                entity.Property(e => e.LedgerLevelsMaxNumber).HasComment("حداکثر تعداد سطوح حساب در یک دوره مالی");

                entity.Property(e => e.Status).HasComment("وضعیت یک دوره مالی");

                entity.Property(e => e.TblCompanyId)
                    .HasColumnName("Tbl_Company_Id")
                    .HasComment("آی دی شرکت از جدول شرکت");

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblFinancialCycles)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinancialCycle_Tbl_Company");
            });

            modelBuilder.Entity<TblFinishedGoodAlbum>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodAlbum");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");
            });

            modelBuilder.Entity<TblFinishedGoodAlbumDesign>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodAlbumDesign");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.TblCodingPatternValueTypeId).HasColumnName("Tbl_CodingPatternValueType_Id");

                entity.Property(e => e.TblCodingPatternValueTypeIdAsProductGroup).HasColumnName("Tbl_CodingPatternValueType_IdAsProductGroup");

                entity.HasOne(d => d.TblCodingPatternValueType)
                    .WithMany(p => p.TblFinishedGoodAlbumDesignTblCodingPatternValueTypes)
                    .HasForeignKey(d => d.TblCodingPatternValueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodAlbumDesign_Tbl_CodingPatternValueType1");

                entity.HasOne(d => d.TblCodingPatternValueTypeIdAsProductGroupNavigation)
                    .WithMany(p => p.TblFinishedGoodAlbumDesignTblCodingPatternValueTypeIdAsProductGroupNavigations)
                    .HasForeignKey(d => d.TblCodingPatternValueTypeIdAsProductGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodAlbumDesign_Tbl_CodingPatternValueType");
            });

            modelBuilder.Entity<TblFinishedGoodAlbumDistribution>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodAlbumDistribution");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.TblFinishedGoodAlbumId).HasColumnName("Tbl_FinishedGoodAlbum_Id");

                entity.Property(e => e.TblPlaceTypeId).HasColumnName("Tbl_PlaceType_Id");

                entity.HasOne(d => d.TblFinishedGoodAlbum)
                    .WithMany(p => p.TblFinishedGoodAlbumDistributions)
                    .HasForeignKey(d => d.TblFinishedGoodAlbumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodAlbumDistribution_Tbl_FinishedGoodAlbum");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblFinishedGoodAlbumDistributions)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodAlbumDistribution_Tbl_PlaceType1");
            });

            modelBuilder.Entity<TblFinishedGoodAlbumPermission>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodAlbumPermission");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.TblCodingPatternValueTypeId).HasColumnName("Tbl_CodingPatternValueType_Id");

                entity.Property(e => e.TblPlaceTypeId).HasColumnName("Tbl_PlaceType_Id");

                entity.HasOne(d => d.TblCodingPatternValueType)
                    .WithMany(p => p.TblFinishedGoodAlbumPermissions)
                    .HasForeignKey(d => d.TblCodingPatternValueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodAlbumPermission_Tbl_CodingPatternValueType");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblFinishedGoodAlbumPermissions)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodAlbumPermission_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblFinishedGoodAlbumPricing>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodAlbumPricing");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblCodingPatternValueTypeId).HasColumnName("Tbl_CodingPatternValueType_Id");

                entity.Property(e => e.TblCodingPatternValueTypeIdAsProductGroup).HasColumnName("Tbl_CodingPatternValueType_IdAsProductGroup");

                entity.Property(e => e.TblFinishedGoodAlbumId).HasColumnName("Tbl_FinishedGoodAlbum_Id");

                entity.HasOne(d => d.TblCodingPatternValueType)
                    .WithMany(p => p.TblFinishedGoodAlbumPricingTblCodingPatternValueTypes)
                    .HasForeignKey(d => d.TblCodingPatternValueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodAlbumPricing_Tbl_CodingPatternValueType");

                entity.HasOne(d => d.TblCodingPatternValueTypeIdAsProductGroupNavigation)
                    .WithMany(p => p.TblFinishedGoodAlbumPricingTblCodingPatternValueTypeIdAsProductGroupNavigations)
                    .HasForeignKey(d => d.TblCodingPatternValueTypeIdAsProductGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodAlbumPricing_Tbl_CodingPatternValueType1");

                entity.HasOne(d => d.TblFinishedGoodAlbum)
                    .WithMany(p => p.TblFinishedGoodAlbumPricings)
                    .HasForeignKey(d => d.TblFinishedGoodAlbumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodAlbumPricing_Tbl_FinishedGoodAlbum");
            });

            modelBuilder.Entity<TblFinishedGoodAlbumRawMaterialProduct>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodAlbumRawMaterialProduct");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.TblFinishedGoodAlbumId).HasColumnName("Tbl_FinishedGoodAlbum_Id");

                entity.Property(e => e.TblRawMaterialProductId).HasColumnName("Tbl_RawMaterialProduct_Id");

                entity.HasOne(d => d.TblFinishedGoodAlbum)
                    .WithMany(p => p.TblFinishedGoodAlbumRawMaterialProducts)
                    .HasForeignKey(d => d.TblFinishedGoodAlbumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodAlbumRawMaterialProduct_Tbl_FinishedGoodAlbum");

                entity.HasOne(d => d.TblRawMaterialProduct)
                    .WithMany(p => p.TblFinishedGoodAlbumRawMaterialProducts)
                    .HasForeignKey(d => d.TblRawMaterialProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodAlbumRawMaterialProduct_Tbl_RawMaterialProduct");
            });

            modelBuilder.Entity<TblFinishedGoodAppliedPricing>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodAppliedPricing");

                entity.HasIndex(e => e.Guid, "NonClusteredIndex-20180804-113240")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه توانایی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.TblFinishedGoodProductId)
                    .HasColumnName("Tbl_FinishedGoodProduct_Id")
                    .HasComment("کد توانایی");

                entity.Property(e => e.TblPlaceTypeId)
                    .HasColumnName("Tbl_PlaceType_Id")
                    .HasComment("نام توانایی");

                entity.HasOne(d => d.TblFinishedGoodProduct)
                    .WithMany(p => p.TblFinishedGoodAppliedPricings)
                    .HasForeignKey(d => d.TblFinishedGoodProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodAppliedPricing_Tbl_FinishedGoodProduct");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblFinishedGoodAppliedPricings)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodAppliedPricing_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblFinishedGoodBeginPeriod>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodBeginPeriod");

                entity.HasIndex(e => new { e.IsDeleted, e.Date, e.TblFinishedGoodProductId, e.TblPlaceTypeId }, "_dta_index_Tbl_FinishedGoodBeginPeriod_16_1691309235__K11_K4_K2_K3_5_6")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.IsDeleted, e.TblFinishedGoodProductId, e.Date }, "_dta_index_Tbl_FinishedGoodBeginPeriod_29_1691309235__K11_K2_K4_5_6")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسایی شروع دوره");

                entity.Property(e => e.Count).HasComment("تعداد شروع دوره");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع دوره");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف شروع دوره");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول شروع دوره");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در چدول شروع دوره");

                entity.Property(e => e.Price).HasComment("قیمت شروع دوره");

                entity.Property(e => e.Status).HasComment("وضعیت شروع دوره");

                entity.Property(e => e.TblFinishedGoodProductId)
                    .HasColumnName("Tbl_FinishedGoodProduct_Id")
                    .HasComment("آی دی محصول از جدول محصول");

                entity.Property(e => e.TblPlaceTypeId).HasColumnName("Tbl_PlaceType_Id");

                entity.HasOne(d => d.TblFinishedGoodProduct)
                    .WithMany(p => p.TblFinishedGoodBeginPeriods)
                    .HasForeignKey(d => d.TblFinishedGoodProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodBeginPeriod_Tbl_FinishedGoodProduct");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblFinishedGoodBeginPeriods)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodBeginPeriod_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblFinishedGoodExtraInfo>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodExtraInfo");

                entity.Property(e => e.Id).HasComment("شناسه توانایی");

                entity.Property(e => e.EnglishName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.LabelCount)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LabelSize)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TblCompanyId)
                    .HasColumnName("Tbl_Company_Id")
                    .HasComment("کد توانایی");

                entity.Property(e => e.TblMeasurementId)
                    .HasColumnName("Tbl_Measurement_Id")
                    .HasComment("نام توانایی");

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblFinishedGoodExtraInfos)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodExtraInfo_Tbl_Company");

                entity.HasOne(d => d.TblMeasurement)
                    .WithMany(p => p.TblFinishedGoodExtraInfos)
                    .HasForeignKey(d => d.TblMeasurementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodExtraInfo_Tbl_Measurement");
            });

            modelBuilder.Entity<TblFinishedGoodPricingResult>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodPricingResult");

                entity.HasIndex(e => new { e.IsDeleted, e.TblFinishedGoodStockSheetId, e.TblPlaceTypeId, e.TblFinishedGoodProductId }, "_dta_index_Tbl_FinishedGoodPricingResult_16_260352142__K13_K2_K3_K4_5_8")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.IsDeleted, e.TblPlaceTypeId, e.TblFinishedGoodStockSheetId, e.TblFinishedGoodProductId }, "_dta_index_Tbl_FinishedGoodPricingResult_29_260352142__K13_K3_K2_K4_5_8")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.TblFinishedGoodStockSheetId, "idx_FinishedGoodPricingResult_id")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه توانایی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.TblFinishedGoodProductId).HasColumnName("Tbl_FinishedGoodProduct_Id");

                entity.Property(e => e.TblFinishedGoodStockSheetId)
                    .HasColumnName("Tbl_FinishedGoodStockSheet_Id")
                    .HasComment("کد توانایی");

                entity.Property(e => e.TblPlaceTypeId)
                    .HasColumnName("Tbl_PlaceType_Id")
                    .HasComment("نام توانایی");

                entity.HasOne(d => d.TblFinishedGoodProduct)
                    .WithMany(p => p.TblFinishedGoodPricingResults)
                    .HasForeignKey(d => d.TblFinishedGoodProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodPricingResult_Tbl_FinishedGoodProduct");

                entity.HasOne(d => d.TblFinishedGoodStockSheet)
                    .WithMany(p => p.TblFinishedGoodPricingResults)
                    .HasForeignKey(d => d.TblFinishedGoodStockSheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodPricingResult_Tbl_FinishedGoodStockSheet");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblFinishedGoodPricingResults)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodPricingResult_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblFinishedGoodProduct>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodProduct");

                entity.HasIndex(e => new { e.Code, e.Id, e.TblCompanyId }, "_dta_index_Tbl_FinishedGoodProduct_29_231828038__K4_K1_K2_5_6_7")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه محصولات");

                entity.Property(e => e.BarCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("بارکد محصول");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد محصول");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("توصیف محصول");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول محصول");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول محصول");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام محصول");

                entity.Property(e => e.Status).HasComment("وضعیت محصول");

                entity.Property(e => e.TblCodingPatternId)
                    .HasColumnName("Tbl_CodingPattern_Id")
                    .HasComment("آی دی الگوی کدینگ از جدول الگوی کدینگ");

                entity.Property(e => e.TblCompanyId).HasColumnName("Tbl_Company_Id");

                entity.HasOne(d => d.TblCodingPattern)
                    .WithMany(p => p.TblFinishedGoodProducts)
                    .HasForeignKey(d => d.TblCodingPatternId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodProduct_Tbl_CodingPattern");

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblFinishedGoodProducts)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodProduct_Tbl_Company");
            });

            modelBuilder.Entity<TblFinishedGoodProductFusingLabel>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodProductFusingLabel");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblOrderHeaderId).HasColumnName("Tbl_OrderHeader_Id");

                entity.HasOne(d => d.TblOrderHeader)
                    .WithMany(p => p.TblFinishedGoodProductFusingLabels)
                    .HasForeignKey(d => d.TblOrderHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodProductFusingLabel_Tbl_OrderHeader");
            });

            modelBuilder.Entity<TblFinishedGoodProductGallery>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodProductGallery");

                entity.HasComment("جدولی برای نمایش اطلاعات گالری محصولات");

                entity.Property(e => e.Id).HasComment("شناسه گالری محصول");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("نوع مفهوم");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف گالری محصول");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("نام فایل");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasComment("تصویر گالری محصول");

                entity.Property(e => e.ImageAngle).HasComment("زاویه تصویر");

                entity.Property(e => e.ImageOrder).HasComment("سفارش تصویر");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ImageURL")
                    .HasComment("آدرس تصویر");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول گالری محصول");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول گالری محصول");

                entity.Property(e => e.Status).HasComment("وضعیت گالری محصول");

                entity.Property(e => e.TblFinishedGoodProductId)
                    .HasColumnName("Tbl_FinishedGoodProduct_Id")
                    .HasComment("کد گالری محصول");

                entity.HasOne(d => d.TblFinishedGoodProduct)
                    .WithMany(p => p.TblFinishedGoodProductGalleries)
                    .HasForeignKey(d => d.TblFinishedGoodProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodProductGallery_Tbl_FinishedGoodProduct");
            });

            modelBuilder.Entity<TblFinishedGoodProductTranslation>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Tbl_FinishedGoodProductTranslation");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasComment("شناسه محصولات");

                entity.Property(e => e.BarCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("بارکد محصول");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد محصول");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("توصیف محصول");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول محصول");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول محصول");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام محصول");

                entity.Property(e => e.ProductColor)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductComposition)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductDesign)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductKalite)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductModel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductPattern)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductSize)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("وضعیت محصول");

                entity.Property(e => e.Supplier)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TblCodingPatternId)
                    .HasColumnName("Tbl_CodingPattern_Id")
                    .HasComment("آی دی الگوی کدینگ از جدول الگوی کدینگ");

                entity.Property(e => e.TblCompanyId).HasColumnName("Tbl_Company_Id");
            });

            modelBuilder.Entity<TblFinishedGoodProductionLabel>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodProductionLabel");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Ec).HasColumnName("ec");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblOrderHeaderId).HasColumnName("Tbl_OrderHeader_Id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TblOrderHeader)
                    .WithMany(p => p.TblFinishedGoodProductionLabels)
                    .HasForeignKey(d => d.TblOrderHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodProductionLabel_Tbl_OrderHeader");
            });

            modelBuilder.Entity<TblFinishedGoodProductionLabelComposition>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodProductionLabelComposition");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblFinishedGoodProductionLabelId).HasColumnName("Tbl_FinishedGoodProductionLabel_Id");

                entity.Property(e => e.TblRawMaterialProductCompositionTypeId).HasColumnName("Tbl_RawMaterialProductCompositionType_Id");

                entity.HasOne(d => d.TblFinishedGoodProductionLabel)
                    .WithMany(p => p.TblFinishedGoodProductionLabelCompositions)
                    .HasForeignKey(d => d.TblFinishedGoodProductionLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodProductionLabelComposition_Tbl_FinishedGoodProductionLabel");

                entity.HasOne(d => d.TblRawMaterialProductCompositionType)
                    .WithMany(p => p.TblFinishedGoodProductionLabelCompositions)
                    .HasForeignKey(d => d.TblRawMaterialProductCompositionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodProductionLabelComposition_Tbl_RawMaterialProductCompositionType");
            });

            modelBuilder.Entity<TblFinishedGoodReportTemporaryTable>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodReportTemporaryTable");

                entity.HasIndex(e => new { e.TblPlaceTypeId, e.TblFinishedGoodProductId, e.TempRemain, e.ToDate, e.Code }, "NonClusteredIndex-20200706-075440");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.FromDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PlaceTypeName).HasMaxLength(50);

                entity.Property(e => e.ProductColorCode).HasMaxLength(50);

                entity.Property(e => e.ProductColorName).HasMaxLength(50);

                entity.Property(e => e.ProductCompositionCode).HasMaxLength(50);

                entity.Property(e => e.ProductCompositionName).HasMaxLength(50);

                entity.Property(e => e.ProductDesign).HasMaxLength(50);

                entity.Property(e => e.ProductGroupCode).HasMaxLength(50);

                entity.Property(e => e.ProductGroupName).HasMaxLength(50);

                entity.Property(e => e.ProductKaliteCode).HasMaxLength(50);

                entity.Property(e => e.ProductKaliteName).HasMaxLength(50);

                entity.Property(e => e.ProductModelCode).HasMaxLength(50);

                entity.Property(e => e.ProductModelName).HasMaxLength(50);

                entity.Property(e => e.ProductPatternCode).HasMaxLength(50);

                entity.Property(e => e.ProductPatternName).HasMaxLength(50);

                entity.Property(e => e.ProductSizeCode).HasMaxLength(50);

                entity.Property(e => e.ProductSizeName).HasMaxLength(50);

                entity.Property(e => e.Supplier).HasMaxLength(50);

                entity.Property(e => e.TblCompanyId).HasColumnName("Tbl_Company_Id");

                entity.Property(e => e.TblFinishedGoodProductId).HasColumnName("Tbl_FinishedGoodProduct_Id");

                entity.Property(e => e.TblPlaceTypeId).HasColumnName("Tbl_PlaceType_Id");

                entity.Property(e => e.ToDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblFinishedGoodStockSheet>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodStockSheet");

                entity.HasIndex(e => new { e.TblFinishedGoodStockSheetSubTypeId, e.TblCompanyIdAsOwner, e.TblPlaceTypeIdAsReceiver, e.IsDeleted, e.TblFinishedGoodStockSheetTypeId, e.Date, e.TblPlaceTypeIdAsIssuer, e.SheetNumber }, "_dta_index_Tbl_FinishedGoodStockSheet_16_1755309463__K10_K2_K5_K18_K9_K13_K8_K11_1_15")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.Id, e.TblFinishedGoodStockSheetSubTypeId, e.TblCompanyIdAsOwner, e.TblPlaceTypeIdAsReceiver, e.IsDeleted, e.TblFinishedGoodStockSheetTypeId, e.Date, e.TblPlaceTypeIdAsIssuer, e.SheetNumber }, "_dta_index_Tbl_FinishedGoodStockSheet_16_1755309463__K1_K10_K2_K5_K18_K9_K13_K8_K11_15")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblPlaceTypeIdAsReceiver, e.IsDeleted, e.TblFinishedGoodStockSheetTypeId, e.Date, e.TblPlaceTypeIdAsIssuer, e.TblCompanyIdAsOwner, e.Id, e.SheetNumber, e.TblFinishedGoodStockSheetSubTypeId }, "_dta_index_Tbl_FinishedGoodStockSheet_16_1755309463__K5_K18_K9_K13_K8_K2_K1_K11_K10_15")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.IsDeleted, e.TblCompanyIdAsOwner, e.Date, e.Id }, "_dta_index_Tbl_FinishedGoodStockSheet_29_1755309463__K18_K2_K13_K1_3_4_5_6_7_8_9_10_11_12_14_15_16_17")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.IsDeleted, e.TblFinishedGoodStockSheetTypeId, e.Date, e.Id, e.TblCompanyIdAsOwner, e.TblPlaceTypeIdAsIssuer, e.TblPlaceTypeIdAsReceiver, e.SheetNumber }, "_dta_index_Tbl_FinishedGoodStockSheet_29_1755309463__K18_K9_K13_K1_K2_K8_K5_K11_15")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.Date, "idc_FinishedGoodStockSheet_date")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه منحصر به فرد برگه های انبار");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ برگه های انبار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف برگه های انبار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول برگه های انبار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول برگه های انبار");

                entity.Property(e => e.SheetIndex).HasComment("فهرست برگه");

                entity.Property(e => e.SheetNumber).HasComment("شماره برگه");

                entity.Property(e => e.Status).HasComment("وضعیت برگه های انبار");

                entity.Property(e => e.TblCompanyIdAsIssuer)
                    .HasColumnName("Tbl_Company_IdAsIssuer")
                    .HasComment("شناسه منحصر به فرد شرکت تحویل دهنده");

                entity.Property(e => e.TblCompanyIdAsOwner).HasColumnName("Tbl_Company_IdAsOwner");

                entity.Property(e => e.TblCompanyIdAsReceiver)
                    .HasColumnName("Tbl_Company_IdAsReceiver")
                    .HasComment("شناسه منحصر به فرد شرکت تحویل گیرنده");

                entity.Property(e => e.TblFinishedGoodStockSheetSubTypeId)
                    .HasColumnName("Tbl_FinishedGoodStockSheetSubType_Id")
                    .HasComment("نوع فرعی برگه");

                entity.Property(e => e.TblFinishedGoodStockSheetTypeId)
                    .HasColumnName("Tbl_FinishedGoodStockSheetType_Id")
                    .HasComment("نوع اصلی برگه");

                entity.Property(e => e.TblPersonIdAsIssuer)
                    .HasColumnName("Tbl_Person_IdAsIssuer")
                    .HasComment("شناسه منحصر به فرد تحویل دهنده");

                entity.Property(e => e.TblPersonIdAsReceiver)
                    .HasColumnName("Tbl_Person_IdAsReceiver")
                    .HasComment("شناسه منحصر به فرد تحویل گیرنده");

                entity.Property(e => e.TblPlaceTypeIdAsIssuer)
                    .HasColumnName("Tbl_PlaceType_IdAsIssuer")
                    .HasComment("شناسه منحصر به فرد محل تحویل دهنده");

                entity.Property(e => e.TblPlaceTypeIdAsReceiver)
                    .HasColumnName("Tbl_PlaceType_IdAsReceiver")
                    .HasComment("شناسه منحصر به فرد تحویل گیرنده");

                entity.HasOne(d => d.TblCompanyIdAsIssuerNavigation)
                    .WithMany(p => p.TblFinishedGoodStockSheetTblCompanyIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsIssuer)
                    .HasConstraintName("FK_Tbl_FinishedGoodStockSheet_Tbl_Company1");

                entity.HasOne(d => d.TblCompanyIdAsOwnerNavigation)
                    .WithMany(p => p.TblFinishedGoodStockSheetTblCompanyIdAsOwnerNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsOwner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodStockSheet_Tbl_Company");

                entity.HasOne(d => d.TblCompanyIdAsReceiverNavigation)
                    .WithMany(p => p.TblFinishedGoodStockSheetTblCompanyIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsReceiver)
                    .HasConstraintName("FK_Tbl_FinishedGoodStockSheet_Tbl_Company2");

                entity.HasOne(d => d.TblFinishedGoodStockSheetSubType)
                    .WithMany(p => p.TblFinishedGoodStockSheets)
                    .HasForeignKey(d => d.TblFinishedGoodStockSheetSubTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodStockSheet_Tbl_FinishedGoodStockSheetSubType");

                entity.HasOne(d => d.TblFinishedGoodStockSheetType)
                    .WithMany(p => p.TblFinishedGoodStockSheets)
                    .HasForeignKey(d => d.TblFinishedGoodStockSheetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodStockSheet_Tbl_FinishedGoodStockSheetType");

                entity.HasOne(d => d.TblPersonIdAsIssuerNavigation)
                    .WithMany(p => p.TblFinishedGoodStockSheetTblPersonIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsIssuer)
                    .HasConstraintName("FK_Tbl_FinishedGoodStockSheet_Tbl_Person");

                entity.HasOne(d => d.TblPersonIdAsReceiverNavigation)
                    .WithMany(p => p.TblFinishedGoodStockSheetTblPersonIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsReceiver)
                    .HasConstraintName("FK_Tbl_FinishedGoodStockSheet_Tbl_Person1");

                entity.HasOne(d => d.TblPlaceTypeIdAsIssuerNavigation)
                    .WithMany(p => p.TblFinishedGoodStockSheetTblPlaceTypeIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblPlaceTypeIdAsIssuer)
                    .HasConstraintName("FK_Tbl_FinishedGoodStockSheet_Tbl_PlaceType");

                entity.HasOne(d => d.TblPlaceTypeIdAsReceiverNavigation)
                    .WithMany(p => p.TblFinishedGoodStockSheetTblPlaceTypeIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblPlaceTypeIdAsReceiver)
                    .HasConstraintName("FK_Tbl_FinishedGoodStockSheet_Tbl_PlaceType1");
            });

            modelBuilder.Entity<TblFinishedGoodStockSheetItem>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodStockSheetItem");

                entity.HasIndex(e => e.TblFinishedGoodStockSheetId, "NonClusteredIndex-20190729-120359")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblFinishedGoodStockSheetId, e.TblFinishedGoodProductId, e.IsDeleted, e.Count }, "_dta_index_Tbl_FinishedGoodStockSheetItem_29_1787309577__K2_K3_K12_K4_5")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblFinishedGoodProductId, e.IsDeleted, e.Count, e.TblFinishedGoodStockSheetId }, "_dta_index_Tbl_FinishedGoodStockSheetItem_29_1787309577__K3_K12_K4_K2_5")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.IsDeleted, "idx_Tbl_FinishedGoodStockSheetItem_isdeleted")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه آیتم برگه انبار");

                entity.Property(e => e.Count).HasComment("تعداد آیتم برگه انبار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف آیتم برگه انبار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول  آیتم برگه انبار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول آیتم برگه انبار");

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Price).HasComment("قیمت آیتم برگه انبار");

                entity.Property(e => e.Status).HasComment("وضعیت آیتم برگه انبار");

                entity.Property(e => e.TblFinishedGoodProductId)
                    .HasColumnName("Tbl_FinishedGoodProduct_Id")
                    .HasComment("آی دی محصول از جدول محصول");

                entity.Property(e => e.TblFinishedGoodStockSheetId)
                    .HasColumnName("Tbl_FinishedGoodStockSheet_Id")
                    .HasComment("آی دی برگه انبار از جدول برگه انبار");

                entity.Property(e => e.TblOrderHeaderId).HasColumnName("Tbl_OrderHeader_Id");

                entity.Property(e => e.TblProductionOrderFinishedGoodProductsId).HasColumnName("Tbl_ProductionOrderFinishedGoodProducts_Id");

                entity.HasOne(d => d.TblFinishedGoodProduct)
                    .WithMany(p => p.TblFinishedGoodStockSheetItems)
                    .HasForeignKey(d => d.TblFinishedGoodProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodStockSheetItem_Tbl_FinishedGoodProduct");

                entity.HasOne(d => d.TblFinishedGoodStockSheet)
                    .WithMany(p => p.TblFinishedGoodStockSheetItems)
                    .HasForeignKey(d => d.TblFinishedGoodStockSheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodStockSheetItem_Tbl_FinishedGoodStockSheet");

                entity.HasOne(d => d.TblOrderHeader)
                    .WithMany(p => p.TblFinishedGoodStockSheetItems)
                    .HasForeignKey(d => d.TblOrderHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodStockSheetItem_Tbl_OrderHeader");

                entity.HasOne(d => d.TblProductionOrderFinishedGoodProducts)
                    .WithMany(p => p.TblFinishedGoodStockSheetItems)
                    .HasForeignKey(d => d.TblProductionOrderFinishedGoodProductsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodStockSheetItem_Tbl_ProductionOrderFinishedGoodProducts");
            });

            modelBuilder.Entity<TblFinishedGoodStockSheetSubType>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodStockSheetSubType");

                entity.Property(e => e.Id).HasComment("شناسه توانایی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد توانایی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.TblFinishedGoodStockSheetTypeId).HasColumnName("Tbl_FinishedGoodStockSheetType_Id");

                entity.HasOne(d => d.TblFinishedGoodStockSheetType)
                    .WithMany(p => p.TblFinishedGoodStockSheetSubTypes)
                    .HasForeignKey(d => d.TblFinishedGoodStockSheetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FinishedGoodStockSheetSubType_Tbl_FinishedGoodStockSheetType");
            });

            modelBuilder.Entity<TblFinishedGoodStockSheetType>(entity =>
            {
                entity.ToTable("Tbl_FinishedGoodStockSheetType");

                entity.Property(e => e.Id).HasComment("شناسه توانایی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد توانایی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");
            });

            modelBuilder.Entity<TblFir>(entity =>
            {
                entity.ToTable("Tbl_FIRs");

                entity.HasComment("جدولی برای نمایش اطلاعات بیومتریک");

                entity.HasIndex(e => e.IsDeleted, "NonClusteredIndex-20190508-081806")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه بیومتریک");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف اثرانگشت");

                entity.Property(e => e.FingerId)
                    .HasColumnName("FingerID")
                    .HasComment("شناسه شماره اثر انگشت");

                entity.Property(e => e.Fir)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("FIR")
                    .HasComment("اطلاعات اثر انگشت");

                entity.Property(e => e.Firdata)
                    .IsRequired()
                    .HasColumnType("image")
                    .HasColumnName("FIRData")
                    .HasComment("عکس های مربوط به اثر انگشت");

                entity.Property(e => e.Firformat)
                    .HasColumnName("FIRFormat")
                    .HasComment("قالب اثر انگشت");

                entity.Property(e => e.Firheader)
                    .IsRequired()
                    .HasColumnType("xml")
                    .HasColumnName("FIRHeader")
                    .HasComment("شامل گره های اثر انگشت برای تشخیص");

                entity.Property(e => e.FirstReserved).HasComment("اولین و بهترین انگشت");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول اثرانگشت");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اثرانگشت");

                entity.Property(e => e.SampleNumber).HasComment("تعداد نمونه ها");

                entity.Property(e => e.SecondReserved).HasComment("دومین و بهترین اثر انگشت");

                entity.Property(e => e.Status).HasComment("وضعیت اثرانگشت");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblFirs)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FIRs_Tbl_Person");
            });

            modelBuilder.Entity<TblFloatLedger>(entity =>
            {
                entity.ToTable("Tbl_FloatLedger");

                entity.HasComment("جدولی برای نمایش اطلاعات حساب شناور");

                entity.Property(e => e.Id).HasComment("شناسه حساب شناور");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("کد حساب شناور");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف حساب شناور");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول حساب شناور");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول حساب شناور");

                entity.Property(e => e.ParentId).HasComment("شناسه والد،در بخش حساب ها اگر حساب تفضیلی است به معین یا مثلا اگر معین است به کل آن اشاره دارد");

                entity.Property(e => e.Status).HasComment("وضعیت حساب شناور");

                entity.Property(e => e.TblFinancialCycleId)
                    .HasColumnName("Tbl_FinancialCycle_Id")
                    .HasComment("آی دی دوره مالی در جدول دوره مالی");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("عنوان حساب شناور");

                entity.HasOne(d => d.TblFinancialCycle)
                    .WithMany(p => p.TblFloatLedgers)
                    .HasForeignKey(d => d.TblFinancialCycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FloatLedger_Tbl_FinancialCycle");
            });

            modelBuilder.Entity<TblFloatLedgerItem>(entity =>
            {
                entity.ToTable("Tbl_FloatLedgerItem");

                entity.HasComment("جدولی برای نمایش اطلاعات آیتم های موجود حساب شناور");

                entity.Property(e => e.Id).HasComment("شناسه آیتم های موجود حساب شناور");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف آیتم های موجود حساب شناور");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول آیتم های موجود حساب شناور");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول آیتم های موجود حساب شناور");

                entity.Property(e => e.Status).HasComment("وضعیت آیتم های موجود حساب شناور");

                entity.Property(e => e.TblFloatLedgerId)
                    .HasColumnName("Tbl_FloatLedger_Id")
                    .HasComment("آی دی حساب از جدول حساب ");

                entity.Property(e => e.TblLedgerId)
                    .HasColumnName("Tbl_Ledger_Id")
                    .HasComment("آی دی حساب شناور از جدول حساب شناور");

                entity.HasOne(d => d.TblFloatLedger)
                    .WithMany(p => p.TblFloatLedgerItems)
                    .HasForeignKey(d => d.TblFloatLedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FloatLedgerItem_Tbl_FloatLedger");

                entity.HasOne(d => d.TblLedger)
                    .WithMany(p => p.TblFloatLedgerItems)
                    .HasForeignKey(d => d.TblLedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FloatLedgerItem_Tbl_Ledger");
            });

            modelBuilder.Entity<TblForm>(entity =>
            {
                entity.ToTable("Tbl_Form");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblFormField>(entity =>
            {
                entity.ToTable("Tbl_FormField");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.TblFormFieldTypeId).HasColumnName("Tbl_FormFieldType_Id");

                entity.Property(e => e.TblFormId).HasColumnName("Tbl_Form_Id");

                entity.HasOne(d => d.TblFormFieldType)
                    .WithMany(p => p.TblFormFields)
                    .HasForeignKey(d => d.TblFormFieldTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FormField_Tbl_FormFieldType");

                entity.HasOne(d => d.TblForm)
                    .WithMany(p => p.TblFormFields)
                    .HasForeignKey(d => d.TblFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FormField_Tbl_Form");
            });

            modelBuilder.Entity<TblFormFieldDefault>(entity =>
            {
                entity.ToTable("Tbl_FormFieldDefault");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TblFormFieldId).HasColumnName("Tbl_FormField_Id");

                entity.HasOne(d => d.TblFormField)
                    .WithMany(p => p.TblFormFieldDefaults)
                    .HasForeignKey(d => d.TblFormFieldId)
                    .HasConstraintName("FK_Tbl_FormFieldDefault_Tbl_FormField");
            });

            modelBuilder.Entity<TblFormFieldType>(entity =>
            {
                entity.ToTable("Tbl_FormFieldType");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblFormFieldValue>(entity =>
            {
                entity.ToTable("Tbl_FormFieldValue");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TblFormFieldId).HasColumnName("Tbl_FormField_Id");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.HasOne(d => d.TblFormField)
                    .WithMany(p => p.TblFormFieldValues)
                    .HasForeignKey(d => d.TblFormFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FormFieldValue_Tbl_FormField");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblFormFieldValues)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FormFieldValue_Tbl_Person");
            });

            modelBuilder.Entity<TblFormalDay>(entity =>
            {
                entity.ToTable("Tbl_FormalDay");

                entity.HasIndex(e => new { e.Date, e.IsDeleted }, "NonClusteredIndex-20200526-153008");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblFormalDayNameId).HasColumnName("Tbl_FormalDayName_Id");

                entity.HasOne(d => d.TblFormalDayName)
                    .WithMany(p => p.TblFormalDays)
                    .HasForeignKey(d => d.TblFormalDayNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FormalDay_Tbl_FormalDayName1");
            });

            modelBuilder.Entity<TblFormalDayName>(entity =>
            {
                entity.ToTable("Tbl_FormalDayName");

                entity.HasComment("جدولی برای نمایش اطلاعات نام روز رسمی");

                entity.HasIndex(e => e.IsDeleted, "NonClusteredIndex-20161218-170031")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه نام روز رسمی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نام روزرسمی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول نام روز رسمی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام روزرسمی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");
            });

            modelBuilder.Entity<TblFormula>(entity =>
            {
                entity.ToTable("Tbl_Formula");

                entity.HasComment("جپولی برای نمایش اطلاعات فرمول ها");

                entity.Property(e => e.Id).HasComment("شناسه فرمول");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف فرمول ");

                entity.Property(e => e.Formula)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasComment("فرمول ها");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول فرمول ها");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول فرمول ها");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام فرمول");

                entity.Property(e => e.ParentId).HasComment("شناسه والد");

                entity.Property(e => e.PropertyType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نوع ویژگی");

                entity.Property(e => e.Status).HasComment("وضعیت فرمول");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("تیتر");
            });

            modelBuilder.Entity<TblFormulaDetail>(entity =>
            {
                entity.ToTable("Tbl_FormulaDetail");

                entity.HasComment("جدولی برای نمایش اطلاعات جزئیات فرمول");

                entity.Property(e => e.Id).HasComment("شناسه جزئیات فرمول");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasComment("شرح جزئیات فرمول");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasComment("توصیف جزئیات فرمول");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("نام گروه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsComment).HasComment("بیان اطلاعات توضیح داده شده است در جدول جزئیات فرمول");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول جزئیات فرمول");

                entity.Property(e => e.IsDynamic).HasComment("بیان اطلاعات داینامیک است در جدول جزئیات فرمول");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول جزئیات فرمول");

                entity.Property(e => e.Opeator)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("عملیات مربوط به فرمول های جزئی");

                entity.Property(e => e.Status).HasComment("وضعیت جزئیات فرمول");

                entity.Property(e => e.TblFormulaHeaderId)
                    .HasColumnName("Tbl_FormulaHeader_Id")
                    .HasComment("آی دی فرمول های ثابت از جدول فرمول های ثابت");

                entity.HasOne(d => d.TblFormulaHeader)
                    .WithMany(p => p.TblFormulaDetails)
                    .HasForeignKey(d => d.TblFormulaHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FormulaDetail_Tbl_FormulaHeader");
            });

            modelBuilder.Entity<TblFormulaGroup>(entity =>
            {
                entity.ToTable("Tbl_FormulaGroup");

                entity.HasComment("جدولی برای نمایش اطلاعات گروه فرمول ها");

                entity.Property(e => e.Id).HasComment("شناسه گروه فرمول ها");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف گروه فرمول ها");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام فیلد");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول گروه فرمول");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول گروه فرمول");

                entity.Property(e => e.Status).HasComment("وضعیت گروه فرمول ها");

                entity.Property(e => e.TblFormulaDetailId)
                    .HasColumnName("Tbl_FormulaDetail_Id")
                    .HasComment("آی دی فرمول های متغییر از جدول فرمول های متغییر  ");

                entity.Property(e => e.TblKeyId)
                    .HasColumnName("Tbl_Key_Id")
                    .HasComment("آی دی کلید از جدول کلیدها");

                entity.HasOne(d => d.TblFormulaDetail)
                    .WithMany(p => p.TblFormulaGroups)
                    .HasForeignKey(d => d.TblFormulaDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FormulaGroup_Tbl_FormulaDetail");
            });

            modelBuilder.Entity<TblFormulaHeader>(entity =>
            {
                entity.ToTable("Tbl_FormulaHeader");

                entity.HasComment("جدولی برای نمایش اطلاعات سرفصل فرمول ها");

                entity.Property(e => e.Id).HasComment("شناسه سرفصل فرمول");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد حساب");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("شرح سرفصل فرمول");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف سرفصل فرمول");

                entity.Property(e => e.FormulaName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام فرمول ");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDebit).HasComment("بیان اطلاعات بدهکار است در جدول سرفصل فرمول");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول سرفصل فرمول");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول سرفصل فرمول");

                entity.Property(e => e.Status).HasComment("وضعیت سرفصل فرمول ها");

                entity.Property(e => e.StoreCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد فروشگاه");

                entity.Property(e => e.TblFinancialCycleId)
                    .HasColumnName("Tbl_FinancialCycle_Id")
                    .HasComment("آی دی دوره گردش مالی از جدول دوره گردش مالی");

                entity.Property(e => e.TblLedgerId)
                    .HasColumnName("Tbl_Ledger_Id")
                    .HasComment("آی دی حساب از جدول حساب");

                entity.HasOne(d => d.TblFinancialCycle)
                    .WithMany(p => p.TblFormulaHeaders)
                    .HasForeignKey(d => d.TblFinancialCycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_FormulaHeader_Tbl_FinancialCycle");
            });

            modelBuilder.Entity<TblGoal>(entity =>
            {
                entity.ToTable("Tbl_Goal");

                entity.HasComment("جدولی برای نمایش اطلاعات اهداف");

                entity.Property(e => e.Id).HasComment("شناسه هدف");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد هدف");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف هدف");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول اهداف");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اهداف");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasComment("نام هدف");

                entity.Property(e => e.Status).HasComment("وضعیت هدف");
            });

            modelBuilder.Entity<TblGroup>(entity =>
            {
                entity.ToTable("Tbl_Group");

                entity.HasComment("جدولی برای نمایش اطلاعات گروه ها");

                entity.Property(e => e.Id).HasComment("شناسه گروه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف گروه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول گروه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول گروه");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام گروه");

                entity.Property(e => e.Status).HasComment("وضعیت گروه");
            });

            modelBuilder.Entity<TblHardware>(entity =>
            {
                entity.ToTable("Tbl_Hardware");

                entity.HasComment("جدولی برای نمایش اطلاعات سخت افزار");

                entity.Property(e => e.Id).HasComment("شناسه سخت افزار");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد سخت افزار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف سخت افزار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول سخت افزار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول سخت افزار");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام سخت افزار");

                entity.Property(e => e.Status).HasComment("وضعیت سخت افزار");
            });

            modelBuilder.Entity<TblHardwareVersion>(entity =>
            {
                entity.ToTable("Tbl_HardwareVersion");

                entity.HasComment("جدولی برای نمایش اطلاعات ورژن سخت افزار");

                entity.Property(e => e.Id).HasComment("شناسه ورژن سخت افزار");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد ورژن سخت افزار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف ورژن سخت افزار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول  ورژن سخت افزار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول ورژن سخت افزار");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام ورژن سخت افزار");

                entity.Property(e => e.Status).HasComment("وضعیت ورژن سخت افزار");

                entity.Property(e => e.TblBrandId)
                    .HasColumnName("Tbl_Brand_Id")
                    .HasComment("آی دی برند در جدول برند");

                entity.Property(e => e.TblHardwareId)
                    .HasColumnName("Tbl_Hardware_Id")
                    .HasComment("آی دی سخت افزار در جدول سخت افزار");

                entity.HasOne(d => d.TblBrand)
                    .WithMany(p => p.TblHardwareVersions)
                    .HasForeignKey(d => d.TblBrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_HardwareVersion_Tbl_Brand");

                entity.HasOne(d => d.TblHardware)
                    .WithMany(p => p.TblHardwareVersions)
                    .HasForeignKey(d => d.TblHardwareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_HardwareVersion_Tbl_Hardware");
            });

            modelBuilder.Entity<TblHistory>(entity =>
            {
                entity.ToTable("Tbl_History");

                entity.HasComment("جدولی برای نمایش اطلاعات تاریخچه");

                entity.HasIndex(e => new { e.Id, e.TblPersonId, e.TblHistoryOperationTypeId }, "History")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblPersonId, e.IsDeleted, e.Id }, "_dta_index_Tbl_History_29_482920892__K2_K11_K1_3_4_5_6_7_8_9_10")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه تاریخچه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف تاریخچه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.HistoryConversation)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("تاریخچه عملیات");

                entity.Property(e => e.HistoryDate)
                    .HasColumnType("date")
                    .HasComment("تاریخ تاریخچه");

                entity.Property(e => e.HistoryTime).HasComment("زمان تاریخچه");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول  تاریخچه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول تاریخچه");

                entity.Property(e => e.Status).HasComment("وضعیت تاریخچه");

                entity.Property(e => e.TblHistoryOperationTypeId)
                    .HasColumnName("Tbl_HistoryOperationType_Id")
                    .HasComment("آی دی نوع عملیات تاریخچه از جدول نوع عملیات تاریخچه");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی پرسنل از جدول پرسنل");

                entity.HasOne(d => d.TblHistoryOperationType)
                    .WithMany(p => p.TblHistories)
                    .HasForeignKey(d => d.TblHistoryOperationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_History_Tbl_HistoryOperationType");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblHistories)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_History_Tbl_Person");
            });

            modelBuilder.Entity<TblHistoryOperation>(entity =>
            {
                entity.ToTable("Tbl_HistoryOperation");

                entity.HasComment("جدولی برای نمایش اطلاعات تاریخچه عملیات");

                entity.HasIndex(e => e.Id, "HistoryOperation")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه تاریخچه عملیات");

                entity.Property(e => e.Code).HasComment("کد عملیات تاریخچه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف تاریخچه عملیات");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول تاریخچه عملیات");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول تاریخچه عملیات");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام عملیات تاریخچه");

                entity.Property(e => e.Status).HasComment("وضعیت تاریخچه عملیات");
            });

            modelBuilder.Entity<TblHistoryOperationType>(entity =>
            {
                entity.ToTable("Tbl_HistoryOperationType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع تاریخچه عملیات");

                entity.HasIndex(e => new { e.Id, e.TblHistoryOperationId }, "OpertaionType")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه نوع تاریخچه عملیات");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع عملیات تاریخچه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع تاریخچه عملیات");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول نوع تاریخچه عملیات");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع تاریخچه عملیات");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع عملیات تاریخچه");

                entity.Property(e => e.Status).HasComment("وضعیت نوع تاریخچه عملیات");

                entity.Property(e => e.TblHistoryOperationId)
                    .HasColumnName("Tbl_HistoryOperation_Id")
                    .HasComment("آی دی تاریخچه عملیات در جدول تاریخچه عملیات ");

                entity.HasOne(d => d.TblHistoryOperation)
                    .WithMany(p => p.TblHistoryOperationTypes)
                    .HasForeignKey(d => d.TblHistoryOperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_HistoryOperationType_Tbl_HistoryOperation");
            });

            modelBuilder.Entity<TblHouseType>(entity =>
            {
                entity.ToTable("Tbl_HouseType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع خانه");

                entity.Property(e => e.Id).HasComment("شناسه نوع خانه");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع خانه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع خانه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول نوع خانه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع خانه");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع خانه");

                entity.Property(e => e.Status).HasComment("وضعیت نوع خانه");
            });

            modelBuilder.Entity<TblImprest>(entity =>
            {
                entity.ToTable("Tbl_Imprest");

                entity.HasComment("جدولی برای نمایش اطلاعات مساعده");

                entity.Property(e => e.Id).HasComment("شناسه مساعده");

                entity.Property(e => e.Amount).HasComment("میزان مساعده");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ مساعده");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف مساعده");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول مساعده");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول مساعده");

                entity.Property(e => e.Status).HasComment("وضعیت مساعده");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول شخص");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblImprests)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Imprest_Tbl_Person");
            });

            modelBuilder.Entity<TblInitializedType>(entity =>
            {
                entity.ToTable("Tbl_InitializedType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع اولیه");

                entity.Property(e => e.Id).HasComment("شناسه نوع اولیه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع اولیه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.InitializedTypeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("کد نوع اولیه");

                entity.Property(e => e.IntilalizedTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع اولیه");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع اولیه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع اولیه");

                entity.Property(e => e.Status).HasComment("وضعیت نوع اولیه");
            });

            modelBuilder.Entity<TblInsuranceBranch>(entity =>
            {
                entity.ToTable("Tbl_InsuranceBranch");

                entity.HasComment("جدولی برای نمایش اطلاعات شعب بیمه");

                entity.Property(e => e.Id).HasComment("شناسه شعب بیمه");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد شعبه بیمه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("توصیف شعب بیمه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول شعب بیمه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول شعب بیمه");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام شعبه بیمه");

                entity.Property(e => e.Status).HasComment("وضعیت شعب بیمه");

                entity.Property(e => e.TblPlaceTypeId)
                    .HasColumnName("Tbl_PlaceType_Id")
                    .HasComment("آی دی نوع مکان از جدول نوع مکان");

                entity.Property(e => e.Tfn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TFN")
                    .HasComment("شماره پرونده مالیاتی شعب بیمه");

                entity.Property(e => e.Tin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TIN")
                    .HasComment("شماره شناسایی مالیات دهندگان شعب بیمه");

                entity.Property(e => e.WorkshopCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد گارگاه آموزشی");

                entity.Property(e => e.WorkshopName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام گارگاه آموزشی");

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد پستی شعب بیمه");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblInsuranceBranches)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InsuranceBranch_Tbl_Place");
            });

            modelBuilder.Entity<TblInsuranceJob>(entity =>
            {
                entity.ToTable("Tbl_InsuranceJob");

                entity.HasComment("جدولی برای نمایش اطلاعات سمت سازمانی");

                entity.Property(e => e.Id).HasComment("شناسه پست سازمانی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد پست سازمانی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف پست سازمانی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول سمت سازمانی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول سمت سازمانی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام پست سازمانی");

                entity.Property(e => e.Status).HasComment("وضعیت پست سازمانی");
            });

            modelBuilder.Entity<TblInsuranceType>(entity =>
            {
                entity.ToTable("Tbl_InsuranceType");

                entity.HasComment("جدولی  برای نمایش اطلاعات نوع بیمه");

                entity.Property(e => e.Id).HasComment(" نوع بیمه");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع بیمه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع بیمه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول نوع بیمه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع بیمه");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع بیمه");

                entity.Property(e => e.Status).HasComment("وضعیت نوع بیمه");
            });

            modelBuilder.Entity<TblInterest>(entity =>
            {
                entity.ToTable("Tbl_Interest");

                entity.HasComment("جدولی برای نمایش اطلاعات علاقه");

                entity.Property(e => e.Id).HasComment("شناسه علاقه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف علاقه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول علاقه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول علاقه");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام علاقه");

                entity.Property(e => e.Status).HasComment("وضعیت علاقه");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نوع علاقه");
            });

            modelBuilder.Entity<TblInvoiceMaster>(entity =>
            {
                entity.ToTable("Tbl_InvoiceMaster");

                entity.HasComment("جدولی برای نمایش اطلاعات فاکتور");

                entity.HasIndex(e => new { e.TblInvoiceStatusId, e.InvoiceDate, e.EffectiveCode, e.ParentId, e.IsDeleted, e.InvoiceNumber }, "IdxTbl_InvoiceMaster_IncludeJustID")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.InvoiceDate, "Idx_Tbl_InvoiceMaster_JustInvoiceDate")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblInvoiceStatusId, e.InvoiceDate, e.ParentId, e.IsDeleted }, "NonClusteredIndex-20190507-173819")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblCompanyIdAsOwner, e.TblInvoiceRegistrarId, e.InvoiceNumber, e.Id, e.IsDeleted, e.InvoiceDate }, "_dta_index_Tbl_InvoiceMaster_16_685453716__K2_K9_K17_K1_K30_K14_10_11_12_13_15_18_19_20_21_22_23_24_25_26_27_28_29")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.IsDeleted, e.TblInvoiceRegistrarId }, "_dta_index_Tbl_InvoiceMaster_16_685453716__K30_K9_17")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblInvoiceStatusId, e.ParentId, e.IsDeleted, e.InvoiceNumber }, "idx_Tbl_InvoiceMaster_Importantfiled")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.IsDeleted, e.InvoiceDate }, "idx_Tbl_InvoiceMaster_invoiceDate")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه فاکتور");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("توضیح فاکتور");

                entity.Property(e => e.EffectiveCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد موثر");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("توصیف فاکتور");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.InvoiceDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ فاکتور");

                entity.Property(e => e.InvoiceDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvoiceNumber).HasComment("شماره فاکتور");

                entity.Property(e => e.InvoiceTo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("مشخصات شخصی که برایش فاکتور زده  شده");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول فاکتور");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول فاکتور");

                entity.Property(e => e.ParentId).HasComment("شناسه والد،اصلی");

                entity.Property(e => e.ParentIdFromReturn).HasComment("مقداردهی اولیه کد");

                entity.Property(e => e.Status).HasComment("وضعیت فاکتور");

                entity.Property(e => e.Tax).HasMaxLength(50);

                entity.Property(e => e.TaxPercent).HasMaxLength(50);

                entity.Property(e => e.TblCompanyIdAsIssuer).HasColumnName("Tbl_Company_IdAsIssuer");

                entity.Property(e => e.TblCompanyIdAsOwner).HasColumnName("Tbl_Company_IdAsOwner");

                entity.Property(e => e.TblCompanyIdAsReceiver).HasColumnName("Tbl_Company_IdAsReceiver");

                entity.Property(e => e.TblEffectiveTypeId)
                    .HasColumnName("Tbl_EffectiveType_Id")
                    .HasComment("آی دی نوع تاثیر از جدول نوع تاثیر");

                entity.Property(e => e.TblInitializedTypeId)
                    .HasColumnName("Tbl_InitializedType_Id")
                    .HasComment("آی دی نوع مقداردهی اولیه از جدول نوع مقداردهی");

                entity.Property(e => e.TblInvoiceRegistrarId)
                    .HasColumnName("Tbl_InvoiceRegistrar_Id")
                    .HasComment("آی دی ثبت کننده فاکتور از جدول ثبت کننده فاکتور");

                entity.Property(e => e.TblInvoiceStatusId)
                    .HasColumnName("Tbl_InvoiceStatus_Id")
                    .HasComment("آی دی وضعیت فاکتور از جدول وضعیت فاکتور");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.Property(e => e.TblPersonIdAsIssuer).HasColumnName("Tbl_Person_IdAsIssuer");

                entity.Property(e => e.TblPersonIdAsReceiver).HasColumnName("Tbl_Person_IdAsReceiver");

                entity.Property(e => e.TblPlaceTypeIdAsIssuer).HasColumnName("Tbl_PlaceType_IdAsIssuer");

                entity.Property(e => e.TblPlaceTypeIdAsReceiver).HasColumnName("Tbl_PlaceType_IdAsReceiver");

                entity.HasOne(d => d.TblCompanyIdAsIssuerNavigation)
                    .WithMany(p => p.TblInvoiceMasterTblCompanyIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsIssuer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMaster_Tbl_Company_IdAsIssuer");

                entity.HasOne(d => d.TblCompanyIdAsOwnerNavigation)
                    .WithMany(p => p.TblInvoiceMasterTblCompanyIdAsOwnerNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsOwner)
                    .HasConstraintName("FK_Tbl_InvoiceMaster_Tbl_Company");

                entity.HasOne(d => d.TblCompanyIdAsReceiverNavigation)
                    .WithMany(p => p.TblInvoiceMasterTblCompanyIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsReceiver)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMaster_Tbl_Company_IdAsReceiver");

                entity.HasOne(d => d.TblEffectiveType)
                    .WithMany(p => p.TblInvoiceMasters)
                    .HasForeignKey(d => d.TblEffectiveTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMaster_Tbl_EffectiveType");

                entity.HasOne(d => d.TblInitializedType)
                    .WithMany(p => p.TblInvoiceMasters)
                    .HasForeignKey(d => d.TblInitializedTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMaster_Tbl_InitializedType");

                entity.HasOne(d => d.TblInvoiceRegistrar)
                    .WithMany(p => p.TblInvoiceMasters)
                    .HasForeignKey(d => d.TblInvoiceRegistrarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMaster_Tbl_RegistrarType");

                entity.HasOne(d => d.TblInvoiceStatus)
                    .WithMany(p => p.TblInvoiceMasters)
                    .HasForeignKey(d => d.TblInvoiceStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMaster_Tbl_InvoiceStatus");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblInvoiceMasterTblPeople)
                    .HasForeignKey(d => d.TblPersonId)
                    .HasConstraintName("FK_Tbl_InvoiceMaster_Tbl_Person");

                entity.HasOne(d => d.TblPersonIdAsIssuerNavigation)
                    .WithMany(p => p.TblInvoiceMasterTblPersonIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsIssuer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMaster_Tbl_Person_IdAsIssuer");

                entity.HasOne(d => d.TblPersonIdAsReceiverNavigation)
                    .WithMany(p => p.TblInvoiceMasterTblPersonIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsReceiver)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMaster_Tbl_Person_IdAsReceiver");

                entity.HasOne(d => d.TblPlaceTypeIdAsIssuerNavigation)
                    .WithMany(p => p.TblInvoiceMasterTblPlaceTypeIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblPlaceTypeIdAsIssuer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMaster_Tbl_PlaceType_IdAsIssuer");

                entity.HasOne(d => d.TblPlaceTypeIdAsReceiverNavigation)
                    .WithMany(p => p.TblInvoiceMasterTblPlaceTypeIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblPlaceTypeIdAsReceiver)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMaster_Tbl_PlaceType_IdAsReceiver");
            });

            modelBuilder.Entity<TblInvoiceMasterAttachment>(entity =>
            {
                entity.ToTable("Tbl_InvoiceMasterAttachment");

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName).IsRequired();

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblInvoiceMasterId).HasColumnName("Tbl_InvoiceMaster_Id");

                entity.HasOne(d => d.TblInvoiceMaster)
                    .WithMany(p => p.TblInvoiceMasterAttachments)
                    .HasForeignKey(d => d.TblInvoiceMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceMasterAttachment_InvoiceMasterAttachment");
            });

            modelBuilder.Entity<TblInvoiceMasterDiscount>(entity =>
            {
                entity.ToTable("Tbl_InvoiceMasterDiscount");

                entity.HasComment("جدولی برای نمایش ازاطلاعات تخفیف  فاکتور");

                entity.HasIndex(e => new { e.TblInvoiceMasterId, e.TblDiscountTypeId, e.Amount, e.IsDeleted }, "NonClusteredIndex-20190904-133544");

                entity.Property(e => e.Id).HasComment("شناسه تخفیف  فاکتور");

                entity.Property(e => e.Amount).HasComment("مقدار تخفیف فاکتور");

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasComment("شماره کارت تخفیف فاکتور");

                entity.Property(e => e.DiscountPercent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("درصد تخفیف ");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف تخفیف فاکتور");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول تخفیف  فاکتور");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول تخفیف  فاکتور");

                entity.Property(e => e.Status).HasComment("وضعیت تخفیف  فاکتور");

                entity.Property(e => e.TblDiscountTypeId)
                    .HasColumnName("Tbl_DiscountType_Id")
                    .HasComment("آی دی نوع تخفیف از جدول نوع تخفیف");

                entity.Property(e => e.TblInvoiceMasterId)
                    .HasColumnName("Tbl_InvoiceMaster_Id")
                    .HasComment("آی دی فاکتور از جدول فاکتور");

                entity.HasOne(d => d.TblDiscountType)
                    .WithMany(p => p.TblInvoiceMasterDiscounts)
                    .HasForeignKey(d => d.TblDiscountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMasterDiscount_Tbl_DiscountType");

                entity.HasOne(d => d.TblInvoiceMaster)
                    .WithMany(p => p.TblInvoiceMasterDiscounts)
                    .HasForeignKey(d => d.TblInvoiceMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMasterDiscount_Tbl_InvoiceMaster");
            });

            modelBuilder.Entity<TblInvoiceMasterPayment>(entity =>
            {
                entity.ToTable("Tbl_InvoiceMasterPayment");

                entity.HasComment("جدولی برای نمایش اطلاعات پرداخت فاکتور");

                entity.HasIndex(e => e.TblInvoiceMasterId, "Idx_Tbl_InvoiceMasterPayment_InvoiceMasterId")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه پرداخت فاکتور");

                entity.Property(e => e.Amount).HasComment("میزان پرداخت فاکتور");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف پرداخت فاکتور");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول پرداخت فاکتور");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول پرداخت فاکتور");

                entity.Property(e => e.Status).HasComment("وضعیت پرداخت فاکتور");

                entity.Property(e => e.TblInvoiceMasterId)
                    .HasColumnName("Tbl_InvoiceMaster_Id")
                    .HasComment("آی دی فاکتور از جدول فاکتور");

                entity.Property(e => e.TblPaymentTypeId)
                    .HasColumnName("Tbl_PaymentType_Id")
                    .HasComment("آی دی نوع پرداخت از جدول نوع پرداخت");

                entity.HasOne(d => d.TblInvoiceMaster)
                    .WithMany(p => p.TblInvoiceMasterPayments)
                    .HasForeignKey(d => d.TblInvoiceMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMasterPayment_Tbl_InvoiceMaster");

                entity.HasOne(d => d.TblPaymentType)
                    .WithMany(p => p.TblInvoiceMasterPayments)
                    .HasForeignKey(d => d.TblPaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMasterPayment_Tbl_PaymentType");
            });

            modelBuilder.Entity<TblInvoiceMasterPermission>(entity =>
            {
                entity.ToTable("Tbl_InvoiceMasterPermission");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblRegistrarTypeId).HasColumnName("Tbl_RegistrarType_Id");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.TblRegistrarType)
                    .WithMany(p => p.TblInvoiceMasterPermissions)
                    .HasForeignKey(d => d.TblRegistrarTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMasterPermission_Tbl_RegistrarType");
            });

            modelBuilder.Entity<TblInvoiceMasterPoint>(entity =>
            {
                entity.ToTable("Tbl_InvoiceMasterPoint");

                entity.HasComment("جدولی برای نمایش اطلاعات فاکتور هدف");

                entity.HasIndex(e => e.TblInvoiceMasterId, "idx_Tbl_InvoiceMasterPoint_InvoiceMasterId")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه فاکتور هدف");

                entity.Property(e => e.Amount).HasComment("مبلغ فاکتور هدف");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف فاکتور هدف");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول فاکتور هدف");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول فاکتور هدف");

                entity.Property(e => e.Status).HasComment("وضعیت فاکتور هدف");

                entity.Property(e => e.TblInvoiceMasterId)
                    .HasColumnName("Tbl_InvoiceMaster_Id")
                    .HasComment("آی دی فاکتور از جدول فاکتور");

                entity.Property(e => e.TblPointTypeId)
                    .HasColumnName("Tbl_PointType_Id")
                    .HasComment("آی دی نوع هدف از جدول نوع هدف");

                entity.HasOne(d => d.TblInvoiceMaster)
                    .WithMany(p => p.TblInvoiceMasterPoints)
                    .HasForeignKey(d => d.TblInvoiceMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMasterPoint_Tbl_InvoiceMaster");

                entity.HasOne(d => d.TblPointType)
                    .WithMany(p => p.TblInvoiceMasterPoints)
                    .HasForeignKey(d => d.TblPointTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMasterPoint_Tbl_PointType");
            });

            modelBuilder.Entity<TblInvoiceMasterPointRange>(entity =>
            {
                entity.ToTable("Tbl_InvoiceMasterPointRange");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblInvoiceMasterPointRangeDetail>(entity =>
            {
                entity.ToTable("Tbl_InvoiceMasterPointRangeDetail");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblInvoiceMasterPointRangeId).HasColumnName("Tbl_InvoiceMasterPointRange_Id");

                entity.HasOne(d => d.TblInvoiceMasterPointRange)
                    .WithMany(p => p.TblInvoiceMasterPointRangeDetails)
                    .HasForeignKey(d => d.TblInvoiceMasterPointRangeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMasterPointRangeDetail_Tbl_InvoiceMasterPointRangeDetail");
            });

            modelBuilder.Entity<TblInvoiceMasterPrepayment>(entity =>
            {
                entity.ToTable("Tbl_InvoiceMasterPrepayment");

                entity.HasComment("جدولی برای نمایش اطلاعات پرداخت فاکتور مورد نظر");

                entity.HasIndex(e => e.TblInvoiceMasterId, "idx_tbl_InvoiceMasterPayment_invoiceMasterID")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه پرداخت فاکتور");

                entity.Property(e => e.Amount).HasComment("میزان پرداخت فاکتور");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف پرداخت فاکتور");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول پرداخت فاکتور");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول پرداخت فاکتور");

                entity.Property(e => e.Status).HasComment("وضعیت پرداخت فاکتور");

                entity.Property(e => e.TblInvoiceMasterId)
                    .HasColumnName("Tbl_InvoiceMaster_Id")
                    .HasComment("آی دی فاکتور از جدول فاکتور");

                entity.Property(e => e.TblPrepaymentTypeId)
                    .HasColumnName("Tbl_PrepaymentType_Id")
                    .HasComment("آی دی نوع پرداخت از جدول نوع پرداخت");

                entity.HasOne(d => d.TblInvoiceMaster)
                    .WithMany(p => p.TblInvoiceMasterPrepayments)
                    .HasForeignKey(d => d.TblInvoiceMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMasterPrepayment_Tbl_InvoiceMaster");

                entity.HasOne(d => d.TblPrepaymentType)
                    .WithMany(p => p.TblInvoiceMasterPrepayments)
                    .HasForeignKey(d => d.TblPrepaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMasterPrepayment_Tbl_PrepaymentType");
            });

            modelBuilder.Entity<TblInvoiceMasterRemain>(entity =>
            {
                entity.ToTable("Tbl_InvoiceMasterRemain");

                entity.HasComment("جدولی برای نمایش اطلاعات باقی مانده فاکتور مورد نظر");

                entity.HasIndex(e => new { e.TblInvoiceMasterId, e.IsDeleted }, "idx_Tbl_InvoiceMasterRemain")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه باقی مانده فاکتور مورد نظر");

                entity.Property(e => e.Amount).HasComment("میزان باقی مانده فاکتور مورد نظر");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف باقی مانده فاکتور مورد نظر");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول باقی مانده فاکتور مورد نظر");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول باقی مانده فاکتور مورد نظر");

                entity.Property(e => e.SettleDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Status).HasComment("وضعیت باقی مانده فاکتور مورد نظر");

                entity.Property(e => e.TblInvoiceMasterId)
                    .HasColumnName("Tbl_InvoiceMaster_Id")
                    .HasComment("آی دی فاکتور از جدول فاکتور");

                entity.Property(e => e.TblRemainTypeId)
                    .HasColumnName("Tbl_RemainType_Id")
                    .HasComment("آی دی باقی مانده از جدول باقی مانده");

                entity.HasOne(d => d.TblInvoiceMaster)
                    .WithMany(p => p.TblInvoiceMasterRemains)
                    .HasForeignKey(d => d.TblInvoiceMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMasterRemain_Tbl_InvoiceMaster");

                entity.HasOne(d => d.TblRemainType)
                    .WithMany(p => p.TblInvoiceMasterRemains)
                    .HasForeignKey(d => d.TblRemainTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMasterRemain_Tbl_RemainType");
            });

            modelBuilder.Entity<TblInvoiceMasterType>(entity =>
            {
                entity.ToTable("Tbl_InvoiceMasterType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع فاکتور مورد نظر");

                entity.Property(e => e.Id).HasComment("شناسه نوع فاکتور مورد نظر");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع فاکتور");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع فاکتور");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع فاکتور");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("مرجع نوع فاکتور");

                entity.Property(e => e.Status).HasComment("وضعیت نوع فاکتور");

                entity.Property(e => e.TblInvoiceMasterId)
                    .HasColumnName("Tbl_InvoiceMaster_Id")
                    .HasComment("آی دی فاکتور از جدول فاکتور");

                entity.Property(e => e.TblInvoiceTypeId)
                    .HasColumnName("Tbl_InvoiceType_Id")
                    .HasComment("آی نوع فاکتور از جدول نوع فاکتور");

                entity.HasOne(d => d.TblInvoiceMaster)
                    .WithMany(p => p.TblInvoiceMasterTypes)
                    .HasForeignKey(d => d.TblInvoiceMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMasterType_Tbl_InvoiceMaster");

                entity.HasOne(d => d.TblInvoiceType)
                    .WithMany(p => p.TblInvoiceMasterTypes)
                    .HasForeignKey(d => d.TblInvoiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMasterType_Tbl_InvoiceType");
            });

            modelBuilder.Entity<TblInvoiceMoreInfo>(entity =>
            {
                entity.ToTable("Tbl_InvoiceMoreInfo");

                entity.HasComment("جدولی برای نمایش  اطلاعات فاکتورها");

                entity.Property(e => e.Id).HasComment("شناسه اطلاعات فاکتورها");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف اطلاعات فاکتور");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.InvoiceAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("آدرس فاکتور");

                entity.Property(e => e.InvoiceMobile)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("موبایل فاکتور");

                entity.Property(e => e.InvoicePhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تلفن فاکتورها");

                entity.Property(e => e.InvoicePostalCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("کد پستی فاکتور");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول فاکتور");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول فاکتور");

                entity.Property(e => e.Status).HasComment("وضعیت اطلاعات فاکتور");

                entity.Property(e => e.TblInvoiceMasterId)
                    .HasColumnName("Tbl_InvoiceMaster_Id")
                    .HasComment("آی دی فاکتور از جدول فاکتور");

                entity.HasOne(d => d.TblInvoiceMaster)
                    .WithMany(p => p.TblInvoiceMoreInfos)
                    .HasForeignKey(d => d.TblInvoiceMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceMoreInfo_Tbl_InvoiceMaster");
            });

            modelBuilder.Entity<TblInvoiceSlave>(entity =>
            {
                entity.ToTable("Tbl_InvoiceSlave");

                entity.HasComment("جدولی برای نمایش اطلاعات اقلام فاکتورها");

                entity.HasIndex(e => e.TblInvoiceMasterId, "idx_Tbl_InvoiceSlave_InvoiceMaster_Id")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.IsDeleted, "idx_tbl_invoiceSlave_isDeleted")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه اقلام فاکتور");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف اقلام فاکتور");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اقلام فاکتور");

                entity.Property(e => e.IsGift).HasComment("بیان اطلاعات هدیه است در جدول اقلام فاکتور");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اقلام فاکتور");

                entity.Property(e => e.ItemIndex).HasComment("فهرست موارد");

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد کالا");

                entity.Property(e => e.PartCount).HasComment("تعداد کالا");

                entity.Property(e => e.SalePrice).HasComment("قیمت فروش");

                entity.Property(e => e.Status).HasComment("وضعیت اقلام فاکتور");

                entity.Property(e => e.TblInvoiceMasterId)
                    .HasColumnName("Tbl_InvoiceMaster_Id")
                    .HasComment("آی دی فاکتور از جدول فاکتور");

                entity.HasOne(d => d.TblInvoiceMaster)
                    .WithMany(p => p.TblInvoiceSlaves)
                    .HasForeignKey(d => d.TblInvoiceMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_InvoiceSlave_Tbl_InvoiceMaster");
            });

            modelBuilder.Entity<TblInvoiceStatus>(entity =>
            {
                entity.ToTable("Tbl_InvoiceStatus");

                entity.HasComment("جدولی برای نمایش اطلاعات وضعیت فاکتورها");

                entity.Property(e => e.Id).HasComment("شناسه وضعیت فاکتور");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف وضعیت فاکتور");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.InvoiceStatusCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("کد وضعیت فاکتور");

                entity.Property(e => e.InvoiceStatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام وضعیت فاکتور");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول وضعیت فاکتور");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول وضعیت فاکتور");

                entity.Property(e => e.Status).HasComment("وضعیت فاکتور");
            });

            modelBuilder.Entity<TblInvoiceType>(entity =>
            {
                entity.ToTable("Tbl_InvoiceType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع فاکتور ها");

                entity.Property(e => e.Id).HasComment("شناسه نوع فاکتور");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع فاکتور");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.InvoiceTypeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("کد نوع فاکتور");

                entity.Property(e => e.InvoiceTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع فاکتور");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع فاکتور");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع فاکتور");

                entity.Property(e => e.Status).HasComment("وضعیت نوع فاکتور");
            });

            modelBuilder.Entity<TblIspcontract>(entity =>
            {
                entity.ToTable("Tbl_ISPContract");

                entity.HasComment("جدولی برای نمایش اطلاعات قراداد آی اس پی");

                entity.Property(e => e.Id).HasComment("شناسه قرارداد آی اس پی");

                entity.Property(e => e.Capacity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("ظرفیت قراداد آی اس پی");

                entity.Property(e => e.ContractNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شماره قرارداد آی اس پی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف قراداد آی اس پی");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع قرارداد آی اس پی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول قراداد آی اس پی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول قراداد آی اس پی");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("رمز عبور قراداد آی اس پی");

                entity.Property(e => e.Status).HasComment("وضعیت قراداد آی اس پی");

                entity.Property(e => e.TblCompanyId)
                    .HasColumnName("Tbl_Company_Id")
                    .HasComment("آی دی شرکت از جدول شرکت");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول شخص");

                entity.Property(e => e.TblPlaceTypeId)
                    .HasColumnName("Tbl_PlaceType_Id")
                    .HasComment("آی دی نوع مکان از جدول نوع مکان");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان قرارداد آی اس پی");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام کاربری قراداد آی اس پی");

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblIspcontracts)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ISPContract_Tbl_Company");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblIspcontracts)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ISPContract_Tbl_Person");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblIspcontracts)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ISPContract_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblJob>(entity =>
            {
                entity.ToTable("Tbl_Job");

                entity.HasComment("جدولی براس نمایش اطلاعات شغل");

                entity.HasIndex(e => e.Id, "Job")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه شغل");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد شغل");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف شغل");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول شغل");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول شغل");

                entity.Property(e => e.Mbti)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MBTI")
                    .HasComment("ام بی تی آی شغل");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام شغل");

                entity.Property(e => e.RevisionDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Status).HasComment("وضعیت شغل");

                entity.Property(e => e.TblJobGroupId).HasColumnName("Tbl_JobGroup_Id");

                entity.Property(e => e.TblPlaceTypeId)
                    .HasColumnName("Tbl_PlaceType_Id")
                    .HasComment("آی دی نوع مکان از جددل نوع مکان");

                entity.Property(e => e.TblPostId)
                    .HasColumnName("Tbl_Post_Id")
                    .HasComment("آی دی پست سازمانی از جدول پست سازمانی");

                entity.Property(e => e.Vision)
                    .IsRequired()
                    .HasComment("چشم انداز شغل");

                entity.Property(e => e.YearOfExperience).HasComment("سال تجربه کاری");

                entity.HasOne(d => d.TblJobGroup)
                    .WithMany(p => p.TblJobs)
                    .HasForeignKey(d => d.TblJobGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Job_Tbl_JobGroup");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblJobs)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Job_Tbl_PlaceType");

                entity.HasOne(d => d.TblPost)
                    .WithMany(p => p.TblJobs)
                    .HasForeignKey(d => d.TblPostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Job_Tbl_Post");
            });

            modelBuilder.Entity<TblJobAbility>(entity =>
            {
                entity.ToTable("Tbl_JobAbility");

                entity.HasComment("جدولی برای نمایش اطلاعات توانایی شغل ها");

                entity.Property(e => e.Id).HasComment("شناسه توانایی شغل");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف توانایی شغل ها");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول توانایی شغل");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی شغل");

                entity.Property(e => e.PreferedValue).HasComment("مقدار ترجیح داده شده");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی شغل ها");

                entity.Property(e => e.TblAbilityId)
                    .HasColumnName("Tbl_Ability_Id")
                    .HasComment("آی دی توانایی از جدول توانایی ");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل از جدول شغل");

                entity.HasOne(d => d.TblAbility)
                    .WithMany(p => p.TblJobAbilities)
                    .HasForeignKey(d => d.TblAbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobAbility_Tbl_Ability");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblJobAbilities)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobAbility_Tbl_Job");
            });

            modelBuilder.Entity<TblJobCompetency>(entity =>
            {
                entity.ToTable("Tbl_JobCompetency");

                entity.HasComment("جدولی برای نمایش اطلاعات شایستگی شغلی");

                entity.Property(e => e.Id).HasComment("شناسه شایستگی شغلی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف شایستگی شغلی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول شایستگی شغلی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول شایستگی شغلی");

                entity.Property(e => e.PreferedValue).HasComment("ارزش ترجیح داده شده شایستگی شغلی");

                entity.Property(e => e.Status).HasComment("وضعیت شایستگی شغلی");

                entity.Property(e => e.TblCompetencyId)
                    .HasColumnName("Tbl_Competency_Id")
                    .HasComment("آی دی شایستگی از جدول شایستگی");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل از جدول شغل");

                entity.HasOne(d => d.TblCompetency)
                    .WithMany(p => p.TblJobCompetencies)
                    .HasForeignKey(d => d.TblCompetencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobCompetency_Tbl_Competency");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblJobCompetencies)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobCompetency_Tbl_Job");
            });

            modelBuilder.Entity<TblJobCourse>(entity =>
            {
                entity.ToTable("Tbl_JobCourse");

                entity.HasComment("جدولی برای نمایش اطاعات دوره شغل ها");

                entity.Property(e => e.Id).HasComment("شناسه دوره شغل");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف دوره شغل");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول دوره شغل");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول دوره شغل");

                entity.Property(e => e.Status).HasComment("وضعیت دوره شغل");

                entity.Property(e => e.TblCourseNameId)
                    .HasColumnName("Tbl_CourseName_Id")
                    .HasComment("آی دی نام دوره از جدول نام دوره");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل از جدول شغل");

                entity.HasOne(d => d.TblCourseName)
                    .WithMany(p => p.TblJobCourses)
                    .HasForeignKey(d => d.TblCourseNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobCourse_Tbl_CourseName");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblJobCourses)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobCourse_Tbl_Job");
            });

            modelBuilder.Entity<TblJobDescription>(entity =>
            {
                entity.ToTable("Tbl_JobDescription");

                entity.HasComment("جدولی برای نمایش اطلاعات شرح شغل");

                entity.Property(e => e.Id).HasComment("شناسه شرح شغل");

                entity.Property(e => e.DutyDescription)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("شرح مسئولیت شغل");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف شرح شغل");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول شرح شغل");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول شرح شغل");

                entity.Property(e => e.Status).HasComment("وضعیت شرح شغل");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل از جدول شغل");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblJobDescriptions)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobDescription_Tbl_Job");
            });

            modelBuilder.Entity<TblJobEducation>(entity =>
            {
                entity.ToTable("Tbl_JobEducation");

                entity.HasComment("جدولی برای نمایش اطلاعات آموزش شغلی");

                entity.Property(e => e.Id).HasComment("شناسه آموزش شغل");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف آموزش شغل");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول آموزش شغلی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول آموزش شغلی");

                entity.Property(e => e.Status).HasComment("وضعیت آموزش شغلی");

                entity.Property(e => e.TblCertificateId)
                    .HasColumnName("Tbl_Certificate_Id")
                    .HasComment("آی دی مدرک از جدول مدرک");

                entity.Property(e => e.TblFieldOfStudyId)
                    .HasColumnName("Tbl_FieldOfStudy_Id")
                    .HasComment("آی دی رشته تحصیلی از جدول رشته تحصیلی");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل از جدول شغل");

                entity.HasOne(d => d.TblCertificate)
                    .WithMany(p => p.TblJobEducations)
                    .HasForeignKey(d => d.TblCertificateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobEducation_Tbl_Certificate");

                entity.HasOne(d => d.TblFieldOfStudy)
                    .WithMany(p => p.TblJobEducations)
                    .HasForeignKey(d => d.TblFieldOfStudyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobEducation_Tbl_FieldOfStudy");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblJobEducations)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobEducation_Tbl_Job");
            });

            modelBuilder.Entity<TblJobEvaluation>(entity =>
            {
                entity.ToTable("Tbl_JobEvaluation");

                entity.HasComment("جدولی برای نمایش اطلاعات ارزیابی شغلی");

                entity.Property(e => e.Id).HasComment("شناسه ارزیابی شغلی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد ارزیابی شغلی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف  ارزیابی شغلی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول ارزیابی شغلی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول ارزیابی شغلی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام ارزیابی شغلی");

                entity.Property(e => e.PreferedValue).HasComment("ارزش ترجیح داده شده");

                entity.Property(e => e.Status).HasComment("وضعیت  ارزیابی شغلی");

                entity.Property(e => e.TblCompetencyItemFactorBehaviourId)
                    .HasColumnName("Tbl_CompetencyItemFactorBehaviour_Id")
                    .HasComment("آی دی نشانه رفتار عامل شایستگی در جدول نشانه رفتار عامل شایستگی ");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل از جدول شغل");

                entity.HasOne(d => d.TblCompetencyItemFactorBehaviour)
                    .WithMany(p => p.TblJobEvaluations)
                    .HasForeignKey(d => d.TblCompetencyItemFactorBehaviourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobEvaluation_Tbl_CompetencyItemFactorBehaviour");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblJobEvaluations)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobEvaluation_Tbl_Job");
            });

            modelBuilder.Entity<TblJobGoal>(entity =>
            {
                entity.ToTable("Tbl_JobGoal");

                entity.HasComment("جدولی برای نمایش اطلاعات اهداف شغل ها");

                entity.Property(e => e.Id).HasComment("شناسه اهداف شغل ");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف هدف شغل");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع اهداف شغل");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول اهداف شغل");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اهداف شغل");

                entity.Property(e => e.MaximumScore).HasComment("بیشترین امتیاز");

                entity.Property(e => e.MeasurementUnit).HasComment("اندازه گیری واحد");

                entity.Property(e => e.MinimumScore).HasComment("کمترین امتیاز ");

                entity.Property(e => e.Score).HasComment("امتیاز اهداف شغل ها");

                entity.Property(e => e.Status).HasComment("وضعیت هدف شغل");

                entity.Property(e => e.TblGoalId)
                    .HasColumnName("Tbl_Goal_Id")
                    .HasComment("آی دی اهداف از جدول اهداف");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل از جدول شغل");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان اهداف شغل");

                entity.HasOne(d => d.TblGoal)
                    .WithMany(p => p.TblJobGoals)
                    .HasForeignKey(d => d.TblGoalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobGoal_Tbl_Job1");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblJobGoals)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobGoal_Tbl_Job");
            });

            modelBuilder.Entity<TblJobGroup>(entity =>
            {
                entity.ToTable("Tbl_JobGroup");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Explanation).HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TblJobInterest>(entity =>
            {
                entity.ToTable("Tbl_JobInterest");

                entity.HasComment("جدولی برای نمایش اطلاعات علاقه شغلی");

                entity.Property(e => e.Id).HasComment("شناسه علاقه شغلی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف علاقه شغل");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول علاقه شغلی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول علاقه شغلی");

                entity.Property(e => e.PreferedValue).HasComment("ارزش ترجیهی ");

                entity.Property(e => e.Status).HasComment("وضعیت علاقه شغل");

                entity.Property(e => e.TblInterestId)
                    .HasColumnName("Tbl_Interest_Id")
                    .HasComment("آی دی علاقه از جدول علاقه");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل از جدول مشاغل");

                entity.HasOne(d => d.TblInterest)
                    .WithMany(p => p.TblJobInterests)
                    .HasForeignKey(d => d.TblInterestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobInterest_Tbl_Interest");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblJobInterests)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobInterest_Tbl_Job");
            });

            modelBuilder.Entity<TblJobKnowledge>(entity =>
            {
                entity.ToTable("Tbl_JobKnowledge");

                entity.HasComment("جدولی برای نمایش اطلاعات دانش شغلی");

                entity.Property(e => e.Id).HasComment("شناسه دانش شغلی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف دانش شغلی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول دانش شغلی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول دانش شغلی");

                entity.Property(e => e.Status).HasComment("وضعیت دانش شغلی");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل از جدول شغل");

                entity.Property(e => e.TblKnowledgeId)
                    .HasColumnName("Tbl_Knowledge_Id")
                    .HasComment("آی دی دانش از جدول دانش");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblJobKnowledges)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobKnowledge_Tbl_Job");

                entity.HasOne(d => d.TblKnowledge)
                    .WithMany(p => p.TblJobKnowledges)
                    .HasForeignKey(d => d.TblKnowledgeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobKnowledge_Tbl_Knowledge");
            });

            modelBuilder.Entity<TblJobModel>(entity =>
            {
                entity.ToTable("Tbl_JobModel");

                entity.HasComment("جدولی برای نمایش اطلاعات مدل شغلی");

                entity.Property(e => e.Id).HasComment("شناسه مدل شغلی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد مدل شغلی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف مدل شغلی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول مدل شغلی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول مدل شغلی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام مدل شغلی");

                entity.Property(e => e.Status).HasComment("وضعیت مدل شغلی");
            });

            modelBuilder.Entity<TblJobModelFactor>(entity =>
            {
                entity.ToTable("Tbl_JobModelFactor");

                entity.HasComment("جدولی برای نمایش اطلاعات فاکتور مدل شغلی");

                entity.Property(e => e.Id).HasComment("شناسه فاکتور مدل شغلی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد مدل شغلی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف مدل شغلی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول فاکتور مدل شغلی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول فاکتور مدل شغلی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام مدل شغلی");

                entity.Property(e => e.Status).HasComment("وضعیت مدل شغلی");

                entity.Property(e => e.TblJobModelId)
                    .HasColumnName("Tbl_JobModel_Id")
                    .HasComment("آی دی مدل شغلی از جدول مدل شغلی");

                entity.HasOne(d => d.TblJobModel)
                    .WithMany(p => p.TblJobModelFactors)
                    .HasForeignKey(d => d.TblJobModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobModelFactor_Tbl_JobModel");
            });

            modelBuilder.Entity<TblJobModelFactorPrefered>(entity =>
            {
                entity.ToTable("Tbl_JobModelFactorPrefered");

                entity.HasComment("جدولی برای نمایش اطلاعات فاکتور مدل شغلی ترجیحی");

                entity.Property(e => e.Id).HasComment("شناسه فاکتور مدل شغل ترجیحی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف فاکتور مدل شغلی ترجیحی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول فاکتور مدل شغلی ترجیهی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول فاکتور مدل شغلی ترجیهی");

                entity.Property(e => e.PreferedValue).HasComment("ارزش ترجیحی");

                entity.Property(e => e.Status).HasComment("وضعیت فاکتور مدل شغلی ترجیحی");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل از جدول شغل");

                entity.Property(e => e.TblJobModelFactorId)
                    .HasColumnName("Tbl_JobModelFactor_Id")
                    .HasComment("آی دی مدل شغلی ترجیحی از جدول مدل شغلی ترجیحی");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblJobModelFactorPrefereds)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobModelFactorPrefered_Tbl_Job");

                entity.HasOne(d => d.TblJobModelFactor)
                    .WithMany(p => p.TblJobModelFactorPrefereds)
                    .HasForeignKey(d => d.TblJobModelFactorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobModelFactorPrefered_Tbl_JobModelFactor");
            });

            modelBuilder.Entity<TblJobPsychology>(entity =>
            {
                entity.ToTable("Tbl_JobPsychology");

                entity.HasComment("جدولی برای نمایش اطلاعات روانشناسی کار");

                entity.Property(e => e.Id).HasComment("شناسه روانشناسی کار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف روانشناسی کار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول روانشناسی کار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول روانشناسی کار");

                entity.Property(e => e.PreferedValue).HasComment("ارزش ترجیهی");

                entity.Property(e => e.Status).HasComment("وضعیت روانشناسی کار");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل از جدول شغل");

                entity.Property(e => e.TblPsychologyTypeId)
                    .HasColumnName("Tbl_PsychologyType_Id")
                    .HasComment("آی دی نوع روانشناسی از جدول نوع روانشناسی");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblJobPsychologies)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobPsychology_Tbl_Job");

                entity.HasOne(d => d.TblPsychologyType)
                    .WithMany(p => p.TblJobPsychologies)
                    .HasForeignKey(d => d.TblPsychologyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobPsychology_Tbl_PsychologyTypes");
            });

            modelBuilder.Entity<TblJobResponsibility>(entity =>
            {
                entity.ToTable("Tbl_JobResponsibility");

                entity.HasComment("جدولی برای نمایش اطلاعات مسئولیت شغلی");

                entity.Property(e => e.Id).HasComment("شناسه مسئولیت شغلی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف مسئولیت شغلی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول مسئولیت شغلی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول مسئولیت شغلی");

                entity.Property(e => e.PreferedValue).HasComment("ارزش ترجیهی مسئولیت شغلی");

                entity.Property(e => e.Status).HasComment("وضعیت مسئولیت شغلی");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل از جدول شغل");

                entity.Property(e => e.TblResponsibilityTaskId)
                    .HasColumnName("Tbl_ResponsibilityTask_Id")
                    .HasComment("آی دی وظیفه مسئولیت از جدول وظیفه مسئولیت");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblJobResponsibilities)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobResponsibility_Tbl_Job");

                entity.HasOne(d => d.TblResponsibilityTask)
                    .WithMany(p => p.TblJobResponsibilities)
                    .HasForeignKey(d => d.TblResponsibilityTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobResponsibility_Tbl_ResponsibilityTask");
            });

            modelBuilder.Entity<TblJobSkill>(entity =>
            {
                entity.ToTable("Tbl_JobSkill");

                entity.HasComment("جدولی برای نمایش اطلاعات مهارت های شغلی");

                entity.Property(e => e.Id).HasComment("شناسه مهارت های شغلی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف مهارت شغل");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول مهارت شغل");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول مهارت شغل");

                entity.Property(e => e.PreferedValue).HasComment("ارزش ترجیهی");

                entity.Property(e => e.Status).HasComment("وضعیت مهارت شغل");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل از جدول شغل");

                entity.Property(e => e.TblSkillId)
                    .HasColumnName("Tbl_Skill_Id")
                    .HasComment("آی دی مهارت از جدول مهارت");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblJobSkills)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobSkill_Tbl_Job");

                entity.HasOne(d => d.TblSkill)
                    .WithMany(p => p.TblJobSkills)
                    .HasForeignKey(d => d.TblSkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobSkill_Tbl_Skill");
            });

            modelBuilder.Entity<TblJobSoftware>(entity =>
            {
                entity.ToTable("Tbl_JobSoftware");

                entity.HasComment("جدولی برای نمایش اطلاعات نرم افزار شغلی");

                entity.Property(e => e.Id).HasComment("شناسه نرم افزار شغلی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نرم افزار شغلی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نرم افزار شغلی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نرم افزار شغلی");

                entity.Property(e => e.Status).HasComment("وضعیت نرم افزار شغلی");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل از جدول شغل");

                entity.Property(e => e.TblSoftwareId)
                    .HasColumnName("Tbl_Software_Id")
                    .HasComment("آی دی نرم افزار از جدول نرم افزار");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblJobSoftwares)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobSoftware_Tbl_Job");

                entity.HasOne(d => d.TblSoftware)
                    .WithMany(p => p.TblJobSoftwares)
                    .HasForeignKey(d => d.TblSoftwareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobSoftware_Tbl_Software");
            });

            modelBuilder.Entity<TblJobWorkCondition>(entity =>
            {
                entity.ToTable("Tbl_JobWorkCondition");

                entity.HasComment("جدولی برای نمایش اطلاعات شرایط کار شغل");

                entity.Property(e => e.Id).HasComment("شناسه شرایط کار شغل");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف شرایط کار شغل");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول شرایط کار شغل");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول شرایط کار شغل");

                entity.Property(e => e.PreferedValue).HasComment("ارزش ترجیهی");

                entity.Property(e => e.Status).HasComment("وضعیت شرایط کار شغل");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل از جدول شغل");

                entity.Property(e => e.TblWorkConditionId)
                    .HasColumnName("Tbl_WorkCondition_Id")
                    .HasComment("آی دی شرایط کار از جدول شرایط کار");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblJobWorkConditions)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobWorkCondition_Tbl_Job");

                entity.HasOne(d => d.TblWorkCondition)
                    .WithMany(p => p.TblJobWorkConditions)
                    .HasForeignKey(d => d.TblWorkConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_JobWorkCondition_Tbl_WorkCondition");
            });

            modelBuilder.Entity<TblKnowledge>(entity =>
            {
                entity.ToTable("Tbl_Knowledge");

                entity.HasComment("جدولی برای نمایش اطلاعات دانش");

                entity.Property(e => e.Id).HasComment("شناسه دانش");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد دانش");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف دانش");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول دانش");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول دانش");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام دانش");

                entity.Property(e => e.Status).HasComment("وضعیت دانش");
            });

            modelBuilder.Entity<TblLedger>(entity =>
            {
                entity.ToTable("Tbl_Ledger");

                entity.HasComment("جدولی برای نمایش اطلاعات حساب");

                entity.Property(e => e.Id).HasComment("شناسه حساب");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasComment("کد حساب");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف حساب");

                entity.Property(e => e.FullAccountCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد کامل حساب");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Nature).HasComment("ماهیت حساب");

                entity.Property(e => e.ParentId).HasComment("شناسه اصلی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.TblLedgerLevelId)
                    .HasColumnName("Tbl_LedgerLevel_Id")
                    .HasComment("آی دی میزان حساب  از جدول میزان حساب");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasComment("عنوان حساب");

                entity.HasOne(d => d.TblLedgerLevel)
                    .WithMany(p => p.TblLedgers)
                    .HasForeignKey(d => d.TblLedgerLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Ledger_Tbl_LedgerLevel");
            });

            modelBuilder.Entity<TblLedgerInfo>(entity =>
            {
                entity.ToTable("Tbl_LedgerInfo");

                entity.HasComment("جدولی برای نمایش اطلاعات حساب ها می باشد");

                entity.Property(e => e.Id).HasComment("شناسه اطلاعات حساب");

                entity.Property(e => e.AccountType).HasComment("نوع حساب بانکی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد اطلاعات حساب");

                entity.Property(e => e.CodeType).HasComment("نوع کد اطلاعات حساب");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف اطلاعات حساب");

                entity.Property(e => e.FinancialCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد مالی");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام صاحب حساب");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IdNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شماره شناسایی");

                entity.Property(e => e.IncludedArticle).HasComment("مشمول مقاله");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اطلاعات حساب");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اطلاعات حساب");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام و نام خانوادگی حساب ها");

                entity.Property(e => e.NationalCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد ملی");

                entity.Property(e => e.NewEconomicCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد اقتصادی جدید");

                entity.Property(e => e.OldEconomicCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد اقتصادی قدیمی");

                entity.Property(e => e.RegistrationCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد ثبت نام ");

                entity.Property(e => e.StandardComment)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نظر استاندارد");

                entity.Property(e => e.Status).HasComment("وضعیت اطلاعات حساب");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("موضوع حساب");

                entity.Property(e => e.TaxPayerType).HasComment("نوع پرداخت کننده مالیات");

                entity.Property(e => e.TblCompanyId)
                    .HasColumnName("Tbl_Company_Id")
                    .HasComment("آی دی شرکت از جدول شرکت");

                entity.Property(e => e.TblCountryId)
                    .HasColumnName("Tbl_Country_Id")
                    .HasComment("آی دی کشور از جدول کشور");

                entity.Property(e => e.TblLedgerId)
                    .HasColumnName("Tbl_Ledger_Id")
                    .HasComment("آی دی حساب از جدول حساب");

                entity.Property(e => e.TblPlaceIdAsAddress)
                    .HasColumnName("Tbl_Place_IdAsAddress")
                    .HasComment("آی دی آدرس از جدول مکان ها");

                entity.Property(e => e.TblPlaceIdAsOffice)
                    .HasColumnName("Tbl_Place_IdAsOffice")
                    .HasComment("آی دی محل کار از جدول مکان ها");

                entity.Property(e => e.TrackCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد مسیر");

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblLedgerInfos)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_LedgerInfo_Tbl_Company");

                entity.HasOne(d => d.TblCountry)
                    .WithMany(p => p.TblLedgerInfos)
                    .HasForeignKey(d => d.TblCountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_LedgerInfo_Tbl_Country");

                entity.HasOne(d => d.TblLedger)
                    .WithMany(p => p.TblLedgerInfos)
                    .HasForeignKey(d => d.TblLedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_LedgerInfo_Tbl_Ledger");

                entity.HasOne(d => d.TblPlaceIdAsAddressNavigation)
                    .WithMany(p => p.TblLedgerInfoTblPlaceIdAsAddressNavigations)
                    .HasForeignKey(d => d.TblPlaceIdAsAddress)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_LedgerInfo_Tbl_Place1");

                entity.HasOne(d => d.TblPlaceIdAsOfficeNavigation)
                    .WithMany(p => p.TblLedgerInfoTblPlaceIdAsOfficeNavigations)
                    .HasForeignKey(d => d.TblPlaceIdAsOffice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_LedgerInfo_Tbl_Place");
            });

            modelBuilder.Entity<TblLedgerLevel>(entity =>
            {
                entity.ToTable("Tbl_LedgerLevel");

                entity.HasComment("جدولی برای نمایش اطلاعات سطح حساب");

                entity.Property(e => e.Id).HasComment("شناسه سطح حساب");

                entity.Property(e => e.Code).HasComment("کد سطح حساب");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف سطح حساب");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول سطح حساب");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول سطح حساب");

                entity.Property(e => e.Length).HasComment("مدت سطح حساب");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام سطح حساب");

                entity.Property(e => e.Status).HasComment("وضعیت سطح حساب");

                entity.Property(e => e.TblFinancialCycleId)
                    .HasColumnName("Tbl_FinancialCycle_Id")
                    .HasComment("آی دی گردش دوره مالی از جدول گردش دوره مالی");

                entity.HasOne(d => d.TblFinancialCycle)
                    .WithMany(p => p.TblLedgerLevels)
                    .HasForeignKey(d => d.TblFinancialCycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_LedgerLevel_Tbl_FinancialCycle");
            });

            modelBuilder.Entity<TblLetter>(entity =>
            {
                entity.ToTable("Tbl_Letter");

                entity.HasComment("جدولی برای نمایش اطلاعات نامه");

                entity.Property(e => e.Id).HasComment("شناسه نامه");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasComment("فایل ضمیمه شده نامه");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ نامه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نامه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نامه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نامه");

                entity.Property(e => e.LetterNumber).HasComment("شماره نامه");

                entity.Property(e => e.Receivers)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("پاسخ دهنده گان نامه");

                entity.Property(e => e.Status).HasComment("وضعیت نامه");

                entity.Property(e => e.TblLetterTypeId)
                    .HasColumnName("Tbl_LetterType_Id")
                    .HasComment("آی دی نوع نامه از جدول نوع نامه");

                entity.Property(e => e.TblPersonIdAsIssue)
                    .HasColumnName("Tbl_Person_IdAsIssue")
                    .HasComment("شخص پاسخ دهنده نامه");

                entity.Property(e => e.TblPersonIdAsReceiver)
                    .HasColumnName("Tbl_Person_IdAsReceiver")
                    .HasComment("شخص درخواست کننده نامه");

                entity.Property(e => e.TblPlaceTypeIdAsIssue)
                    .HasColumnName("Tbl_PlaceType_IdAsIssue")
                    .HasComment("نام واحد فرستنده نامه");

                entity.Property(e => e.TblPlaceTypeIdAsReceiver)
                    .HasColumnName("Tbl_PlaceType_IdAsReceiver")
                    .HasComment("نام واحد پاسخ دهنده نامه");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("متن نامه");

                entity.HasOne(d => d.TblLetterType)
                    .WithMany(p => p.TblLetters)
                    .HasForeignKey(d => d.TblLetterTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Leter_Tbl_LeterType");

                entity.HasOne(d => d.TblPersonIdAsIssueNavigation)
                    .WithMany(p => p.TblLetterTblPersonIdAsIssueNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsIssue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Leter_Tbl_Person1");

                entity.HasOne(d => d.TblPersonIdAsReceiverNavigation)
                    .WithMany(p => p.TblLetterTblPersonIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsReceiver)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Leter_Tbl_Person");

                entity.HasOne(d => d.TblPlaceTypeIdAsIssueNavigation)
                    .WithMany(p => p.TblLetterTblPlaceTypeIdAsIssueNavigations)
                    .HasForeignKey(d => d.TblPlaceTypeIdAsIssue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Leter_Tbl_PlaceType1");

                entity.HasOne(d => d.TblPlaceTypeIdAsReceiverNavigation)
                    .WithMany(p => p.TblLetterTblPlaceTypeIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblPlaceTypeIdAsReceiver)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Leter_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblLetterType>(entity =>
            {
                entity.ToTable("Tbl_LetterType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع نامه");

                entity.Property(e => e.Id).HasComment("شناسه نوع نامه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع نامه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع نامه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع نامه");

                entity.Property(e => e.LetterTypeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع نامه");

                entity.Property(e => e.LetterTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع نامه");

                entity.Property(e => e.Status).HasComment("وضعیت نوع نامه");
            });

            modelBuilder.Entity<TblLicense>(entity =>
            {
                entity.ToTable("Tbl_License");

                entity.HasComment("جدولی برای نمایش اطلاعات مجوزهاي سيستم");

                entity.Property(e => e.Id).HasComment("شناسه مجوزهاي سيستم");

                entity.Property(e => e.Code).HasComment("کد مرخصی یا ماموریت");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف مجوز های سیستم");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول مجوزهاي سيستم");

                entity.Property(e => e.IsMission).HasComment("بیان اطلاعات اینکه آیا جزو دسته مأموریت ها است در جدول مجوزهای سیستم");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول مجوزهاي سيستم");

                entity.Property(e => e.Status).HasComment("وضعیت مجوزهای سیستم");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نوع مرخصی یا ماموریت");
            });

            modelBuilder.Entity<TblLifeStatus>(entity =>
            {
                entity.ToTable("Tbl_LifeStatus");

                entity.HasComment("جدولی برای نمایش اطلاعات وضعیت زندگی");

                entity.Property(e => e.Id).HasComment("شناسه وضعیت زندگی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف وضعیت زندگی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول وضعیت زندگی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول وضعیت زندگی");

                entity.Property(e => e.KeyValue).HasComment("مقدار کلید انتخابی");

                entity.Property(e => e.Status).HasComment("وضعیت وضعیت زندگی");

                entity.Property(e => e.TblLifeStatusTypeId)
                    .HasColumnName("Tbl_LifeStatusType_Id")
                    .HasComment("آی دی نوع وضعیت زندگی از جدول نوع وضعیت زندگی");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.HasOne(d => d.TblLifeStatusType)
                    .WithMany(p => p.TblLifeStatuses)
                    .HasForeignKey(d => d.TblLifeStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_LifeStatus_Tbl_LifeStatusType");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblLifeStatuses)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_LifeStatus_Tbl_Person1");
            });

            modelBuilder.Entity<TblLifeStatusType>(entity =>
            {
                entity.ToTable("Tbl_LifeStatusType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع وضعیت زندگی");

                entity.Property(e => e.Id).HasComment("شناسه نوع وضعیت زندگی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع وضعیت زندگی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع وضعیت زندگی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع وضعیت زندگی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع وضعیت زندگی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع وضعیت زندگی");

                entity.Property(e => e.Status).HasComment("وضعیت نوع وضعیت زندگی");
            });

            modelBuilder.Entity<TblLoan>(entity =>
            {
                entity.ToTable("Tbl_Loan");

                entity.HasComment("جدولی برای نمایش اطلاعات وام");

                entity.Property(e => e.Id).HasComment("شناسه وام");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ دریافت وام");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف وام");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول وام");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول وام");

                entity.Property(e => e.LoanPayment).HasComment("مبلغ هر قسط");

                entity.Property(e => e.Status).HasComment("وضعیت وام");

                entity.Property(e => e.TblLoanTypeId)
                    .HasColumnName("Tbl_LoanType_Id")
                    .HasComment("آی دی نوع وام از جدول نوع وام");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.Property(e => e.TotalLoan).HasComment("کل مبلغ وام");

                entity.HasOne(d => d.TblLoanType)
                    .WithMany(p => p.TblLoans)
                    .HasForeignKey(d => d.TblLoanTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Loan_Tbl_LoanType");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblLoans)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Loan_Tbl_Person");
            });

            modelBuilder.Entity<TblLoanPayment>(entity =>
            {
                entity.ToTable("Tbl_LoanPayment");

                entity.HasComment("جدولی برای نمایش اطلاعات پرداخت وام");

                entity.Property(e => e.Id).HasComment("شناسه پرداخت وام");

                entity.Property(e => e.Amount).HasComment("مبلغ پرداخت وام");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پرداخت وام");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف پرداخت وام");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول پرداخت وام");

                entity.Property(e => e.IsPassed).HasComment("بیان اطلاعات اینکه آیا پرداخت شده یا نه در جدول پرداخت وام");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول پرداخت وام");

                entity.Property(e => e.Status).HasComment("وضعیت پرداخت وام ");

                entity.Property(e => e.TblLoanId)
                    .HasColumnName("Tbl_Loan_Id")
                    .HasComment("آی دی وام از جدول وام");

                entity.HasOne(d => d.TblLoan)
                    .WithMany(p => p.TblLoanPayments)
                    .HasForeignKey(d => d.TblLoanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_LoanPayment_Tbl_Loan");
            });

            modelBuilder.Entity<TblLoanType>(entity =>
            {
                entity.ToTable("Tbl_LoanType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع وام");

                entity.Property(e => e.Id).HasComment("شناسه نوع وام");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع وام");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع وام");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع وام");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع وام");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع وام");

                entity.Property(e => e.Status).HasComment("وضعیت نوع وام");
            });

            modelBuilder.Entity<TblLogMaster>(entity =>
            {
                entity.ToTable("Tbl_LogMaster");

                entity.HasComment("جدولی برای نمایش اطلاعات ثبت کردن وقایع");

                entity.Property(e => e.Id).HasComment("شناسه ثبت کردن وقایع");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف ثبت کردن وقایع");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول ثبت کردن وقایع");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول ثبت کردن وقایع");

                entity.Property(e => e.ManipulationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasComment("زمان و تاریخ استفاده شده");

                entity.Property(e => e.Status).HasComment("وضعیت ثبت کردن وقایع");

                entity.Property(e => e.SubSystem)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("اطلاعات زیر سیستم ");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام جدول");

                entity.Property(e => e.TableRowId).HasComment("شناسه سطر جدول ها");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام کاربری");
            });

            modelBuilder.Entity<TblLogSlave>(entity =>
            {
                entity.ToTable("Tbl_LogSlave");

                entity.HasComment("جدولی برای نمایش اطلاعات محتوای ثبت کردن وقایع");

                entity.Property(e => e.Id).HasComment("شناسه محتوای ثبت کردن وقایع");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف محتوای ثبت کردن وقایع");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام فایل");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول محتوای ثبت کردن وقایع");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول محتوای ثبت کردن وقایع");

                entity.Property(e => e.NewValue)
                    .IsRequired()
                    .HasComment("مقادیر جدید");

                entity.Property(e => e.OldValue)
                    .IsRequired()
                    .HasComment("مقادیر قدیم");

                entity.Property(e => e.Status).HasComment("وضعیت محتوای ثبت کردن وقایع");

                entity.Property(e => e.TblLogMasterId)
                    .HasColumnName("Tbl_LogMaster_Id")
                    .HasComment("آی دی ثبت کردن وقایع از جدول ثبت کردن وقایع");

                entity.HasOne(d => d.TblLogMaster)
                    .WithMany(p => p.TblLogSlaves)
                    .HasForeignKey(d => d.TblLogMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_LogSlave_Tbl_LogMaster");
            });

            modelBuilder.Entity<TblLogicalProperty>(entity =>
            {
                entity.ToTable("Tbl_LogicalProperties");

                entity.HasComment("جدولی برای نمایش اطلاعات ثابت");

                entity.Property(e => e.Id).HasComment("شناسه اطلاعات ثابت");

                entity.Property(e => e.Code).HasComment("کد اطلاعات ثابت");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح اطلاعات ثابت");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اطلاعات ثابت");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اطلاعات ثابت");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام اطلاعات ثابت");

                entity.Property(e => e.RelatedId).HasComment("شناسه مرتبط با اطلاعات ثابت");

                entity.Property(e => e.Status).HasComment("وضعیت اطلاعات ثابت");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("مقدار اطلاعات ثابت");
            });

            modelBuilder.Entity<TblMarriageStatus>(entity =>
            {
                entity.ToTable("Tbl_MarriageStatus");

                entity.HasComment("جدولی برای نمایش اطلاعات وضعیت ازدواج");

                entity.Property(e => e.Id).HasComment("شناسه وضعیت ازدواج");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد وضعیت ازدواج");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف وضعیت ازدواج");

                entity.Property(e => e.Guid).HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول وضعیت ازدواج");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول وضعیت ازدواج");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام وضعیت ازدواج");

                entity.Property(e => e.Status).HasComment("وضعیت وضعیت ازدواج");
            });

            modelBuilder.Entity<TblMeal>(entity =>
            {
                entity.ToTable("Tbl_Meal");

                entity.HasComment("جدولی برای نمایش اطلاعات وعده غذایی");

                entity.Property(e => e.Id).HasComment("شناسه وعده غذایی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف وعده غذایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول وعده غذایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول وعده غذایی");

                entity.Property(e => e.MealCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد وعده غذایی");

                entity.Property(e => e.MealName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام وعده غذایی");

                entity.Property(e => e.Status).HasComment("وضعیت وعده غذایی");
            });

            modelBuilder.Entity<TblMeasurement>(entity =>
            {
                entity.ToTable("Tbl_Measurement");

                entity.HasComment("جدولی برای نمایش اطلاعات سنجش");

                entity.Property(e => e.Id).HasComment("شناسه سنجش");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد سنجش");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف سنجش");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول سنجش");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول سنجش");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام سنجش");

                entity.Property(e => e.Status).HasComment("وضعیت سنجش");
            });

            modelBuilder.Entity<TblMenu>(entity =>
            {
                entity.ToTable("Tbl_Menu");

                entity.HasComment("جدولی برای نمایش اطلاعات منو(هاکوپدیا)");

                entity.Property(e => e.Id).HasComment("شناسه منو");

                entity.Property(e => e.Arrange).HasComment("ترتیب قرارگیری منوها");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح منو");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصربفرد بین المللی");

                entity.Property(e => e.IsDeleted).HasComment("حذف شده؟");

                entity.Property(e => e.IsSent).HasComment("ارسال شده؟");

                entity.Property(e => e.Parent).HasComment("والد برای مشخص کردن مکان منو و زیر منو ها");

                entity.Property(e => e.Status).HasComment("وضعیت منو");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("عنوان منو");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasComment("آدرس منو");
            });

            modelBuilder.Entity<TblMilitaryService>(entity =>
            {
                entity.ToTable("Tbl_MilitaryService");

                entity.HasComment("جدولی برای نمایش اطلاعات خدمت سربازی");

                entity.Property(e => e.Id).HasComment("شناسه خدمت سربازی");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasComment("کد خدمت سربازی");

                entity.Property(e => e.Explanation)
                    .HasMaxLength(50)
                    .HasComment("توصیف خدمت سربازی");

                entity.Property(e => e.Guid).HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول خدمت سربازی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول خدمت سربازی");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasComment("نام خدمت سربازی");

                entity.Property(e => e.Status).HasComment("وضعیت خدمت سربازی");
            });

            modelBuilder.Entity<TblMonthlyReport>(entity =>
            {
                entity.ToTable("Tbl_MonthlyReport");

                entity.HasComment("جدولی برای نمایش اطلاعات گزارش ماهانه");

                entity.HasIndex(e => new { e.IsClosed, e.Date }, "NonClusteredIndex-20190508-134711")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.Date, e.TblPersonId }, "_dta_index_Tbl_MonthlyReport_29_287392143__K3_K2")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه گزارش ماهانه");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("تاریخ گزارش");

                entity.Property(e => e.Delay).HasComment("به تاخیر افتادن");

                entity.Property(e => e.Deleted).HasComment("بیان اطلاعات حذف شده است در جدول نوع بیمه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsClosed).HasComment("بیان اطلاعات بسته شده است در جدول نوع بیمه");

                entity.Property(e => e.OverAfter).HasComment("اضافه کار بعد ساعت کار");

                entity.Property(e => e.OverBefore).HasComment("اضافه کار قبل ساعت کار");

                entity.Property(e => e.Rush).HasComment("هجوم بردن به گزارش ماهانه");

                entity.Property(e => e.Sent).HasComment("بیان اطلاعات ارسال شده است در جدول نوع بیمه");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.Property(e => e.TotalWork).HasComment("جمع کارکرد");

                entity.Property(e => e.WithoutLicenseAbsence).HasComment("غیبت بدون مجوز");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblMonthlyReports)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_MonthlyReport_Tbl_Person");
            });

            modelBuilder.Entity<TblNetworkUsage>(entity =>
            {
                entity.ToTable("Tbl_NetworkUsage");

                entity.HasComment("جدولی برای نمایش اطلاعات استفاده از شبکه");

                entity.Property(e => e.Id).HasComment("شناسه استفاده از شبکه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف استفاده از شبکه");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع مقدار استفاده شده");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول استفاده از شبکه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول استفاده از شبکه");

                entity.Property(e => e.Status).HasComment("وضعیت استفاده از شبکه");

                entity.Property(e => e.TblIspcontractId)
                    .HasColumnName("Tbl_ISPContract_Id")
                    .HasComment("آی دی قرارداد آی آس پی از جدول دی قرارداد آی آس پی");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان استفاده از شبکه");

                entity.Property(e => e.Usage)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد مقدار استفاده شده");

                entity.HasOne(d => d.TblIspcontract)
                    .WithMany(p => p.TblNetworkUsages)
                    .HasForeignKey(d => d.TblIspcontractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_NetworkUsage_Tbl_ISPContract");
            });

            modelBuilder.Entity<TblNews>(entity =>
            {
                entity.ToTable("Tbl_News");

                entity.HasComment("جدولی برای نمایش اطلاعات اخبار");

                entity.Property(e => e.Id).HasComment("شناسه اخبار");

                entity.Property(e => e.Article)
                    .IsRequired()
                    .HasComment("مقاله اخبار");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد اخبار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف اخبار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ImageURL")
                    .HasComment("آدرس عکس اخبار");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اخبار");

                entity.Property(e => e.IsOffer).HasComment("بیان اطلاعات ارسال شده در جدول اخبار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اخبار");

                entity.Property(e => e.PublishDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ انتشار اخبار");

                entity.Property(e => e.Status).HasComment("وضعیت اخبار");

                entity.Property(e => e.Thumbnail)
                    .IsRequired()
                    .HasComment("تصویر بند انگشت ");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("عنوان اخبار");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("URL")
                    .HasComment("آدرس اخبار");
            });

            modelBuilder.Entity<TblNewsPhoto>(entity =>
            {
                entity.ToTable("Tbl_NewsPhoto");

                entity.HasComment("جدولی برای نمایش اطلاعات تصاویراخبار");

                entity.Property(e => e.Id).HasComment("شناسه تصاویراخبار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف اخبار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasComment("تصاویر اخبار");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اخبار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اخبار");

                entity.Property(e => e.Order).HasComment("ترتیب تصاویر عکس ها");

                entity.Property(e => e.Status).HasComment("وضعیت اخبار");

                entity.Property(e => e.TblNewsId)
                    .HasColumnName("Tbl_News_Id")
                    .HasComment("آی دی اخباراز جدول اخبار");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("URL")
                    .HasComment("آدرس اخبار");

                entity.HasOne(d => d.TblNews)
                    .WithMany(p => p.TblNewsPhotos)
                    .HasForeignKey(d => d.TblNewsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_NewsPhoto_Tbl_News");
            });

            modelBuilder.Entity<TblOrderDetail>(entity =>
            {
                entity.ToTable("Tbl_OrderDetail");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.GarmentType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.PegOrRollCount)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PegOrRollUnit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PegOrRollWidth)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.SupplierRawMaterialCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SupplierRawMaterialColor)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TblCompanyId).HasColumnName("Tbl_Company_Id");

                entity.Property(e => e.TblOrderHeaderId).HasColumnName("Tbl_OrderHeader_Id");

                entity.Property(e => e.TblRawMaterialProductId).HasColumnName("Tbl_RawMaterialProduct_Id");

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblOrderDetails)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrderDetail_Tbl_Company");

                entity.HasOne(d => d.TblOrderHeader)
                    .WithMany(p => p.TblOrderDetails)
                    .HasForeignKey(d => d.TblOrderHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrderDetail_Tbl_OrderHeader");

                entity.HasOne(d => d.TblRawMaterialProduct)
                    .WithMany(p => p.TblOrderDetails)
                    .HasForeignKey(d => d.TblRawMaterialProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrderDetail_Tbl_RawMaterialProduct");
            });

            modelBuilder.Entity<TblOrderDetailDevelopment>(entity =>
            {
                entity.ToTable("Tbl_OrderDetailDevelopment");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblOrderDetailId).HasColumnName("Tbl_OrderDetail_Id");

                entity.Property(e => e.TblRawMaterialProductDevelopmentId).HasColumnName("Tbl_RawMaterialProductDevelopment_Id");

                entity.HasOne(d => d.TblOrderDetail)
                    .WithMany(p => p.TblOrderDetailDevelopments)
                    .HasForeignKey(d => d.TblOrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrderDetailDevelopment_Tbl_OrderDetail");

                entity.HasOne(d => d.TblRawMaterialProductDevelopment)
                    .WithMany(p => p.TblOrderDetailDevelopments)
                    .HasForeignKey(d => d.TblRawMaterialProductDevelopmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrderDetailDevelopment_Tbl_RawMaterialProductDevelopment");
            });

            modelBuilder.Entity<TblOrderDetailProgram>(entity =>
            {
                entity.ToTable("Tbl_OrderDetailProgram");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblOrderDetailId).HasColumnName("Tbl_OrderDetail_Id");

                entity.Property(e => e.TblRawMaterialProductProgramId).HasColumnName("Tbl_RawMaterialProductProgram_Id");

                entity.HasOne(d => d.TblOrderDetail)
                    .WithMany(p => p.TblOrderDetailPrograms)
                    .HasForeignKey(d => d.TblOrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrderDetailProgram_Tbl_OrderDetail");

                entity.HasOne(d => d.TblRawMaterialProductProgram)
                    .WithMany(p => p.TblOrderDetailPrograms)
                    .HasForeignKey(d => d.TblRawMaterialProductProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrderDetailProgram_Tbl_RawMaterialProductProgram");
            });

            modelBuilder.Entity<TblOrderHeader>(entity =>
            {
                entity.ToTable("Tbl_OrderHeader");

                entity.Property(e => e.CoatOrderNumber)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CoatProductCode).HasMaxLength(200);

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Count)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeliveryDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Glue)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Liner)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OrderDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PantsOrderNumber)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PantsProductCode).HasMaxLength(200);

                entity.Property(e => e.ProductionCount)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SheetIndex)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SheetRawIndex)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.TblCompanyId).HasColumnName("Tbl_Company_Id");

                entity.Property(e => e.TblFinishedGoodProductId).HasColumnName("Tbl_FinishedGoodProduct_Id");

                entity.Property(e => e.TblPersonAsIssuerId).HasColumnName("Tbl_PersonAsIssuer_Id");

                entity.Property(e => e.TblPlaceTypeAsIssuerId).HasColumnName("Tbl_PlaceTypeAsIssuer_Id");

                entity.Property(e => e.Thickness)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblOrderHeaders)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrderHeader_Tbl_Company");

                entity.HasOne(d => d.TblFinishedGoodProduct)
                    .WithMany(p => p.TblOrderHeaders)
                    .HasForeignKey(d => d.TblFinishedGoodProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrderHeader_Tbl_FinishedGoodProduct");

                entity.HasOne(d => d.TblPersonAsIssuer)
                    .WithMany(p => p.TblOrderHeaders)
                    .HasForeignKey(d => d.TblPersonAsIssuerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrderHeader_Tbl_Person");

                entity.HasOne(d => d.TblPlaceTypeAsIssuer)
                    .WithMany(p => p.TblOrderHeaders)
                    .HasForeignKey(d => d.TblPlaceTypeAsIssuerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrderHeader_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblOrderHeaderAttachment>(entity =>
            {
                entity.ToTable("Tbl_OrderHeaderAttachment");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblOrderHeaderId).HasColumnName("Tbl_OrderHeader_Id");

                entity.HasOne(d => d.TblOrderHeader)
                    .WithMany(p => p.TblOrderHeaderAttachments)
                    .HasForeignKey(d => d.TblOrderHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrderHeaderAttachment_Tbl_OrderHeader");
            });

            modelBuilder.Entity<TblOrderHeaderMoreInfo>(entity =>
            {
                entity.ToTable("Tbl_OrderHeaderMoreInfo");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.TblCodingPatternValueId).HasColumnName("Tbl_CodingPatternValue_Id");

                entity.Property(e => e.TblOrderHeaderId).HasColumnName("Tbl_OrderHeader_Id");

                entity.HasOne(d => d.TblOrderHeader)
                    .WithMany(p => p.TblOrderHeaderMoreInfos)
                    .HasForeignKey(d => d.TblOrderHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrderHeaderMoreInfo_Tbl_OrderHeader");
            });

            modelBuilder.Entity<TblOrderHeaderOwner>(entity =>
            {
                entity.ToTable("Tbl_OrderHeaderOwner");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblCompanyId).HasColumnName("Tbl_Company_Id");

                entity.Property(e => e.TblOrderHeaderId).HasColumnName("Tbl_OrderHeader_Id");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblOrderHeaderOwners)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrderHeaderOwner_Tbl_Company");

                entity.HasOne(d => d.TblOrderHeader)
                    .WithMany(p => p.TblOrderHeaderOwners)
                    .HasForeignKey(d => d.TblOrderHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrderHeaderOwner_Tbl_OrderHeader");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblOrderHeaderOwners)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrderHeaderOwner_Tbl_Person");
            });

            modelBuilder.Entity<TblOrganizationChart>(entity =>
            {
                entity.ToTable("Tbl_OrganizationChart");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblOrganizationChartKeyId).HasColumnName("Tbl_OrganizationChartKey_Id");

                entity.HasOne(d => d.TblOrganizationChartKey)
                    .WithMany(p => p.TblOrganizationCharts)
                    .HasForeignKey(d => d.TblOrganizationChartKeyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_OrganizationChart_Tbl_OrganizationChartKey");
            });

            modelBuilder.Entity<TblOrganizationChartKey>(entity =>
            {
                entity.ToTable("Tbl_OrganizationChartKey");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblPaymentType>(entity =>
            {
                entity.ToTable("Tbl_PaymentType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع پرداخت ها");

                entity.Property(e => e.Id).HasComment("شناسه نوع پرداخت");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع پرداخت");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع پرداخت");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع پرداخت");

                entity.Property(e => e.PaymentTypeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("کد نوع پرداخت");

                entity.Property(e => e.PaymentTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع پرداخت");

                entity.Property(e => e.Status).HasComment("وضعیت نوع پرداخت");
            });

            modelBuilder.Entity<TblPayrollAttachment>(entity =>
            {
                entity.ToTable("Tbl_PayrollAttachment");

                entity.HasComment("جدولی برای نمایش اطلاعات فایل های ضمیمه شده حقوق و دستمزد");

                entity.Property(e => e.Id).HasComment("شناسه ضمیمه حقوق و دستمزد");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasComment("فایل های ضمیمه شده");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("تاریخ فایل های ضمیمه شده حقوق و دستمزد");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("توصیف فایل های ضمیمه شده حقوق و دستمزد");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasComment("نام فایل های ضمیمه شده");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول فایل های ضمیمه شده حقوق و دستمزد");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول فایل های ضمیمه شده حقوق و دستمزد");

                entity.Property(e => e.Status).HasComment("وضعیت فایل های ضمیمه شده حقوق و دستمزد");

                entity.Property(e => e.TblAttachmentTypeId)
                    .HasColumnName("Tbl_AttachmentType_Id")
                    .HasComment("آی دی نوع ضمیمه از جدول نوع ضمیمه");

                entity.HasOne(d => d.TblAttachmentType)
                    .WithMany(p => p.TblPayrollAttachments)
                    .HasForeignKey(d => d.TblAttachmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PayrollAttachment_Tbl_AttachmentType");
            });

            modelBuilder.Entity<TblPayrollFactor>(entity =>
            {
                entity.ToTable("Tbl_PayrollFactors");

                entity.HasComment("جدولی برای نمایش اطلاعات عوامل استخدام");

                entity.HasIndex(e => new { e.TblPersonId, e.TblPayrollKeyId, e.IsDeleted }, "NonClusteredIndex-20161218-165743")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه عوامل استخدام");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ عوامل استخدام");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف عوامل استخدام");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول عوامل استخدام");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول عوامل استخدام");

                entity.Property(e => e.KeyValue).HasComment("ارزش عوامل استخدام");

                entity.Property(e => e.Status).HasComment("وضعیت عوامل استخدام");

                entity.Property(e => e.TblPayrollKeyId)
                    .HasColumnName("Tbl_PayrollKey_Id")
                    .HasComment("آی دی عوامل حقوقی از جدول عوامل حقوقی");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول شخص");

                entity.HasOne(d => d.TblPayrollKey)
                    .WithMany(p => p.TblPayrollFactors)
                    .HasForeignKey(d => d.TblPayrollKeyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PayrollFactors_Tbl_PayrollKey");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPayrollFactors)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PayrollFactors_Tbl_Person");
            });

            modelBuilder.Entity<TblPayrollKey>(entity =>
            {
                entity.ToTable("Tbl_PayrollKey");

                entity.HasComment("جدولی برای نمایش اطلاعات عوامل حقوقی");

                entity.Property(e => e.Id).HasComment("شناسه عامل حقوقی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد عامل حقوقی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف عوامل حقوق");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول عوامل حقوقی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول عوامل حقوقی");

                entity.Property(e => e.KeyGroup)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("گروه عوامل حقوقی");

                entity.Property(e => e.KeyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام عامل حقوقی");

                entity.Property(e => e.KeyValue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("مقدار عامل حقوقی");

                entity.Property(e => e.ParentId).HasComment("شناسه اصلی عوامل حقوقی");

                entity.Property(e => e.Status).HasComment("وضعیت عوامل حقوق");
            });

            modelBuilder.Entity<TblPermission>(entity =>
            {
                entity.ToTable("Tbl_Permission");

                entity.HasComment("جدولی برای نمایش اطلاعات دسترسی");

                entity.Property(e => e.Id).HasComment("شناسه دسترسی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد دسترسی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف دسترسی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول دسترسی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول دسترسی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام دسترسی");

                entity.Property(e => e.Status).HasComment("وضعیت دسترسی");
            });

            modelBuilder.Entity<TblPerson>(entity =>
            {
                entity.ToTable("Tbl_Person");

                entity.HasComment("جدولی برای نمایش اطلاعات شخص");

                entity.HasIndex(e => new { e.Email, e.IsDeleted, e.TblPersonTypeId, e.Password, e.LastName, e.Id }, "NonClusteredIndex-20190507-153221")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.IsDeleted, e.LastName }, "_dta_index_Tbl_Person_16_543445110__K32_K14_1_2_3_4_5_6_7_8_9_10_11_12_13_15_16_17_18_19_20_21_22_23_24_25_26_27_28_29_30_31")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.IsDeleted, e.Code, e.TblPersonTypeId, e.Id }, "_dta_index_Tbl_Person_29_1670401120__K31_K12_K2_K1_3_4_5_6_7_8_9_10_11_13_14_15_16_17_18_19_20_21_22_23_24_25_26_27_28_29_30")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.Email, e.TblPersonTypeId, e.IsDeleted, e.Id, e.Password }, "_dta_index_Tbl_Person_29_543445110__K23_K2_K32_K1_K27_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_19_20_21_22_24_25_26_28_29_30_31")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblPersonTypeId, e.IsDeleted, e.Status }, "_dta_index_Tbl_Person_29_543445110__K2_K32_K29")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.IsDeleted, e.Id }, "_dta_index_Tbl_Person_29_543445110__K32_K1_2_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_19_20_21_22_23_24_25_26_27_28_29_30_31")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.IsDeleted, e.TblPersonTypeId, e.Id }, "_dta_index_Tbl_Person_29_543445110__K32_K2_K1_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_19_20_21_22_23_24_25_26_27_28_29_30_31")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblPersonTypeId, e.IsDeleted }, "_dta_index_Tbl_Person_29_688109592__K2_K31_1_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_19_20_21_22_23_24_25_26_27_28_29_30")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.IsDeleted, e.Id }, "_dta_index_Tbl_Person_29_688109592__K31_K1")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.IsDeleted, e.Id }, "_dta_index_Tbl_Person_29_688109592__K31_K1_2_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_19_20_21_22_23_24_25_26_27_28_29_30")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه شخص");

                entity.Property(e => e.BirthCertificateNumber)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("شماره شناسنامه");

                entity.Property(e => e.BirthDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("تاریخ تولد");

                entity.Property(e => e.CardNumber).HasComment("شماره کارت");

                entity.Property(e => e.Code).HasComment("کد شخص");

                entity.Property(e => e.DeathDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ وفات");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("ایمیل شخص");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasComment("توصیف شخص");

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام پدر");

                entity.Property(e => e.FileNumber).HasComment("شماره پوشه");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام شخص");

                entity.Property(e => e.GetEmail).HasComment("فیلد دریافت ایمیل");

                entity.Property(e => e.GetSms)
                    .HasColumnName("GetSMS")
                    .HasComment("فیلد دریافت اس ام اس");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول شخص");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول شخص");

                entity.Property(e => e.IssueDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("تاریخ صدور");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("نام خانوادگی شخص");

                entity.Property(e => e.MarriageDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("تاریخ ازدواج");

                entity.Property(e => e.NationalCode)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("کد ملی");

                entity.Property(e => e.Nfc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NFC")
                    .HasComment("کارت های ان اف سی");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("رمزعبور شخص");

                entity.Property(e => e.Sex).HasComment("جنسیت");

                entity.Property(e => e.Status).HasComment("وضعیت شخص");

                entity.Property(e => e.TblCityIdAsBirthPlace)
                    .HasColumnName("Tbl_City_IdAsBirthPlace")
                    .HasComment("آی دی شهر محل تولد از جدول شهرها");

                entity.Property(e => e.TblCityIdAsIssuePlace)
                    .HasColumnName("Tbl_City_IdAsIssuePlace")
                    .HasComment("آی دی شهر محل صدور شناسنامه از جدول شهرها");

                entity.Property(e => e.TblCountryIdAsNationality)
                    .HasColumnName("Tbl_Country_IdAsNationality")
                    .HasComment("آی دی ملیت از جدول کشور");

                entity.Property(e => e.TblJobId)
                    .HasColumnName("Tbl_Job_Id")
                    .HasComment("آی دی شغل در جدول شغل");

                entity.Property(e => e.TblMarriageStatusId)
                    .HasColumnName("Tbl_MarriageStatus_Id")
                    .HasComment("آی دی وضعیت تاهل از جدول وضعیت تاهل");

                entity.Property(e => e.TblMilitaryServiceId)
                    .HasColumnName("Tbl_MilitaryService_Id")
                    .HasComment("آی دی وضعیت سربازی از جدول وضعیت سربازی");

                entity.Property(e => e.TblPersonTypeId)
                    .HasColumnName("Tbl_PersonType_Id")
                    .HasComment("آی دی نوع شخص از جدول اشخاص");

                entity.Property(e => e.TblReligionId)
                    .HasColumnName("Tbl_Religion_Id")
                    .HasComment("آی دی دین و مذهب از جدول دین و مذهب");

                entity.HasOne(d => d.TblCityIdAsBirthPlaceNavigation)
                    .WithMany(p => p.TblPersonTblCityIdAsBirthPlaceNavigations)
                    .HasForeignKey(d => d.TblCityIdAsBirthPlace)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Person_Tbl_City");

                entity.HasOne(d => d.TblCityIdAsIssuePlaceNavigation)
                    .WithMany(p => p.TblPersonTblCityIdAsIssuePlaceNavigations)
                    .HasForeignKey(d => d.TblCityIdAsIssuePlace)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Person_Tbl_City1");

                entity.HasOne(d => d.TblCountryIdAsNationalityNavigation)
                    .WithMany(p => p.TblPeople)
                    .HasForeignKey(d => d.TblCountryIdAsNationality)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Person_Tbl_Country");

                entity.HasOne(d => d.TblJob)
                    .WithMany(p => p.TblPeople)
                    .HasForeignKey(d => d.TblJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Person_Tbl_Job");

                entity.HasOne(d => d.TblMarriageStatus)
                    .WithMany(p => p.TblPeople)
                    .HasForeignKey(d => d.TblMarriageStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Person_Tbl_MarriageStatus");

                entity.HasOne(d => d.TblMilitaryService)
                    .WithMany(p => p.TblPeople)
                    .HasForeignKey(d => d.TblMilitaryServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Person_Tbl_MilitaryService");

                entity.HasOne(d => d.TblPersonType)
                    .WithMany(p => p.TblPeople)
                    .HasForeignKey(d => d.TblPersonTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Person_Tbl_PersonType");

                entity.HasOne(d => d.TblReligion)
                    .WithMany(p => p.TblPeople)
                    .HasForeignKey(d => d.TblReligionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Person_Tbl_Religion");
            });

            modelBuilder.Entity<TblPersonCertificate>(entity =>
            {
                entity.ToTable("Tbl_PersonCertificate");

                entity.HasComment("جدولی برای نمایش اطلاعات مدارک شخص");

                entity.Property(e => e.Id).HasComment("شناسه مدرک شخص");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف مدرک تحصیلی شخص");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع مدرک تحصیلی شخص");

                entity.Property(e => e.GraduationLevel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))")
                    .HasComment("سطح فارغ التحصیلی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول مدرک تحصیلی شخص");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول مدرک تحصیلی شخص");

                entity.Property(e => e.Status).HasComment("وضعیت مدرک تحصیلی شخص");

                entity.Property(e => e.TblCertificateId)
                    .HasColumnName("Tbl_Certificate_Id")
                    .HasComment("آی دی مدرک از جدول مدرک");

                entity.Property(e => e.TblFieldOfStudyId)
                    .HasColumnName("Tbl_FieldOfStudy_Id")
                    .HasComment(" آی دی رشته تحصیلی از جدول رشته تحصیلی");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول شخص");

                entity.Property(e => e.TblPlaceTypeIdAsUniversity)
                    .HasColumnName("Tbl_PlaceType_IdAsUniversity")
                    .HasComment("آی دی دانشگاه یا موسسه محل تحصیل از جدول محل ها");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان مدرک تحصیلی شخص");

                entity.HasOne(d => d.TblCertificate)
                    .WithMany(p => p.TblPersonCertificates)
                    .HasForeignKey(d => d.TblCertificateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonCertificate_Tbl_Certificate");

                entity.HasOne(d => d.TblFieldOfStudy)
                    .WithMany(p => p.TblPersonCertificates)
                    .HasForeignKey(d => d.TblFieldOfStudyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonCertificate_Tbl_StudyField");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPersonCertificates)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonCertificate_Tbl_Person");

                entity.HasOne(d => d.TblPlaceTypeIdAsUniversityNavigation)
                    .WithMany(p => p.TblPersonCertificates)
                    .HasForeignKey(d => d.TblPlaceTypeIdAsUniversity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonCertificate_Tbl_Place");
            });

            modelBuilder.Entity<TblPersonCharge>(entity =>
            {
                entity.ToTable("Tbl_PersonCharge");

                entity.HasComment("جدولی برای نمایش اطلاعات شارژ کارت شخص");

                entity.HasIndex(e => new { e.IsDeleted, e.TblPersonId }, "_dta_index_Tbl_PersonCharge_16_912930524__K22_K2_1_3_5_6_7_8_9_10_11_12_13_14_15_16_18_19_20_21")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه شارژ شخص");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف شارژ کارت شخص");

                entity.Property(e => e.FromAmount).HasComment("شروع مبلغ خرید شارژ کارت شخص");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع کارت شارژ شخص");

                entity.Property(e => e.FromPercent).HasComment("شروع درصد خرید شارژ کارت شخص");

                entity.Property(e => e.FromPurchase).HasComment("شروع خرید از");

                entity.Property(e => e.FromRemained).HasComment("کف باقیمانده شارژ");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول شارژ کارت شخص");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول شارژ کارت شخص");

                entity.Property(e => e.Status).HasComment("وضعیت شارژ کارت شخص");

                entity.Property(e => e.TblDiscountTypeId).HasColumnName("Tbl_DiscountType_Id");

                entity.Property(e => e.TblInvoiceMasterId).HasColumnName("Tbl_InvoiceMaster_Id");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.Property(e => e.ToAmount).HasComment("پایان مبلغ خرید شارژ کارت شخص");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان شارژ  کارت شخص");

                entity.Property(e => e.ToPercent).HasComment("پایان درصد خرید شارژ کارت شخص");

                entity.Property(e => e.ToPurchase).HasComment("پایان خرید تا");

                entity.Property(e => e.ToRemained).HasComment("سقف باقیمانده شارژ");

                entity.HasOne(d => d.TblDiscountType)
                    .WithMany(p => p.TblPersonCharges)
                    .HasForeignKey(d => d.TblDiscountTypeId)
                    .HasConstraintName("FK_Tbl_PersonCharge_Tbl_DiscountType");

                entity.HasOne(d => d.TblInvoiceMaster)
                    .WithMany(p => p.TblPersonCharges)
                    .HasForeignKey(d => d.TblInvoiceMasterId)
                    .HasConstraintName("FK_Tbl_PersonCharge_Tbl_InvoiceMaster");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPersonCharges)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonCharge_Tbl_Person");
            });

            modelBuilder.Entity<TblPersonDevice>(entity =>
            {
                entity.ToTable("Tbl_PersonDevice");

                entity.HasComment("جدولی برای نمایش اطلاعات دستگاه شخص");

                entity.Property(e => e.Id).HasComment("شناسه دستگاه شخص");

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasComment("آی دی دستگاه از جدول دستگاه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف دستگاه شخص");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول دستگاه شخص");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول دستگاه شخص");

                entity.Property(e => e.Status).HasComment("وضعیت دستگاه شخص");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPersonDevices)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonDevice_Tbl_Person");
            });

            modelBuilder.Entity<TblPersonEmploymentRequest>(entity =>
            {
                entity.ToTable("Tbl_PersonEmploymentRequest");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblEmploymentRequestId).HasColumnName("Tbl_EmploymentRequest_Id");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.HasOne(d => d.TblEmploymentRequest)
                    .WithMany(p => p.TblPersonEmploymentRequests)
                    .HasForeignKey(d => d.TblEmploymentRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonEmploymentRequest_Tbl_EmploymentRequest");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPersonEmploymentRequests)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonEmploymentRequest_Tbl_Person");
            });

            modelBuilder.Entity<TblPersonEvaluation>(entity =>
            {
                entity.ToTable("Tbl_PersonEvaluation");

                entity.HasComment("جدولی برای نمایش ارزیابی شخص");

                entity.Property(e => e.Id).HasComment("شناسه ارزیابی شخص");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف ارزیابی شخص");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول ارزیابی شخص");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول ارزیابی شخص");

                entity.Property(e => e.ResultScore).HasComment("نتیجه ارزیابی شخص");

                entity.Property(e => e.Status).HasComment("وضعیت ارزیابی شخص");

                entity.Property(e => e.TblEvaluationPeriodId)
                    .HasColumnName("Tbl_EvaluationPeriod_Id")
                    .HasComment("آی دی دوره ارزیابی از جدول دوره ارزیابی");

                entity.Property(e => e.TblJobResponsibilityId)
                    .HasColumnName("Tbl_JobResponsibility_Id")
                    .HasComment("آی دی هدف ارزیابی از جدول هدف ارزیابی");

                entity.Property(e => e.TblJobSkillId).HasColumnName("Tbl_JobSkill_Id");

                entity.Property(e => e.TblMeasurementId)
                    .HasColumnName("Tbl_Measurement_Id")
                    .HasComment("آی دی واحد اندازه گیری از جدول واحد اندازه گیری");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.HasOne(d => d.TblEvaluationPeriod)
                    .WithMany(p => p.TblPersonEvaluations)
                    .HasForeignKey(d => d.TblEvaluationPeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonEvaluation_Tbl_EvaluationPeriod");

                entity.HasOne(d => d.TblJobResponsibility)
                    .WithMany(p => p.TblPersonEvaluations)
                    .HasForeignKey(d => d.TblJobResponsibilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonEvaluation_Tbl_JobResponsibility");

                entity.HasOne(d => d.TblJobSkill)
                    .WithMany(p => p.TblPersonEvaluations)
                    .HasForeignKey(d => d.TblJobSkillId)
                    .HasConstraintName("FK_Tbl_PersonEvaluation_Tbl_JobSkill");

                entity.HasOne(d => d.TblMeasurement)
                    .WithMany(p => p.TblPersonEvaluations)
                    .HasForeignKey(d => d.TblMeasurementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonEvaluation_Tbl_Measurement");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPersonEvaluations)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Person_Evaluation_Tbl_Person");
            });

            modelBuilder.Entity<TblPersonEvaluationProjectTask>(entity =>
            {
                entity.ToTable("Tbl_PersonEvaluationProjectTask");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف ارزیابی شخص");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول ارزیابی شخص");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول ارزیابی شخص");

                entity.Property(e => e.Status).HasComment("وضعیت ارزیابی شخص");

                entity.Property(e => e.TblPersonEvaluationId).HasColumnName("Tbl_PersonEvaluation_Id");

                entity.Property(e => e.TblProjectTaskId).HasColumnName("Tbl_ProjectTask_Id");

                entity.HasOne(d => d.TblPersonEvaluation)
                    .WithMany(p => p.TblPersonEvaluationProjectTasks)
                    .HasForeignKey(d => d.TblPersonEvaluationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonEvaluationProjectTask_Tbl_PersonEvaluation");

                entity.HasOne(d => d.TblProjectTask)
                    .WithMany(p => p.TblPersonEvaluationProjectTasks)
                    .HasForeignKey(d => d.TblProjectTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonEvaluationProjectTask_Tbl_ProjectTask");
            });

            modelBuilder.Entity<TblPersonGroup>(entity =>
            {
                entity.ToTable("Tbl_PersonGroup");

                entity.HasComment("جدولی برای نمایش اطلاعات گروه اشخاص");

                entity.Property(e => e.Id).HasComment("شناسه گروه اشخاص");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف گروه اشخاص");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول  گروه اشخاص");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول  گروه اشخاص");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع");

                entity.Property(e => e.Status).HasComment("وضعیت گروه اشخاص");

                entity.Property(e => e.TblGroupId)
                    .HasColumnName("Tbl_Group_Id")
                    .HasComment("آی دی گروه از جدول گروه");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.HasOne(d => d.TblGroup)
                    .WithMany(p => p.TblPersonGroups)
                    .HasForeignKey(d => d.TblGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonnelGroup_Tbl_Group");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPersonGroups)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonnelGroup_Tbl_Person");
            });

            modelBuilder.Entity<TblPersonInterest>(entity =>
            {
                entity.ToTable("Tbl_PersonInterest");

                entity.HasComment("جدولی برای نمایش اطلاعات علایق اشخاص");

                entity.Property(e => e.Id).HasComment("شناسه علایق اشخاص");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف علایق اشخاص");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول  علایق اشخاص");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات حذف شده است در جدول  علایق اشخاص");

                entity.Property(e => e.KeyValue).HasComment("مقدار کلید انتخابی");

                entity.Property(e => e.Status).HasComment("وضعیت علایق اشخاص");

                entity.Property(e => e.TblInterestId)
                    .HasColumnName("Tbl_Interest_Id")
                    .HasComment("آی دی علاقه از جدول علایق");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.HasOne(d => d.TblInterest)
                    .WithMany(p => p.TblPersonInterests)
                    .HasForeignKey(d => d.TblInterestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonInterest_Tbl_Interest");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPersonInterests)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonInterest_Tbl_Person");
            });

            modelBuilder.Entity<TblPersonInterview>(entity =>
            {
                entity.ToTable("Tbl_PersonInterview");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblPersonEmploymentRequestId).HasColumnName("Tbl_PersonEmploymentRequest_Id");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.HasOne(d => d.TblPersonEmploymentRequest)
                    .WithMany(p => p.TblPersonInterviews)
                    .HasForeignKey(d => d.TblPersonEmploymentRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonInterview_Tbl_PersonEmploymentRequest");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPersonInterviews)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonInterview_Tbl_Person");
            });

            modelBuilder.Entity<TblPersonMeal>(entity =>
            {
                entity.ToTable("Tbl_PersonMeal");

                entity.HasComment("جدولی برای نمایش اطلاعات غذای شخص");

                entity.HasIndex(e => new { e.TblPersonId, e.IsDeleted, e.TblCatteringItemId }, "_dta_index_Tbl_PersonMeal_16_1486016425__K2_K9_K3_1_5_6_7_8")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف غذای شخص");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول  غذای شخص");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده است در جدول  غذای شخص");

                entity.Property(e => e.Status).HasComment("وضعیت غذای شخص");

                entity.Property(e => e.TblCatteringItemId)
                    .HasColumnName("Tbl_CatteringItem_Id")
                    .HasComment("آی دی غذای انتخابی از غذاهای آشپزخانه");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.HasOne(d => d.TblCatteringItem)
                    .WithMany(p => p.TblPersonMeals)
                    .HasForeignKey(d => d.TblCatteringItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonMeal_Tbl_CatteringItem");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPersonMeals)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonMeal_Tbl_Person");
            });

            modelBuilder.Entity<TblPersonNote>(entity =>
            {
                entity.ToTable("Tbl_PersonNote");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TblPersonIdAsFrom).HasColumnName("Tbl_Person_IdAsFrom");

                entity.Property(e => e.TblPersonIdAsTo).HasColumnName("Tbl_Person_IdAsTo");

                entity.HasOne(d => d.TblPersonIdAsFromNavigation)
                    .WithMany(p => p.TblPersonNoteTblPersonIdAsFromNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsFrom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonNote_Tbl_Person");

                entity.HasOne(d => d.TblPersonIdAsToNavigation)
                    .WithMany(p => p.TblPersonNoteTblPersonIdAsToNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonNote_Tbl_Person1");
            });

            modelBuilder.Entity<TblPersonPermission>(entity =>
            {
                entity.ToTable("Tbl_PersonPermission");

                entity.HasComment("جدولی برای نمایش اطلاعات دسترسی شخص");

                entity.Property(e => e.Id).HasComment("شناسه دسترسی شخص");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف دسترسی شخص");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول دسترسی شخص");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده است در جدول دسترسی شخص");

                entity.Property(e => e.Status).HasComment("وضعیت دسترسی شخص");

                entity.Property(e => e.TblPermissionId)
                    .HasColumnName("Tbl_Permission_Id")
                    .HasComment("آی دی  دسترسی از جدول دسترسی");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.HasOne(d => d.TblPermission)
                    .WithMany(p => p.TblPersonPermissions)
                    .HasForeignKey(d => d.TblPermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonPermission_Tbl_Permission");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPersonPermissions)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonPermission_Tbl_Person");
            });

            modelBuilder.Entity<TblPersonRole>(entity =>
            {
                entity.ToTable("Tbl_PersonRole");

                entity.HasComment("جدولی برای نمایش اطلاعات نقش شخص");

                entity.HasIndex(e => new { e.TblPersonId, e.IsDeleted }, "NonClusteredIndex-20190507-174340")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه نقش شخص");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نقش شخص");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نقش شخص");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع نقش شخص");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول نقش شخص");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده است در جدول نقش شخص");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نقش شخص");

                entity.Property(e => e.Status).HasComment("وضعیت نقش شخص");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول شخص");

                entity.Property(e => e.TblRoleId)
                    .HasColumnName("Tbl_Role_Id")
                    .HasComment("آی دی نقش از جدول نقش");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان نقش شخص");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPersonRoles)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonRole_Tbl_Person");

                entity.HasOne(d => d.TblRole)
                    .WithMany(p => p.TblPersonRoles)
                    .HasForeignKey(d => d.TblRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonRole_Tbl_Role");
            });

            modelBuilder.Entity<TblPersonSkill>(entity =>
            {
                entity.ToTable("Tbl_PersonSkill");

                entity.HasComment("جدولی برای نمایش اطلاعات مهارت شخص");

                entity.Property(e => e.Id).HasComment("شناسه مهارت شخص");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف مهارت شخص");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول مهارت شخص");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده است در جدول مهارت شخص");

                entity.Property(e => e.SkillLevel).HasComment("سطح مهارت");

                entity.Property(e => e.Status).HasComment("وضعیت مهارت شخص");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول شخص");

                entity.Property(e => e.TblSkillId)
                    .HasColumnName("Tbl_Skill_Id")
                    .HasComment("آی دی مهارت از جدول مهارت");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPersonSkills)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonSkill_Tbl_Person");

                entity.HasOne(d => d.TblSkill)
                    .WithMany(p => p.TblPersonSkills)
                    .HasForeignKey(d => d.TblSkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonSkill_Tbl_Skill");
            });

            modelBuilder.Entity<TblPersonSystem>(entity =>
            {
                entity.ToTable("Tbl_PersonSystem");

                entity.HasComment("جدولی برای نمایش اطلاعات سیستم شخص");

                entity.Property(e => e.Id).HasComment("شناسه سیستم شخص");

                entity.Property(e => e.Adusername)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ADUsername")
                    .HasComment("افزودن نام کاربری");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف سیستم شخص");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("IP")
                    .HasComment("آی پی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول سیستم شخص");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده است در جدول سیستم شخص");

                entity.Property(e => e.Status).HasComment("وضعیت سیستم شخص");

                entity.Property(e => e.TblComputerId)
                    .HasColumnName("Tbl_Computer_Id")
                    .HasComment("آی دی کامپیوتر از جدول کامپیوتر");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول شخص");

                entity.HasOne(d => d.TblComputer)
                    .WithMany(p => p.TblPersonSystems)
                    .HasForeignKey(d => d.TblComputerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonSystem_Tbl_PersonSystem");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPersonSystems)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonSystem_Tbl_Person");
            });

            modelBuilder.Entity<TblPersonType>(entity =>
            {
                entity.ToTable("Tbl_PersonType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع شخص");

                entity.Property(e => e.Id).HasComment("شناسه نوع شخص");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع شخص");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول نوع شخص");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده است در جدول نوع شخص");

                entity.Property(e => e.Status).HasComment("وضعیت نوع شخص");

                entity.Property(e => e.Type).HasComment("نوع شخص");
            });

            modelBuilder.Entity<TblPersonVisitedUrl>(entity =>
            {
                entity.ToTable("Tbl_PersonVisitedUrl");

                entity.HasIndex(e => new { e.TblPersonId, e.Url, e.IsDeleted }, "NonClusteredIndex-20200714-153404");

                entity.HasIndex(e => new { e.IsDeleted, e.TblPersonId, e.Url }, "_dta_index_Tbl_PersonVisitedUrl_16_1367168116__K10_K2_K5")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.VisitDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPersonVisitedUrls)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PersonVisitedUrl_Tbl_Person");
            });

            modelBuilder.Entity<TblPhone>(entity =>
            {
                entity.ToTable("Tbl_Phone");

                entity.HasComment("جدولی برای نمایش اطلاعات تلفن");

                entity.HasIndex(e => new { e.TblPersonId, e.IsDeleted, e.Number }, "_dta_index_Tbl_Phone_16_1434540244__K2_K9_K4")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.Number, e.IsDeleted, e.Id }, "_dta_index_Tbl_Phone_16_1434540244__K4_K9_K1_2")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.TblPersonId, "_dta_index_Tbl_Phone_29_1434540244__K2_1_3_4_5_6_7_8_9")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.Number, e.TblPersonId }, "_dta_index_Tbl_Phone_29_1434540244__K4_K2")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.IsDeleted, "_dta_index_Tbl_Phone_29_1434540244__K9_1_2_3_4_5_6_7_8")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.IsDeleted, "_dta_index_Tbl_Phone_29_1434540244__K9_2_4")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment(" تلفن");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف تلفن");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول تلفن");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده است در جدول تلفن");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شماره تلفن");

                entity.Property(e => e.Status).HasComment("وضعیت تلفن");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.Property(e => e.TblPhoneTypeId)
                    .HasColumnName("Tbl_PhoneType_Id")
                    .HasComment("آی دی نوع تلفن از جدول نوع تلفن");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPhones)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Phone_Tbl_Person");

                entity.HasOne(d => d.TblPhoneType)
                    .WithMany(p => p.TblPhones)
                    .HasForeignKey(d => d.TblPhoneTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Phone_Tbl_PhoneType");
            });

            modelBuilder.Entity<TblPhoneType>(entity =>
            {
                entity.ToTable("Tbl_PhoneType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع تلفن");

                entity.Property(e => e.Id).HasComment("شناسه نوع تلفن");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع تلفن");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع تلفن");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول نوع تلفن");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده است در جدول نوع تلفن");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع تلفن");

                entity.Property(e => e.Status).HasComment("وضعیت نوع تلفن");
            });

            modelBuilder.Entity<TblPlace>(entity =>
            {
                entity.ToTable("Tbl_Place");

                entity.HasComment("جدولی برای نمایش اطلاعات مکان");

                entity.HasIndex(e => e.TblPersonId, "NonClusteredIndex-20190507-152434")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblPersonId, e.IsDeleted }, "_dta_index_Tbl_Place_29_997682702__K2_K12_1_3_4_5_6_7_8_9_10_11")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه مکان");

                entity.Property(e => e.AddressLine)
                    .IsRequired()
                    .HasComment("خط آدرس");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف مکان ");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول مکان");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده است در جدول مکان");

                entity.Property(e => e.Latitude)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("عرض جغرافیایی");

                entity.Property(e => e.Longitude)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("طول جغرافیایی");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد پستی");

                entity.Property(e => e.Settelment)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شخصی یا استیجاری");

                entity.Property(e => e.Status).HasComment("وضعیت مکان");

                entity.Property(e => e.TblCityId)
                    .HasColumnName("Tbl_City_Id")
                    .HasComment("آی دی شهر از جدول شهر");

                entity.Property(e => e.TblDistrictId).HasColumnName("Tbl_District_Id");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول شخص");

                entity.Property(e => e.TblPlaceTypeId)
                    .HasColumnName("Tbl_PlaceType_Id")
                    .HasComment("آی دی نوع مکان از جدول نوع مکان");

                entity.HasOne(d => d.TblCity)
                    .WithMany(p => p.TblPlaces)
                    .HasForeignKey(d => d.TblCityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Place_Tbl_City");

                entity.HasOne(d => d.TblDistrict)
                    .WithMany(p => p.TblPlaces)
                    .HasForeignKey(d => d.TblDistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Place_Tbl_District");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPlaces)
                    .HasForeignKey(d => d.TblPersonId)
                    .HasConstraintName("FK_Tbl_Place_Tbl_Person");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblPlaces)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Place_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblPlaceType>(entity =>
            {
                entity.ToTable("Tbl_PlaceType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع مکان");

                entity.HasIndex(e => e.Id, "_dta_index_Tbl_PlaceType_29_752773789__K1_2_3")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.PlaceTypeName, e.Id }, "_dta_index_Tbl_PlaceType_29_752773789__K3_K1")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.IsDeleted, e.Id }, "_dta_index_Tbl_PlaceType_29_752773789__K8_K1_2_3")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه نوع مکان");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع مکان");

                entity.Property(e => e.FinishedGoodProductAccountCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول نوع مکان");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده است در جدول نوع مکان");

                entity.Property(e => e.PlaceTypeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع مکان");

                entity.Property(e => e.PlaceTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع مکان");

                entity.Property(e => e.RawMaterialAccountCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("وضعیت نوع مکان");
            });

            modelBuilder.Entity<TblPlaceTypeFinishedGoodCapacity>(entity =>
            {
                entity.ToTable("Tbl_PlaceTypeFinishedGoodCapacity");

                entity.HasIndex(e => new { e.TblPlaceTypeId, e.PartCode, e.IsDeleted }, "NonClusteredIndex-20190814-161617")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TblPlaceTypeId).HasColumnName("Tbl_PlaceType_Id");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblPlaceTypeFinishedGoodCapacities)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PlaceTypeFinishedGoodCapacity_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblPlaceTypeImage>(entity =>
            {
                entity.ToTable("Tbl_PlaceTypeImages");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع محل تصاویر");

                entity.Property(e => e.Id).HasComment("شناسه نوع محل تصاویر");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع محل تصاویر");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasComment("تصویر");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است در جدول نوع محل تصاویر");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده است در جدول نوع محل تصاویر");

                entity.Property(e => e.Status).HasComment("وضعیت نوع محل تصاویر");

                entity.Property(e => e.TblPlaceTypeId)
                    .HasColumnName("Tbl_PlaceType_Id")
                    .HasComment("آی دی نوع محل از جدول نوع محل");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("URL")
                    .HasComment("آدرس تصویر");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblPlaceTypeImages)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PlaceTypeImages_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblPlan>(entity =>
            {
                entity.ToTable("Tbl_Plan");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.PlanCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PlanName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblPo>(entity =>
            {
                entity.ToTable("Tbl_POS");

                entity.HasComment("جدولی برای نمایش اطلاعات دستگاه پز");

                entity.Property(e => e.Id).HasComment("شناسه دستگاه پز");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد دستگاه پز");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف دستگاه پز");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول دستگاه پز");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول دستگاه پز");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام دستگاه پز");

                entity.Property(e => e.Status).HasComment("وضعیت دستگاه پز");

                entity.Property(e => e.TblBankBranchAccountId)
                    .HasColumnName("Tbl_BankBranchAccount_Id")
                    .HasComment("آی دی حساب های موجود در شعب بانکی از جدول حساب های موجود در شعب بانکی");

                entity.Property(e => e.TerminalNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شماره ترمینال دستگاه پوز");

                entity.HasOne(d => d.TblBankBranchAccount)
                    .WithMany(p => p.TblPos)
                    .HasForeignKey(d => d.TblBankBranchAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_POS_Tbl_BankBranchAccount");
            });

            modelBuilder.Entity<TblPointType>(entity =>
            {
                entity.ToTable("Tbl_PointType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع امتیاز");

                entity.Property(e => e.Id).HasComment("شناسه نوع امتیاز");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع امتیاز");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع امتیاز");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع امتیاز");

                entity.Property(e => e.PointTypeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("کد نوع امتیاز");

                entity.Property(e => e.PointTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع امتیاز");

                entity.Property(e => e.Status).HasComment("وضعیت نوع امتیاز");
            });

            modelBuilder.Entity<TblPollProductQuality>(entity =>
            {
                entity.ToTable("Tbl_PollProductQuality");

                entity.HasComment("جدولی برای نظرسنجی محصول, بعد از 45 روز");

                entity.Property(e => e.Cons)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("معایب");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ نظرسنجی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pros)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("مزایا");

                entity.Property(e => e.QuestionId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("شناسه سوال");

                entity.Property(e => e.Rate).HasComment("امتیاز داده شده به سوال");

                entity.Property(e => e.TblFinishedGoodProductId)
                    .HasColumnName("Tbl_FinishedGoodProduct_Id")
                    .HasComment("شناسه محصول");

                entity.Property(e => e.TblInvoiceMasterId)
                    .HasColumnName("Tbl_InvoiceMaster_Id")
                    .HasComment("شناسه فاکتور");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("شناسه مشترک");

                entity.HasOne(d => d.TblFinishedGoodProduct)
                    .WithMany(p => p.TblPollProductQualities)
                    .HasForeignKey(d => d.TblFinishedGoodProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PollProductQuality_Tbl_FinishedGoodProduct");

                entity.HasOne(d => d.TblInvoiceMaster)
                    .WithMany(p => p.TblPollProductQualities)
                    .HasForeignKey(d => d.TblInvoiceMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PollProductQuality_Tbl_InvoiceMaster");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPollProductQualities)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PollProductQuality_Tbl_PollProductQuality");
            });

            modelBuilder.Entity<TblPollServiceQuality>(entity =>
            {
                entity.ToTable("Tbl_PollServiceQuality");

                entity.HasComment("جدولی برای نظرسنجی سرویس, ۳ ساعت بعد از خرید");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("تاریخ نظرسنجی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شناسه سوال پاسخ داده شده");

                entity.Property(e => e.Rate).HasComment("امتیاز داده شده به سوال");

                entity.Property(e => e.TblInvoiceMasterId)
                    .HasColumnName("Tbl_InvoiceMaster_Id")
                    .HasComment("شناسه فاکتور");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("شناسه مشترک");

                entity.HasOne(d => d.TblInvoiceMaster)
                    .WithMany(p => p.TblPollServiceQualities)
                    .HasForeignKey(d => d.TblInvoiceMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PollServiceQuality_Tbl_InvoiceMaster");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblPollServiceQualities)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_PollServiceQuality_Tbl_Person");
            });

            modelBuilder.Entity<TblPost>(entity =>
            {
                entity.ToTable("Tbl_Post");

                entity.HasComment("جدولی برای نمایش اطلاعات سمت");

                entity.Property(e => e.Id).HasComment("شناسه سمت");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد سمت");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف سمت");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول سمت");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در چدول سمت");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام سمت");

                entity.Property(e => e.Status).HasComment("وضعیت سمت");
            });

            modelBuilder.Entity<TblPrepaymentType>(entity =>
            {
                entity.ToTable("Tbl_PrepaymentType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع پیش پرداخت");

                entity.Property(e => e.Id).HasComment("شناسه نوع پیش پرداخت");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع پیش پرداخت");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع پیش پرداخت");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع پیش پرداخت");

                entity.Property(e => e.PrepaymentTypeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("کد نوع پیش پرداخت");

                entity.Property(e => e.PrepaymentTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع پیش پرداخت");

                entity.Property(e => e.Status).HasComment("وضعیت نوع پیش پرداخت");
            });

            modelBuilder.Entity<TblPriority>(entity =>
            {
                entity.ToTable("Tbl_Priority");

                entity.HasComment("جدولی برای نمایش اطلاعات اولویت");

                entity.Property(e => e.Id).HasComment("شناسه اولویت");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد اولویت");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف اولویت");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اولویت");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اولویت");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام اولویت");

                entity.Property(e => e.Status).HasComment("وضعیت اولویت");
            });

            modelBuilder.Entity<TblProcess>(entity =>
            {
                entity.ToTable("Tbl_Process");

                entity.HasComment("جدولی برای نمایش اطلاعات پردازش");

                entity.HasIndex(e => new { e.TblPersonId, e.IsDeleted }, "NonClusteredIndex-20161218-165337")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه پردازش");

                entity.Property(e => e.BuyLoan).HasComment("وام خرید");

                entity.Property(e => e.BuyLoanRemain).HasComment("مانده وام خرید");

                entity.Property(e => e.ChildAmount).HasComment("مبلغ حق اولاد");

                entity.Property(e => e.Closed).HasComment("آیا ماه بسته شده است");

                entity.Property(e => e.Coupon).HasComment("کپن");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("ماه پردازش");

                entity.Property(e => e.EfficiencyAmount).HasComment("درآمد مشمول بیمه");

                entity.Property(e => e.EmployeeShare).HasComment("مبلغ بیمه سهم کارگر");

                entity.Property(e => e.EmployerShare).HasComment("مبلغ بیمه سهم کارفرما");

                entity.Property(e => e.FoodAmount).HasComment("مبلغ خواروبار");

                entity.Property(e => e.HelpFacility).HasComment("کمک هزینه رفاهی");

                entity.Property(e => e.HouseAmount).HasComment("مبلغ مسکن");

                entity.Property(e => e.InsuranceLoan).HasComment("قسط وام بیمه تکمیلی");

                entity.Property(e => e.InsuranceLoanRemain).HasComment("مانده وام بیمه تکمیلی");

                entity.Property(e => e.IsDeleted).HasComment("آیا حذف شده است");

                entity.Property(e => e.JobAlluanceAmount).HasComment("مزد شغل");

                entity.Property(e => e.LendLaon).HasComment("وام قرض الحسنه");

                entity.Property(e => e.LendLoanRemain).HasComment("مانده وام قرض الحسنه");

                entity.Property(e => e.MiddleYearBonus).HasComment("پاداش میانسال");

                entity.Property(e => e.MinTaxedSalary).HasComment("حداقل حقوق مشمول مالیات");

                entity.Property(e => e.MonthTax).HasComment("مالیات ماه");

                entity.Property(e => e.NetPay).HasComment("خالص پرداخت");

                entity.Property(e => e.NightAmount).HasComment("مبلغ شب کاری");

                entity.Property(e => e.OtherLoan).HasComment("سایر وام ها");

                entity.Property(e => e.OtherLoanRemain).HasComment("مانده سایر وام ها");

                entity.Property(e => e.OverWorkAmount).HasComment("مبلغ اضافه کار");

                entity.Property(e => e.PermanentAlluanceAmount).HasComment("مبلغ بهره وری");

                entity.Property(e => e.RefInsuredIncome).HasComment("مبلغ بیمه سهم کار");

                entity.Property(e => e.Remain).HasComment("مانده مسکوک کسر");

                entity.Property(e => e.RemainLast).HasComment("مانده مذکوک اضافه");

                entity.Property(e => e.Salary).HasComment("حقوق کارکرد");

                entity.Property(e => e.Segration).HasComment("سنوات");

                entity.Property(e => e.ShiftCodeAmount).HasComment("مبلغ مزایای مستمر");

                entity.Property(e => e.TaxedIncome).HasComment("درآمد مشمول مالیات");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول شخص");

                entity.Property(e => e.UnEmploymentShare).HasComment("مبلغ بیمه بیکاری");

                entity.Property(e => e.UrgentLoan).HasComment("وام ضروری");

                entity.Property(e => e.UrgentLoanRemain).HasComment("مانده وام ضروری");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblProcesses)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Process_Tbl_Person");
            });

            modelBuilder.Entity<TblProcessingResult>(entity =>
            {
                entity.ToTable("Tbl_ProcessingResult");

                entity.HasComment("جدولی برای نمایش اطلاعات نتایج پردازش");

                entity.HasIndex(e => new { e.Date, e.TblPersonId }, "Date")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه نتایج پردازش");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پردازش حقوق");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نتایج پردازش");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نتایج پردازش");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نتایج پردازش");

                entity.Property(e => e.Status).HasComment("وضعیت نتایج پردازش");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblProcessingResults)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProcessingResult_Tbl_Person");
            });

            modelBuilder.Entity<TblProcessingResultFactor>(entity =>
            {
                entity.ToTable("Tbl_ProcessingResultFactor");

                entity.HasComment("جدولی برای نمایش اطلاعات نتایج پردازش");

                entity.Property(e => e.Id).HasComment("شناسه نتایج پردازش حقوق");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نتایج پردازش");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نتایج پردازش");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نتایج پردازش");

                entity.Property(e => e.KeyValue).HasComment("مقدار کلید انتخابی");

                entity.Property(e => e.Status).HasComment("وضعیت نتایج پردازش");

                entity.Property(e => e.TblKeyId)
                    .HasColumnName("Tbl_Key_Id")
                    .HasComment("آی دی عوامل پردازش از جدول عوامل پردازش");

                entity.Property(e => e.TblProcessingResultId)
                    .HasColumnName("Tbl_ProcessingResult_Id")
                    .HasComment("آی دی نتایج پردازش از جدول نتایج پردازش");

                entity.HasOne(d => d.TblProcessingResult)
                    .WithMany(p => p.TblProcessingResultFactors)
                    .HasForeignKey(d => d.TblProcessingResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProcessingResultFactor_Tbl_ProcessingResult");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.ToTable("Tbl_Product");

                entity.HasComment("جدولی برای نمایش اطلاعات نتایج محصولات");

                entity.Property(e => e.Id).HasComment("شناسه محصولات");

                entity.Property(e => e.BarCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("بارکد محصول");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد محصول");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف محصول");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول محصول");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول محصول");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام محصول");

                entity.Property(e => e.Status).HasComment("وضعیت محصول");

                entity.Property(e => e.TblCodingPatternId)
                    .HasColumnName("Tbl_CodingPattern_Id")
                    .HasComment("آی دی الگوی کدینگ از جدول الگوی کدینگ");

                entity.Property(e => e.TblCompanyId).HasColumnName("Tbl_Company_Id");

                entity.HasOne(d => d.TblCodingPattern)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.TblCodingPatternId)
                    .HasConstraintName("FK_Tbl_Product_Tbl_CodingPattern");

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Product_Tbl_Company");
            });

            modelBuilder.Entity<TblProductAlbum>(entity =>
            {
                entity.ToTable("Tbl_ProductAlbum");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblProductAlbumCategory>(entity =>
            {
                entity.ToTable("Tbl_ProductAlbumCategory");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TblProductAlbumId).HasColumnName("Tbl_ProductAlbum_Id");

                entity.HasOne(d => d.TblProductAlbum)
                    .WithMany(p => p.TblProductAlbumCategories)
                    .HasForeignKey(d => d.TblProductAlbumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductAlbumCategory_Tbl_ProductAlbum");
            });

            modelBuilder.Entity<TblProductAlbumDetail>(entity =>
            {
                entity.ToTable("Tbl_ProductAlbumDetails");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblProductAlbumCategoryId).HasColumnName("Tbl_ProductAlbumCategory_Id");

                entity.Property(e => e.TblRawMaterialProductId).HasColumnName("Tbl_RawMaterialProduct_Id");

                entity.HasOne(d => d.TblProductAlbumCategory)
                    .WithMany(p => p.TblProductAlbumDetails)
                    .HasForeignKey(d => d.TblProductAlbumCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductAlbumDetails_Tbl_ProductAlbumCategory");

                entity.HasOne(d => d.TblRawMaterialProduct)
                    .WithMany(p => p.TblProductAlbumDetails)
                    .HasForeignKey(d => d.TblRawMaterialProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductAlbumDetails_Tbl_RawMaterialProduct");
            });

            modelBuilder.Entity<TblProductAlbumDistribution>(entity =>
            {
                entity.ToTable("Tbl_ProductAlbumDistribution");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblPlaceTypeId).HasColumnName("Tbl_PlaceType_Id");

                entity.Property(e => e.TblProductAlbumHeaderId).HasColumnName("Tbl_ProductAlbumHeader_Id");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblProductAlbumDistributions)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductAlbumDistribution_Tbl_PlaceType");

                entity.HasOne(d => d.TblProductAlbumHeader)
                    .WithMany(p => p.TblProductAlbumDistributions)
                    .HasForeignKey(d => d.TblProductAlbumHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductAlbumDistribution_Tbl_ProductAlbumHeader");
            });

            modelBuilder.Entity<TblProductAlbumHeader>(entity =>
            {
                entity.ToTable("Tbl_ProductAlbumHeader");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblCodingPatternValueTypeId).HasColumnName("Tbl_CodingPatternValueType_Id");

                entity.Property(e => e.TblProductAlbumCategoryId).HasColumnName("Tbl_ProductAlbumCategory_Id");

                entity.HasOne(d => d.TblCodingPatternValueType)
                    .WithMany(p => p.TblProductAlbumHeaders)
                    .HasForeignKey(d => d.TblCodingPatternValueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductAlbumHeader_Tbl_CodingPatternValueType");

                entity.HasOne(d => d.TblProductAlbumCategory)
                    .WithMany(p => p.TblProductAlbumHeaders)
                    .HasForeignKey(d => d.TblProductAlbumCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductAlbumHeader_Tbl_ProductAlbumCategory");
            });

            modelBuilder.Entity<TblProductAlbumMoreInfo>(entity =>
            {
                entity.ToTable("Tbl_ProductAlbumMoreInfo");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblCodingPatternValueTypeId).HasColumnName("Tbl_CodingPatternValueType_Id");

                entity.Property(e => e.TblProductAlbumHeaderId).HasColumnName("Tbl_ProductAlbumHeader_Id");

                entity.HasOne(d => d.TblCodingPatternValueType)
                    .WithMany(p => p.TblProductAlbumMoreInfos)
                    .HasForeignKey(d => d.TblCodingPatternValueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductAlbumMoreInfo_Tbl_CodingPatternValueType");

                entity.HasOne(d => d.TblProductAlbumHeader)
                    .WithMany(p => p.TblProductAlbumMoreInfos)
                    .HasForeignKey(d => d.TblProductAlbumHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductAlbumMoreInfo_Tbl_ProductAlbumHeader");
            });

            modelBuilder.Entity<TblProductGallery>(entity =>
            {
                entity.ToTable("Tbl_ProductGallery");

                entity.Property(e => e.ContentType).HasMaxLength(100);

                entity.Property(e => e.Explanation).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(100)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.TblProductId).HasColumnName("Tbl_Product_Id");

                entity.HasOne(d => d.TblProduct)
                    .WithMany(p => p.TblProductGalleries)
                    .HasForeignKey(d => d.TblProductId)
                    .HasConstraintName("FK_Tbl_ProductGallery_Tbl_Product");
            });

            modelBuilder.Entity<TblProductionOrder>(entity =>
            {
                entity.ToTable("Tbl_ProductionOrder");

                entity.HasComment("سفارش تولید");

                entity.Property(e => e.Id).HasComment("شناسه سفارش تولید");

                entity.Property(e => e.Explanation).IsRequired();

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Number).HasComment("شماره سفارش تولید");
            });

            modelBuilder.Entity<TblProductionOrderAttachment>(entity =>
            {
                entity.ToTable("Tbl_ProductionOrderAttachment");

                entity.HasComment("پیوست سفارش تولید");

                entity.Property(e => e.Id).HasComment("شناسه پیوست سفارش تولید");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نوع پیوست سفارش تولید");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasComment("دیتای پیوست سفارش تولید");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("عنوان پیوست  سفارش تولید");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblProductionOrderId)
                    .HasColumnName("Tbl_ProductionOrder_Id")
                    .HasComment("شناسه سفارش تولید");

                entity.HasOne(d => d.TblProductionOrder)
                    .WithMany(p => p.TblProductionOrderAttachments)
                    .HasForeignKey(d => d.TblProductionOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderAttachment_Tbl_ProductionOrder");
            });

            modelBuilder.Entity<TblProductionOrderFinishedGoodProduct>(entity =>
            {
                entity.ToTable("Tbl_ProductionOrderFinishedGoodProducts");

                entity.HasComment("محصولات تولیدی در سفارش تولید");

                entity.Property(e => e.Id).HasComment(" شناسه محصولات تولیدی در سفارش تولید");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.OrderCount).HasComment("تعداد سفارش");

                entity.Property(e => e.ProductionCount).HasComment("تعداد محصول");

                entity.Property(e => e.TblFinishedGoodProductId)
                    .HasColumnName("Tbl_FinishedGoodProduct_Id")
                    .HasComment("شناسه محصول");

                entity.Property(e => e.TblProductionOrderId)
                    .HasColumnName("Tbl_ProductionOrder_Id")
                    .HasComment("شناسه سفارش تولید");

                entity.HasOne(d => d.TblFinishedGoodProduct)
                    .WithMany(p => p.TblProductionOrderFinishedGoodProducts)
                    .HasForeignKey(d => d.TblFinishedGoodProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderFinishedGoodProducts_Tbl_FinishedGoodProduct");

                entity.HasOne(d => d.TblProductionOrder)
                    .WithMany(p => p.TblProductionOrderFinishedGoodProducts)
                    .HasForeignKey(d => d.TblProductionOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderFinishedGoodProducts_Tbl_ProductionOrder");
            });

            modelBuilder.Entity<TblProductionOrderMoreInfo>(entity =>
            {
                entity.ToTable("Tbl_ProductionOrderMoreInfos");

                entity.HasComment("اطلاعات بیشتر در سفارش تولید");

                entity.Property(e => e.Id).HasComment("شناسه اطلاعات بیشتر در سفارش تولید");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblCodingPatternValueId)
                    .HasColumnName("Tbl_CodingPatternValue_Id")
                    .HasComment("شناسه الگو کد");

                entity.Property(e => e.TblProductionOrderId)
                    .HasColumnName("Tbl_ProductionOrder_Id")
                    .HasComment("شناسه سفارش تولید");

                entity.HasOne(d => d.TblProductionOrder)
                    .WithMany(p => p.TblProductionOrderMoreInfos)
                    .HasForeignKey(d => d.TblProductionOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderMoreInfos_Tbl_ProductionOrder");
            });

            modelBuilder.Entity<TblProductionOrderRawMaterialProduct>(entity =>
            {
                entity.ToTable("Tbl_ProductionOrderRawMaterialProducts");

                entity.HasComment("سفارش مواد اولیه");

                entity.Property(e => e.Id).HasComment("شتاسه سفارش مواد اولیه");

                entity.Property(e => e.Count).HasComment("تعداد");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblProductionOrderId)
                    .HasColumnName("Tbl_ProductionOrder_Id")
                    .HasComment("شناسه سفارش تولید");

                entity.Property(e => e.TblRawMaterialProductId)
                    .HasColumnName("Tbl_RawMaterialProduct_Id")
                    .HasComment("شناسه مواد اولیه");

                entity.HasOne(d => d.TblProductionOrder)
                    .WithMany(p => p.TblProductionOrderRawMaterialProducts)
                    .HasForeignKey(d => d.TblProductionOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderRawMaterialProducts_Tbl_ProductionOrder");

                entity.HasOne(d => d.TblRawMaterialProduct)
                    .WithMany(p => p.TblProductionOrderRawMaterialProducts)
                    .HasForeignKey(d => d.TblRawMaterialProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderRawMaterialProducts_Tbl_RawMaterialProduct");
            });

            modelBuilder.Entity<TblProductionOrderRawMaterialProductsDetail>(entity =>
            {
                entity.ToTable("Tbl_ProductionOrderRawMaterialProductsDetails");

                entity.HasComment("جزئیات سفارش مواد اولیه");

                entity.Property(e => e.Id).HasComment("شناسه جزئیات سفارش مواد اولیه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblProductionOrderFinishedGoodProductsId)
                    .HasColumnName("Tbl_ProductionOrderFinishedGoodProducts_Id")
                    .HasComment("شناسه محصول در سفارش تولید");

                entity.Property(e => e.TblProductionOrderRawMaterialProductsId)
                    .HasColumnName("Tbl_ProductionOrderRawMaterialProducts_Id")
                    .HasComment("شناسه مواد اولیه در سفارش تولید");

                entity.HasOne(d => d.TblProductionOrderFinishedGoodProducts)
                    .WithMany(p => p.TblProductionOrderRawMaterialProductsDetails)
                    .HasForeignKey(d => d.TblProductionOrderFinishedGoodProductsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderRawMaterialProductsDetails_Tbl_ProductionOrderFinishedGoodProducts");

                entity.HasOne(d => d.TblProductionOrderRawMaterialProducts)
                    .WithMany(p => p.TblProductionOrderRawMaterialProductsDetails)
                    .HasForeignKey(d => d.TblProductionOrderRawMaterialProductsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderRawMaterialProductsDetails_Tbl_ProductionOrderRawMaterialProducts");
            });

            modelBuilder.Entity<TblProductionOrderRawMaterialProductsDevelopment>(entity =>
            {
                entity.ToTable("Tbl_ProductionOrderRawMaterialProductsDevelopment");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblProductionOrderRawMaterialProductsId).HasColumnName("Tbl_ProductionOrderRawMaterialProducts_Id");

                entity.Property(e => e.TblRawMaterialProductDevelopmentId).HasColumnName("Tbl_RawMaterialProductDevelopment_Id");

                entity.HasOne(d => d.TblProductionOrderRawMaterialProducts)
                    .WithMany(p => p.TblProductionOrderRawMaterialProductsDevelopments)
                    .HasForeignKey(d => d.TblProductionOrderRawMaterialProductsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderRawMaterialProductsDevelopment_Tbl_ProductionOrderRawMaterialProducts");

                entity.HasOne(d => d.TblRawMaterialProductDevelopment)
                    .WithMany(p => p.TblProductionOrderRawMaterialProductsDevelopments)
                    .HasForeignKey(d => d.TblRawMaterialProductDevelopmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderRawMaterialProductsDevelopment_Tbl_RawMaterialProductDevelopment");
            });

            modelBuilder.Entity<TblProductionOrderRawMaterialProductsProgram>(entity =>
            {
                entity.ToTable("Tbl_ProductionOrderRawMaterialProductsProgram");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblProductionOrderRawMaterialProductsId).HasColumnName("Tbl_ProductionOrderRawMaterialProducts_Id");

                entity.Property(e => e.TblRawMaterialProductProgramId).HasColumnName("Tbl_RawMaterialProductProgram_Id");

                entity.HasOne(d => d.TblProductionOrderRawMaterialProducts)
                    .WithMany(p => p.TblProductionOrderRawMaterialProductsPrograms)
                    .HasForeignKey(d => d.TblProductionOrderRawMaterialProductsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderRawMaterialProductsProgram_Tbl_ProductionOrderRawMaterialProducts");

                entity.HasOne(d => d.TblRawMaterialProductProgram)
                    .WithMany(p => p.TblProductionOrderRawMaterialProductsPrograms)
                    .HasForeignKey(d => d.TblRawMaterialProductProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderRawMaterialProductsProgram_Tbl_RawMaterialProductProgram");
            });

            modelBuilder.Entity<TblProductionOrderTracking>(entity =>
            {
                entity.ToTable("Tbl_ProductionOrderTracking");

                entity.HasComment("پیگیری در سفارش تولید");

                entity.Property(e => e.Id).HasComment("شناسه پیگیری در سفارش تولید");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.IssueDateTime)
                    .HasColumnType("datetime")
                    .HasComment("تاریخ و ساعت ارسال از مبدا در سفارش تولید");

                entity.Property(e => e.ReceiveDateTime)
                    .HasColumnType("datetime")
                    .HasComment("تاریخ و ساعت ارسال از مقصد در سفارش تولید");

                entity.Property(e => e.TblCompanyIdAsIssuer)
                    .HasColumnName("Tbl_Company_IdAsIssuer")
                    .HasComment("شناسه شرکت مبدا در سفارش تولید");

                entity.Property(e => e.TblCompanyIdAsReceiver)
                    .HasColumnName("Tbl_Company_IdAsReceiver")
                    .HasComment("شناسه شرکت مقصد در سفارش تولید");

                entity.Property(e => e.TblPersonIdAsIssuer)
                    .HasColumnName("Tbl_Person_IdAsIssuer")
                    .HasComment("شناسه شخص مبدا در سفارش تولید");

                entity.Property(e => e.TblPersonIdAsReceiver)
                    .HasColumnName("Tbl_Person_IdAsReceiver")
                    .HasComment("شناسه شخص مقصد در سفارش تولید");

                entity.Property(e => e.TblPlaceTypeIdAsIssuer)
                    .HasColumnName("Tbl_PlaceType_IdAsIssuer")
                    .HasComment("شناسه واحد مبدا در سفارش تولید");

                entity.Property(e => e.TblPlaceTypeIdAsReceiver)
                    .HasColumnName("Tbl_PlaceType_IdAsReceiver")
                    .HasComment("شناسه واحد مقصد در سفارش تولید");

                entity.Property(e => e.TblProductionOrderId)
                    .HasColumnName("Tbl_ProductionOrder_Id")
                    .HasComment("شناسه سفارش تولید");

                entity.Property(e => e.TblProductionOrderTrackingTypeId)
                    .HasColumnName("Tbl_ProductionOrderTrackingType_Id")
                    .HasComment("شناسه نوع پیگیری در سفارش تولید");

                entity.HasOne(d => d.TblCompanyIdAsIssuerNavigation)
                    .WithMany(p => p.TblProductionOrderTrackingTblCompanyIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsIssuer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderTracking_Tbl_Company");

                entity.HasOne(d => d.TblCompanyIdAsReceiverNavigation)
                    .WithMany(p => p.TblProductionOrderTrackingTblCompanyIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsReceiver)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderTracking_Tbl_Company1");

                entity.HasOne(d => d.TblPersonIdAsIssuerNavigation)
                    .WithMany(p => p.TblProductionOrderTrackingTblPersonIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsIssuer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderTracking_Tbl_Person");

                entity.HasOne(d => d.TblPersonIdAsReceiverNavigation)
                    .WithMany(p => p.TblProductionOrderTrackingTblPersonIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsReceiver)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderTracking_Tbl_Person1");

                entity.HasOne(d => d.TblPlaceTypeIdAsIssuerNavigation)
                    .WithMany(p => p.TblProductionOrderTrackingTblPlaceTypeIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblPlaceTypeIdAsIssuer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderTracking_Tbl_PlaceType");

                entity.HasOne(d => d.TblPlaceTypeIdAsReceiverNavigation)
                    .WithMany(p => p.TblProductionOrderTrackingTblPlaceTypeIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblPlaceTypeIdAsReceiver)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderTracking_Tbl_PlaceType1");

                entity.HasOne(d => d.TblProductionOrder)
                    .WithMany(p => p.TblProductionOrderTrackings)
                    .HasForeignKey(d => d.TblProductionOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderTracking_Tbl_ProductionOrder");

                entity.HasOne(d => d.TblProductionOrderTrackingType)
                    .WithMany(p => p.TblProductionOrderTrackings)
                    .HasForeignKey(d => d.TblProductionOrderTrackingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProductionOrderTracking_Tbl_ProductionOrderTrackingType");
            });

            modelBuilder.Entity<TblProductionOrderTrackingType>(entity =>
            {
                entity.ToTable("Tbl_ProductionOrderTrackingType");

                entity.HasComment("نوع پیگیری در سفارش تولید");

                entity.Property(e => e.Id).HasComment("شناسه نوع پیگیری در سفارش تولید");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع پیگیری در سفارش تولید");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("عنوان نوع پیگیری در سفارش تولید");
            });

            modelBuilder.Entity<TblProject>(entity =>
            {
                entity.ToTable("Tbl_Project");

                entity.HasComment("جدولی برای نمایش اطلاعات پروژه");

                entity.Property(e => e.Id).HasComment("شناسه پروژه");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد پروژه");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان پروژه");

                entity.Property(e => e.EndTime).HasComment("زمان پایان پروژه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف پروژه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول پروژه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول پروژه");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام پروژه");

                entity.Property(e => e.OrderNumber).HasComment("شماره سفارش پروژه");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع پروژه");

                entity.Property(e => e.StartTime).HasComment("زمان شروع پروژه");

                entity.Property(e => e.Status).HasComment("وضعیت پروژه");

                entity.Property(e => e.TblPriorityId)
                    .HasColumnName("Tbl_Priority_Id")
                    .HasComment("آی دی اولویت از جدول اولویت");

                entity.HasOne(d => d.TblPriority)
                    .WithMany(p => p.TblProjects)
                    .HasForeignKey(d => d.TblPriorityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Project_Tbl_Priority");
            });

            modelBuilder.Entity<TblProjectTask>(entity =>
            {
                entity.ToTable("Tbl_ProjectTask");

                entity.HasComment("جدولی برای نمایش اطلاعات تسک پروژه");

                entity.HasIndex(e => new { e.TblProjectId, e.TblPriorityId, e.TblTaskTypeId, e.TblTaskStatusId, e.StartDate, e.EndDate, e.IsDeleted }, "NonClusteredIndex-20190218-092343")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه تسک پروژه");

                entity.Property(e => e.Code).HasComment("کد تسک پروژه");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasComment("شرح تسک پروژه");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان تسک پروژه");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasComment("زمان پایان تسک پروژه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف تسک پروژه");

                entity.Property(e => e.FinishDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول تسک پروژه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول تسک پروژه");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("نام تسک پروژه");

                entity.Property(e => e.OrderNumber).HasComment("شماره سفارش");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasComment("نتیجه تسک پروژه");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع تسک پروژه");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasComment("زمان شروع تسک پروژه");

                entity.Property(e => e.Status).HasComment("وضعیت تسک پروژه");

                entity.Property(e => e.TblPriorityId)
                    .HasColumnName("Tbl_Priority_Id")
                    .HasComment("آی دی اولویت از جدول اولویت");

                entity.Property(e => e.TblProjectId)
                    .HasColumnName("Tbl_Project_Id")
                    .HasComment("آی دی تسک پروژه از جدول تسک پروژه");

                entity.Property(e => e.TblTaskStatusId)
                    .HasColumnName("Tbl_TaskStatus_Id")
                    .HasComment("آی دی نوع وضعیت از جدول نوع وضعیت");

                entity.Property(e => e.TblTaskTypeId)
                    .HasColumnName("Tbl_TaskType_Id")
                    .HasComment("آی دی نوع تسک از جدول نوع تسک");

                entity.HasOne(d => d.TblPriority)
                    .WithMany(p => p.TblProjectTasks)
                    .HasForeignKey(d => d.TblPriorityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProjectTask_Tbl_Priority");

                entity.HasOne(d => d.TblProject)
                    .WithMany(p => p.TblProjectTasks)
                    .HasForeignKey(d => d.TblProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProjectTask_Tbl_Project");

                entity.HasOne(d => d.TblTaskStatus)
                    .WithMany(p => p.TblProjectTasks)
                    .HasForeignKey(d => d.TblTaskStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProjectTask_Tbl_TaskStatus");

                entity.HasOne(d => d.TblTaskType)
                    .WithMany(p => p.TblProjectTasks)
                    .HasForeignKey(d => d.TblTaskTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProjectTask_Tbl_TaskType");
            });

            modelBuilder.Entity<TblProjectTaskAttachment>(entity =>
            {
                entity.ToTable("Tbl_ProjectTaskAttachment");

                entity.HasIndex(e => new { e.TblProjectTaskId, e.TblPersonId }, "NonClusteredIndex-20190218-092413")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.ContentType).HasMaxLength(100);

                entity.Property(e => e.EndDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.Property(e => e.TblProjectTaskId).HasColumnName("Tbl_ProjectTask_Id");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblProjectTaskAttachments)
                    .HasForeignKey(d => d.TblPersonId)
                    .HasConstraintName("FK_Tbl_ProjectTaskAttachmen_Tbl_Person");

                entity.HasOne(d => d.TblProjectTask)
                    .WithMany(p => p.TblProjectTaskAttachments)
                    .HasForeignKey(d => d.TblProjectTaskId)
                    .HasConstraintName("FK_Tbl_ProjectTaskAttachmen_Tbl_ProjectTask");
            });

            modelBuilder.Entity<TblProjectTaskChat>(entity =>
            {
                entity.ToTable("Tbl_ProjectTaskChat");

                entity.HasIndex(e => new { e.TblProjectTaskId, e.TblPersonId, e.IsDeleted }, "NonClusteredIndex-20190218-092433")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.EndDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation).HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Message).HasMaxLength(400);

                entity.Property(e => e.StartDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.Property(e => e.TblProjectTaskId).HasColumnName("Tbl_ProjectTask_Id");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblProjectTaskChats)
                    .HasForeignKey(d => d.TblPersonId)
                    .HasConstraintName("FK_Tbl_ProjectTaskChat_Tbl_Person");

                entity.HasOne(d => d.TblProjectTask)
                    .WithMany(p => p.TblProjectTaskChats)
                    .HasForeignKey(d => d.TblProjectTaskId)
                    .HasConstraintName("FK_Tbl_ProjectTaskChat_Tbl_ProjectTask");
            });

            modelBuilder.Entity<TblProjectTaskRecipient>(entity =>
            {
                entity.ToTable("Tbl_ProjectTaskRecipient");

                entity.HasIndex(e => new { e.TblProjectTaskId, e.TblPersonIdAsLogin, e.TblPersonId, e.Type, e.IsDeleted }, "NonClusteredIndex-20190218-092454")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblProjectTaskId, e.IsDeleted }, "NonClusteredIndex-20190507-161527")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.IsDeleted, "NonClusteredIndex-20190508-081613")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblProjectTaskId, e.IsDeleted, e.Id }, "_dta_index_Tbl_ProjectTaskRecipient_16_1152215355__K2_K14_K1_3_4_5_6_7_8_9_10_11_12_13")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblPersonId, e.Status, e.Type, e.IsDeleted }, "_dta_index_Tbl_ProjectTaskRecipient_16_1152215355__K4_K11_K5_K14_1_2")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.TblPersonId, e.TblProjectTaskId }, "_dta_index_Tbl_ProjectTaskRecipient_16_1152215355__K4_K2")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.Property(e => e.TblPersonIdAsLogin).HasColumnName("Tbl_Person_IdAsLogin");

                entity.Property(e => e.TblProjectTaskId).HasColumnName("Tbl_ProjectTask_Id");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblProjectTaskRecipientTblPeople)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProjectTaskRecipient_Tbl_Person1");

                entity.HasOne(d => d.TblPersonIdAsLoginNavigation)
                    .WithMany(p => p.TblProjectTaskRecipientTblPersonIdAsLoginNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsLogin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProjectTaskRecipient_Tbl_Person");

                entity.HasOne(d => d.TblProjectTask)
                    .WithMany(p => p.TblProjectTaskRecipients)
                    .HasForeignKey(d => d.TblProjectTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProjectTaskRecepent_Tbl_ProjectTask");
            });

            modelBuilder.Entity<TblProjectTaskTag>(entity =>
            {
                entity.ToTable("Tbl_ProjectTaskTag");

                entity.HasComment("جدولی برای نمایش اطلاعات تگ تسک پروژه");

                entity.Property(e => e.Id).HasComment("شناسه تگ تسک پروژه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف تگ تسک پروژه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول تگ تسک پروژه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول تگ تسک پروژه");

                entity.Property(e => e.Status).HasComment("وضعیت تگ تسک پروژه");

                entity.Property(e => e.TblProjectTaskId)
                    .HasColumnName("Tbl_ProjectTask_Id")
                    .HasComment("آی دی تسک پروژه از جدول تسک پروژه");

                entity.Property(e => e.TblTagId)
                    .HasColumnName("Tbl_Tag_Id")
                    .HasComment("آی دی تگ از جدول تگ");

                entity.HasOne(d => d.TblProjectTask)
                    .WithMany(p => p.TblProjectTaskTags)
                    .HasForeignKey(d => d.TblProjectTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProjectTaskTag_Tbl_ProjectTask");

                entity.HasOne(d => d.TblTag)
                    .WithMany(p => p.TblProjectTaskTags)
                    .HasForeignKey(d => d.TblTagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ProjectTaskTag_Tbl_Tag");
            });

            modelBuilder.Entity<TblProvince>(entity =>
            {
                entity.ToTable("Tbl_Province");

                entity.HasComment("جدولی برای نمایش اطلاعات استان");

                entity.Property(e => e.Id).HasComment(" استان");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف استان");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول استان");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول استان");

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.ProvinceCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد استان");

                entity.Property(e => e.ProvinceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام استان");

                entity.Property(e => e.Status).HasComment("وضعیت استان");

                entity.Property(e => e.TblCountryId)
                    .HasColumnName("Tbl_Country_Id")
                    .HasComment("آی دی کشور از جدول کشور");

                entity.HasOne(d => d.TblCountry)
                    .WithMany(p => p.TblProvinces)
                    .HasForeignKey(d => d.TblCountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Province_Tbl_Country");
            });

            modelBuilder.Entity<TblPsychologyType>(entity =>
            {
                entity.ToTable("Tbl_PsychologyTypes");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع شخصیت شناسی  ");

                entity.Property(e => e.Id).HasComment("شناسه شخصیت شناسی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع شخصیت شناسی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع شخصیت شناسی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع شخصیت شناسی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع شخصیت شناسی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نوع شخصیت شناسی");

                entity.Property(e => e.Status).HasComment("وضعیت نوع شخصیت شناسی");
            });

            modelBuilder.Entity<TblRawMaterialAlbum>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialAlbum");

                entity.Property(e => e.Id).HasComment("شناسه توانایی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.GarmentType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.TblRawMaterialProductId)
                    .HasColumnName("Tbl_RawMaterialProduct_Id")
                    .HasComment("کد توانایی");

                entity.HasOne(d => d.TblRawMaterialProduct)
                    .WithMany(p => p.TblRawMaterialAlbums)
                    .HasForeignKey(d => d.TblRawMaterialProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialAlbum_Tbl_RawMaterialProduct");
            });

            modelBuilder.Entity<TblRawMaterialAlbumDesign>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialAlbumDesign");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TblCodingPatternValueId).HasColumnName("Tbl_CodingPatternValue_Id");

                entity.Property(e => e.TblRawMaterialAlbumId).HasColumnName("Tbl_RawMaterialAlbum_Id");

                entity.HasOne(d => d.TblRawMaterialAlbum)
                    .WithMany(p => p.TblRawMaterialAlbumDesigns)
                    .HasForeignKey(d => d.TblRawMaterialAlbumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialAlbumDesign_Tbl_RawMaterialAlbum");
            });

            modelBuilder.Entity<TblRawMaterialAlbumDistribution>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialAlbumDistribution");

                entity.Property(e => e.Id).HasComment("شناسه توانایی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.TblPlaceTypeId)
                    .HasColumnName("Tbl_PlaceType_Id")
                    .HasComment("نام توانایی");

                entity.Property(e => e.TblRawMaterialAlbumId)
                    .HasColumnName("Tbl_RawMaterialAlbum_Id")
                    .HasComment("کد توانایی");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblRawMaterialAlbumDistributions)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialAlbumDistribution_Tbl_PlaceType");

                entity.HasOne(d => d.TblRawMaterialAlbum)
                    .WithMany(p => p.TblRawMaterialAlbumDistributions)
                    .HasForeignKey(d => d.TblRawMaterialAlbumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialAlbumDistribution_Tbl_RawMaterialAlbum");
            });

            modelBuilder.Entity<TblRawMaterialBeginPeriod>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialBeginPeriod");

                entity.Property(e => e.Id).HasComment("شناسایی شروع دوره");

                entity.Property(e => e.Count).HasComment("تعداد شروع دوره");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع دوره");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف شروع دوره");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول شروع دوره");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در چدول شروع دوره");

                entity.Property(e => e.Price).HasComment("قیمت شروع دوره");

                entity.Property(e => e.Status).HasComment("وضعیت شروع دوره");

                entity.Property(e => e.TblPlaceTypeId).HasColumnName("Tbl_PlaceType_Id");

                entity.Property(e => e.TblRawMaterialProductId)
                    .HasColumnName("Tbl_RawMaterialProduct_Id")
                    .HasComment("آی دی محصول از جدول محصول");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblRawMaterialBeginPeriods)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialBeginPeriod_Tbl_PlaceType");

                entity.HasOne(d => d.TblRawMaterialProduct)
                    .WithMany(p => p.TblRawMaterialBeginPeriods)
                    .HasForeignKey(d => d.TblRawMaterialProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialBeginPeriod_Tbl_RawMaterialProduct");
            });

            modelBuilder.Entity<TblRawMaterialProduct>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialProduct");

                entity.Property(e => e.Id).HasComment("شناسه محصولات");

                entity.Property(e => e.BarCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("بارکد محصول");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد محصول");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف محصول");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول محصول");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول محصول");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام محصول");

                entity.Property(e => e.Status).HasComment("وضعیت محصول");

                entity.Property(e => e.TblCodingPatternId)
                    .HasColumnName("Tbl_CodingPattern_Id")
                    .HasComment("آی دی الگوی کدینگ از جدول الگوی کدینگ");

                entity.Property(e => e.TblCompanyId).HasColumnName("Tbl_Company_Id");

                entity.Property(e => e.TblCompanyIdAsSupplier).HasColumnName("Tbl_Company_IdAsSupplier");

                entity.HasOne(d => d.TblCodingPattern)
                    .WithMany(p => p.TblRawMaterialProducts)
                    .HasForeignKey(d => d.TblCodingPatternId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialProduct_Tbl_CodingPattern");

                entity.HasOne(d => d.TblCompany)
                    .WithMany(p => p.TblRawMaterialProductTblCompanies)
                    .HasForeignKey(d => d.TblCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialProduct_Tbl_Company");

                entity.HasOne(d => d.TblCompanyIdAsSupplierNavigation)
                    .WithMany(p => p.TblRawMaterialProductTblCompanyIdAsSupplierNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsSupplier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialProduct_Tbl_Company1");
            });

            modelBuilder.Entity<TblRawMaterialProductComposition>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialProductComposition");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblRawMaterialProductCompositionTypeId).HasColumnName("Tbl_RawMaterialProductCompositionType_Id");

                entity.Property(e => e.TblRawMaterialProductId).HasColumnName("Tbl_RawMaterialProduct_Id");

                entity.HasOne(d => d.TblRawMaterialProductCompositionType)
                    .WithMany(p => p.TblRawMaterialProductCompositions)
                    .HasForeignKey(d => d.TblRawMaterialProductCompositionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialProductComposition_Tbl_RawMaterialProductCompositionType");

                entity.HasOne(d => d.TblRawMaterialProduct)
                    .WithMany(p => p.TblRawMaterialProductCompositions)
                    .HasForeignKey(d => d.TblRawMaterialProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialProductComposition_Tbl_RawMaterialProduct");
            });

            modelBuilder.Entity<TblRawMaterialProductCompositionType>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialProductCompositionType");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblRawMaterialProductDevelopment>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialProductDevelopment");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblRawMaterialProductAsConsumingMaterialId).HasColumnName("Tbl_RawMaterialProductAsConsumingMaterial_Id");

                entity.Property(e => e.TblRawMaterialProductDevelopmentTypeId).HasColumnName("Tbl_RawMaterialProductDevelopmentType_Id");

                entity.Property(e => e.TblRawMaterialProductId).HasColumnName("Tbl_RawMaterialProduct_Id");

                entity.HasOne(d => d.TblRawMaterialProductAsConsumingMaterial)
                    .WithMany(p => p.TblRawMaterialProductDevelopmentTblRawMaterialProductAsConsumingMaterials)
                    .HasForeignKey(d => d.TblRawMaterialProductAsConsumingMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialProductDevelopment_Tbl_RawMaterialProduct1");

                entity.HasOne(d => d.TblRawMaterialProductDevelopmentType)
                    .WithMany(p => p.TblRawMaterialProductDevelopments)
                    .HasForeignKey(d => d.TblRawMaterialProductDevelopmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialProductDevelopment_Tbl_RawMaterialProductDevelopmentType");

                entity.HasOne(d => d.TblRawMaterialProduct)
                    .WithMany(p => p.TblRawMaterialProductDevelopmentTblRawMaterialProducts)
                    .HasForeignKey(d => d.TblRawMaterialProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialProductDevelopment_Tbl_RawMaterialProduct");
            });

            modelBuilder.Entity<TblRawMaterialProductDevelopmentType>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialProductDevelopmentType");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblRawMaterialProductGallery>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialProductGallery");

                entity.Property(e => e.ContentType).HasMaxLength(100);

                entity.Property(e => e.Explanation).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(100)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.TblRawMaterialProductId).HasColumnName("Tbl_RawMaterialProduct_Id");

                entity.HasOne(d => d.TblRawMaterialProduct)
                    .WithMany(p => p.TblRawMaterialProductGalleries)
                    .HasForeignKey(d => d.TblRawMaterialProductId)
                    .HasConstraintName("FK_Tbl_RawMaterialProductGallery_Tbl_RawMaterialProduct");
            });

            modelBuilder.Entity<TblRawMaterialProductProgram>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialProductProgram");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblRawMaterialProductId).HasColumnName("Tbl_RawMaterialProduct_Id");

                entity.Property(e => e.TblRawMaterialProductProgramParameterId).HasColumnName("Tbl_RawMaterialProductProgramParameter_Id");

                entity.HasOne(d => d.TblRawMaterialProduct)
                    .WithMany(p => p.TblRawMaterialProductPrograms)
                    .HasForeignKey(d => d.TblRawMaterialProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialProductProgram_Tbl_RawMaterialProduct");

                entity.HasOne(d => d.TblRawMaterialProductProgramParameter)
                    .WithMany(p => p.TblRawMaterialProductPrograms)
                    .HasForeignKey(d => d.TblRawMaterialProductProgramParameterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialProductProgram_Tbl_RawMaterialProductProgramParameter");
            });

            modelBuilder.Entity<TblRawMaterialProductProgramParameter>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialProductProgramParameter");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TblRawMaterialProductProgramTypeId).HasColumnName("Tbl_RawMaterialProductProgramType_Id");

                entity.HasOne(d => d.TblRawMaterialProductProgramType)
                    .WithMany(p => p.TblRawMaterialProductProgramParameters)
                    .HasForeignKey(d => d.TblRawMaterialProductProgramTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialProductProgramParameter_Tbl_RawMaterialProductProgramType");
            });

            modelBuilder.Entity<TblRawMaterialProductProgramType>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialProductProgramType");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblRawMaterialStockSheet>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialStockSheet");

                entity.HasIndex(e => new { e.TblCompanyIdAsOwner, e.IsDeleted, e.TblRawMaterialStockSheetTypeId, e.Date, e.Id }, "_dta_index_Tbl_RawMaterialStockSheet_29_1678785188__K2_K18_K9_K13_K1")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه منحصر به فرد برگه های انبار");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ برگه های انبار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف برگه های انبار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول برگه های انبار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول برگه های انبار");

                entity.Property(e => e.SheetIndex).HasComment("فهرست برگه");

                entity.Property(e => e.SheetNumber).HasComment("شماره برگه");

                entity.Property(e => e.Status).HasComment("وضعیت برگه های انبار");

                entity.Property(e => e.TblCompanyIdAsIssuer)
                    .HasColumnName("Tbl_Company_IdAsIssuer")
                    .HasComment("شناسه منحصر به فرد شرکت تحویل دهنده");

                entity.Property(e => e.TblCompanyIdAsOwner).HasColumnName("Tbl_Company_IdAsOwner");

                entity.Property(e => e.TblCompanyIdAsReceiver)
                    .HasColumnName("Tbl_Company_IdAsReceiver")
                    .HasComment("شناسه منحصر به فرد شرکت تحویل گیرنده");

                entity.Property(e => e.TblPersonIdAsIssuer)
                    .HasColumnName("Tbl_Person_IdAsIssuer")
                    .HasComment("شناسه منحصر به فرد تحویل دهنده");

                entity.Property(e => e.TblPersonIdAsReceiver)
                    .HasColumnName("Tbl_Person_IdAsReceiver")
                    .HasComment("شناسه منحصر به فرد تحویل گیرنده");

                entity.Property(e => e.TblPlaceTypeIdAsIssuer)
                    .HasColumnName("Tbl_PlaceType_IdAsIssuer")
                    .HasComment("شناسه منحصر به فرد محل تحویل دهنده");

                entity.Property(e => e.TblPlaceTypeIdAsReceiver)
                    .HasColumnName("Tbl_PlaceType_IdAsReceiver")
                    .HasComment("شناسه منحصر به فرد تحویل گیرنده");

                entity.Property(e => e.TblRawMaterialStockSheetSubTypeId)
                    .HasColumnName("Tbl_RawMaterialStockSheetSubType_Id")
                    .HasComment("نوع فرعی برگه");

                entity.Property(e => e.TblRawMaterialStockSheetTypeId)
                    .HasColumnName("Tbl_RawMaterialStockSheetType_Id")
                    .HasComment("نوع اصلی برگه");

                entity.HasOne(d => d.TblCompanyIdAsIssuerNavigation)
                    .WithMany(p => p.TblRawMaterialStockSheetTblCompanyIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsIssuer)
                    .HasConstraintName("FK_Tbl_RawMaterialStockSheet_Tbl_Company2");

                entity.HasOne(d => d.TblCompanyIdAsOwnerNavigation)
                    .WithMany(p => p.TblRawMaterialStockSheetTblCompanyIdAsOwnerNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsOwner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialStockSheet_Tbl_Company");

                entity.HasOne(d => d.TblCompanyIdAsReceiverNavigation)
                    .WithMany(p => p.TblRawMaterialStockSheetTblCompanyIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsReceiver)
                    .HasConstraintName("FK_Tbl_RawMaterialStockSheet_Tbl_Company1");

                entity.HasOne(d => d.TblPersonIdAsIssuerNavigation)
                    .WithMany(p => p.TblRawMaterialStockSheetTblPersonIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsIssuer)
                    .HasConstraintName("FK_Tbl_RawMaterialStockSheet_Tbl_Person1");

                entity.HasOne(d => d.TblPersonIdAsReceiverNavigation)
                    .WithMany(p => p.TblRawMaterialStockSheetTblPersonIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsReceiver)
                    .HasConstraintName("FK_Tbl_RawMaterialStockSheet_Tbl_Person");

                entity.HasOne(d => d.TblPlaceTypeIdAsIssuerNavigation)
                    .WithMany(p => p.TblRawMaterialStockSheetTblPlaceTypeIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblPlaceTypeIdAsIssuer)
                    .HasConstraintName("FK_Tbl_RawMaterialStockSheet_Tbl_PlaceType1");

                entity.HasOne(d => d.TblPlaceTypeIdAsReceiverNavigation)
                    .WithMany(p => p.TblRawMaterialStockSheetTblPlaceTypeIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblPlaceTypeIdAsReceiver)
                    .HasConstraintName("FK_Tbl_RawMaterialStockSheet_Tbl_PlaceType");

                entity.HasOne(d => d.TblRawMaterialStockSheetSubType)
                    .WithMany(p => p.TblRawMaterialStockSheets)
                    .HasForeignKey(d => d.TblRawMaterialStockSheetSubTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialStockSheet_Tbl_RawMaterialStockSheetSubType");

                entity.HasOne(d => d.TblRawMaterialStockSheetType)
                    .WithMany(p => p.TblRawMaterialStockSheets)
                    .HasForeignKey(d => d.TblRawMaterialStockSheetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialStockSheet_Tbl_RawMaterialStockSheetType");
            });

            modelBuilder.Entity<TblRawMaterialStockSheetItem>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialStockSheetItem");

                entity.HasIndex(e => new { e.IsDeleted, e.TblRawMaterailStockSheetId, e.TblRawMaterialProductId }, "_dta_index_Tbl_RawMaterialStockSheetItem_29_1067307012__K12_K2_K3_4_5")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه آیتم برگه انبار");

                entity.Property(e => e.Count).HasComment("تعداد آیتم برگه انبار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف آیتم برگه انبار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول  آیتم برگه انبار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول آیتم برگه انبار");

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Price).HasComment("قیمت آیتم برگه انبار");

                entity.Property(e => e.Status).HasComment("وضعیت آیتم برگه انبار");

                entity.Property(e => e.TblInvoiceSlaveId).HasColumnName("Tbl_InvoiceSlave_Id");

                entity.Property(e => e.TblOrderHeaderId).HasColumnName("Tbl_OrderHeader_Id");

                entity.Property(e => e.TblProductionOrderRawMaterialProductsId).HasColumnName("Tbl_ProductionOrderRawMaterialProducts_Id");

                entity.Property(e => e.TblRawMaterailStockSheetId)
                    .HasColumnName("Tbl_RawMaterailStockSheet_Id")
                    .HasComment("آی دی برگه انبار از جدول برگه انبار");

                entity.Property(e => e.TblRawMaterialProductId)
                    .HasColumnName("Tbl_RawMaterialProduct_Id")
                    .HasComment("آی دی محصول از جدول محصول");

                entity.HasOne(d => d.TblInvoiceSlave)
                    .WithMany(p => p.TblRawMaterialStockSheetItems)
                    .HasForeignKey(d => d.TblInvoiceSlaveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialStockSheetItem_Tbl_InvoiceSlave");

                entity.HasOne(d => d.TblOrderHeader)
                    .WithMany(p => p.TblRawMaterialStockSheetItems)
                    .HasForeignKey(d => d.TblOrderHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialStockSheetItem_Tbl_OrderHeader");

                entity.HasOne(d => d.TblProductionOrderRawMaterialProducts)
                    .WithMany(p => p.TblRawMaterialStockSheetItems)
                    .HasForeignKey(d => d.TblProductionOrderRawMaterialProductsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialStockSheetItem_Tbl_ProductionOrderRawMaterialProducts");

                entity.HasOne(d => d.TblRawMaterailStockSheet)
                    .WithMany(p => p.TblRawMaterialStockSheetItems)
                    .HasForeignKey(d => d.TblRawMaterailStockSheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialStockSheetItem_Tbl_RawMaterialStockSheet");

                entity.HasOne(d => d.TblRawMaterialProduct)
                    .WithMany(p => p.TblRawMaterialStockSheetItems)
                    .HasForeignKey(d => d.TblRawMaterialProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialStockSheetItem_Tbl_RawMaterialProduct");
            });

            modelBuilder.Entity<TblRawMaterialStockSheetSubType>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialStockSheetSubType");

                entity.Property(e => e.Id).HasComment("شناسه توانایی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد توانایی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.TblRawMaterialStockSheetTypeId).HasColumnName("Tbl_RawMaterialStockSheetType_Id");

                entity.HasOne(d => d.TblRawMaterialStockSheetType)
                    .WithMany(p => p.TblRawMaterialStockSheetSubTypes)
                    .HasForeignKey(d => d.TblRawMaterialStockSheetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RawMaterialStockSheetSubType_Tbl_RawMaterialStockSheetType");
            });

            modelBuilder.Entity<TblRawMaterialStockSheetType>(entity =>
            {
                entity.ToTable("Tbl_RawMaterialStockSheetType");

                entity.Property(e => e.Id).HasComment("شناسه توانایی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد توانایی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");
            });

            modelBuilder.Entity<TblReason>(entity =>
            {
                entity.ToTable("Tbl_Reason");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblRegistrarType>(entity =>
            {
                entity.ToTable("Tbl_RegistrarType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع ثبت نام  ");

                entity.Property(e => e.Id).HasComment("شناسه نوع ثبت نام");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع ثبت نام");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع ثبت نام");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع ثبت نام");

                entity.Property(e => e.RegistrarTypeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("کد نوع ثبت نام");

                entity.Property(e => e.RegistrarTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نوع ثبت نام");

                entity.Property(e => e.Status).HasComment("وضعیت نوع ثبت نام");
            });

            modelBuilder.Entity<TblRelationType>(entity =>
            {
                entity.ToTable("Tbl_RelationType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع ارتباط  ");

                entity.Property(e => e.Id).HasComment("شناسه نوع ارتباط");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع ارتباط");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع ارتباط");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع ارتباط");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع ارتباط");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع ارتباط");

                entity.Property(e => e.Status).HasComment("وضعیت نوع ارتباط");
            });

            modelBuilder.Entity<TblReligion>(entity =>
            {
                entity.ToTable("Tbl_Religion");

                entity.HasComment("جدولی برای نمایش اطلاعات مذهب");

                entity.Property(e => e.Id).HasComment("شناسه مذهب");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد مذهب");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف مذهب");

                entity.Property(e => e.Guid).HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول مذهب");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول مذهب");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام مذهب");

                entity.Property(e => e.Status).HasComment("وضعیت مذهب");
            });

            modelBuilder.Entity<TblRemainType>(entity =>
            {
                entity.ToTable("Tbl_RemainType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع مانده");

                entity.Property(e => e.Id).HasComment("شناسه نوع مانده");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع مانده");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع مانده");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع مانده");

                entity.Property(e => e.RemainTypeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("کد نوع مانده");

                entity.Property(e => e.RemainTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع مانده");

                entity.Property(e => e.Status).HasComment("وضعیت نوع مانده");
            });

            modelBuilder.Entity<TblReportDetail>(entity =>
            {
                entity.ToTable("Tbl_ReportDetail");

                entity.HasComment("جدولی برای نمایش اطلاعات جزئیات گزارش");

                entity.Property(e => e.Id).HasComment("شناسه جزئیات گزارش");

                entity.Property(e => e.DetailName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام جزئیات گزارش");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف جزئیات گزارش");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول جزئیات گزارش");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول جزئیات گزارش");

                entity.Property(e => e.Status).HasComment("وضعیت جزئیات گزارش");

                entity.Property(e => e.TblReportHeaderId)
                    .HasColumnName("Tbl_ReportHeader_Id")
                    .HasComment("آی دی سرفصل گزارش از جدول سرفصل گزارش ");

                entity.HasOne(d => d.TblReportHeader)
                    .WithMany(p => p.TblReportDetails)
                    .HasForeignKey(d => d.TblReportHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ReportDetail_Tbl_ReportHeader");
            });

            modelBuilder.Entity<TblReportDetailItem>(entity =>
            {
                entity.ToTable("Tbl_ReportDetailItem");

                entity.HasComment("جدولی برای نمایش اطلاعات آیتم جزئیات گزارش");

                entity.Property(e => e.Id).HasComment("شناسه آیتم جزئیات گزارش");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف آیتم جزئیات گزارش");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول آیتم جزئیات گزارش");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول جزئیات گزارش");

                entity.Property(e => e.Status).HasComment("وضعیت آیتم جزئیات گزارش");

                entity.Property(e => e.TblFormulaHeaderId)
                    .HasColumnName("Tbl_FormulaHeader_Id")
                    .HasComment("آی دی سرفصل فرمول از جدول سرفصل فرمول");

                entity.Property(e => e.TblReportDetailId)
                    .HasColumnName("Tbl_ReportDetail_Id")
                    .HasComment("آی دی جزئیات گزارش از جدول جزئیات گزارش");

                entity.HasOne(d => d.TblReportDetail)
                    .WithMany(p => p.TblReportDetailItems)
                    .HasForeignKey(d => d.TblReportDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ReportDetailItem_Tbl_ReportDetail");
            });

            modelBuilder.Entity<TblReportDetailItemYear>(entity =>
            {
                entity.ToTable("Tbl_ReportDetailItemYear");

                entity.HasComment("جدولی برای نمایش اطلاعات آیتم جزئیات گزارش سالانه");

                entity.Property(e => e.Id).HasComment("شناسه آیتم جزئیات گزارش سالانه");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ آیتم جزئیات گزارش سالانه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف آیتم جزئیات گزارش سالانه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول آیتم جزئیات گزارش سالانه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول آیتم جزئیات گزارش سالانه");

                entity.Property(e => e.Status).HasComment("وضعیت آیتم جزئیات گزارش سالانه");

                entity.Property(e => e.TblReportDetailItemId)
                    .HasColumnName("Tbl_ReportDetailItem_Id")
                    .HasComment("آی دی آیتم جزئیات گزارش از جدول  آیتم جزئیات گزارش ");

                entity.HasOne(d => d.TblReportDetailItem)
                    .WithMany(p => p.TblReportDetailItemYears)
                    .HasForeignKey(d => d.TblReportDetailItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ReportDetailItemYear_Tbl_ReportDetailItem");
            });

            modelBuilder.Entity<TblReportHeader>(entity =>
            {
                entity.ToTable("Tbl_ReportHeader");

                entity.HasComment("جدولی برای نمایش اطلاعات سرفصل گزارش");

                entity.Property(e => e.Id).HasComment("شناسه سرفصل گزارش");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف سرفصل گزارش");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول سرفصل گزارش");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول سرفصل گزارش");

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام گزارش");

                entity.Property(e => e.Status).HasComment("وضعیت سرفصل گزارش");

                entity.Property(e => e.TblReportTypeId)
                    .HasColumnName("Tbl_ReportType_Id")
                    .HasComment("آی دی نوع گزارش از جدول نوع گزارش  ");

                entity.HasOne(d => d.TblReportType)
                    .WithMany(p => p.TblReportHeaders)
                    .HasForeignKey(d => d.TblReportTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ReportHeader_Tbl_ReportType");
            });

            modelBuilder.Entity<TblReportType>(entity =>
            {
                entity.ToTable("Tbl_ReportType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع گزارش");

                entity.Property(e => e.Id).HasComment("شناسه نوع گزارش");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع گزارش");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول نوع گزارش");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع گزارش");

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام گزارش");

                entity.Property(e => e.ReportType).HasComment("نوع گزارش");

                entity.Property(e => e.Status).HasComment("وضعیت نوع گزارش");
            });

            modelBuilder.Entity<TblResponsibility>(entity =>
            {
                entity.ToTable("Tbl_Responsibility");

                entity.HasComment("جدولی برای نمایش اطلاعات مسئوليت ها");

                entity.Property(e => e.Id).HasComment("شناسه مسئوليت");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("کد مسئوليت");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف مسئوليت");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول مسئوليت");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول مسئوليت");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("نام مسئوليت");

                entity.Property(e => e.Status).HasComment("وضعیت مسئوليت");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("نوع مسئوليت");
            });

            modelBuilder.Entity<TblResponsibilityTask>(entity =>
            {
                entity.ToTable("Tbl_ResponsibilityTask");

                entity.HasComment("جدولی برای نمایش اطلاعات تسک مسئوليت ها");

                entity.Property(e => e.Id).HasComment("شناسه تسک مسئوليت ");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("کد تسک مسئوليت");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف تسک مسئوليت");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول تسک مسئوليت");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول تسک مسئوليت");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasComment("نام تسک مسئوليت");

                entity.Property(e => e.Status).HasComment("وضعیت تسک مسئوليت");

                entity.Property(e => e.TblResponsibilityId)
                    .HasColumnName("Tbl_Responsibility_Id")
                    .HasComment("آی دی مسئوليت از جدول مسئوليت");

                entity.HasOne(d => d.TblResponsibility)
                    .WithMany(p => p.TblResponsibilityTasks)
                    .HasForeignKey(d => d.TblResponsibilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ResponsibilityTask_Tbl_Responsibility");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.ToTable("Tbl_Role");

                entity.HasComment("جدولی برای نمایش اطلاعات نقش ها");

                entity.HasIndex(e => e.IsDeleted, "NonClusteredIndex-20190507-174238")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه نقش");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نقش");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نقش");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول نقش");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نقش");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نقش");

                entity.Property(e => e.Status).HasComment("وضعیت نقش");
            });

            modelBuilder.Entity<TblRolePermision>(entity =>
            {
                entity.ToTable("Tbl_RolePermision");

                entity.HasComment("جدولی برای نمایش اطلاعات دسترسی نقش ها");

                entity.Property(e => e.Id).HasComment(" دسترسی نقش ها");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد دسترسی نقش");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف دسترسی نقش");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول دسترسی نقش");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول دسترسی نقش");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام دسترسی نقش");

                entity.Property(e => e.Status).HasComment("وضعیت دسترسی نقش");

                entity.Property(e => e.TblRoleId)
                    .HasColumnName("Tbl_Role_Id")
                    .HasComment("آی دی نقش از جدول نقش");

                entity.HasOne(d => d.TblRole)
                    .WithMany(p => p.TblRolePermisions)
                    .HasForeignKey(d => d.TblRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_RolePermision_Tbl_Role");
            });

            modelBuilder.Entity<TblRoleTypesMatrix>(entity =>
            {
                entity.HasKey(e => new { e.Dim1, e.Dim2 })
                    .HasName("PK_Tbl_RoleTypeMatrix");

                entity.ToTable("Tbl_RoleTypesMatrix");
            });

            modelBuilder.Entity<TblSafe>(entity =>
            {
                entity.ToTable("Tbl_Safe");

                entity.HasComment("جدولی برای نمایش اطلاعات صندوق ها");

                entity.Property(e => e.Id).HasComment("شناسه صندوق");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد صندوق");

                entity.Property(e => e.EstablishmentDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("ایجاد تاریخ صندوق");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف صندوق");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.InitialBalance).HasComment("موجودی اولیه صندوق");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول صندوق");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول صندوق");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام صندوق");

                entity.Property(e => e.Status).HasComment("وضعیت صندوق");

                entity.Property(e => e.TblFinancialCycleId)
                    .HasColumnName("Tbl_FinancialCycle_Id")
                    .HasComment("آی دی چرخه مالی از جدول چرخه مالی  ");

                entity.HasOne(d => d.TblFinancialCycle)
                    .WithMany(p => p.TblSaves)
                    .HasForeignKey(d => d.TblFinancialCycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Safe_Tbl_FinancialCycle");
            });

            modelBuilder.Entity<TblSafeReceiptPayment>(entity =>
            {
                entity.ToTable("Tbl_SafeReceiptPayment");

                entity.HasComment("جدولی برای نمایش اطلاعات دریافت و پرداخت صندوق ها");

                entity.HasIndex(e => new { e.TblSafeId, e.TblPersonId, e.TblSafeReceiptPaymentTypeId, e.IsReceipt, e.Date, e.Comment, e.IsDeleted }, "NonClusteredIndex-20190826-083930")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه صندوق");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(550)
                    .HasComment("تفصیر دریافت و پرداخت صندوق");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ رسید پرداخت صندوق");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف دریافت و پرداخت صندوق");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.InvalidDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ نامعتبر دریافت و پرداخت صندوق");

                entity.Property(e => e.InvalidReason)
                    .IsRequired()
                    .HasMaxLength(550)
                    .HasComment("دلیل نامعتبردریافت و پرداخت صندوق");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول دریافت و پرداخت صندوق");

                entity.Property(e => e.IsReceipt).HasComment("دریافتی صندوق");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول دریافت و پرداخت صندوق");

                entity.Property(e => e.Number).HasComment("شماره رسید دریافت و پرداخت صندوق");

                entity.Property(e => e.PrintDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ چاپ دریافت و پرداخت صندوق");

                entity.Property(e => e.Status).HasComment("وضعیت دریافت و پرداخت صندوق");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول شخص");

                entity.Property(e => e.TblSafeId)
                    .HasColumnName("Tbl_Safe_Id")
                    .HasComment("آی دی صندوق از جدول صندوق  ");

                entity.Property(e => e.TblSafeReceiptPaymentTypeId)
                    .HasColumnName("Tbl_SafeReceiptPaymentType_Id")
                    .HasComment("آی دی دریافتی پرداختی صندوق از جدول دریافتی پرداختی صندوق");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblSafeReceiptPayments)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPayment_Tbl_Person");

                entity.HasOne(d => d.TblSafe)
                    .WithMany(p => p.TblSafeReceiptPayments)
                    .HasForeignKey(d => d.TblSafeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPayment_Tbl_Safe");

                entity.HasOne(d => d.TblSafeReceiptPaymentType)
                    .WithMany(p => p.TblSafeReceiptPayments)
                    .HasForeignKey(d => d.TblSafeReceiptPaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPayment_Tbl_SafeReceiptPaymentType");
            });

            modelBuilder.Entity<TblSafeReceiptPaymentCash>(entity =>
            {
                entity.ToTable("Tbl_SafeReceiptPaymentCash");

                entity.HasComment("جدولی برای نمایش اطلاعات رسید دریافت و پرداخت صندوق");

                entity.Property(e => e.Id).HasComment("شناسه رسید دریافت و پرداخت صندوق");

                entity.Property(e => e.Amount).HasComment("مبلغ نقدی رسید دریافت و پرداخت صندوق");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف رسید دریافت و پرداخت صندوق");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.InvalidDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ نامعتبر رسید دریافت و پرداخت صندوق");

                entity.Property(e => e.InvalidReason)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("دلیل نامعتبر رسید دریافت و پرداخت صندوق");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول رسید دریافت و پرداخت صندوق");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول رسید دریافت و پرداخت صندوق");

                entity.Property(e => e.PrintDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ چاپ رسید دریافت و پرداخت صندوق");

                entity.Property(e => e.Status).HasComment("وضعیت رسید دریافت و پرداخت صندوق");

                entity.Property(e => e.TblSafeReceiptPaymentId)
                    .HasColumnName("Tbl_SafeReceiptPayment_Id")
                    .HasComment("آی دی رسید دریافت و پرداخت صندوق از جدول پول نقد دریافتی پرداختی صندوق");

                entity.HasOne(d => d.TblSafeReceiptPayment)
                    .WithMany(p => p.TblSafeReceiptPaymentCashes)
                    .HasForeignKey(d => d.TblSafeReceiptPaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPaymentCash_Tbl_SafeReceiptPayment");
            });

            modelBuilder.Entity<TblSafeReceiptPaymentCashBeginPeriod>(entity =>
            {
                entity.ToTable("Tbl_SafeReceiptPaymentCashBeginPeriod");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TblSafeId).HasColumnName("Tbl_Safe_Id");

                entity.HasOne(d => d.TblSafe)
                    .WithMany(p => p.TblSafeReceiptPaymentCashBeginPeriods)
                    .HasForeignKey(d => d.TblSafeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPaymentCashBeginPeriod_Tbl_Safe");
            });

            modelBuilder.Entity<TblSafeReceiptPaymentCashEndOfDayOperation>(entity =>
            {
                entity.ToTable("Tbl_SafeReceiptPaymentCashEndOfDayOperation");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblSafeId).HasColumnName("Tbl_Safe_Id");

                entity.HasOne(d => d.TblSafe)
                    .WithMany(p => p.TblSafeReceiptPaymentCashEndOfDayOperations)
                    .HasForeignKey(d => d.TblSafeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPaymentCashEndOfDayOperation_Tbl_Safe");
            });

            modelBuilder.Entity<TblSafeReceiptPaymentCheque>(entity =>
            {
                entity.ToTable("Tbl_SafeReceiptPaymentCheque");

                entity.HasComment("جدولی برای نمایش اطلاعات چک دریافتی پرداختی صندوق");

                entity.HasIndex(e => new { e.TblSafeReceiptPaymentId, e.TblBankBranchAccountId, e.TblChequeId, e.Date, e.IsDeleted }, "NonClusteredIndex-20190826-084009")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه چک دریافتی پرداختی صندوق");

                entity.Property(e => e.Amount).HasComment("مبلغ رسید دریافت و پرداخت صندوق چک");

                entity.Property(e => e.BackNumber)
                    .IsRequired()
                    .HasMaxLength(550)
                    .HasComment("پشت نمره چک");

                entity.Property(e => e.ChequeNumber)
                    .IsRequired()
                    .HasMaxLength(550)
                    .HasComment("شماره چک");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ رسید دریافت و پرداخت صندوق چک");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("توصیف چک دریافتی پرداختی صندوق");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.InvalidDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ نامعتبر");

                entity.Property(e => e.InvalidReason)
                    .IsRequired()
                    .HasMaxLength(550)
                    .HasComment("دلیل نامعتبر");

                entity.Property(e => e.IsCarrier).HasComment("بیان اطلاعات حامل است در جدول رسید دریافت و پرداخت صندوق");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول رسید دریافت و پرداخت صندوق");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول رسید دریافت و پرداخت صندوق");

                entity.Property(e => e.PassedDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ تصویب چک دریافتی پرداختی صندوق");

                entity.Property(e => e.PrintDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ چاپ");

                entity.Property(e => e.Status).HasComment("وضعیت چک دریافتی پرداختی صندوق");

                entity.Property(e => e.TblBankBranchAccountAsReceiptId).HasColumnName("Tbl_BankBranchAccountAsReceipt_Id");

                entity.Property(e => e.TblBankBranchAccountId)
                    .HasColumnName("Tbl_BankBranchAccount_Id")
                    .HasComment("آی دی حساب شعبه بانکی از جدول حساب شعبه بانکی  ");

                entity.Property(e => e.TblChequeId)
                    .HasColumnName("Tbl_Cheque_Id")
                    .HasComment("آی دی چک از جدول چک");

                entity.Property(e => e.TblSafeReceiptPaymentId)
                    .HasColumnName("Tbl_SafeReceiptPayment_Id")
                    .HasComment("آی دی رسید دریافت و پرداخت صندوق از جدول رسید دریافت و پرداخت صندوق ");

                entity.HasOne(d => d.TblBankBranchAccountAsReceipt)
                    .WithMany(p => p.TblSafeReceiptPaymentChequeTblBankBranchAccountAsReceipts)
                    .HasForeignKey(d => d.TblBankBranchAccountAsReceiptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPaymentCheque_Tbl_BankBranchAccount1");

                entity.HasOne(d => d.TblBankBranchAccount)
                    .WithMany(p => p.TblSafeReceiptPaymentChequeTblBankBranchAccounts)
                    .HasForeignKey(d => d.TblBankBranchAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPaymentCheque_Tbl_BankBranchAccount");

                entity.HasOne(d => d.TblCheque)
                    .WithMany(p => p.TblSafeReceiptPaymentCheques)
                    .HasForeignKey(d => d.TblChequeId)
                    .HasConstraintName("FK_Tbl_SafeReceiptPaymentCheque_Tbl_Cheque");

                entity.HasOne(d => d.TblSafeReceiptPayment)
                    .WithMany(p => p.TblSafeReceiptPaymentCheques)
                    .HasForeignKey(d => d.TblSafeReceiptPaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPaymentCheque_Tbl_SafeReceiptPayment");
            });

            modelBuilder.Entity<TblSafeReceiptPaymentChequeExpenditure>(entity =>
            {
                entity.ToTable("Tbl_SafeReceiptPaymentChequeExpenditure");

                entity.HasComment("جدولی برای نمایش اطلاعات چک دریافتی پرداختی صندوق");

                entity.Property(e => e.Id).HasComment("شناسه چک دریافتی پرداختی صندوق");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف چک دریافتی پرداختی صندوق");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.InvalidDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ نامعتبر");

                entity.Property(e => e.InvalidReason)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("دلیل نامعتبر");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول  چک دریافتی پرداختی صندوق");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول چک دریافتی پرداختی صندوق");

                entity.Property(e => e.PrintDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ چاپ");

                entity.Property(e => e.Status).HasComment("وضعیت چک دریافتی پرداختی صندوق");

                entity.Property(e => e.TblSafeReceiptPaymentChequeId)
                    .HasColumnName("Tbl_SafeReceiptPaymentCheque_Id")
                    .HasComment("آی دی رسید دریافت و پرداخت صندوق چک از جدول رسید دریافت و پرداخت صندوق چک ");

                entity.Property(e => e.TblSafeReceiptPaymentId)
                    .HasColumnName("Tbl_SafeReceiptPayment_Id")
                    .HasComment("آی دی رسید دریافت و پرداخت صندوق از جدول رسید دریافت و پرداخت صندوق ");

                entity.HasOne(d => d.TblSafeReceiptPaymentCheque)
                    .WithMany(p => p.TblSafeReceiptPaymentChequeExpenditures)
                    .HasForeignKey(d => d.TblSafeReceiptPaymentChequeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPaymentChequeExpenditure_Tbl_SafeReceiptPaymentCheque");

                entity.HasOne(d => d.TblSafeReceiptPayment)
                    .WithMany(p => p.TblSafeReceiptPaymentChequeExpenditures)
                    .HasForeignKey(d => d.TblSafeReceiptPaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPaymentChequeExpenditure_Tbl_SafeReceiptPayment");
            });

            modelBuilder.Entity<TblSafeReceiptPaymentPo>(entity =>
            {
                entity.ToTable("Tbl_SafeReceiptPaymentPOS");

                entity.HasComment("جدولی برای نمایش اطلاعات دریافتی پرداختی صندوق پز");

                entity.Property(e => e.Id).HasComment("شناسه دریافتی پرداختی صندوق پز");

                entity.Property(e => e.Amount).HasComment("مبلغ پز دریافت و پرداختی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف دریافتی پرداختی صندوق پز");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.InvalidDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ نامعتبر");

                entity.Property(e => e.InvalidReason)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("دلیل نامعتبر");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول دریافتی پرداختی صندوق پز");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول دریافتی پرداختی صندوق پز");

                entity.Property(e => e.PrintDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ چاپ");

                entity.Property(e => e.Status).HasComment("وضعیت دریافتی پرداختی صندوق پز");

                entity.Property(e => e.TblPosId)
                    .HasColumnName("Tbl_POS_Id")
                    .HasComment("آی دی پز از جدول پز");

                entity.Property(e => e.TblSafeReceiptPaymentId)
                    .HasColumnName("Tbl_SafeReceiptPayment_Id")
                    .HasComment("آی دی دریافت و پرداخت از جدول دریافت و پرداخت");

                entity.HasOne(d => d.TblPos)
                    .WithMany(p => p.TblSafeReceiptPaymentPos)
                    .HasForeignKey(d => d.TblPosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPaymentPOS_Tbl_POS");

                entity.HasOne(d => d.TblSafeReceiptPayment)
                    .WithMany(p => p.TblSafeReceiptPaymentPos)
                    .HasForeignKey(d => d.TblSafeReceiptPaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPaymentPOS_Tbl_SafeReceiptPayment");
            });

            modelBuilder.Entity<TblSafeReceiptPaymentPromissoryNote>(entity =>
            {
                entity.ToTable("Tbl_SafeReceiptPaymentPromissoryNote");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.InvalidDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.InvalidReason)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PassedDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TblSafeReceiptPaymentId).HasColumnName("Tbl_SafeReceiptPayment_Id");

                entity.HasOne(d => d.TblSafeReceiptPayment)
                    .WithMany(p => p.TblSafeReceiptPaymentPromissoryNotes)
                    .HasForeignKey(d => d.TblSafeReceiptPaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPaymentPromissoryNote_Tbl_SafeReceiptPayment");
            });

            modelBuilder.Entity<TblSafeReceiptPaymentSettleTransfer>(entity =>
            {
                entity.ToTable("Tbl_SafeReceiptPaymentSettleTransfer");

                entity.HasComment("جدولی برای نمایش اطلاعات دریافت و پرداخت جابه جایی صندوق");

                entity.Property(e => e.Id).HasComment("شناسه دریافت و پرداخت جابه جایی صندوق");

                entity.Property(e => e.Amount).HasComment("میزان رسید دریافت و پرداخت جابه جایی صندوق");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ دریافت و پرداخت جابه جایی صندوق");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف دریافت و پرداخت جابه جایی صندوق");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.InvalidDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ نامعتبر دریافت و پرداخت جابه جایی صندوق");

                entity.Property(e => e.InvalidReason)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("دلیل نامعتبر دریافت و پرداخت جابه جایی صندوق");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول دریافت و پرداخت جابه جایی صندوق");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول دریافت و پرداخت جابه جایی صندوق");

                entity.Property(e => e.PrintDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ چاپ رسید دریافت و پرداخت جابه جایی صندوق");

                entity.Property(e => e.Status).HasComment("وضعیت دریافت و پرداخت جابه جایی صندوق");

                entity.Property(e => e.TblBankBranchAccountAsIssuerId).HasColumnName("Tbl_BankBranchAccountAsIssuer_Id");

                entity.Property(e => e.TblBankBranchAccountId)
                    .HasColumnName("Tbl_BankBranchAccount_Id")
                    .HasComment("آی دی حساب شعبه بانکی از جدول حساب شعبه بانکی ");

                entity.Property(e => e.TblSafeReceiptPaymentId)
                    .HasColumnName("Tbl_SafeReceiptPayment_Id")
                    .HasComment("آی دی رسید دریافت و پرداخت صندوق از جدول رسید دریافت و پرداخت صندوق ");

                entity.Property(e => e.TransactionNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شماره تراکنش دریافت و پرداخت جابه جایی صندوق");

                entity.HasOne(d => d.TblBankBranchAccountAsIssuer)
                    .WithMany(p => p.TblSafeReceiptPaymentSettleTransferTblBankBranchAccountAsIssuers)
                    .HasForeignKey(d => d.TblBankBranchAccountAsIssuerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPaymentSettleTransfer_Tbl_BankBranchAccount1");

                entity.HasOne(d => d.TblBankBranchAccount)
                    .WithMany(p => p.TblSafeReceiptPaymentSettleTransferTblBankBranchAccounts)
                    .HasForeignKey(d => d.TblBankBranchAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPaymentSettleTransfer_Tbl_BankBranchAccount");

                entity.HasOne(d => d.TblSafeReceiptPayment)
                    .WithMany(p => p.TblSafeReceiptPaymentSettleTransfers)
                    .HasForeignKey(d => d.TblSafeReceiptPaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SafeReceiptPaymentSettleTransfer_Tbl_SafeReceiptPayment");
            });

            modelBuilder.Entity<TblSafeReceiptPaymentType>(entity =>
            {
                entity.ToTable("Tbl_SafeReceiptPaymentType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع دریافتی پرداختی صندوق");

                entity.Property(e => e.Id).HasComment("شناسه نوع دریافتی پرداختی صندوق");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع دریافتی پرداختی صندوق");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع دریافتی پرداختی صندوق");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده در جدول نوع دریافتی پرداختی صندوق");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع دریافتی پرداختی صندوق");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع دریافتی پرداختی صندوق");

                entity.Property(e => e.Status).HasComment("وضعیت نوع دریافتی پرداختی صندوق");
            });

            modelBuilder.Entity<TblSeasonReportDetail>(entity =>
            {
                entity.ToTable("Tbl_SeasonReportDetail");

                entity.HasComment("جدولی برای نمایش اطلاعات جزئیات گزارش فصل");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasComment("شناسه جزئیات گزارش فصل");

                entity.Property(e => e.AddedValue).HasComment("ارزش افزوده");

                entity.Property(e => e.AllAmount).HasComment("جمع کل");

                entity.Property(e => e.Discount).HasComment("تخفيف");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف جزئیات گزارش فصل");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsBelowTenPercentDeal).HasComment("بیان اطلاعات آیا کمتر از ده درصد است در جدول جزئیات گزارش فصل");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول جزئیات گزارش فصل");

                entity.Property(e => e.IsReturned).HasComment("بیان اطلاعات بازگشتی است در جدول جزئیات گزارش فصل");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول جزئیات گزارش فصل");

                entity.Property(e => e.IsTotal).HasComment("بیان اطلاعات بازگشتی است در جدول جزئیات گزارش فصل");

                entity.Property(e => e.MinusTax).HasComment("ماليات مسکوک");

                entity.Property(e => e.NotNetPayment).HasComment("مبلغ ناخالص پرداختي");

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد کالا");

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام کالا");

                entity.Property(e => e.PayDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح پرداخت");

                entity.Property(e => e.SeasonReportDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ گزارش فصل");

                entity.Property(e => e.SeasonReportNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شماره گزارش فصل");

                entity.Property(e => e.Status).HasComment("وضعیت جزئیات گزارش فصل");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("موضوع جزئیات گزارش فصل");

                entity.Property(e => e.Tax).HasComment("ماليات");

                entity.Property(e => e.TblSeasonReportHeaderId)
                    .HasColumnName("Tbl_SeasonReportHeader_Id")
                    .HasComment("آی دی سر فصل گزارش فصل از جدول سر فصل گزارش فصل");

                entity.Property(e => e.TotalAmount).HasComment("مقدار کل");

                entity.HasOne(d => d.TblSeasonReportHeader)
                    .WithMany(p => p.TblSeasonReportDetails)
                    .HasForeignKey(d => d.TblSeasonReportHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SeasonReportDetail_Tbl_SeasonReportHeader");
            });

            modelBuilder.Entity<TblSeasonReportHeader>(entity =>
            {
                entity.ToTable("Tbl_SeasonReportHeader");

                entity.HasComment("جدولی برای نمایش اطلاعات سرفصل گزارش فصل");

                entity.Property(e => e.Id).HasComment("شناسه سرفصل گزارش فصل");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف سرفصل گزارش فصل");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول سرفصل گزارش فصل");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول سرفصل گزارش فصل");

                entity.Property(e => e.ReportNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("شماره گزارش");

                entity.Property(e => e.ReportType).HasComment("نوع گزارش");

                entity.Property(e => e.Status).HasComment("وضعیت سرفصل گزارش فصل");

                entity.Property(e => e.TblFinancialCycleId)
                    .HasColumnName("Tbl_FinancialCycle_Id")
                    .HasComment("آی دی دوره مالی از جدول دوره مالی");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع");

                entity.HasOne(d => d.TblFinancialCycle)
                    .WithMany(p => p.TblSeasonReportHeaders)
                    .HasForeignKey(d => d.TblFinancialCycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SeasonReportHeader_Tbl_FinancialCycle");
            });

            modelBuilder.Entity<TblService>(entity =>
            {
                entity.ToTable("Tbl_Service");

                entity.HasComment("جدولی برای نمایش اطلاعات سرویس ایاب ذهاب");

                entity.Property(e => e.Id).HasComment("شناسه سرویس ایاب ذهاب");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف سرویس ایاب ذهاب");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول سرویس ایاب ذهاب");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول سرویس ایاب ذهاب");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام سرویس ایاب ذهاب");

                entity.Property(e => e.Status).HasComment("وضعیت سرویس ایاب ذهاب");
            });

            modelBuilder.Entity<TblServiceAttendance>(entity =>
            {
                entity.ToTable("Tbl_ServiceAttendance");

                entity.HasComment("جدولی برای نمایش اطلاعات ورود و خروج سرویس");

                entity.HasIndex(e => new { e.TblServiceId, e.TblWorkdayId, e.IsDeleted }, "NonClusteredIndex-20161218-165233")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه ورود و خروج سرویس");

                entity.Property(e => e.DelayTime).HasComment("زمان تاخیر ورود و خروج سرویس");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف ورود و خروج سرویس");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول ورود و خروج سرویس");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول ورود و خروج سرویس");

                entity.Property(e => e.Status).HasComment("وضعیت ورود و خروج سرویس");

                entity.Property(e => e.TblServiceId)
                    .HasColumnName("Tbl_Service_Id")
                    .HasComment("آی دی سرویس ایاب و ذهاب از جدول سرویس ایاب و ذهاب");

                entity.Property(e => e.TblWorkdayId)
                    .HasColumnName("Tbl_Workday_Id")
                    .HasComment("آی دی روز کاری از جدول روز کاری");

                entity.HasOne(d => d.TblService)
                    .WithMany(p => p.TblServiceAttendances)
                    .HasForeignKey(d => d.TblServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ServiceAttendance_Tbl_Service");

                entity.HasOne(d => d.TblWorkday)
                    .WithMany(p => p.TblServiceAttendances)
                    .HasForeignKey(d => d.TblWorkdayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ServiceAttendance_Tbl_WorkDay1");
            });

            modelBuilder.Entity<TblServiceEmployee>(entity =>
            {
                entity.ToTable("Tbl_Service_Employee");

                entity.HasComment("جدولی برای نمایش اطلاعات افراد در سرویس ");

                entity.Property(e => e.Id).HasComment("شناسه افراد در سرویس");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف افراد در سرویس");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول افراد در سرویس");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول افراد در سرویس");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع");

                entity.Property(e => e.Status).HasComment("وضعیت افراد در سرویس");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول شخص");

                entity.Property(e => e.TblServiceId)
                    .HasColumnName("Tbl_Service_Id")
                    .HasComment("آی دی سرویس از جدول سرویسهای ایاب ذهاب");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblServiceEmployees)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Service_Employee_Tbl_Person");

                entity.HasOne(d => d.TblService)
                    .WithMany(p => p.TblServiceEmployees)
                    .HasForeignKey(d => d.TblServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Service_Employee_Tbl_Service");
            });

            modelBuilder.Entity<TblShiftDay>(entity =>
            {
                entity.ToTable("Tbl_ShiftDay");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblWorkdayId).HasColumnName("Tbl_Workday_Id");

                entity.HasOne(d => d.TblWorkday)
                    .WithMany(p => p.TblShiftDays)
                    .HasForeignKey(d => d.TblWorkdayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_ShiftDay_Tbl_WorkDay1");
            });

            modelBuilder.Entity<TblShiftDayName>(entity =>
            {
                entity.ToTable("Tbl_ShiftDayName");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblShiftEmployee>(entity =>
            {
                entity.ToTable("Tbl_Shift_Employee");

                entity.HasIndex(e => new { e.TblPersonId, e.TblShiftdayId, e.IsDeleted }, "NonClusteredIndex-20200526-152814");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.Property(e => e.TblShiftdayId).HasColumnName("Tbl_Shiftday_Id");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblShiftEmployees)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Shift_Employee_Tbl_Person1");

                entity.HasOne(d => d.TblShiftday)
                    .WithMany(p => p.TblShiftEmployees)
                    .HasForeignKey(d => d.TblShiftdayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Shift_Employee_Tbl_ShiftDay1");
            });

            modelBuilder.Entity<TblSkill>(entity =>
            {
                entity.ToTable("Tbl_Skill");

                entity.HasComment("جدولی برای نمایش اطلاعات مهارت");

                entity.Property(e => e.Id).HasComment("شناسه مهارت");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف مهارت");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول مهارت");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول مهارت");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("مهارت");

                entity.Property(e => e.Status).HasComment("وضعیت مهارت");
            });

            modelBuilder.Entity<TblSm>(entity =>
            {
                entity.ToTable("Tbl_SMS");

                entity.HasComment("جدولی برای نمایش اطلاعات اس ام اس ");

                entity.HasIndex(e => new { e.TblPersonId, e.Smsdate, e.TblSmstypeId, e.FromNumber, e.ToNumber, e.Reference, e.IsDeleted }, "NonClusteredIndex-20170410-201300")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه اس ام اس ");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف اس ام اس");

                entity.Property(e => e.FromNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasComment("شماره ارسالی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اس ام اس");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اس ام اس");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasComment("پیام اس ام اس");

                entity.Property(e => e.MessageStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("وضعیت پیام ها");

                entity.Property(e => e.Reference).HasComment("منابع اس ام اس");

                entity.Property(e => e.Smsdate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SMSDate")
                    .IsFixedLength(true)
                    .HasComment("تاریخ ارسال اس ام اس");

                entity.Property(e => e.Smstime)
                    .HasColumnName("SMSTime")
                    .HasComment("زمان ارسال اس ام اس");

                entity.Property(e => e.Status).HasComment("وضعیت اس ام اس");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.Property(e => e.TblSmstypeId)
                    .HasColumnName("Tbl_SMSType_Id")
                    .HasComment("آی دی نوع اس ام اس از جدول نوع اس ام اس");

                entity.Property(e => e.ToNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasComment("شماره دریافتی");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblSms)
                    .HasForeignKey(d => d.TblPersonId)
                    .HasConstraintName("FK_Tbl_SMS_Tbl_Person");

                entity.HasOne(d => d.TblSmstype)
                    .WithMany(p => p.TblSms)
                    .HasForeignKey(d => d.TblSmstypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SMS_Tbl_SMSType");
            });

            modelBuilder.Entity<TblSmstype>(entity =>
            {
                entity.ToTable("Tbl_SMSType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع اس ام اس ");

                entity.HasIndex(e => e.Id, "SMSType")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه نوع اس ام اس");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع اس ام اس");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف اس ام اس");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع اس ام اس");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع اس ام اس");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع اس ام اس");

                entity.Property(e => e.Status).HasComment("وضعیت اس ام اس");
            });

            modelBuilder.Entity<TblSoftware>(entity =>
            {
                entity.ToTable("Tbl_Software");

                entity.HasComment("جدولی برای نمایش اطلاعات نرم افزار ");

                entity.Property(e => e.Id).HasComment("شناسه نرم افزار");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نرم افزار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نرم افزار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نرم افزار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نرم افزار");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نرم افزار");

                entity.Property(e => e.Status).HasComment("وضعیت نرم افزار");

                entity.Property(e => e.TblSoftwareTypeId)
                    .HasColumnName("Tbl_SoftwareType_Id")
                    .HasComment("آی دی نوع نرم افزار از جدول نوع نرم افزار");

                entity.HasOne(d => d.TblSoftwareType)
                    .WithMany(p => p.TblSoftwares)
                    .HasForeignKey(d => d.TblSoftwareTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_Software_Tbl_SoftwareType");
            });

            modelBuilder.Entity<TblSoftwareType>(entity =>
            {
                entity.ToTable("Tbl_SoftwareType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع نرم افزار ");

                entity.Property(e => e.Id).HasComment("شناسه نوع نرم افزار");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع نرم افزار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع نرم افزار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع نرم افزار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع نرم افزار");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع نرم افزار");

                entity.Property(e => e.Status).HasComment("وضعیت نوع نرم افزار");
            });

            modelBuilder.Entity<TblSoftwareVersion>(entity =>
            {
                entity.ToTable("Tbl_SoftwareVersion");

                entity.HasComment("جدولی برای نمایش اطلاعات ورژن نرم افزار ");

                entity.Property(e => e.Id).HasComment("شناسه ورژن نرم افزار");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد ورژن نرم افزار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف ورژن نرم افزار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول ورژن نرم افزار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول ورژن نرم افزار");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام ورژن نرم افزار");

                entity.Property(e => e.Status).HasComment("وضعیت ورژن نرم افزار");

                entity.Property(e => e.TblSoftwareId)
                    .HasColumnName("Tbl_Software_Id")
                    .HasComment("آی دی نرم افزار از جدول نرم افزار");

                entity.HasOne(d => d.TblSoftware)
                    .WithMany(p => p.TblSoftwareVersions)
                    .HasForeignKey(d => d.TblSoftwareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SoftwareVersion_Tbl_Software");
            });

            modelBuilder.Entity<TblStockSheet>(entity =>
            {
                entity.ToTable("Tbl_StockSheet");

                entity.HasComment("جدولی برای نمایش اطلاعات برگه های انبار ");

                entity.Property(e => e.Id).HasComment("شناسه منحصر به فرد برگه های انبار");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ برگه های انبار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف برگه های انبار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول برگه های انبار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول برگه های انبار");

                entity.Property(e => e.SheetIndex).HasComment("فهرست برگه");

                entity.Property(e => e.SheetNumber).HasComment("شماره برگه");

                entity.Property(e => e.Status).HasComment("وضعیت برگه های انبار");

                entity.Property(e => e.TblCompanyIdAsIssuer)
                    .HasColumnName("Tbl_Company_IdAsIssuer")
                    .HasComment("شناسه منحصر به فرد شرکت تحویل دهنده");

                entity.Property(e => e.TblCompanyIdAsOwner).HasColumnName("Tbl_Company_IdAsOwner");

                entity.Property(e => e.TblCompanyIdAsReceiver)
                    .HasColumnName("Tbl_Company_IdAsReceiver")
                    .HasComment("شناسه منحصر به فرد شرکت تحویل گیرنده");

                entity.Property(e => e.TblPersonIdAsIssuer)
                    .HasColumnName("Tbl_Person_IdAsIssuer")
                    .HasComment("شناسه منحصر به فرد تحویل دهنده");

                entity.Property(e => e.TblPersonIdAsReceiver)
                    .HasColumnName("Tbl_Person_IdAsReceiver")
                    .HasComment("شناسه منحصر به فرد تحویل گیرنده");

                entity.Property(e => e.TblPlaceTypeIdAsIssuer)
                    .HasColumnName("Tbl_PlaceType_IdAsIssuer")
                    .HasComment("شناسه منحصر به فرد محل تحویل دهنده");

                entity.Property(e => e.TblPlaceTypeIdAsReceiver)
                    .HasColumnName("Tbl_PlaceType_IdAsReceiver")
                    .HasComment("شناسه منحصر به فرد تحویل گیرنده");

                entity.Property(e => e.TblStockSheetSubTypeId)
                    .HasColumnName("Tbl_StockSheetSubType_Id")
                    .HasComment("نوع فرعی برگه");

                entity.Property(e => e.TblStockSheetTypeId)
                    .HasColumnName("Tbl_StockSheetType_Id")
                    .HasComment("نوع اصلی برگه");

                entity.HasOne(d => d.TblCompanyIdAsIssuerNavigation)
                    .WithMany(p => p.TblStockSheetTblCompanyIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsIssuer)
                    .HasConstraintName("FK_Tbl_StockSheet_Tbl_Company");

                entity.HasOne(d => d.TblCompanyIdAsOwnerNavigation)
                    .WithMany(p => p.TblStockSheetTblCompanyIdAsOwnerNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsOwner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_StockSheet_Tbl_Company2");

                entity.HasOne(d => d.TblCompanyIdAsReceiverNavigation)
                    .WithMany(p => p.TblStockSheetTblCompanyIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblCompanyIdAsReceiver)
                    .HasConstraintName("FK_Tbl_StockSheet_Tbl_Company1");

                entity.HasOne(d => d.TblPersonIdAsIssuerNavigation)
                    .WithMany(p => p.TblStockSheetTblPersonIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsIssuer)
                    .HasConstraintName("FK_Tbl_StockSheet_Tbl_Person1");

                entity.HasOne(d => d.TblPersonIdAsReceiverNavigation)
                    .WithMany(p => p.TblStockSheetTblPersonIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblPersonIdAsReceiver)
                    .HasConstraintName("FK_Tbl_StockSheet_Tbl_Person");

                entity.HasOne(d => d.TblPlaceTypeIdAsIssuerNavigation)
                    .WithMany(p => p.TblStockSheetTblPlaceTypeIdAsIssuerNavigations)
                    .HasForeignKey(d => d.TblPlaceTypeIdAsIssuer)
                    .HasConstraintName("FK_Tbl_StockSheet_Tbl_PlaceType");

                entity.HasOne(d => d.TblPlaceTypeIdAsReceiverNavigation)
                    .WithMany(p => p.TblStockSheetTblPlaceTypeIdAsReceiverNavigations)
                    .HasForeignKey(d => d.TblPlaceTypeIdAsReceiver)
                    .HasConstraintName("FK_Tbl_StockSheet_Tbl_PlaceType1");

                entity.HasOne(d => d.TblStockSheetSubType)
                    .WithMany(p => p.TblStockSheets)
                    .HasForeignKey(d => d.TblStockSheetSubTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_StockSheet_Tbl_StockSheetSubType");

                entity.HasOne(d => d.TblStockSheetType)
                    .WithMany(p => p.TblStockSheets)
                    .HasForeignKey(d => d.TblStockSheetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_StockSheet_Tbl_StockSheetType");
            });

            modelBuilder.Entity<TblStockSheetItem>(entity =>
            {
                entity.ToTable("Tbl_StockSheetItem");

                entity.HasComment("جدولی برای نمایش اطلاعات آیتم برگه های انبار ");

                entity.HasIndex(e => new { e.TblProductId, e.IsDeleted, e.Count, e.TblStockSheetId }, "_dta_index_Tbl_StockSheetItem_29_821018106__K3_K10_K4_K2_5")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه آیتم برگه انبار");

                entity.Property(e => e.Count).HasComment("تعداد آیتم برگه انبار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف آیتم برگه انبار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول  آیتم برگه انبار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول آیتم برگه انبار");

                entity.Property(e => e.Price).HasComment("قیمت آیتم برگه انبار");

                entity.Property(e => e.Status).HasComment("وضعیت آیتم برگه انبار");

                entity.Property(e => e.TblProductId)
                    .HasColumnName("Tbl_Product_Id")
                    .HasComment("آی دی محصول از جدول محصول");

                entity.Property(e => e.TblStockSheetId)
                    .HasColumnName("Tbl_StockSheet_Id")
                    .HasComment("آی دی برگه انبار از جدول برگه انبار");

                entity.HasOne(d => d.TblProduct)
                    .WithMany(p => p.TblStockSheetItems)
                    .HasForeignKey(d => d.TblProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_StockSheetItem_Tbl_Product");

                entity.HasOne(d => d.TblStockSheet)
                    .WithMany(p => p.TblStockSheetItems)
                    .HasForeignKey(d => d.TblStockSheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_StockSheetItem_Tbl_StockSheet");
            });

            modelBuilder.Entity<TblStockSheetSubType>(entity =>
            {
                entity.ToTable("Tbl_StockSheetSubType");

                entity.Property(e => e.Id).HasComment("شناسه توانایی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد توانایی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");

                entity.Property(e => e.TblStockSheetTypeId).HasColumnName("Tbl_StockSheetType_Id");

                entity.HasOne(d => d.TblStockSheetType)
                    .WithMany(p => p.TblStockSheetSubTypes)
                    .HasForeignKey(d => d.TblStockSheetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_StockSheetSubType_Tbl_StockSheetType");
            });

            modelBuilder.Entity<TblStockSheetType>(entity =>
            {
                entity.ToTable("Tbl_StockSheetType");

                entity.Property(e => e.Id).HasComment("شناسه توانایی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد توانایی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("شرح توانایی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول توانایی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول توانایی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام توانایی");

                entity.Property(e => e.Status).HasComment("وضعیت توانایی");
            });

            modelBuilder.Entity<TblStorePlan>(entity =>
            {
                entity.ToTable("Tbl_StorePlan");

                entity.HasComment("جدولی برای نمایش اطلاعات پلن فروشگاه ");

                entity.Property(e => e.Id).HasComment("شناسه پلن فروشگاه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف پلن فروشگاه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول  آیتم برگه انبار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول آیتم برگه انبار");

                entity.Property(e => e.PartGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام قسمت");

                entity.Property(e => e.Status).HasComment("وضعیت پلن فروشگاه");

                entity.Property(e => e.TblPlaceTypeId)
                    .HasColumnName("Tbl_PlaceType_Id")
                    .HasComment("آی دی نوع مکان از جدول نوع مکان");

                entity.Property(e => e.TblPlanId).HasColumnName("Tbl_Plan_Id");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblStorePlans)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_StorePlan_Tbl_PhoneType");

                entity.HasOne(d => d.TblPlan)
                    .WithMany(p => p.TblStorePlans)
                    .HasForeignKey(d => d.TblPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_StorePlan_Tbl_Plan");
            });

            modelBuilder.Entity<TblTag>(entity =>
            {
                entity.ToTable("Tbl_Tag");

                entity.HasComment("جدولی برای نمایش اطلاعات تگ ");

                entity.Property(e => e.Id).HasComment("شناسه تگ");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد تگ");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف تگ");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول تگ");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول تگ");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام تگ");

                entity.Property(e => e.Status).HasComment("وضعیت تگ");
            });

            modelBuilder.Entity<TblTaskStatus>(entity =>
            {
                entity.ToTable("Tbl_TaskStatus");

                entity.HasComment("جدولی برای نمایش اطلاعات وضعیت تسک");

                entity.Property(e => e.Id).HasComment("شناسه وضعیت تسک");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد وضعیت تسک");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف وضعیت تسک");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول وضعیت تسک");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول وضعیت تسک");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام وضعیت تسک");

                entity.Property(e => e.Status).HasComment("وضعیت تسک");
            });

            modelBuilder.Entity<TblTaskType>(entity =>
            {
                entity.ToTable("Tbl_TaskType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع تسک");

                entity.Property(e => e.Id).HasComment(" شناسه نوع تسک");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع تسک");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع تسک");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول نوع تسک");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول نوع تسک");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام نوع تسک");

                entity.Property(e => e.Status).HasComment("وضعیت نوع تسک");
            });

            modelBuilder.Entity<TblTaxBranch>(entity =>
            {
                entity.ToTable("Tbl_TaxBranch");

                entity.HasComment("جدولی برای نمایش اطلاعات شعب مالیاتی");

                entity.Property(e => e.Id).HasComment("شناسه شعب مالیاتی");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد شعب مالیاتی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("توصیف شعب مالیاتی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول شعب مالیاتی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول شعب مالیاتی");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام شعب مالیاتی");

                entity.Property(e => e.Status).HasComment("وضعیت شعب مالیاتی");

                entity.Property(e => e.TblPlaceTypeId)
                    .HasColumnName("Tbl_PlaceType_Id")
                    .HasComment("آی دی نوع مکان از جدول نوع مکان");

                entity.Property(e => e.Tfn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TFN")
                    .HasComment("شماره پرونده مالیاتی");

                entity.Property(e => e.Tin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TIN")
                    .HasComment("شماره شناسایی مالیات دهندگان");

                entity.Property(e => e.WorkshopCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد کارگاه مالیاتی");

                entity.Property(e => e.WorkshopName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام کارگاه مالیاتی");

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد پستی مالیاتی");

                entity.HasOne(d => d.TblPlaceType)
                    .WithMany(p => p.TblTaxBranches)
                    .HasForeignKey(d => d.TblPlaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_TaxBranch_Tbl_PlaceType");
            });

            modelBuilder.Entity<TblTaxBranchSummary>(entity =>
            {
                entity.ToTable("Tbl_TaxBranchSummary");

                entity.HasComment("جدولی برای نمایش اطلاعات خلاصه شعب مالیاتی");

                entity.Property(e => e.Id).HasComment("شناسه خلاصه شعب مالیاتی");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ خلاصه شعب مالیاتی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف خلاصه شعب مالیاتی");

                entity.Property(e => e.First).HasComment("اولین خلاصه شعب مالیاتی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول خلاصه شعب مالیاتی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول خلاصه شعب مالیاتی");

                entity.Property(e => e.Second).HasComment("دومین خلاصه شعب مالیاتی");

                entity.Property(e => e.Status).HasComment("وضعیت خلاصه شعب مالیاتی");

                entity.Property(e => e.TblTaxBranchId)
                    .HasColumnName("Tbl_TaxBranch_Id")
                    .HasComment("آی دی شعب مالیاتی از جدول شعب مالیاتی");

                entity.Property(e => e.Third).HasComment("سومین خلاصه شعب مالیاتی");

                entity.HasOne(d => d.TblTaxBranch)
                    .WithMany(p => p.TblTaxBranchSummaries)
                    .HasForeignKey(d => d.TblTaxBranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_TaxBranchSummary_Tbl_TaxBranch");
            });

            modelBuilder.Entity<TblTaxInfo>(entity =>
            {
                entity.ToTable("Tbl_TaxInfo");

                entity.HasComment("جدولی برای نمایش اطلاعات مالیاتی");

                entity.Property(e => e.Id).HasComment("شناسه اطلاعات مالیاتی");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف اطلاعات مالیاتی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اطلاعات مالیاتی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اطلاعات مالیاتی");

                entity.Property(e => e.Status).HasComment("وضعیت اطلاعات مالیاتی");

                entity.Property(e => e.TblEvidenceItemId)
                    .HasColumnName("Tbl_EvidenceItem_Id")
                    .HasComment("آی دی نمونه شواهد از جدول نمونه شواهد");

                entity.Property(e => e.TblLedgerInfoId)
                    .HasColumnName("Tbl_LedgerInfo_Id")
                    .HasComment("آی دی اطلاعات دفترحساب از جدول اطلاعات دفترحساب");

                entity.HasOne(d => d.TblEvidenceItem)
                    .WithMany(p => p.TblTaxInfos)
                    .HasForeignKey(d => d.TblEvidenceItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_TaxInfo_Tbl_EvidenceItem");

                entity.HasOne(d => d.TblLedgerInfo)
                    .WithMany(p => p.TblTaxInfos)
                    .HasForeignKey(d => d.TblLedgerInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_TaxInfo_Tbl_LedgerInfo");
            });

            modelBuilder.Entity<TblTaxPercent>(entity =>
            {
                entity.ToTable("Tbl_TaxPercent");

                entity.HasComment("جدولی برای نمایش اطلاعات جدول مالیاتی");

                entity.Property(e => e.Id).HasComment("شناسه جدول مالیات");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف جدول مالیات");

                entity.Property(e => e.FromAmount).HasComment("کف مبلغ");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ شروع");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اطلاعات جدول مالیاتی");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اطلاعات جدول مالیاتی");

                entity.Property(e => e.Status).HasComment("وضعیت جدول مالیات");

                entity.Property(e => e.TaxPercentage).HasComment("درصد مالیاتی");

                entity.Property(e => e.ToAmount).HasComment("سقف مبلغ");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ پایان");
            });

            modelBuilder.Entity<TblTimeKeeping>(entity =>
            {
                entity.ToTable("Tbl_TimeKeeping");

                entity.HasComment("جدولی برای نمایش اطلاعات کارکرد");

                entity.HasIndex(e => new { e.IsDeleted, e.Date }, "_dta_index_Tbl_TimeKeeping_29_1191063379__K12_K3_1_2_4_5_6_7_8_9_10_11")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه اطلاعات کارکرد");

                entity.Property(e => e.AbsenceTime).HasComment("زمان غیبت");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ اطلاعات کارکرد");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("توصیف اطلاعات کارکرد");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اطلاعات کارکرد");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اطلاعات کارکرد");

                entity.Property(e => e.OverTime).HasComment("اضافه کار");

                entity.Property(e => e.SickTime).HasComment("زمان بیماری");

                entity.Property(e => e.Status).HasComment("وضعیت اطلاعات کارکرد");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول شخص");

                entity.Property(e => e.TotalTime).HasComment("مجموع مدت زمان");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblTimeKeepings)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_TimeKeeping_Tbl_Person");
            });

            modelBuilder.Entity<TblUniqueInfo>(entity =>
            {
                entity.ToTable("Tbl_UniqueInfos");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblUserRight>(entity =>
            {
                entity.ToTable("Tbl_UserRight");

                entity.HasComment("جدولی برای نمایش اطلاعات سطح دسترسی کاربران");

                entity.HasIndex(e => new { e.IsDeleted, e.UserName }, "_dta_index_Tbl_UserRight_29_505156945__K14_K2_1_3_4_5_6_7_8_9_10_11_12_13")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه سطح دسترسی کاربران");

                entity.Property(e => e.Application)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("برنامه مورد نظر");

                entity.Property(e => e.Control)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کنترل های مورد نظر");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف سطح دسترسی");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("تاریخ شروع سطح دسترسی");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اطلاعات سطح دسترسی کاربران");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اطلاعات سطح دسترسی کاربران");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("رمز عبور");

                entity.Property(e => e.Status).HasComment("وضعیت سطح دسترسی");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("تاریخ پایان سطح دسترسی");

                entity.Property(e => e.UserControl)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("یوزر کنترل های مورد نظر");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام کاربری");

                entity.Property(e => e.Visibility).HasComment("قابلیت دیدن");
            });

            modelBuilder.Entity<TblVehicleType>(entity =>
            {
                entity.ToTable("Tbl_VehicleType");

                entity.HasComment("جدولی برای نمایش اطلاعات نوع وسیله نقلیه");

                entity.Property(e => e.Id).HasComment("شناسه نوع وسیله نقلیه");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد نوع وسیله نقلیه");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نوع وسیله نقلیه");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اطلاعات نوع وسیله نقلیه");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اطلاعات نوع وسیله نقلیه");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نوع وسیله نقلیه");

                entity.Property(e => e.Status).HasComment("وضعیت نوع وسیله نقلیه");
            });

            modelBuilder.Entity<TblWhQ>(entity =>
            {
                entity.ToTable("Tbl_WhQ");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TblWorkCondition>(entity =>
            {
                entity.ToTable("Tbl_WorkCondition");

                entity.HasComment("جدولی برای نمایش اطلاعات شرایط کار");

                entity.Property(e => e.Id).HasComment("شناسه شرایط کار");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد شرایط کار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف شرایط کار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اطلاعات شرایط کار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اطلاعات شرایط کار");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام شرایط کار");

                entity.Property(e => e.Status).HasComment("وضعیت شرایط کار");
            });

            modelBuilder.Entity<TblWorkDay>(entity =>
            {
                entity.ToTable("Tbl_WorkDay");

                entity.HasIndex(e => new { e.TblFormaldayId, e.IsDeleted }, "NonClusteredIndex-20200526-152730");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.TblFormaldayId).HasColumnName("Tbl_Formalday_Id");

                entity.Property(e => e.TblWorkDayNameId).HasColumnName("Tbl_WorkDayName_Id");

                entity.HasOne(d => d.TblFormalday)
                    .WithMany(p => p.TblWorkDays)
                    .HasForeignKey(d => d.TblFormaldayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_WorkDay_Tbl_FormalDay1");

                entity.HasOne(d => d.TblWorkDayName)
                    .WithMany(p => p.TblWorkDays)
                    .HasForeignKey(d => d.TblWorkDayNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_WorkDay_Tbl_WorkDayName1");
            });

            modelBuilder.Entity<TblWorkDayName>(entity =>
            {
                entity.ToTable("Tbl_WorkDayName");

                entity.HasComment("جدولی برای نمایش اطلاعات نام روز کاري");

                entity.Property(e => e.Id).HasComment("شناسه نام روز کاری");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد  نام روز کاری");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف نام روز کاری");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اطلاعات نام روز کاری");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اطلاعات نام روز کاری");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام روز کاری");

                entity.Property(e => e.Status).HasComment("وضعیت نام روز کاری");
            });

            modelBuilder.Entity<TblWorkOperation>(entity =>
            {
                entity.ToTable("Tbl_WorkOperation");

                entity.HasComment("جدولی برای نمایش اطلاعات گردش کار");

                entity.HasIndex(e => new { e.Date, e.TblPersonId }, "Date")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasComment("شناسه");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("تاریخ گردش کار ");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف گردش کار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اطلاعات گردش کار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اطلاعات گردش کار");

                entity.Property(e => e.KeyValue).HasComment("مقدار کلید انتخابی");

                entity.Property(e => e.Status).HasComment("وضعیت گردش کار");

                entity.Property(e => e.TblKeyId)
                    .HasColumnName("Tbl_Key_Id")
                    .HasComment("آی دی عوامل از جدول عوامل");

                entity.Property(e => e.TblPersonId)
                    .HasColumnName("Tbl_Person_Id")
                    .HasComment("آی دی شخص از جدول اشخاص");

                entity.HasOne(d => d.TblPerson)
                    .WithMany(p => p.TblWorkOperations)
                    .HasForeignKey(d => d.TblPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_WorkOperation_Tbl_Person");
            });

            modelBuilder.Entity<TblWorkPlaceSituation>(entity =>
            {
                entity.ToTable("Tbl_WorkPlaceSituation");

                entity.HasComment("جدولی برای نمایش اطلاعات وضعیت محل کار");

                entity.Property(e => e.Id).HasComment("شناسه وضعیت محل کار");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("کد وضعیت محل کار");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("توصیف وضعیت محل کار");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasComment("شناسه منحصر به فرد جهانی");

                entity.Property(e => e.IsDeleted).HasComment("بیان اطلاعات حذف شده است درجدول اطلاعات وضعیت محل کار");

                entity.Property(e => e.IsSent).HasComment("بیان اطلاعات ارسال شده در جدول اطلاعات وضعیت محل کار");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("نام وضعیت محل کار");

                entity.Property(e => e.Status).HasComment("وضعیت وضعیت محل کار");
            });

            modelBuilder.Entity<TempAsso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempAsso");

                entity.HasComment("سیستم پیشنهاد دهنده مبتنی بر سبد خرید");

                entity.Property(e => e.A)
                    .HasMaxLength(50)
                    .HasComment("اگر خریدند");

                entity.Property(e => e.B).HasMaxLength(50);

                entity.Property(e => e.C).HasMaxLength(50);

                entity.Property(e => e.D).HasMaxLength(50);

                entity.Property(e => e.E).HasMaxLength(50);

                entity.Property(e => e.F).HasMaxLength(50);

                entity.Property(e => e.G).HasMaxLength(50);

                entity.Property(e => e.H).HasMaxLength(50);

                entity.Property(e => e.I).HasMaxLength(50);

                entity.Property(e => e.J)
                    .HasMaxLength(50)
                    .HasComment("چه پیشنهاد دهیم");
            });

            modelBuilder.Entity<TempFullAccountCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempFullAccountCode");

                entity.Property(e => e.ChildName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Parents)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TempMember>(entity =>
            {
                entity.HasNoKey();

                entity.HasComment("ارزیابی در عضو گیری جدید-مشترک");

                entity.Property(e => e.Store)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TempTable1>(entity =>
            {
                entity.ToTable("TempTable_1");

                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GroupCode).HasMaxLength(50);

                entity.Property(e => e.GroupCodeSizeKalite).HasMaxLength(50);

                entity.Property(e => e.SizeKalite).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewEmploymentAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Employment_All");

                entity.Property(e => e.ContractNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ContractTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ContractType_Name");

                entity.Property(e => e.EmploymentTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EmploymentType_Name");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.InsuranceBranchName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InsuranceBranch_Name");

                entity.Property(e => e.InsuranceJobName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InsuranceJob_Name");

                entity.Property(e => e.InsuranceNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InsuranceTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InsuranceType_Name");

                entity.Property(e => e.PlaceTypeCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PlaceTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Post_Name");

                entity.Property(e => e.PostTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ResignationDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ResignationReason)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SentenceTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TblCompanyId).HasColumnName("Tbl_Company_Id");

                entity.Property(e => e.TblContractTypeId).HasColumnName("Tbl_ContractType_Id");

                entity.Property(e => e.TblEmploymentId).HasColumnName("Tbl_Employment_Id");

                entity.Property(e => e.TblEmploymentTypeId).HasColumnName("Tbl_EmploymentType_Id");

                entity.Property(e => e.TblInsuranceBranchId).HasColumnName("Tbl_InsuranceBranch_Id");

                entity.Property(e => e.TblInsuranceJobId).HasColumnName("Tbl_InsuranceJob_Id");

                entity.Property(e => e.TblInsuranceTypeId).HasColumnName("Tbl_InsuranceType_Id");

                entity.Property(e => e.TblJobId).HasColumnName("Tbl_Job_Id");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.Property(e => e.TblPlaceTypeId).HasColumnName("Tbl_PlaceType_Id");

                entity.Property(e => e.TblPostId).HasColumnName("Tbl_Post_Id");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ViewEmploymentAllFactor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Employment_AllFactors");

                entity.Property(e => e.TblEmployementId).HasColumnName("Tbl_Employement_Id");

                entity.Property(e => e.TblEmploymentKeyAttract).HasColumnName("Tbl_EmploymentKey_Attract");

                entity.Property(e => e.TblEmploymentKeyChild).HasColumnName("Tbl_EmploymentKey_Child");

                entity.Property(e => e.TblEmploymentKeyDiff).HasColumnName("Tbl_EmploymentKey_Diff");

                entity.Property(e => e.TblEmploymentKeyFood).HasColumnName("Tbl_EmploymentKey_Food");

                entity.Property(e => e.TblEmploymentKeyGrade).HasColumnName("Tbl_EmploymentKey_Grade");

                entity.Property(e => e.TblEmploymentKeyHelp).HasColumnName("Tbl_EmploymentKey_Help");

                entity.Property(e => e.TblEmploymentKeyHouse).HasColumnName("Tbl_EmploymentKey_House");

                entity.Property(e => e.TblEmploymentKeyJob).HasColumnName("Tbl_EmploymentKey_Job");

                entity.Property(e => e.TblEmploymentKeyOther).HasColumnName("Tbl_EmploymentKey_Other");

                entity.Property(e => e.TblEmploymentKeyPost).HasColumnName("Tbl_EmploymentKey_Post");

                entity.Property(e => e.TblEmploymentKeyYear).HasColumnName("Tbl_EmploymentKey_Year");
            });

            modelBuilder.Entity<ViewEmploymentAllStaff>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Employment_AllStaff");

                entity.Property(e => e.ContractNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ContractTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ContractType_Name");

                entity.Property(e => e.EmploymentTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EmploymentType_Name");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.InsuranceBranchName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InsuranceBranch_Name");

                entity.Property(e => e.InsuranceJobName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InsuranceJob_Name");

                entity.Property(e => e.InsuranceNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InsuranceTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InsuranceType_Name");

                entity.Property(e => e.PlaceTypeCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PlaceTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Post_Name");

                entity.Property(e => e.PostTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ResignationDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ResignationReason)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SentenceTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TblCompanyId).HasColumnName("Tbl_Company_Id");

                entity.Property(e => e.TblContractTypeId).HasColumnName("Tbl_ContractType_Id");

                entity.Property(e => e.TblEmploymentId).HasColumnName("Tbl_Employment_Id");

                entity.Property(e => e.TblEmploymentTypeId).HasColumnName("Tbl_EmploymentType_Id");

                entity.Property(e => e.TblInsuranceBranchId).HasColumnName("Tbl_InsuranceBranch_Id");

                entity.Property(e => e.TblInsuranceJobId).HasColumnName("Tbl_InsuranceJob_Id");

                entity.Property(e => e.TblInsuranceTypeId).HasColumnName("Tbl_InsuranceType_Id");

                entity.Property(e => e.TblJobId).HasColumnName("Tbl_Job_Id");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.Property(e => e.TblPlaceTypeId).HasColumnName("Tbl_PlaceType_Id");

                entity.Property(e => e.TblPostId).HasColumnName("Tbl_Post_Id");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ViewInvoiceDiscount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_InvoiceDiscount");

                entity.Property(e => e.CardNumber).IsRequired();

                entity.Property(e => e.DiscountPercent)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TblDiscountTypeId).HasColumnName("Tbl_DiscountType_Id");

                entity.Property(e => e.TblInvoiceMasterDiscountId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Tbl_InvoiceMasterDiscount_Id");

                entity.Property(e => e.TblInvoiceMasterId).HasColumnName("Tbl_InvoiceMaster_Id");
            });

            modelBuilder.Entity<ViewInvoiceMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_InvoiceMaster");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EffectiveCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.InvoiceDateTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceTo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tax).HasMaxLength(50);

                entity.Property(e => e.TaxPercent).HasMaxLength(50);

                entity.Property(e => e.TblCompanyIdAsOwner).HasColumnName("Tbl_Company_IdAsOwner");

                entity.Property(e => e.TblEffectiveTypeId).HasColumnName("Tbl_EffectiveType_Id");

                entity.Property(e => e.TblInitializedTypeId).HasColumnName("Tbl_InitializedType_Id");

                entity.Property(e => e.TblInvoiceMasterId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Tbl_InvoiceMaster_Id");

                entity.Property(e => e.TblInvoiceRegistrarId).HasColumnName("Tbl_InvoiceRegistrar_Id");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");
            });

            modelBuilder.Entity<ViewInvoiceMasterDiscount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_InvoiceMaster_Discount");

                entity.Property(e => e.DiscountPercent).HasMaxLength(50);

                entity.Property(e => e.EffectiveCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TblDiscountTypeId).HasColumnName("Tbl_DiscountType_Id");

                entity.Property(e => e.TblInvoiceMasterDiscountId).HasColumnName("Tbl_InvoiceMasterDiscount_Id");

                entity.Property(e => e.TblInvoiceMasterId).HasColumnName("Tbl_InvoiceMaster_Id");
            });

            modelBuilder.Entity<ViewInvoiceMasterPointRange>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_InvoiceMasterPointRange");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ViewInvoiceSlave>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_InvoiceSlave");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PartCode).HasMaxLength(50);

                entity.Property(e => e.TblInvoiceMasterId).HasColumnName("Tbl_InvoiceMaster_Id");
            });

            modelBuilder.Entity<ViewPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Person");

                entity.Property(e => e.AddressLine).IsRequired();

                entity.Property(e => e.CityName).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MarriageDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewPersonAllStaff>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Person_AllStaff");

                entity.Property(e => e.BirthCertificateNumber)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MarriageDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NationalCode)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TblJobId).HasColumnName("Tbl_Job_Id");

                entity.Property(e => e.TblMarriageStatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Tbl_MarriageStatus_Name");

                entity.Property(e => e.TblMilitaryServiceName)
                    .HasMaxLength(50)
                    .HasColumnName("Tbl_MilitaryService_Name");

                entity.Property(e => e.TblPersonId).HasColumnName("Tbl_Person_Id");

                entity.Property(e => e.TblPersonTypeId).HasColumnName("Tbl_PersonType_Id");
            });

            modelBuilder.Entity<ViewPersonVisitedUrl>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PersonVisitedUrl");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("IP");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PId).HasColumnName("pId");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.VId).HasColumnName("vId");
            });

            modelBuilder.Entity<ViewPost>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Post");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRoleTypeMatrix>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_RoleTypeMatrix");

                entity.Property(e => e.Dim1NameE)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Dim1_NameE");

                entity.Property(e => e.Dim1NameF)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dim1_NameF");

                entity.Property(e => e.Dim2NameF)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dim2_NameF");

                entity.Property(e => e.Dim2Namee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Dim2_Namee");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
