using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblRawMaterialStockSheetType
    {
        public TblRawMaterialStockSheetType()
        {
            TblRawMaterialStockSheetSubTypes = new HashSet<TblRawMaterialStockSheetSubType>();
            TblRawMaterialStockSheets = new HashSet<TblRawMaterialStockSheet>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblRawMaterialStockSheetSubType> TblRawMaterialStockSheetSubTypes { get; set; }
        public virtual ICollection<TblRawMaterialStockSheet> TblRawMaterialStockSheets { get; set; }
    }
}
