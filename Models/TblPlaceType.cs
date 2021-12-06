using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblPlaceType
    {
        public TblPlaceType()
        {
            TblAssets = new HashSet<TblAsset>();
            TblBeginPeriods = new HashSet<TblBeginPeriod>();
            TblCompanyPlaces = new HashSet<TblCompanyPlace>();
            TblCostFactors = new HashSet<TblCostFactor>();
            TblCourses = new HashSet<TblCourse>();
            TblCustomerCareSheetItemDefects = new HashSet<TblCustomerCareSheetItemDefect>();
            TblCustomerCareSheetItemTrackingTblPlaceTypeAsIssuers = new HashSet<TblCustomerCareSheetItemTracking>();
            TblCustomerCareSheetItemTrackingTblPlaceTypeAsReceivers = new HashSet<TblCustomerCareSheetItemTracking>();
            TblCustomerCareSheets = new HashSet<TblCustomerCareSheet>();
            TblDepartmentGoals = new HashSet<TblDepartmentGoal>();
            TblDraftOrderTblPlaceTypeIdAsIssuerNavigations = new HashSet<TblDraftOrder>();
            TblDraftOrderTblPlaceTypeIdAsReceiverNavigations = new HashSet<TblDraftOrder>();
            TblEmploymentRequests = new HashSet<TblEmploymentRequest>();
            TblEmployments = new HashSet<TblEmployment>();
            TblEventPlaceTypes = new HashSet<TblEventPlaceType>();
            TblFinishedGoodAlbumDistributions = new HashSet<TblFinishedGoodAlbumDistribution>();
            TblFinishedGoodAlbumPermissions = new HashSet<TblFinishedGoodAlbumPermission>();
            TblFinishedGoodAppliedPricings = new HashSet<TblFinishedGoodAppliedPricing>();
            TblFinishedGoodBeginPeriods = new HashSet<TblFinishedGoodBeginPeriod>();
            TblFinishedGoodPricingResults = new HashSet<TblFinishedGoodPricingResult>();
            TblFinishedGoodStockSheetTblPlaceTypeIdAsIssuerNavigations = new HashSet<TblFinishedGoodStockSheet>();
            TblFinishedGoodStockSheetTblPlaceTypeIdAsReceiverNavigations = new HashSet<TblFinishedGoodStockSheet>();
            TblInsuranceBranches = new HashSet<TblInsuranceBranch>();
            TblInvoiceMasterTblPlaceTypeIdAsIssuerNavigations = new HashSet<TblInvoiceMaster>();
            TblInvoiceMasterTblPlaceTypeIdAsReceiverNavigations = new HashSet<TblInvoiceMaster>();
            TblIspcontracts = new HashSet<TblIspcontract>();
            TblJobs = new HashSet<TblJob>();
            TblLetterTblPlaceTypeIdAsIssueNavigations = new HashSet<TblLetter>();
            TblLetterTblPlaceTypeIdAsReceiverNavigations = new HashSet<TblLetter>();
            TblOrderHeaders = new HashSet<TblOrderHeader>();
            TblPersonCertificates = new HashSet<TblPersonCertificate>();
            TblPlaceTypeFinishedGoodCapacities = new HashSet<TblPlaceTypeFinishedGoodCapacity>();
            TblPlaceTypeImages = new HashSet<TblPlaceTypeImage>();
            TblPlaces = new HashSet<TblPlace>();
            TblProductAlbumDistributions = new HashSet<TblProductAlbumDistribution>();
            TblProductionOrderTrackingTblPlaceTypeIdAsIssuerNavigations = new HashSet<TblProductionOrderTracking>();
            TblProductionOrderTrackingTblPlaceTypeIdAsReceiverNavigations = new HashSet<TblProductionOrderTracking>();
            TblRawMaterialAlbumDistributions = new HashSet<TblRawMaterialAlbumDistribution>();
            TblRawMaterialBeginPeriods = new HashSet<TblRawMaterialBeginPeriod>();
            TblRawMaterialStockSheetTblPlaceTypeIdAsIssuerNavigations = new HashSet<TblRawMaterialStockSheet>();
            TblRawMaterialStockSheetTblPlaceTypeIdAsReceiverNavigations = new HashSet<TblRawMaterialStockSheet>();
            TblStockSheetTblPlaceTypeIdAsIssuerNavigations = new HashSet<TblStockSheet>();
            TblStockSheetTblPlaceTypeIdAsReceiverNavigations = new HashSet<TblStockSheet>();
            TblStorePlans = new HashSet<TblStorePlan>();
            TblTaxBranches = new HashSet<TblTaxBranch>();
        }

        public long Id { get; set; }
        public string PlaceTypeCode { get; set; }
        public string PlaceTypeName { get; set; }
        public string FinishedGoodProductAccountCode { get; set; }
        public string RawMaterialAccountCode { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblAsset> TblAssets { get; set; }
        public virtual ICollection<TblBeginPeriod> TblBeginPeriods { get; set; }
        public virtual ICollection<TblCompanyPlace> TblCompanyPlaces { get; set; }
        public virtual ICollection<TblCostFactor> TblCostFactors { get; set; }
        public virtual ICollection<TblCourse> TblCourses { get; set; }
        public virtual ICollection<TblCustomerCareSheetItemDefect> TblCustomerCareSheetItemDefects { get; set; }
        public virtual ICollection<TblCustomerCareSheetItemTracking> TblCustomerCareSheetItemTrackingTblPlaceTypeAsIssuers { get; set; }
        public virtual ICollection<TblCustomerCareSheetItemTracking> TblCustomerCareSheetItemTrackingTblPlaceTypeAsReceivers { get; set; }
        public virtual ICollection<TblCustomerCareSheet> TblCustomerCareSheets { get; set; }
        public virtual ICollection<TblDepartmentGoal> TblDepartmentGoals { get; set; }
        public virtual ICollection<TblDraftOrder> TblDraftOrderTblPlaceTypeIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblDraftOrder> TblDraftOrderTblPlaceTypeIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblEmploymentRequest> TblEmploymentRequests { get; set; }
        public virtual ICollection<TblEmployment> TblEmployments { get; set; }
        public virtual ICollection<TblEventPlaceType> TblEventPlaceTypes { get; set; }
        public virtual ICollection<TblFinishedGoodAlbumDistribution> TblFinishedGoodAlbumDistributions { get; set; }
        public virtual ICollection<TblFinishedGoodAlbumPermission> TblFinishedGoodAlbumPermissions { get; set; }
        public virtual ICollection<TblFinishedGoodAppliedPricing> TblFinishedGoodAppliedPricings { get; set; }
        public virtual ICollection<TblFinishedGoodBeginPeriod> TblFinishedGoodBeginPeriods { get; set; }
        public virtual ICollection<TblFinishedGoodPricingResult> TblFinishedGoodPricingResults { get; set; }
        public virtual ICollection<TblFinishedGoodStockSheet> TblFinishedGoodStockSheetTblPlaceTypeIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblFinishedGoodStockSheet> TblFinishedGoodStockSheetTblPlaceTypeIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblInsuranceBranch> TblInsuranceBranches { get; set; }
        public virtual ICollection<TblInvoiceMaster> TblInvoiceMasterTblPlaceTypeIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblInvoiceMaster> TblInvoiceMasterTblPlaceTypeIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblIspcontract> TblIspcontracts { get; set; }
        public virtual ICollection<TblJob> TblJobs { get; set; }
        public virtual ICollection<TblLetter> TblLetterTblPlaceTypeIdAsIssueNavigations { get; set; }
        public virtual ICollection<TblLetter> TblLetterTblPlaceTypeIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblOrderHeader> TblOrderHeaders { get; set; }
        public virtual ICollection<TblPersonCertificate> TblPersonCertificates { get; set; }
        public virtual ICollection<TblPlaceTypeFinishedGoodCapacity> TblPlaceTypeFinishedGoodCapacities { get; set; }
        public virtual ICollection<TblPlaceTypeImage> TblPlaceTypeImages { get; set; }
        public virtual ICollection<TblPlace> TblPlaces { get; set; }
        public virtual ICollection<TblProductAlbumDistribution> TblProductAlbumDistributions { get; set; }
        public virtual ICollection<TblProductionOrderTracking> TblProductionOrderTrackingTblPlaceTypeIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblProductionOrderTracking> TblProductionOrderTrackingTblPlaceTypeIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblRawMaterialAlbumDistribution> TblRawMaterialAlbumDistributions { get; set; }
        public virtual ICollection<TblRawMaterialBeginPeriod> TblRawMaterialBeginPeriods { get; set; }
        public virtual ICollection<TblRawMaterialStockSheet> TblRawMaterialStockSheetTblPlaceTypeIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblRawMaterialStockSheet> TblRawMaterialStockSheetTblPlaceTypeIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblStockSheet> TblStockSheetTblPlaceTypeIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblStockSheet> TblStockSheetTblPlaceTypeIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblStorePlan> TblStorePlans { get; set; }
        public virtual ICollection<TblTaxBranch> TblTaxBranches { get; set; }
    }
}
