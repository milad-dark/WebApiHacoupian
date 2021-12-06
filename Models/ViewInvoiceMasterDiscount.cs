using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class ViewInvoiceMasterDiscount
    {
        public long TblInvoiceMasterId { get; set; }
        public string InvoiceDate { get; set; }
        public TimeSpan? InvoiceTime { get; set; }
        public string EffectiveCode { get; set; }
        public long? ParentId { get; set; }
        public long? TblInvoiceMasterDiscountId { get; set; }
        public string CardNumber { get; set; }
        public string DiscountPercent { get; set; }
        public long? TblDiscountTypeId { get; set; }
    }
}
