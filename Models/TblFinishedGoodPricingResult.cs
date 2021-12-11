using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblFinishedGoodPricingResult
    {
        public long Id { get; set; }
        public long TblFinishedGoodStockSheetId { get; set; }
        public long TblPlaceTypeId { get; set; }
        public long TblFinishedGoodProductId { get; set; }
        public long Count { get; set; }
        public long OldPrice { get; set; }
        public long NewPrice { get; set; }
        public long Price { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFinishedGoodProduct TblFinishedGoodProduct { get; set; }
        public virtual TblFinishedGoodStockSheet TblFinishedGoodStockSheet { get; set; }
        public virtual TblPlaceType TblPlaceType { get; set; }
    }
}
