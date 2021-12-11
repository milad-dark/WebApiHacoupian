using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblRemainType
    {
        public TblRemainType()
        {
            TblDraftOrders = new HashSet<TblDraftOrder>();
            TblInvoiceMasterRemains = new HashSet<TblInvoiceMasterRemain>();
        }

        public long Id { get; set; }
        public string RemainTypeCode { get; set; }
        public string RemainTypeName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblDraftOrder> TblDraftOrders { get; set; }
        public virtual ICollection<TblInvoiceMasterRemain> TblInvoiceMasterRemains { get; set; }
    }
}
