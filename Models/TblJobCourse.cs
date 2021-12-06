using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblJobCourse
    {
        public long Id { get; set; }
        public long TblJobId { get; set; }
        public long TblCourseNameId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCourseName TblCourseName { get; set; }
        public virtual TblJob TblJob { get; set; }
    }
}
