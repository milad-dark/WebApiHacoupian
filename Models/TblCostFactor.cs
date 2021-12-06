using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblCostFactor
    {
        public long Id { get; set; }
        public long? TblPlaceTypeId { get; set; }
        public string AccountCode { get; set; }
        public long AccountType { get; set; }
        public long AccountDeduction { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPlaceType TblPlaceType { get; set; }
    }
}
