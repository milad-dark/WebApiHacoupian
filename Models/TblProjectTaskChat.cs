using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblProjectTaskChat
    {
        public long Id { get; set; }
        public long? TblProjectTaskId { get; set; }
        public long? TblPersonId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public string Message { get; set; }
        public string Explanation { get; set; }
        public byte? Status { get; set; }
        public Guid? Guid { get; set; }
        public bool? IsSent { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TblPerson TblPerson { get; set; }
        public virtual TblProjectTask TblProjectTask { get; set; }
    }
}
