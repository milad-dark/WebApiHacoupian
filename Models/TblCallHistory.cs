using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblCallHistory
    {
        public long Id { get; set; }
        public long TblPersonIdAsFromPerson { get; set; }
        public long TblPersonIdAsToPerson { get; set; }
        public long TblCallStatusId { get; set; }
        public string FromNumber { get; set; }
        public string ToNumber { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan AnswerTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Comment { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCallStatus TblCallStatus { get; set; }
        public virtual TblPerson TblPersonIdAsFromPersonNavigation { get; set; }
        public virtual TblPerson TblPersonIdAsToPersonNavigation { get; set; }
    }
}
