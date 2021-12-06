using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblInvoiceSlave
    {
        public TblInvoiceSlave()
        {
            TblCustomerCareSheetItems = new HashSet<TblCustomerCareSheetItem>();
            TblRawMaterialStockSheetItems = new HashSet<TblRawMaterialStockSheetItem>();
        }

        public long Id { get; set; }
        public long TblInvoiceMasterId { get; set; }
        public string PartCode { get; set; }
        public long ItemIndex { get; set; }
        public long PartCount { get; set; }
        public long SalePrice { get; set; }
        public bool IsGift { get; set; }
        public long PartTax { get; set; }
        public long PartDiscount { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblInvoiceMaster TblInvoiceMaster { get; set; }
        public virtual ICollection<TblCustomerCareSheetItem> TblCustomerCareSheetItems { get; set; }
        public virtual ICollection<TblRawMaterialStockSheetItem> TblRawMaterialStockSheetItems { get; set; }
    }
}
