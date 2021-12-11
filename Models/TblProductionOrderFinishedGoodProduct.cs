using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblProductionOrderFinishedGoodProduct
    {
        public TblProductionOrderFinishedGoodProduct()
        {
            TblFinishedGoodStockSheetItems = new HashSet<TblFinishedGoodStockSheetItem>();
            TblProductionOrderRawMaterialProductsDetails = new HashSet<TblProductionOrderRawMaterialProductsDetail>();
        }

        public long Id { get; set; }
        public long TblProductionOrderId { get; set; }
        public long TblFinishedGoodProductId { get; set; }
        public long OrderCount { get; set; }
        public long ProductionCount { get; set; }
        public long OrderPrice { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFinishedGoodProduct TblFinishedGoodProduct { get; set; }
        public virtual TblProductionOrder TblProductionOrder { get; set; }
        public virtual ICollection<TblFinishedGoodStockSheetItem> TblFinishedGoodStockSheetItems { get; set; }
        public virtual ICollection<TblProductionOrderRawMaterialProductsDetail> TblProductionOrderRawMaterialProductsDetails { get; set; }
    }
}
