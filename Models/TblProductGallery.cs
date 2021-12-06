using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblProductGallery
    {
        public long Id { get; set; }
        public long? TblProductId { get; set; }
        public byte[] Image { get; set; }
        public long? ImageAngle { get; set; }
        public long? ImageOrder { get; set; }
        public string ImageUrl { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public string Explanation { get; set; }
        public byte? Status { get; set; }
        public Guid? Guid { get; set; }
        public bool? IsSent { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TblProduct TblProduct { get; set; }
    }
}
