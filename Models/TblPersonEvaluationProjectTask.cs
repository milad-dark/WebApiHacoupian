using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblPersonEvaluationProjectTask
    {
        public long Id { get; set; }
        public long TblPersonEvaluationId { get; set; }
        public long TblProjectTaskId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPersonEvaluation TblPersonEvaluation { get; set; }
        public virtual TblProjectTask TblProjectTask { get; set; }
    }
}
