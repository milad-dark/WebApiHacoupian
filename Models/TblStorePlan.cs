using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblStorePlan
    {
        public long Id { get; set; }
        public long TblPlaceTypeId { get; set; }
        public long TblPlanId { get; set; }
        public string PartName { get; set; }
        public string PartGroup { get; set; }
        public long CountByDesired { get; set; }
        public long PriceByDesired { get; set; }
        public long CountByMinimum { get; set; }
        public long PriceByMinimum { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPlaceType TblPlaceType { get; set; }
        public virtual TblPlan TblPlan { get; set; }
    }
}
