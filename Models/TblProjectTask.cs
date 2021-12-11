using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblProjectTask
    {
        public TblProjectTask()
        {
            TblPersonEvaluationProjectTasks = new HashSet<TblPersonEvaluationProjectTask>();
            TblProjectTaskAttachments = new HashSet<TblProjectTaskAttachment>();
            TblProjectTaskChats = new HashSet<TblProjectTaskChat>();
            TblProjectTaskRecipients = new HashSet<TblProjectTaskRecipient>();
            TblProjectTaskTags = new HashSet<TblProjectTaskTag>();
        }

        public long Id { get; set; }
        public long TblProjectId { get; set; }
        public long TblPriorityId { get; set; }
        public long TblTaskTypeId { get; set; }
        public long TblTaskStatusId { get; set; }
        public long OrderNumber { get; set; }
        public long Code { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public string Result { get; set; }
        public long ElapsedTime { get; set; }
        public bool IsTimerEnabled { get; set; }
        public long Progress { get; set; }
        public string FinishDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPriority TblPriority { get; set; }
        public virtual TblProject TblProject { get; set; }
        public virtual TblTaskStatus TblTaskStatus { get; set; }
        public virtual TblTaskType TblTaskType { get; set; }
        public virtual ICollection<TblPersonEvaluationProjectTask> TblPersonEvaluationProjectTasks { get; set; }
        public virtual ICollection<TblProjectTaskAttachment> TblProjectTaskAttachments { get; set; }
        public virtual ICollection<TblProjectTaskChat> TblProjectTaskChats { get; set; }
        public virtual ICollection<TblProjectTaskRecipient> TblProjectTaskRecipients { get; set; }
        public virtual ICollection<TblProjectTaskTag> TblProjectTaskTags { get; set; }
    }
}
