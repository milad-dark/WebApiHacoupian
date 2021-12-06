using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblRawMaterialProductDevelopment
    {
        public TblRawMaterialProductDevelopment()
        {
            TblOrderDetailDevelopments = new HashSet<TblOrderDetailDevelopment>();
            TblProductionOrderRawMaterialProductsDevelopments = new HashSet<TblProductionOrderRawMaterialProductsDevelopment>();
        }

        public long Id { get; set; }
        public long TblRawMaterialProductId { get; set; }
        public long TblRawMaterialProductDevelopmentTypeId { get; set; }
        public long TblRawMaterialProductAsConsumingMaterialId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblRawMaterialProduct TblRawMaterialProduct { get; set; }
        public virtual TblRawMaterialProduct TblRawMaterialProductAsConsumingMaterial { get; set; }
        public virtual TblRawMaterialProductDevelopmentType TblRawMaterialProductDevelopmentType { get; set; }
        public virtual ICollection<TblOrderDetailDevelopment> TblOrderDetailDevelopments { get; set; }
        public virtual ICollection<TblProductionOrderRawMaterialProductsDevelopment> TblProductionOrderRawMaterialProductsDevelopments { get; set; }
    }
}
