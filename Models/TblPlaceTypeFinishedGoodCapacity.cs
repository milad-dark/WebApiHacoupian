using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPlaceTypeFinishedGoodCapacity
    {
        public long Id { get; set; }
        public long TblPlaceTypeId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string PartCode { get; set; }
        public long MainCapacity { get; set; }
        public long SideCapacity { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPlaceType TblPlaceType { get; set; }
    }
}
