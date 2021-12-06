using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblProductionOrderRawMaterialProduct
    {
        public TblProductionOrderRawMaterialProduct()
        {
            TblProductionOrderRawMaterialProductsDetails = new HashSet<TblProductionOrderRawMaterialProductsDetail>();
            TblProductionOrderRawMaterialProductsDevelopments = new HashSet<TblProductionOrderRawMaterialProductsDevelopment>();
            TblProductionOrderRawMaterialProductsPrograms = new HashSet<TblProductionOrderRawMaterialProductsProgram>();
            TblRawMaterialStockSheetItems = new HashSet<TblRawMaterialStockSheetItem>();
        }

        public long Id { get; set; }
        public long TblProductionOrderId { get; set; }
        public long TblRawMaterialProductId { get; set; }
        public double Count { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblProductionOrder TblProductionOrder { get; set; }
        public virtual TblRawMaterialProduct TblRawMaterialProduct { get; set; }
        public virtual ICollection<TblProductionOrderRawMaterialProductsDetail> TblProductionOrderRawMaterialProductsDetails { get; set; }
        public virtual ICollection<TblProductionOrderRawMaterialProductsDevelopment> TblProductionOrderRawMaterialProductsDevelopments { get; set; }
        public virtual ICollection<TblProductionOrderRawMaterialProductsProgram> TblProductionOrderRawMaterialProductsPrograms { get; set; }
        public virtual ICollection<TblRawMaterialStockSheetItem> TblRawMaterialStockSheetItems { get; set; }
    }
}
