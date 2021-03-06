#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblSafeReceiptPaymentCashBeginPeriod
    {
        public long Id { get; set; }
        public long TblSafeId { get; set; }
        public long Amount { get; set; }
        public string Date { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblSafe TblSafe { get; set; }
    }
}
