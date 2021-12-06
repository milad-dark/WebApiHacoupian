using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblTimeKeeping
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public string Date { get; set; }
        public long OverTime { get; set; }
        public long AbsenceTime { get; set; }
        public long SickTime { get; set; }
        public long TotalTime { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPerson TblPerson { get; set; }
    }
}
