#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class ViewInvoiceMasterPointRange
    {
        public long Id { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public long StartPrice { get; set; }
        public long EndPrice { get; set; }
        public long Discount { get; set; }
    }
}
