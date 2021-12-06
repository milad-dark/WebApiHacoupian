using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblBeginPeriods = new HashSet<TblBeginPeriod>();
            TblProductGalleries = new HashSet<TblProductGallery>();
            TblStockSheetItems = new HashSet<TblStockSheetItem>();
        }

        public long Id { get; set; }
        public long TblCompanyId { get; set; }
        public long? TblCodingPatternId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public string BarCode { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCodingPattern TblCodingPattern { get; set; }
        public virtual TblCompany TblCompany { get; set; }
        public virtual ICollection<TblBeginPeriod> TblBeginPeriods { get; set; }
        public virtual ICollection<TblProductGallery> TblProductGalleries { get; set; }
        public virtual ICollection<TblStockSheetItem> TblStockSheetItems { get; set; }
    }
}
