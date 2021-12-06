using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblShiftDay
    {
        public TblShiftDay()
        {
            TblShiftEmployees = new HashSet<TblShiftEmployee>();
        }

        public long Id { get; set; }
        public long TblWorkdayId { get; set; }
        public TimeSpan StartWorkTime { get; set; }
        public TimeSpan EndWorkTime { get; set; }
        public TimeSpan MinOverBefore { get; set; }
        public TimeSpan MinOverAfter { get; set; }
        public TimeSpan RestTimeStart { get; set; }
        public TimeSpan RestTimeEnd { get; set; }
        public int DelayTime { get; set; }
        public int RushTime { get; set; }
        public long ShiftId { get; set; }
        public TimeSpan MaxOverBefore { get; set; }
        public TimeSpan MaxOverAfter { get; set; }
        public bool ActRestAsOver { get; set; }
        public TimeSpan ObligedStartTime { get; set; }
        public TimeSpan ObligedEndTime { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblWorkDay TblWorkday { get; set; }
        public virtual ICollection<TblShiftEmployee> TblShiftEmployees { get; set; }
    }
}
