using System;

namespace WebApiHacoupian.Models
{
    public partial class TblAssetGoodFormula
    {
        public long Id { get; set; }
        public long TblAssetGoodId { get; set; }
        public long TblAssetMethodId { get; set; }
        public long SalvageYears { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAssetGood TblAssetGood { get; set; }
        public virtual TblAssetMethod TblAssetMethod { get; set; }
    }
}
