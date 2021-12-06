using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblEmployeeAttendance
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblWorkDayId { get; set; }
        public TimeSpan EntranceTime { get; set; }
        public TimeSpan ExitTime { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPerson TblPerson { get; set; }
        public virtual TblWorkDay TblWorkDay { get; set; }
    }
}
