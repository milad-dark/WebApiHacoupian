using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblProject
    {
        public TblProject()
        {
            TblEvaluationGoalProjects = new HashSet<TblEvaluationGoalProject>();
            TblProjectTasks = new HashSet<TblProjectTask>();
        }

        public long Id { get; set; }
        public long TblPriorityId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long OrderNumber { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPriority TblPriority { get; set; }
        public virtual ICollection<TblEvaluationGoalProject> TblEvaluationGoalProjects { get; set; }
        public virtual ICollection<TblProjectTask> TblProjectTasks { get; set; }
    }
}
