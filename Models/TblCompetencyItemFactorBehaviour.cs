using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCompetencyItemFactorBehaviour
    {
        public TblCompetencyItemFactorBehaviour()
        {
            TblJobEvaluations = new HashSet<TblJobEvaluation>();
        }

        public long Id { get; set; }
        public long TblCompetencyItemFactorId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long PreferedValue { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompetencyItemFactor TblCompetencyItemFactor { get; set; }
        public virtual ICollection<TblJobEvaluation> TblJobEvaluations { get; set; }
    }
}
