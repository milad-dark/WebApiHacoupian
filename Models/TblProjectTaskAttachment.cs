using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblProjectTaskAttachment
    {
        public long Id { get; set; }
        public long? TblProjectTaskId { get; set; }
        public long? TblPersonId { get; set; }
        public byte[] Attachment { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public string Explanation { get; set; }
        public byte? Status { get; set; }
        public Guid? Guid { get; set; }
        public bool? IsSent { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TblPerson TblPerson { get; set; }
        public virtual TblProjectTask TblProjectTask { get; set; }
    }
}
