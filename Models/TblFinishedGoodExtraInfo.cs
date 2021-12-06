using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblFinishedGoodExtraInfo
    {
        public long Id { get; set; }
        public long TblCompanyId { get; set; }
        public long TblMeasurementId { get; set; }
        public string ProductGroup { get; set; }
        public string LabelCount { get; set; }
        public string LabelSize { get; set; }
        public string EnglishName { get; set; }
        public bool SelfProduction { get; set; }
        public string Symbol { get; set; }
        public string GroupName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompany TblCompany { get; set; }
        public virtual TblMeasurement TblMeasurement { get; set; }
    }
}
