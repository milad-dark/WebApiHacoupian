using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblRawMaterialAlbum
    {
        public TblRawMaterialAlbum()
        {
            TblRawMaterialAlbumDesigns = new HashSet<TblRawMaterialAlbumDesign>();
            TblRawMaterialAlbumDistributions = new HashSet<TblRawMaterialAlbumDistribution>();
        }

        public long Id { get; set; }
        public long TblRawMaterialProductId { get; set; }
        public long Size { get; set; }
        public long Price { get; set; }
        public string GarmentType { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblRawMaterialProduct TblRawMaterialProduct { get; set; }
        public virtual ICollection<TblRawMaterialAlbumDesign> TblRawMaterialAlbumDesigns { get; set; }
        public virtual ICollection<TblRawMaterialAlbumDistribution> TblRawMaterialAlbumDistributions { get; set; }
    }
}
