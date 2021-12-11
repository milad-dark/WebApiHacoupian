using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblDraftOrderSafeReceiptPayment
    {
        public long Id { get; set; }
        public long TblDraftOrderId { get; set; }
        public long? TblSafeReceiptPaymentId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblDraftOrder TblDraftOrder { get; set; }
        public virtual TblSafeReceiptPayment TblSafeReceiptPayment { get; set; }
    }
}
