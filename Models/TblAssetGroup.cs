using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblAssetGroup
    {
        public TblAssetGroup()
        {
            TblAssetGoods = new HashSet<TblAssetGood>();
        }

        public long Id { get; set; }
        public long TblCompanyId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompany TblCompany { get; set; }
        public virtual ICollection<TblAssetGood> TblAssetGoods { get; set; }
    }
}
