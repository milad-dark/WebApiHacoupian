using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCourse
    {
        public TblCourse()
        {
            TblCourseAudiences = new HashSet<TblCourseAudience>();
            TblCourseDays = new HashSet<TblCourseDay>();
        }

        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblPlaceTypeId { get; set; }
        public long TblCourseNameId { get; set; }
        public long TblGoalId { get; set; }
        public string Code { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCourseName TblCourseName { get; set; }
        public virtual TblGoal TblGoal { get; set; }
        public virtual TblPerson TblPerson { get; set; }
        public virtual TblPlaceType TblPlaceType { get; set; }
        public virtual ICollection<TblCourseAudience> TblCourseAudiences { get; set; }
        public virtual ICollection<TblCourseDay> TblCourseDays { get; set; }
    }
}
