using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblInvoiceStatus
    {
        public TblInvoiceStatus()
        {
            TblDraftOrderItems = new HashSet<TblDraftOrderItem>();
            TblDraftOrders = new HashSet<TblDraftOrder>();
            TblInvoiceMasters = new HashSet<TblInvoiceMaster>();
        }

        public long Id { get; set; }
        public string InvoiceStatusCode { get; set; }
        public string InvoiceStatusName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblDraftOrderItem> TblDraftOrderItems { get; set; }
        public virtual ICollection<TblDraftOrder> TblDraftOrders { get; set; }
        public virtual ICollection<TblInvoiceMaster> TblInvoiceMasters { get; set; }
    }
}
