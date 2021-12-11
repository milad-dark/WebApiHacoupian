using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblEvaluationPeriodCalendar
    {
        public long Id { get; set; }
        public long TblEvaluationPeriodId { get; set; }
        public long TblWorkDayNameId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblEvaluationPeriod TblEvaluationPeriod { get; set; }
        public virtual TblWorkDayName TblWorkDayName { get; set; }
    }
}
