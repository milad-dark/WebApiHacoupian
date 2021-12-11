using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblStockSheetItem
    {
        public long Id { get; set; }
        public long TblStockSheetId { get; set; }
        public long TblProductId { get; set; }
        public double Count { get; set; }
        public double Price { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblProduct TblProduct { get; set; }
        public virtual TblStockSheet TblStockSheet { get; set; }
    }
}
