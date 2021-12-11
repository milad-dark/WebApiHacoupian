using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblBlogTag
    {
        public long Id { get; set; }
        public long TblBlogId { get; set; }
        public long TblTagId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblBlog TblBlog { get; set; }
        public virtual TblTag TblTag { get; set; }
    }
}
