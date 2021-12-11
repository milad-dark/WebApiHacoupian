#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class ViewInvoiceSlave
    {
        public long Id { get; set; }
        public long TblInvoiceMasterId { get; set; }
        public string PartCode { get; set; }
        public long ItemIndex { get; set; }
        public long PartCount { get; set; }
        public long SalePrice { get; set; }
        public bool IsGift { get; set; }
        public string Explanation { get; set; }
    }
}
