using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblWorkDay
    {
        public TblWorkDay()
        {
            TblEmployeeAttendances = new HashSet<TblEmployeeAttendance>();
            TblServiceAttendances = new HashSet<TblServiceAttendance>();
            TblShiftDays = new HashSet<TblShiftDay>();
        }

        public long Id { get; set; }
        public long TblWorkDayNameId { get; set; }
        public bool IsWorkDay { get; set; }
        public long TblFormaldayId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFormalDay TblFormalday { get; set; }
        public virtual TblWorkDayName TblWorkDayName { get; set; }
        public virtual ICollection<TblEmployeeAttendance> TblEmployeeAttendances { get; set; }
        public virtual ICollection<TblServiceAttendance> TblServiceAttendances { get; set; }
        public virtual ICollection<TblShiftDay> TblShiftDays { get; set; }
    }
}
