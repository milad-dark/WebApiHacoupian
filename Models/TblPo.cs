using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblPo
    {
        public TblPo()
        {
            TblSafeReceiptPaymentPos = new HashSet<TblSafeReceiptPaymentPo>();
        }

        public long Id { get; set; }
        public long TblBankBranchAccountId { get; set; }
        public string TerminalNumber { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblBankBranchAccount TblBankBranchAccount { get; set; }
        public virtual ICollection<TblSafeReceiptPaymentPo> TblSafeReceiptPaymentPos { get; set; }
    }
}
