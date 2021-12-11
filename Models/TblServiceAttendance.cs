using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblServiceAttendance
    {
        public long Id { get; set; }
        public long TblServiceId { get; set; }
        public long TblWorkdayId { get; set; }
        public int DelayTime { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblService TblService { get; set; }
        public virtual TblWorkDay TblWorkday { get; set; }
    }
}
