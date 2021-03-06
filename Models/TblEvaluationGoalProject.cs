using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblEvaluationGoalProject
    {
        public long Id { get; set; }
        public long TblProjectId { get; set; }
        public long TblEvaluationGoalId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblEvaluationGoal TblEvaluationGoal { get; set; }
        public virtual TblProject TblProject { get; set; }
    }
}
