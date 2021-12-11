using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblFinishedGoodAlbumDesign
    {
        public long Id { get; set; }
        public long TblCodingPatternValueTypeIdAsProductGroup { get; set; }
        public long TblCodingPatternValueTypeId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCodingPatternValueType TblCodingPatternValueType { get; set; }
        public virtual TblCodingPatternValueType TblCodingPatternValueTypeIdAsProductGroupNavigation { get; set; }
    }
}
