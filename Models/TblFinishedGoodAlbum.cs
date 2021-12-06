using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblFinishedGoodAlbum
    {
        public TblFinishedGoodAlbum()
        {
            TblFinishedGoodAlbumDistributions = new HashSet<TblFinishedGoodAlbumDistribution>();
            TblFinishedGoodAlbumPricings = new HashSet<TblFinishedGoodAlbumPricing>();
            TblFinishedGoodAlbumRawMaterialProducts = new HashSet<TblFinishedGoodAlbumRawMaterialProduct>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblFinishedGoodAlbumDistribution> TblFinishedGoodAlbumDistributions { get; set; }
        public virtual ICollection<TblFinishedGoodAlbumPricing> TblFinishedGoodAlbumPricings { get; set; }
        public virtual ICollection<TblFinishedGoodAlbumRawMaterialProduct> TblFinishedGoodAlbumRawMaterialProducts { get; set; }
    }
}
