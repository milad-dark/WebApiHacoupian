using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPrepaymentType
    {
        public TblPrepaymentType()
        {
            TblInvoiceMasterPrepayments = new HashSet<TblInvoiceMasterPrepayment>();
        }

        public long Id { get; set; }
        public string PrepaymentTypeCode { get; set; }
        public string PrepaymentTypeName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblInvoiceMasterPrepayment> TblInvoiceMasterPrepayments { get; set; }
    }
}
