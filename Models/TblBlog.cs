using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblBlog
    {
        public TblBlog()
        {
            TblBlogAttachments = new HashSet<TblBlogAttachment>();
            TblBlogCategories = new HashSet<TblBlogCategory>();
            TblBlogGoals = new HashSet<TblBlogGoal>();
            TblBlogLikes = new HashSet<TblBlogLike>();
            TblBlogTags = new HashSet<TblBlogTag>();
            TblComments = new HashSet<TblComment>();
        }

        public long Id { get; set; }
        public long TblPersonIdAsAuthor { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Body { get; set; }
        public string Date { get; set; }
        public TimeSpan Time { get; set; }
        public string FileName { get; set; }
        public byte[] Image { get; set; }
        public string ContentType { get; set; }
        public string LastReview { get; set; }
        public long ReviewNumber { get; set; }
        public string RunSchedule { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPerson TblPersonIdAsAuthorNavigation { get; set; }
        public virtual ICollection<TblBlogAttachment> TblBlogAttachments { get; set; }
        public virtual ICollection<TblBlogCategory> TblBlogCategories { get; set; }
        public virtual ICollection<TblBlogGoal> TblBlogGoals { get; set; }
        public virtual ICollection<TblBlogLike> TblBlogLikes { get; set; }
        public virtual ICollection<TblBlogTag> TblBlogTags { get; set; }
        public virtual ICollection<TblComment> TblComments { get; set; }
    }
}
