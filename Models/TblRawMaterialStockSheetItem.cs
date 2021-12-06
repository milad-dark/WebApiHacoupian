using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblRawMaterialStockSheetItem
    {
        public long Id { get; set; }
        public long TblRawMaterailStockSheetId { get; set; }
        public long TblRawMaterialProductId { get; set; }
        public long TblOrderHeaderId { get; set; }
        public long TblProductionOrderRawMaterialProductsId { get; set; }
        public long TblInvoiceSlaveId { get; set; }
        public double Count { get; set; }
        public double Price { get; set; }
        public string ParentId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblInvoiceSlave TblInvoiceSlave { get; set; }
        public virtual TblOrderHeader TblOrderHeader { get; set; }
        public virtual TblProductionOrderRawMaterialProduct TblProductionOrderRawMaterialProducts { get; set; }
        public virtual TblRawMaterialStockSheet TblRawMaterailStockSheet { get; set; }
        public virtual TblRawMaterialProduct TblRawMaterialProduct { get; set; }
    }
}
