using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblMeasurement
    {
        public TblMeasurement()
        {
            TblEvaluationGoals = new HashSet<TblEvaluationGoal>();
            TblFinishedGoodExtraInfos = new HashSet<TblFinishedGoodExtraInfo>();
            TblPersonEvaluations = new HashSet<TblPersonEvaluation>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblEvaluationGoal> TblEvaluationGoals { get; set; }
        public virtual ICollection<TblFinishedGoodExtraInfo> TblFinishedGoodExtraInfos { get; set; }
        public virtual ICollection<TblPersonEvaluation> TblPersonEvaluations { get; set; }
    }
}
