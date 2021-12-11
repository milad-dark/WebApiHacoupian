using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblFinishedGoodStockSheetItem
    {
        public long Id { get; set; }
        public long TblFinishedGoodStockSheetId { get; set; }
        public long TblFinishedGoodProductId { get; set; }
        public long TblOrderHeaderId { get; set; }
        public long TblProductionOrderFinishedGoodProductsId { get; set; }
        public double Count { get; set; }
        public double Price { get; set; }
        public string ParentId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFinishedGoodProduct TblFinishedGoodProduct { get; set; }
        public virtual TblFinishedGoodStockSheet TblFinishedGoodStockSheet { get; set; }
        public virtual TblOrderHeader TblOrderHeader { get; set; }
        public virtual TblProductionOrderFinishedGoodProduct TblProductionOrderFinishedGoodProducts { get; set; }
    }
}
