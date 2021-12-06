using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblBlogGoal
    {
        public long Id { get; set; }
        public long TblBlogId { get; set; }
        public long TblGoalId { get; set; }
        public string Explanation { get; set; }
        public byte? Status { get; set; }
        public Guid? Guid { get; set; }
        public bool? IsSent { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TblBlog TblBlog { get; set; }
        public virtual TblGoal TblGoal { get; set; }
    }
}
