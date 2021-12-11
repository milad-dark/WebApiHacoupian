using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCodingPatternValueType
    {
        public TblCodingPatternValueType()
        {
            TblCodingPatternValues = new HashSet<TblCodingPatternValue>();
            TblFinishedGoodAlbumDesignTblCodingPatternValueTypeIdAsProductGroupNavigations = new HashSet<TblFinishedGoodAlbumDesign>();
            TblFinishedGoodAlbumDesignTblCodingPatternValueTypes = new HashSet<TblFinishedGoodAlbumDesign>();
            TblFinishedGoodAlbumPermissions = new HashSet<TblFinishedGoodAlbumPermission>();
            TblFinishedGoodAlbumPricingTblCodingPatternValueTypeIdAsProductGroupNavigations = new HashSet<TblFinishedGoodAlbumPricing>();
            TblFinishedGoodAlbumPricingTblCodingPatternValueTypes = new HashSet<TblFinishedGoodAlbumPricing>();
            TblProductAlbumHeaders = new HashSet<TblProductAlbumHeader>();
            TblProductAlbumMoreInfos = new HashSet<TblProductAlbumMoreInfo>();
        }

        public long Id { get; set; }
        public long TblCodingPatternKeyId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblCodingPatternValue> TblCodingPatternValues { get; set; }
        public virtual ICollection<TblFinishedGoodAlbumDesign> TblFinishedGoodAlbumDesignTblCodingPatternValueTypeIdAsProductGroupNavigations { get; set; }
        public virtual ICollection<TblFinishedGoodAlbumDesign> TblFinishedGoodAlbumDesignTblCodingPatternValueTypes { get; set; }
        public virtual ICollection<TblFinishedGoodAlbumPermission> TblFinishedGoodAlbumPermissions { get; set; }
        public virtual ICollection<TblFinishedGoodAlbumPricing> TblFinishedGoodAlbumPricingTblCodingPatternValueTypeIdAsProductGroupNavigations { get; set; }
        public virtual ICollection<TblFinishedGoodAlbumPricing> TblFinishedGoodAlbumPricingTblCodingPatternValueTypes { get; set; }
        public virtual ICollection<TblProductAlbumHeader> TblProductAlbumHeaders { get; set; }
        public virtual ICollection<TblProductAlbumMoreInfo> TblProductAlbumMoreInfos { get; set; }
    }
}
