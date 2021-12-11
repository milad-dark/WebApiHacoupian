using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblEvaluationPeriod
    {
        public TblEvaluationPeriod()
        {
            TblEvaluationGoals = new HashSet<TblEvaluationGoal>();
            TblEvaluationPeriodCalendars = new HashSet<TblEvaluationPeriodCalendar>();
            TblPersonEvaluations = new HashSet<TblPersonEvaluation>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public long MinimumScore { get; set; }
        public long MaximumScore { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblEvaluationGoal> TblEvaluationGoals { get; set; }
        public virtual ICollection<TblEvaluationPeriodCalendar> TblEvaluationPeriodCalendars { get; set; }
        public virtual ICollection<TblPersonEvaluation> TblPersonEvaluations { get; set; }
    }
}
