using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblPlaceTypeImage
    {
        public long Id { get; set; }
        public long TblPlaceTypeId { get; set; }
        public byte[] Image { get; set; }
        public string Url { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPlaceType TblPlaceType { get; set; }
    }
}
