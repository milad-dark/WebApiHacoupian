using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblRawMaterialProductProgram
    {
        public TblRawMaterialProductProgram()
        {
            TblOrderDetailPrograms = new HashSet<TblOrderDetailProgram>();
            TblProductionOrderRawMaterialProductsPrograms = new HashSet<TblProductionOrderRawMaterialProductsProgram>();
        }

        public long Id { get; set; }
        public long TblRawMaterialProductId { get; set; }
        public long TblRawMaterialProductProgramParameterId { get; set; }
        public string Comment { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblRawMaterialProduct TblRawMaterialProduct { get; set; }
        public virtual TblRawMaterialProductProgramParameter TblRawMaterialProductProgramParameter { get; set; }
        public virtual ICollection<TblOrderDetailProgram> TblOrderDetailPrograms { get; set; }
        public virtual ICollection<TblProductionOrderRawMaterialProductsProgram> TblProductionOrderRawMaterialProductsPrograms { get; set; }
    }
}
