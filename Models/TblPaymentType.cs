using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPaymentType
    {
        public TblPaymentType()
        {
            TblInvoiceMasterPayments = new HashSet<TblInvoiceMasterPayment>();
        }

        public long Id { get; set; }
        public string PaymentTypeCode { get; set; }
        public string PaymentTypeName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblInvoiceMasterPayment> TblInvoiceMasterPayments { get; set; }
    }
}
