using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblOrderDetailProgram
    {
        public long Id { get; set; }
        public long TblOrderDetailId { get; set; }
        public long TblRawMaterialProductProgramId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblOrderDetail TblOrderDetail { get; set; }
        public virtual TblRawMaterialProductProgram TblRawMaterialProductProgram { get; set; }
    }
}
