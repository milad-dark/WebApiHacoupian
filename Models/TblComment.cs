using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblComment
    {
        public TblComment()
        {
            TblCommentLikes = new HashSet<TblCommentLike>();
        }

        public long Id { get; set; }
        public long TblBlogId { get; set; }
        public long TblPersonId { get; set; }
        public string Reply { get; set; }
        public string Date { get; set; }
        public TimeSpan Time { get; set; }
        public int ParentId { get; set; }
        public string Explanation { get; set; }
        public byte? Status { get; set; }
        public bool? IsSent { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? Guid { get; set; }

        public virtual TblBlog TblBlog { get; set; }
        public virtual TblPerson TblPerson { get; set; }
        public virtual ICollection<TblCommentLike> TblCommentLikes { get; set; }
    }
}
