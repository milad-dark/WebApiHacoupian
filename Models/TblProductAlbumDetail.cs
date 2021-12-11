using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblProductAlbumDetail
    {
        public long Id { get; set; }
        public long TblProductAlbumCategoryId { get; set; }
        public long TblRawMaterialProductId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblProductAlbumCategory TblProductAlbumCategory { get; set; }
        public virtual TblRawMaterialProduct TblRawMaterialProduct { get; set; }
    }
}
