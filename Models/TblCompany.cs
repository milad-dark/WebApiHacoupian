using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCompany
    {
        public TblCompany()
        {
            TblAssetGroups = new HashSet<TblAssetGroup>();
            TblBankBranchAccounts = new HashSet<TblBankBranchAccount>();
            TblCodingPatterns = new HashSet<TblCodingPattern>();
            TblCompanyCharges = new HashSet<TblCompanyCharge>();
            TblCompanyPeople = new HashSet<TblCompanyPerson>();
            TblCompanyPhones = new HashSet<TblCompanyPhone>();
            TblCompanyPlaces = new HashSet<TblCompanyPlace>();
            TblDraftOrderTblCompanyIdAsIssuerNavigations = new HashSet<TblDraftOrder>();
            TblDraftOrderTblCompanyIdAsReceiverNavigations = new HashSet<TblDraftOrder>();
            TblEmployments = new HashSet<TblEmployment>();
            TblFinancialCycles = new HashSet<TblFinancialCycle>();
            TblFinishedGoodExtraInfos = new HashSet<TblFinishedGoodExtraInfo>();
            TblFinishedGoodProducts = new HashSet<TblFinishedGoodProduct>();
            TblFinishedGoodStockSheetTblCompanyIdAsIssuerNavigations = new HashSet<TblFinishedGoodStockSheet>();
            TblFinishedGoodStockSheetTblCompanyIdAsOwnerNavigations = new HashSet<TblFinishedGoodStockSheet>();
            TblFinishedGoodStockSheetTblCompanyIdAsReceiverNavigations = new HashSet<TblFinishedGoodStockSheet>();
            TblInvoiceMasterTblCompanyIdAsIssuerNavigations = new HashSet<TblInvoiceMaster>();
            TblInvoiceMasterTblCompanyIdAsOwnerNavigations = new HashSet<TblInvoiceMaster>();
            TblInvoiceMasterTblCompanyIdAsReceiverNavigations = new HashSet<TblInvoiceMaster>();
            TblIspcontracts = new HashSet<TblIspcontract>();
            TblLedgerInfos = new HashSet<TblLedgerInfo>();
            TblOrderDetails = new HashSet<TblOrderDetail>();
            TblOrderHeaderOwners = new HashSet<TblOrderHeaderOwner>();
            TblOrderHeaders = new HashSet<TblOrderHeader>();
            TblProductionOrderTrackingTblCompanyIdAsIssuerNavigations = new HashSet<TblProductionOrderTracking>();
            TblProductionOrderTrackingTblCompanyIdAsReceiverNavigations = new HashSet<TblProductionOrderTracking>();
            TblProducts = new HashSet<TblProduct>();
            TblRawMaterialProductTblCompanies = new HashSet<TblRawMaterialProduct>();
            TblRawMaterialProductTblCompanyIdAsSupplierNavigations = new HashSet<TblRawMaterialProduct>();
            TblRawMaterialStockSheetTblCompanyIdAsIssuerNavigations = new HashSet<TblRawMaterialStockSheet>();
            TblRawMaterialStockSheetTblCompanyIdAsOwnerNavigations = new HashSet<TblRawMaterialStockSheet>();
            TblRawMaterialStockSheetTblCompanyIdAsReceiverNavigations = new HashSet<TblRawMaterialStockSheet>();
            TblStockSheetTblCompanyIdAsIssuerNavigations = new HashSet<TblStockSheet>();
            TblStockSheetTblCompanyIdAsOwnerNavigations = new HashSet<TblStockSheet>();
            TblStockSheetTblCompanyIdAsReceiverNavigations = new HashSet<TblStockSheet>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public byte[] Logo { get; set; }
        public string EconomicNumber { get; set; }
        public string RegistrationNumber { get; set; }
        public string NationalNumber { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblAssetGroup> TblAssetGroups { get; set; }
        public virtual ICollection<TblBankBranchAccount> TblBankBranchAccounts { get; set; }
        public virtual ICollection<TblCodingPattern> TblCodingPatterns { get; set; }
        public virtual ICollection<TblCompanyCharge> TblCompanyCharges { get; set; }
        public virtual ICollection<TblCompanyPerson> TblCompanyPeople { get; set; }
        public virtual ICollection<TblCompanyPhone> TblCompanyPhones { get; set; }
        public virtual ICollection<TblCompanyPlace> TblCompanyPlaces { get; set; }
        public virtual ICollection<TblDraftOrder> TblDraftOrderTblCompanyIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblDraftOrder> TblDraftOrderTblCompanyIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblEmployment> TblEmployments { get; set; }
        public virtual ICollection<TblFinancialCycle> TblFinancialCycles { get; set; }
        public virtual ICollection<TblFinishedGoodExtraInfo> TblFinishedGoodExtraInfos { get; set; }
        public virtual ICollection<TblFinishedGoodProduct> TblFinishedGoodProducts { get; set; }
        public virtual ICollection<TblFinishedGoodStockSheet> TblFinishedGoodStockSheetTblCompanyIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblFinishedGoodStockSheet> TblFinishedGoodStockSheetTblCompanyIdAsOwnerNavigations { get; set; }
        public virtual ICollection<TblFinishedGoodStockSheet> TblFinishedGoodStockSheetTblCompanyIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblInvoiceMaster> TblInvoiceMasterTblCompanyIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblInvoiceMaster> TblInvoiceMasterTblCompanyIdAsOwnerNavigations { get; set; }
        public virtual ICollection<TblInvoiceMaster> TblInvoiceMasterTblCompanyIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblIspcontract> TblIspcontracts { get; set; }
        public virtual ICollection<TblLedgerInfo> TblLedgerInfos { get; set; }
        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }
        public virtual ICollection<TblOrderHeaderOwner> TblOrderHeaderOwners { get; set; }
        public virtual ICollection<TblOrderHeader> TblOrderHeaders { get; set; }
        public virtual ICollection<TblProductionOrderTracking> TblProductionOrderTrackingTblCompanyIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblProductionOrderTracking> TblProductionOrderTrackingTblCompanyIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblProduct> TblProducts { get; set; }
        public virtual ICollection<TblRawMaterialProduct> TblRawMaterialProductTblCompanies { get; set; }
        public virtual ICollection<TblRawMaterialProduct> TblRawMaterialProductTblCompanyIdAsSupplierNavigations { get; set; }
        public virtual ICollection<TblRawMaterialStockSheet> TblRawMaterialStockSheetTblCompanyIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblRawMaterialStockSheet> TblRawMaterialStockSheetTblCompanyIdAsOwnerNavigations { get; set; }
        public virtual ICollection<TblRawMaterialStockSheet> TblRawMaterialStockSheetTblCompanyIdAsReceiverNavigations { get; set; }
        public virtual ICollection<TblStockSheet> TblStockSheetTblCompanyIdAsIssuerNavigations { get; set; }
        public virtual ICollection<TblStockSheet> TblStockSheetTblCompanyIdAsOwnerNavigations { get; set; }
        public virtual ICollection<TblStockSheet> TblStockSheetTblCompanyIdAsReceiverNavigations { get; set; }
    }
}
