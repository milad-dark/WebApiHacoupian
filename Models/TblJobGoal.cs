using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblJobGoal
    {
        public long Id { get; set; }
        public long TblJobId { get; set; }
        public long TblGoalId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public long Score { get; set; }
        public long MeasurementUnit { get; set; }
        public long MinimumScore { get; set; }
        public long MaximumScore { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblGoal TblGoal { get; set; }
        public virtual TblJob TblJob { get; set; }
    }
}
