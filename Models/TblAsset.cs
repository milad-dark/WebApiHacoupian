using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblAsset
    {
        public TblAsset()
        {
            TblAssetCumulativeDepreciations = new HashSet<TblAssetCumulativeDepreciation>();
        }

        public long Id { get; set; }
        public long TblAssetGoodId { get; set; }
        public long TblPlaceTypeId { get; set; }
        public long TblAssetOutTypeId { get; set; }
        public long Number { get; set; }
        public string AssetCode { get; set; }
        public string AssetName { get; set; }
        public long InvoiceNumber { get; set; }
        public string InvoiceDate { get; set; }
        public string AccountCode { get; set; }
        public long Count { get; set; }
        public long Price { get; set; }
        public long CumulativeDepreciation { get; set; }
        public string SalvageDate { get; set; }
        public long SalvageNumber { get; set; }
        public long SalvagePrice { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAssetGood TblAssetGood { get; set; }
        public virtual TblAssetOutType TblAssetOutType { get; set; }
        public virtual TblPlaceType TblPlaceType { get; set; }
        public virtual ICollection<TblAssetCumulativeDepreciation> TblAssetCumulativeDepreciations { get; set; }
    }
}
