using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblSafeReceiptPaymentCashEndOfDayOperation
    {
        public long Id { get; set; }
        public long TblSafeId { get; set; }
        public string Date { get; set; }
        public int Number { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblSafe TblSafe { get; set; }
    }
}
