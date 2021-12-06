using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblStockSheetType
    {
        public TblStockSheetType()
        {
            TblStockSheetSubTypes = new HashSet<TblStockSheetSubType>();
            TblStockSheets = new HashSet<TblStockSheet>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblStockSheetSubType> TblStockSheetSubTypes { get; set; }
        public virtual ICollection<TblStockSheet> TblStockSheets { get; set; }
    }
}
