using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblEvaluationGoal
    {
        public TblEvaluationGoal()
        {
            TblEvaluationGoalProjects = new HashSet<TblEvaluationGoalProject>();
        }

        public long Id { get; set; }
        public long TblEvaluationPeriodId { get; set; }
        public long TblGoalId { get; set; }
        public long TblMeasurementId { get; set; }
        public long? Threshold { get; set; }
        public long Weight { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblEvaluationPeriod TblEvaluationPeriod { get; set; }
        public virtual TblGoal TblGoal { get; set; }
        public virtual TblMeasurement TblMeasurement { get; set; }
        public virtual ICollection<TblEvaluationGoalProject> TblEvaluationGoalProjects { get; set; }
    }
}
