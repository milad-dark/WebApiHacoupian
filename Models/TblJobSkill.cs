using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblJobSkill
    {
        public TblJobSkill()
        {
            TblPersonEvaluations = new HashSet<TblPersonEvaluation>();
        }

        public long Id { get; set; }
        public long TblJobId { get; set; }
        public long TblSkillId { get; set; }
        public long PreferedValue { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblJob TblJob { get; set; }
        public virtual TblSkill TblSkill { get; set; }
        public virtual ICollection<TblPersonEvaluation> TblPersonEvaluations { get; set; }
    }
}
