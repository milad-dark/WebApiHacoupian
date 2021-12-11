using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblBlogLike
    {
        public long Id { get; set; }
        public long? TblBlogId { get; set; }
        public long? TblPersonId { get; set; }
        public int? Score { get; set; }
        public string Explanation { get; set; }
        public byte? Status { get; set; }
        public Guid? Guid { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsSent { get; set; }

        public virtual TblBlog TblBlog { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
