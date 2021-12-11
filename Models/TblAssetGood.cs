using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblAssetGood
    {
        public TblAssetGood()
        {
            TblAssetGoodFormulas = new HashSet<TblAssetGoodFormula>();
            TblAssets = new HashSet<TblAsset>();
        }

        public long Id { get; set; }
        public long TblAssetGroupId { get; set; }
        public long Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAssetGroup TblAssetGroup { get; set; }
        public virtual ICollection<TblAssetGoodFormula> TblAssetGoodFormulas { get; set; }
        public virtual ICollection<TblAsset> TblAssets { get; set; }
    }
}
