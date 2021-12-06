using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblFinishedGoodAlbumPricing
    {
        public long Id { get; set; }
        public long TblFinishedGoodAlbumId { get; set; }
        public long TblCodingPatternValueTypeIdAsProductGroup { get; set; }
        public long TblCodingPatternValueTypeId { get; set; }
        public long Price { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCodingPatternValueType TblCodingPatternValueType { get; set; }
        public virtual TblCodingPatternValueType TblCodingPatternValueTypeIdAsProductGroupNavigation { get; set; }
        public virtual TblFinishedGoodAlbum TblFinishedGoodAlbum { get; set; }
    }
}
