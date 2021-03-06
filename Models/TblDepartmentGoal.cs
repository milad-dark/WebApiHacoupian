using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblDepartmentGoal
    {
        public long Id { get; set; }
        public long TblPlaceTypeId { get; set; }
        public string Goal { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public long Score { get; set; }
        public long MeasurementUnit { get; set; }
        public long MinimumScore { get; set; }
        public long MaximumScore { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPlaceType TblPlaceType { get; set; }
    }
}
