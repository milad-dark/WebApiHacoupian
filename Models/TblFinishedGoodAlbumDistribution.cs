using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblFinishedGoodAlbumDistribution
    {
        public long Id { get; set; }
        public long TblFinishedGoodAlbumId { get; set; }
        public long TblPlaceTypeId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFinishedGoodAlbum TblFinishedGoodAlbum { get; set; }
        public virtual TblPlaceType TblPlaceType { get; set; }
    }
}
