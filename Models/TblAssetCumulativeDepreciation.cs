using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblAssetCumulativeDepreciation
    {
        public long Id { get; set; }
        public long TblAssetId { get; set; }
        public string ProcessDate { get; set; }
        public double CumulativeDepreciation { get; set; }
        public double CurrentDepreciation { get; set; }
        public long RemainedDepreciation { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAsset TblAsset { get; set; }
    }
}
