#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblFinishedGoodReportTemporaryTable
    {
        public long Id { get; set; }
        public long? TblCompanyId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public long? TblPlaceTypeId { get; set; }
        public long? TempRemain { get; set; }
        public string PlaceTypeName { get; set; }
        public string ProductGroupCode { get; set; }
        public string ProductGroupName { get; set; }
        public string ProductCompositionCode { get; set; }
        public string ProductCompositionName { get; set; }
        public string ProductPatternCode { get; set; }
        public string ProductPatternName { get; set; }
        public string ProductModelCode { get; set; }
        public string ProductModelName { get; set; }
        public string ProductColorCode { get; set; }
        public string ProductColorName { get; set; }
        public string ProductSizeCode { get; set; }
        public string ProductSizeName { get; set; }
        public string ProductKaliteCode { get; set; }
        public string ProductKaliteName { get; set; }
        public string ProductDesign { get; set; }
        public string Supplier { get; set; }
        public long? TblFinishedGoodProductId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long? FirstPrice { get; set; }
        public long? SalesPrice { get; set; }
        public long? BeginPeriod { get; set; }
        public long? BeginPeriodPrice { get; set; }
        public long? InWareHouse { get; set; }
        public long? InWareHousePrice { get; set; }
        public long? OutWareHouse { get; set; }
        public long? OutWareHousePrice { get; set; }
        public long? Adjustment { get; set; }
        public long? AdjustmentPrice { get; set; }
        public long? ReplacementIn { get; set; }
        public long? ReplacementInPrice { get; set; }
        public long? ReplacementOut { get; set; }
        public long? ReplacementOutPrice { get; set; }
        public long? SaleCountIn { get; set; }
        public long? SalePriceIn { get; set; }
        public long? SaleCountOut { get; set; }
        public long? SalePriceOut { get; set; }
        public long? PricingCount { get; set; }
        public long? PricingPrice { get; set; }
        public long? InventoryDays { get; set; }
        public long? Capacity { get; set; }
        public long? InDraftCount { get; set; }
        public long? InDraftPrice { get; set; }
        public long? OutDraftCount { get; set; }
        public long? OutDraftPrice { get; set; }
    }
}
