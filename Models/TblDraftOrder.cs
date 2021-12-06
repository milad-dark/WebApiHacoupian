using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblDraftOrder
    {
        public TblDraftOrder()
        {
            TblDraftOrderAttachments = new HashSet<TblDraftOrderAttachment>();
            TblDraftOrderItems = new HashSet<TblDraftOrderItem>();
            TblDraftOrderSafeReceiptPayments = new HashSet<TblDraftOrderSafeReceiptPayment>();
        }

        public long Id { get; set; }
        public long TblDraftOrderTypeId { get; set; }
        public long TblDiscountTypeId { get; set; }
        public long TblRemainTypeId { get; set; }
        public long TblPlaceTypeIdAsIssuer { get; set; }
        public long TblPlaceTypeIdAsReceiver { get; set; }
        public long TblCompanyIdAsIssuer { get; set; }
        public long TblCompanyIdAsReceiver { get; set; }
        public long TblPersonIdAsIssuer { get; set; }
        public long TblPersonIdAsReceiver { get; set; }
        public long TblInvoiceStatusId { get; set; }
        public long Number { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string PrintDate { get; set; }
        public long ParentId { get; set; }
        public string AccountCode { get; set; }
        public string Comment { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompany TblCompanyIdAsIssuerNavigation { get; set; }
        public virtual TblCompany TblCompanyIdAsReceiverNavigation { get; set; }
        public virtual TblDiscountType TblDiscountType { get; set; }
        public virtual TblDraftOrderType TblDraftOrderType { get; set; }
        public virtual TblInvoiceStatus TblInvoiceStatus { get; set; }
        public virtual TblPerson TblPersonIdAsIssuerNavigation { get; set; }
        public virtual TblPerson TblPersonIdAsReceiverNavigation { get; set; }
        public virtual TblPlaceType TblPlaceTypeIdAsIssuerNavigation { get; set; }
        public virtual TblPlaceType TblPlaceTypeIdAsReceiverNavigation { get; set; }
        public virtual TblRemainType TblRemainType { get; set; }
        public virtual ICollection<TblDraftOrderAttachment> TblDraftOrderAttachments { get; set; }
        public virtual ICollection<TblDraftOrderItem> TblDraftOrderItems { get; set; }
        public virtual ICollection<TblDraftOrderSafeReceiptPayment> TblDraftOrderSafeReceiptPayments { get; set; }
    }
}
