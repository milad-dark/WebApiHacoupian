using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblPersonNote
    {
        public long Id { get; set; }
        public long TblPersonIdAsFrom { get; set; }
        public long TblPersonIdAsTo { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Message { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPerson TblPersonIdAsFromNavigation { get; set; }
        public virtual TblPerson TblPersonIdAsToNavigation { get; set; }
    }
}
