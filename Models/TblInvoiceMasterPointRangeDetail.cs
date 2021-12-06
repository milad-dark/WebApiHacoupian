using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblInvoiceMasterPointRangeDetail
    {
        public long Id { get; set; }
        public long TblInvoiceMasterPointRangeId { get; set; }
        public long StartPrice { get; set; }
        public long EndPrice { get; set; }
        public double Discount { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblInvoiceMasterPointRange TblInvoiceMasterPointRange { get; set; }
    }
}
