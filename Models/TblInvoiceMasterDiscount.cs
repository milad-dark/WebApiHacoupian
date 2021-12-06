using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblInvoiceMasterDiscount
    {
        public long Id { get; set; }
        public long TblInvoiceMasterId { get; set; }
        public long TblDiscountTypeId { get; set; }
        public long Amount { get; set; }
        public string CardNumber { get; set; }
        public string DiscountPercent { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblDiscountType TblDiscountType { get; set; }
        public virtual TblInvoiceMaster TblInvoiceMaster { get; set; }
    }
}
