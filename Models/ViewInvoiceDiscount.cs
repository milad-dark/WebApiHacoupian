#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class ViewInvoiceDiscount
    {
        public long TblInvoiceMasterDiscountId { get; set; }
        public long TblInvoiceMasterId { get; set; }
        public long TblDiscountTypeId { get; set; }
        public long Amount { get; set; }
        public string CardNumber { get; set; }
        public string DiscountPercent { get; set; }
    }
}
