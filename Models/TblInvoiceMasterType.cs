using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblInvoiceMasterType
    {
        public long Id { get; set; }
        public long TblInvoiceMasterId { get; set; }
        public long TblInvoiceTypeId { get; set; }
        public string Reference { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblInvoiceMaster TblInvoiceMaster { get; set; }
        public virtual TblInvoiceType TblInvoiceType { get; set; }
    }
}
