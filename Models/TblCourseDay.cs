using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblCourseDay
    {
        public long Id { get; set; }
        public long TblCourseId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCourse TblCourse { get; set; }
    }
}
