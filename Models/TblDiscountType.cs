using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblDiscountType
    {
        public TblDiscountType()
        {
            TblDraftOrders = new HashSet<TblDraftOrder>();
            TblEvents = new HashSet<TblEvent>();
            TblInvoiceMasterDiscounts = new HashSet<TblInvoiceMasterDiscount>();
            TblPersonCharges = new HashSet<TblPersonCharge>();
        }

        public long Id { get; set; }
        public string DiscountTypeCode { get; set; }
        public string DiscountTypeName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblDraftOrder> TblDraftOrders { get; set; }
        public virtual ICollection<TblEvent> TblEvents { get; set; }
        public virtual ICollection<TblInvoiceMasterDiscount> TblInvoiceMasterDiscounts { get; set; }
        public virtual ICollection<TblPersonCharge> TblPersonCharges { get; set; }
    }
}
