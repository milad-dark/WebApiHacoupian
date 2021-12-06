using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblProductionOrder
    {
        public TblProductionOrder()
        {
            TblProductionOrderAttachments = new HashSet<TblProductionOrderAttachment>();
            TblProductionOrderFinishedGoodProducts = new HashSet<TblProductionOrderFinishedGoodProduct>();
            TblProductionOrderMoreInfos = new HashSet<TblProductionOrderMoreInfo>();
            TblProductionOrderRawMaterialProducts = new HashSet<TblProductionOrderRawMaterialProduct>();
            TblProductionOrderTrackings = new HashSet<TblProductionOrderTracking>();
        }

        public long Id { get; set; }
        public long Number { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblProductionOrderAttachment> TblProductionOrderAttachments { get; set; }
        public virtual ICollection<TblProductionOrderFinishedGoodProduct> TblProductionOrderFinishedGoodProducts { get; set; }
        public virtual ICollection<TblProductionOrderMoreInfo> TblProductionOrderMoreInfos { get; set; }
        public virtual ICollection<TblProductionOrderRawMaterialProduct> TblProductionOrderRawMaterialProducts { get; set; }
        public virtual ICollection<TblProductionOrderTracking> TblProductionOrderTrackings { get; set; }
    }
}
