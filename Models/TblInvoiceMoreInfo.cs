using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblInvoiceMoreInfo
    {
        public long Id { get; set; }
        public long TblInvoiceMasterId { get; set; }
        public string InvoiceAddress { get; set; }
        public string InvoicePhone { get; set; }
        public string InvoiceMobile { get; set; }
        public string InvoicePostalCode { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblInvoiceMaster TblInvoiceMaster { get; set; }
    }
}
