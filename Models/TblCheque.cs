using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCheque
    {
        public TblCheque()
        {
            TblSafeReceiptPaymentCheques = new HashSet<TblSafeReceiptPaymentCheque>();
        }

        public long Id { get; set; }
        public long TblChequeTemplateId { get; set; }
        public long TblBankBranchAccountId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string FromSerialNumber { get; set; }
        public string ToSerialNumber { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblBankBranchAccount TblBankBranchAccount { get; set; }
        public virtual TblChequeTemplate TblChequeTemplate { get; set; }
        public virtual ICollection<TblSafeReceiptPaymentCheque> TblSafeReceiptPaymentCheques { get; set; }
    }
}
