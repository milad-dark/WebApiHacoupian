using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblProductionOrderRawMaterialProductsDevelopment
    {
        public long Id { get; set; }
        public long TblProductionOrderRawMaterialProductsId { get; set; }
        public long TblRawMaterialProductDevelopmentId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblProductionOrderRawMaterialProduct TblProductionOrderRawMaterialProducts { get; set; }
        public virtual TblRawMaterialProductDevelopment TblRawMaterialProductDevelopment { get; set; }
    }
}
