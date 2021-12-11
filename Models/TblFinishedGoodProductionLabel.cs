using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblFinishedGoodProductionLabel
    {
        public TblFinishedGoodProductionLabel()
        {
            TblFinishedGoodProductionLabelCompositions = new HashSet<TblFinishedGoodProductionLabelComposition>();
        }

        public long Id { get; set; }
        public long TblOrderHeaderId { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public bool Ec { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblOrderHeader TblOrderHeader { get; set; }
        public virtual ICollection<TblFinishedGoodProductionLabelComposition> TblFinishedGoodProductionLabelCompositions { get; set; }
    }
}
