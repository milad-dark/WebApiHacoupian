using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblCompetencyItemFactor
    {
        public TblCompetencyItemFactor()
        {
            TblCompetencyItemFactorBehaviours = new HashSet<TblCompetencyItemFactorBehaviour>();
        }

        public long Id { get; set; }
        public long TblCompetencyItemId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long PreferedValue { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompetencyItem TblCompetencyItem { get; set; }
        public virtual ICollection<TblCompetencyItemFactorBehaviour> TblCompetencyItemFactorBehaviours { get; set; }
    }
}
