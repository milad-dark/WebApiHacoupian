using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblFinishedGoodBeginPeriod
    {
        public long Id { get; set; }
        public long TblFinishedGoodProductId { get; set; }
        public long TblPlaceTypeId { get; set; }
        public string Date { get; set; }
        public double Price { get; set; }
        public double Count { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFinishedGoodProduct TblFinishedGoodProduct { get; set; }
        public virtual TblPlaceType TblPlaceType { get; set; }
    }
}
