using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblProductAlbumCategory
    {
        public TblProductAlbumCategory()
        {
            TblProductAlbumDetails = new HashSet<TblProductAlbumDetail>();
            TblProductAlbumHeaders = new HashSet<TblProductAlbumHeader>();
        }

        public long Id { get; set; }
        public long TblProductAlbumId { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblProductAlbum TblProductAlbum { get; set; }
        public virtual ICollection<TblProductAlbumDetail> TblProductAlbumDetails { get; set; }
        public virtual ICollection<TblProductAlbumHeader> TblProductAlbumHeaders { get; set; }
    }
}
