using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblSafeReceiptPaymentCash
    {
        public long Id { get; set; }
        public long TblSafeReceiptPaymentId { get; set; }
        public long Amount { get; set; }
        public string PrintDate { get; set; }
        public string InvalidDate { get; set; }
        public string InvalidReason { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblSafeReceiptPayment TblSafeReceiptPayment { get; set; }
    }
}
