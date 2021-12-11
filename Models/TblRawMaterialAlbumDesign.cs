using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblRawMaterialAlbumDesign
    {
        public long Id { get; set; }
        public long TblRawMaterialAlbumId { get; set; }
        public long TblCodingPatternValueId { get; set; }
        public string Price { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblRawMaterialAlbum TblRawMaterialAlbum { get; set; }
    }
}
