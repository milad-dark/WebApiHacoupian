using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblProductAlbumHeader
    {
        public TblProductAlbumHeader()
        {
            TblProductAlbumDistributions = new HashSet<TblProductAlbumDistribution>();
            TblProductAlbumMoreInfos = new HashSet<TblProductAlbumMoreInfo>();
        }

        public long Id { get; set; }
        public long TblProductAlbumCategoryId { get; set; }
        public long TblCodingPatternValueTypeId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCodingPatternValueType TblCodingPatternValueType { get; set; }
        public virtual TblProductAlbumCategory TblProductAlbumCategory { get; set; }
        public virtual ICollection<TblProductAlbumDistribution> TblProductAlbumDistributions { get; set; }
        public virtual ICollection<TblProductAlbumMoreInfo> TblProductAlbumMoreInfos { get; set; }
    }
}
