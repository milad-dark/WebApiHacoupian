using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblPersonVisitedUrl
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public string Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Url { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? VisitDateTime { get; set; }

        public virtual TblPerson TblPerson { get; set; }
    }
}
