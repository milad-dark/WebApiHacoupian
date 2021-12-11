using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCourseAudience
    {
        public long Id { get; set; }
        public long TblCourseId { get; set; }
        public long TblPersonId { get; set; }
        public string Score { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCourse TblCourse { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
