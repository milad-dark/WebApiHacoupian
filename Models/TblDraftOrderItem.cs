using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblDraftOrderItem
    {
        public long Id { get; set; }
        public long TblDraftOrderId { get; set; }
        public long TblPersonId { get; set; }
        public long TblDraftTypeId { get; set; }
        public long TblInvoiceStatusId { get; set; }
        public int Count { get; set; }
        public long NameAmount { get; set; }
        public long PureAmount { get; set; }
        public int FromSerialNo { get; set; }
        public int ToSerialNo { get; set; }
        public int DiscountPercent { get; set; }
        public long ParentId { get; set; }
        public string ValidDate { get; set; }
        public string Barcode { get; set; }
        public string PrintDate { get; set; }
        public string UsedDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblDraftOrder TblDraftOrder { get; set; }
        public virtual TblDraftType TblDraftType { get; set; }
        public virtual TblInvoiceStatus TblInvoiceStatus { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
