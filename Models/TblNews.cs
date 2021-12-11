using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblNews
    {
        public TblNews()
        {
            TblNewsPhotos = new HashSet<TblNewsPhoto>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Article { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public string PublishDate { get; set; }
        public byte[] Thumbnail { get; set; }
        public bool IsOffer { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblNewsPhoto> TblNewsPhotos { get; set; }
    }
}
