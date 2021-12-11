using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblProductionOrderMoreInfo
    {
        public long Id { get; set; }
        public long TblProductionOrderId { get; set; }
        public long TblCodingPatternValueId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblProductionOrder TblProductionOrder { get; set; }
    }
}
