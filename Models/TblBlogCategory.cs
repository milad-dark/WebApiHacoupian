using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblBlogCategory
    {
        public long Id { get; set; }
        public long TblBlogId { get; set; }
        public long TblCategoryId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblBlog TblBlog { get; set; }
        public virtual TblCategory TblCategory { get; set; }
    }
}
