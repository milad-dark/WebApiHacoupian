using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblOrderDetail
    {
        public TblOrderDetail()
        {
            TblOrderDetailDevelopments = new HashSet<TblOrderDetailDevelopment>();
            TblOrderDetailPrograms = new HashSet<TblOrderDetailProgram>();
        }

        public long Id { get; set; }
        public long TblOrderHeaderId { get; set; }
        public long TblRawMaterialProductId { get; set; }
        public long TblCompanyId { get; set; }
        public string SupplierRawMaterialCode { get; set; }
        public string SupplierRawMaterialColor { get; set; }
        public string PegOrRollUnit { get; set; }
        public string PegOrRollCount { get; set; }
        public string PegOrRollWidth { get; set; }
        public string GarmentType { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompany TblCompany { get; set; }
        public virtual TblOrderHeader TblOrderHeader { get; set; }
        public virtual TblRawMaterialProduct TblRawMaterialProduct { get; set; }
        public virtual ICollection<TblOrderDetailDevelopment> TblOrderDetailDevelopments { get; set; }
        public virtual ICollection<TblOrderDetailProgram> TblOrderDetailPrograms { get; set; }
    }
}
