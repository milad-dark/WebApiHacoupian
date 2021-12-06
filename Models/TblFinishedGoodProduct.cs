using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblFinishedGoodProduct
    {
        public TblFinishedGoodProduct()
        {
            TblFinishedGoodAppliedPricings = new HashSet<TblFinishedGoodAppliedPricing>();
            TblFinishedGoodBeginPeriods = new HashSet<TblFinishedGoodBeginPeriod>();
            TblFinishedGoodPricingResults = new HashSet<TblFinishedGoodPricingResult>();
            TblFinishedGoodProductGalleries = new HashSet<TblFinishedGoodProductGallery>();
            TblFinishedGoodStockSheetItems = new HashSet<TblFinishedGoodStockSheetItem>();
            TblOrderHeaders = new HashSet<TblOrderHeader>();
            TblPollProductQualities = new HashSet<TblPollProductQuality>();
            TblProductionOrderFinishedGoodProducts = new HashSet<TblProductionOrderFinishedGoodProduct>();
        }

        public long Id { get; set; }
        public long TblCompanyId { get; set; }
        public long TblCodingPatternId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long FirstPrice { get; set; }
        public long SalesPrice { get; set; }
        public string BarCode { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCodingPattern TblCodingPattern { get; set; }
        public virtual TblCompany TblCompany { get; set; }
        public virtual ICollection<TblFinishedGoodAppliedPricing> TblFinishedGoodAppliedPricings { get; set; }
        public virtual ICollection<TblFinishedGoodBeginPeriod> TblFinishedGoodBeginPeriods { get; set; }
        public virtual ICollection<TblFinishedGoodPricingResult> TblFinishedGoodPricingResults { get; set; }
        public virtual ICollection<TblFinishedGoodProductGallery> TblFinishedGoodProductGalleries { get; set; }
        public virtual ICollection<TblFinishedGoodStockSheetItem> TblFinishedGoodStockSheetItems { get; set; }
        public virtual ICollection<TblOrderHeader> TblOrderHeaders { get; set; }
        public virtual ICollection<TblPollProductQuality> TblPollProductQualities { get; set; }
        public virtual ICollection<TblProductionOrderFinishedGoodProduct> TblProductionOrderFinishedGoodProducts { get; set; }
    }
}
