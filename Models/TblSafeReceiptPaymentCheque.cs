using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblSafeReceiptPaymentCheque
    {
        public TblSafeReceiptPaymentCheque()
        {
            TblSafeReceiptPaymentChequeExpenditures = new HashSet<TblSafeReceiptPaymentChequeExpenditure>();
        }

        public long Id { get; set; }
        public long TblSafeReceiptPaymentId { get; set; }
        public long TblBankBranchAccountId { get; set; }
        public long? TblChequeId { get; set; }
        public string Date { get; set; }
        public string ChequeNumber { get; set; }
        public string BackNumber { get; set; }
        public long Amount { get; set; }
        public string PrintDate { get; set; }
        public string InvalidDate { get; set; }
        public string InvalidReason { get; set; }
        public string PassedDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsCarrier { get; set; }
        public long TblBankBranchAccountAsReceiptId { get; set; }

        public virtual TblBankBranchAccount TblBankBranchAccount { get; set; }
        public virtual TblBankBranchAccount TblBankBranchAccountAsReceipt { get; set; }
        public virtual TblCheque TblCheque { get; set; }
        public virtual TblSafeReceiptPayment TblSafeReceiptPayment { get; set; }
        public virtual ICollection<TblSafeReceiptPaymentChequeExpenditure> TblSafeReceiptPaymentChequeExpenditures { get; set; }
    }
}
