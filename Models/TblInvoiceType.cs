using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblInvoiceType
    {
        public TblInvoiceType()
        {
            TblInvoiceMasterTypes = new HashSet<TblInvoiceMasterType>();
        }

        public long Id { get; set; }
        public string InvoiceTypeCode { get; set; }
        public string InvoiceTypeName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblInvoiceMasterType> TblInvoiceMasterTypes { get; set; }
    }
}
