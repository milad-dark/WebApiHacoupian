using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPersonEvaluation
    {
        public TblPersonEvaluation()
        {
            TblPersonEvaluationProjectTasks = new HashSet<TblPersonEvaluationProjectTask>();
        }

        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblEvaluationPeriodId { get; set; }
        public long TblJobResponsibilityId { get; set; }
        public long? TblJobSkillId { get; set; }
        public long TblMeasurementId { get; set; }
        public long Weight { get; set; }
        public long ResultScore { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblEvaluationPeriod TblEvaluationPeriod { get; set; }
        public virtual TblJobResponsibility TblJobResponsibility { get; set; }
        public virtual TblJobSkill TblJobSkill { get; set; }
        public virtual TblMeasurement TblMeasurement { get; set; }
        public virtual TblPerson TblPerson { get; set; }
        public virtual ICollection<TblPersonEvaluationProjectTask> TblPersonEvaluationProjectTasks { get; set; }
    }
}
