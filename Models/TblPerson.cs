using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblPerson
    {
        public TblPerson()
        {
            TblAbsenceLicenseRequestDetails = new HashSet<TblAbsenceLicenseRequestDetail>();
            TblAbsenceLicenseRequests = new HashSet<TblAbsenceLicenseRequest>();
            TblAbsenceLicenses = new HashSet<TblAbsenceLicense>();
            TblAttachments = new HashSet<TblAttachment>();
            TblBankBranchAccounts = new HashSet<TblBankBranchAccount>();
            TblBlogLikes = new HashSet<TblBlogLike>();
            TblBlogs = new HashSet<TblBlog>();
            TblBpmns = new HashSet<TblBpmn>();
            TblCallHistoryTblPersonIdAsFromPersonNavigations = new HashSet<TblCallHistory>();
            TblCallHistoryTblPersonIdAsToPersonNavigations = new HashSet<TblCallHistory>();
            TblChatTblPersonIdAsFromNavigations = new HashSet<TblChat>();
            TblChatTblPersonIdAsToNavigations = new HashSet<TblChat>();
            TblCommentLikes = new HashSet<TblCommentLike>();
            TblComments = new HashSet<TblComment>();
            TblCompanyPeople = new HashSet<TblCompanyPerson>();
            TblCorrections = new HashSet<TblCorrection>();
            TblCourseAudiences = new HashSet<TblCourseAudience>();
            TblCourses = new HashSet<TblCourse>();
            TblCustomerCareSheetItemDefects = new HashSet<TblCustomerCareSheetItemDefect>();
            TblCustomerCareSheetItemTrackingTblPersonAsIssuers = new HashSet<TblCustomerCareSheetItemTracking>();
            TblCustomerCareSheetItemTrackingTblPersonAsReceivers = new HashSet<TblCustomerCareSheetItemTracking>();
            TblCustomerCareSheets = new HashSet<TblCustomerCareSheet>();
            TblDraftOrderItems = new HashSet<TblDraftOrderItem>();
            TblDraftOrderTblPersonIdAsIssuerNavigations = new HashSet<TblDraftOrder>();
            TblDraftOrderTblPersonIdAsReceiverNavigations = new HashSet<TblDraftOrder>();
            TblEmployeeAttendances = new HashSet<TblEmployeeAttendance>();
            TblEmploymentRequests = new HashSet<TblEmploymentRequest>();
            TblEmployments = new HashSet<TblEmployment>();
            TblExports = new HashSet<TblExport>();
            TblFamilyTblPeople = new HashSet<TblFamily>();
            TblFamilyTblPersonIdAsFamilyNavigations = new HashSet<TblFamily>();
            TblFinishedGoodStockSheetTblPersonIdAsIssuerNavigations = new HashSet<TblFinishedGoodStockSheet>();
            TblFinishedGoodStockSheetTblPersonIdAsReceiverNavigations = new HashSet<TblFinishedGoodStockSheet>();
            TblFirs = new HashSet<TblFir>();
            TblFormFieldValues = new HashSet<TblFormFieldValue>();
            TblHistories = new HashSet<TblHistory>();
            TblImprests = new HashSet<TblImprest>();
            TblInvoiceMasterTblPeople = new HashSet<TblInvoiceMaster>();
            TblInvoiceMasterTblPersonIdAsIssuerNavigations = new HashSet<TblInvoiceMaster>();
            TblInvoiceMasterTblPersonIdAsReceiverNavigations = new HashSet<TblInvoiceMaster>();
            TblIspcontracts = new HashSet<TblIspcontract>();
            TblLetterTblPersonIdAsIssueNavigations = new HashSet<TblLetter>();
            TblLetterTblPersonIdAsReceiverNavigations = new HashSet<TblLetter>();
            TblLifeStatuses = new HashSet<TblLifeStatus>();
            TblLoans = new HashSet<TblLoan>();
            TblMonthlyReports = new HashSet<TblMonthlyReport>();
            TblOrderHeaderOwners = new HashSet<TblOrderHeaderOwner>();
            TblOrderHeaders = new HashSet<TblOrderHeader>();
            TblPayrollFactors = new HashSet<TblPayrollFactor>();
            TblPersonCertificates = new HashSet<TblPersonCertificate>();
            TblPersonCharges = new HashSet<TblPersonCharge>();
            TblPersonDevices = new HashSet<TblPersonDevice>();
            TblPersonEmploymentRequests = new HashSet<TblPersonEmploymentRequest>();
            TblPersonEvaluations = new HashSet<TblPersonEvaluation>();
            TblPersonGroups = new HashSet<TblPersonGroup>();
            TblPersonInterests = new HashSet<TblPersonInterest>();
            TblPersonInterviews = new HashSet<TblPersonInterview>();
            TblPersonMeals = new HashSet<TblPersonMeal>();
            TblPersonNoteTblPersonIdAsFromNavigations = new HashSet<TblPersonNote>();
            TblPersonNoteTblPersonIdAsToNavigations = new HashSet<TblPersonNote>();
            TblPersonPermissions = new HashSet<TblPersonPermission>();
            TblPersonRoles = new HashSet<TblPersonRole>();
            TblPersonSkills = new HashSet<TblPersonSkill>();
            TblPersonSystems = new HashSet<TblPersonSystem>();
            TblPersonVisitedUrls = new HashSet<TblPersonVisitedUrl>();
            TblPhones = new HashSet<TblPhone>();
            TblPlaces = new HashSet<TblPlace>();
            TblPollProductQualities = new HashSet<TblPollProductQuality>();
            TblPollServiceQualities = new HashSet<TblPollServiceQuality>();
            TblProcesses = new HashSet<TblProcess>();
            TblProcessingResults = new HashSet<TblProcessingResult>();
            TblProductionOrderTrackingTblPersonIdAsIssuerNavigations = new HashSet<TblProductionOrderTracking>();
            TblProductionOrderTrackingTblPersonIdAsReceiverNavigations = new HashSet<TblProductionOrderTracking>();
            TblProjectTaskAttachments = new HashSet<TblProjectTaskAttachment>();
            TblProjectTaskChats = new HashSet<TblProjectTaskChat>();
            TblProjectTaskRecipientTblPeople = new HashSet<TblProjectTaskRecipient>();
            TblProjectTaskRecipientTblPersonIdAsLoginNavigations = new HashSet<TblProjectTaskRecipient>();
            TblRawMaterialStockSheetTblPersonIdAsIssuerNavigations = new HashSet<TblRawMaterialStockSheet>();
            TblRawMaterialStockSheetTblPersonIdAsReceiverNavigations = new HashSet<TblRawMaterialStockSheet>();
            TblSafeReceiptPayments = new HashSet<TblSafeReceiptPayment>();
            TblServiceEmployees = new HashSet<TblServiceEmployee>();
            TblShiftEmployees = new HashSet<TblShiftEmployee>();
            TblSms = new HashSet<TblSm>();
            TblStockSheetTblPersonIdAsIssuerNavigations = new HashSet<TblStockSheet>();
            TblStockSheetTblPersonIdAsReceiverNavigations = new HashSet<TblStockSheet>();
            TblTimeKeepings = new HashSet<TblTimeKeeping>();
            TblWorkOperations = new HashSet<TblWorkOperation>();
        }

        public long Id { get; set; }
        public long TblPersonTypeId { get; set; }
        public long TblCityIdAsBirthPlace { get; set; }
        public long TblCityIdAsIssuePlace { get; set; }
        public long TblCountryIdAsNationality { get; set; }
        public long TblMarriageStatusId { get; set; }
        public long TblMilitaryServiceId { get; set; }
        public long TblReligionId { get; set; }
        public long TblJobId { get; set; }
        public long FileNumber { get; set; }
        public long CardNumber { get; set; }
        public long Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string NationalCode { get; set; }
        public string BirthCertificateNumber { get; set; }
        public string IssueDate { get; set; }
        public string BirthDate { get; set; }
        public string DeathDate { get; set; }
        public string MarriageDate { get; set; }
        public bool Sex { get; set; }
        public string Email { get; set; }
        public bool GetEmail { get; set; }
        public bool GetSms { get; set; }
        public string Nfc { get; set; }
        public string Password { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCity TblCityIdAsBirthPlaceNavigation { get; set; }
        public virtual TblCity TblCityIdAsIssuePlaceNavigation { get; set; }
        public virtual TblCountry TblCountryIdAsNationalityNavigation { get; set; }
        public virtual TblJob TblJob { get; set; }
        public virtual TblMarriageStatus TblMarriageStatus { get; set; }
        public virtual TblMilitaryService TblMilitaryService { get; set; }
        public virtual TblPersonType TblPersonType { get; set; }
        public virtual TblReligion TblReligion { get; set; }
        public virtual ICollection<TblAbsenceLicenseRequestDetail> TblAbsenceLicenseRequestDetails { get; set; }
        public virtual ICollection<TblAbsenceLicenseRequest> TblAbsenceLicenseRequests { get; set; }
        public virtual ICollection<TblAbsenceLicense> TblAbsenceLicenses { get; set; }
        public virtual ICollection<TblAttachment> TblAttachments { get; set; }
        public virtual ICollection<TblBankBranchAccount> TblBankBranchAccounts { get; set; }
        public virtual ICollection<TblBlogLike> TblBlogLikes { get; set; }
        public virtual ICollection<TblBlog> TblBlogs { get; set; }
        public virtual ICollection<TblBpmn> TblBpmns { get; set; }
        public virtual ICollection<TblCallHistory> TblCallHistoryTblPersonIdAsFromPersonNavigations { get; set; }
        public virtual ICollection<TblCallHistory> TblCallHistoryTblPersonIdAsToPersonNavigations { get; set; }
        public virtual ICollection<TblChat> TblChatTblPersonIdAsFromNavigations { get; set; }
        public virtual ICollection<TblChat> TblChatTblPersonIdAsToNavigations { get; set; }
        public virtual ICollection<TblCommentLike> TblCommentLikes { get; set; }
        public virtual ICollection<TblComment> TblComments { get; set; }
        public virtual ICollection<TblCompanyPerson> TblCompanyPeople { get; set; }
        public virtual ICollection<TblCorrection> TblCorrections { get; set; }
        public virtual ICollection<TblCourseAudience> TblCourseAudiences { get; set; }
        public virtual ICollection<TblCourse> TblCourses { get; set; }
        public virtual ICollection<TblCustomerCareSheetItemDefect> TblCustomerCareSheetItemDefects { get; set; }
        public virtual ICollection<TblCustomerCareSheetItemTracking> TblCustomerCareSheetItemTrackingTblPersonAsIssuers { get; set; }
        public virtual ICollection<TblCustomerCareSheetItemTracking> TblCustomerCareSheetItemTrackingTblPersonAsReceivers { get; set; }
        public virtual ICollection<TblCustomerCareSheet> TblCustomerCareSheets { get; set; }
        public virtual ICollection<TblDraftOrderItem> TblDraftOrderItems { get; set; }
        public virtual ICollection<TblDraftOrder> TblDraftOrderTblPersonIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblDraftOrder> TblDraftOrderTblPersonIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblEmployeeAttendance> TblEmployeeAttendances { get; set; }
        public virtual ICollection<TblEmploymentRequest> TblEmploymentRequests { get; set; }
        public virtual ICollection<TblEmployment> TblEmployments { get; set; }
        public virtual ICollection<TblExport> TblExports { get; set; }
        public virtual ICollection<TblFamily> TblFamilyTblPeople { get; set; }
        public virtual ICollection<TblFamily> TblFamilyTblPersonIdAsFamilyNavigations { get; set; }
        public virtual ICollection<TblFinishedGoodStockSheet> TblFinishedGoodStockSheetTblPersonIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblFinishedGoodStockSheet> TblFinishedGoodStockSheetTblPersonIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblFir> TblFirs { get; set; }
        public virtual ICollection<TblFormFieldValue> TblFormFieldValues { get; set; }
        public virtual ICollection<TblHistory> TblHistories { get; set; }
        public virtual ICollection<TblImprest> TblImprests { get; set; }
        public virtual ICollection<TblInvoiceMaster> TblInvoiceMasterTblPeople { get; set; }
        public virtual ICollection<TblInvoiceMaster> TblInvoiceMasterTblPersonIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblInvoiceMaster> TblInvoiceMasterTblPersonIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblIspcontract> TblIspcontracts { get; set; }
        public virtual ICollection<TblLetter> TblLetterTblPersonIdAsIssueNavigations { get; set; }
        public virtual ICollection<TblLetter> TblLetterTblPersonIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblLifeStatus> TblLifeStatuses { get; set; }
        public virtual ICollection<TblLoan> TblLoans { get; set; }
        public virtual ICollection<TblMonthlyReport> TblMonthlyReports { get; set; }
        public virtual ICollection<TblOrderHeaderOwner> TblOrderHeaderOwners { get; set; }
        public virtual ICollection<TblOrderHeader> TblOrderHeaders { get; set; }
        public virtual ICollection<TblPayrollFactor> TblPayrollFactors { get; set; }
        public virtual ICollection<TblPersonCertificate> TblPersonCertificates { get; set; }
        public virtual ICollection<TblPersonCharge> TblPersonCharges { get; set; }
        public virtual ICollection<TblPersonDevice> TblPersonDevices { get; set; }
        public virtual ICollection<TblPersonEmploymentRequest> TblPersonEmploymentRequests { get; set; }
        public virtual ICollection<TblPersonEvaluation> TblPersonEvaluations { get; set; }
        public virtual ICollection<TblPersonGroup> TblPersonGroups { get; set; }
        public virtual ICollection<TblPersonInterest> TblPersonInterests { get; set; }
        public virtual ICollection<TblPersonInterview> TblPersonInterviews { get; set; }
        public virtual ICollection<TblPersonMeal> TblPersonMeals { get; set; }
        public virtual ICollection<TblPersonNote> TblPersonNoteTblPersonIdAsFromNavigations { get; set; }
        public virtual ICollection<TblPersonNote> TblPersonNoteTblPersonIdAsToNavigations { get; set; }
        public virtual ICollection<TblPersonPermission> TblPersonPermissions { get; set; }
        public virtual ICollection<TblPersonRole> TblPersonRoles { get; set; }
        public virtual ICollection<TblPersonSkill> TblPersonSkills { get; set; }
        public virtual ICollection<TblPersonSystem> TblPersonSystems { get; set; }
        public virtual ICollection<TblPersonVisitedUrl> TblPersonVisitedUrls { get; set; }
        public virtual ICollection<TblPhone> TblPhones { get; set; }
        public virtual ICollection<TblPlace> TblPlaces { get; set; }
        public virtual ICollection<TblPollProductQuality> TblPollProductQualities { get; set; }
        public virtual ICollection<TblPollServiceQuality> TblPollServiceQualities { get; set; }
        public virtual ICollection<TblProcess> TblProcesses { get; set; }
        public virtual ICollection<TblProcessingResult> TblProcessingResults { get; set; }
        public virtual ICollection<TblProductionOrderTracking> TblProductionOrderTrackingTblPersonIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblProductionOrderTracking> TblProductionOrderTrackingTblPersonIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblProjectTaskAttachment> TblProjectTaskAttachments { get; set; }
        public virtual ICollection<TblProjectTaskChat> TblProjectTaskChats { get; set; }
        public virtual ICollection<TblProjectTaskRecipient> TblProjectTaskRecipientTblPeople { get; set; }
        public virtual ICollection<TblProjectTaskRecipient> TblProjectTaskRecipientTblPersonIdAsLoginNavigations { get; set; }
        public virtual ICollection<TblRawMaterialStockSheet> TblRawMaterialStockSheetTblPersonIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblRawMaterialStockSheet> TblRawMaterialStockSheetTblPersonIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblSafeReceiptPayment> TblSafeReceiptPayments { get; set; }
        public virtual ICollection<TblServiceEmployee> TblServiceEmployees { get; set; }
        public virtual ICollection<TblShiftEmployee> TblShiftEmployees { get; set; }
        public virtual ICollection<TblSm> TblSms { get; set; }
        public virtual ICollection<TblStockSheet> TblStockSheetTblPersonIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblStockSheet> TblStockSheetTblPersonIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblTimeKeeping> TblTimeKeepings { get; set; }
        public virtual ICollection<TblWorkOperation> TblWorkOperations { get; set; }
    }
}
