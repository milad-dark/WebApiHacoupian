using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblGoal
    {
        public TblGoal()
        {
            TblBlogGoals = new HashSet<TblBlogGoal>();
            TblCourses = new HashSet<TblCourse>();
            TblEvaluationGoals = new HashSet<TblEvaluationGoal>();
            TblJobGoals = new HashSet<TblJobGoal>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblBlogGoal> TblBlogGoals { get; set; }
        public virtual ICollection<TblCourse> TblCourses { get; set; }
        public virtual ICollection<TblEvaluationGoal> TblEvaluationGoals { get; set; }
        public virtual ICollection<TblJobGoal> TblJobGoals { get; set; }
    }
}
