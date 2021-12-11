using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblRawMaterialProductCompositionType
    {
        public TblRawMaterialProductCompositionType()
        {
            TblFinishedGoodProductionLabelCompositions = new HashSet<TblFinishedGoodProductionLabelComposition>();
            TblRawMaterialProductCompositions = new HashSet<TblRawMaterialProductComposition>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblFinishedGoodProductionLabelComposition> TblFinishedGoodProductionLabelCompositions { get; set; }
        public virtual ICollection<TblRawMaterialProductComposition> TblRawMaterialProductCompositions { get; set; }
    }
}
