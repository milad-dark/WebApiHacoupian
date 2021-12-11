using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblRawMaterialAlbumDistribution
    {
        public long Id { get; set; }
        public long TblRawMaterialAlbumId { get; set; }
        public long TblPlaceTypeId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPlaceType TblPlaceType { get; set; }
        public virtual TblRawMaterialAlbum TblRawMaterialAlbum { get; set; }
    }
}
