using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCodingPattern
    {
        public TblCodingPattern()
        {
            TblCodingPatternKeys = new HashSet<TblCodingPatternKey>();
            TblFinishedGoodProducts = new HashSet<TblFinishedGoodProduct>();
            TblProducts = new HashSet<TblProduct>();
            TblRawMaterialProducts = new HashSet<TblRawMaterialProduct>();
        }

        public long Id { get; set; }
        public long TblCompanyId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompany TblCompany { get; set; }
        public virtual ICollection<TblCodingPatternKey> TblCodingPatternKeys { get; set; }
        public virtual ICollection<TblFinishedGoodProduct> TblFinishedGoodProducts { get; set; }
        public virtual ICollection<TblProduct> TblProducts { get; set; }
        public virtual ICollection<TblRawMaterialProduct> TblRawMaterialProducts { get; set; }
    }
}
