using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblOrderDetailDevelopment
    {
        public long Id { get; set; }
        public long TblOrderDetailId { get; set; }
        public long TblRawMaterialProductDevelopmentId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblOrderDetail TblOrderDetail { get; set; }
        public virtual TblRawMaterialProductDevelopment TblRawMaterialProductDevelopment { get; set; }
    }
}
