using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblProductAlbum
    {
        public TblProductAlbum()
        {
            TblProductAlbumCategories = new HashSet<TblProductAlbumCategory>();
        }

        public long Id { get; set; }
        public long Number { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblProductAlbumCategory> TblProductAlbumCategories { get; set; }
    }
}
