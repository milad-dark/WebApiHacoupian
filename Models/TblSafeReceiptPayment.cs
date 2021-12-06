using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblSafeReceiptPayment
    {
        public TblSafeReceiptPayment()
        {
            TblDraftOrderSafeReceiptPayments = new HashSet<TblDraftOrderSafeReceiptPayment>();
            TblSafeReceiptPaymentCashes = new HashSet<TblSafeReceiptPaymentCash>();
            TblSafeReceiptPaymentChequeExpenditures = new HashSet<TblSafeReceiptPaymentChequeExpenditure>();
            TblSafeReceiptPaymentCheques = new HashSet<TblSafeReceiptPaymentCheque>();
            TblSafeReceiptPaymentPos = new HashSet<TblSafeReceiptPaymentPo>();
            TblSafeReceiptPaymentPromissoryNotes = new HashSet<TblSafeReceiptPaymentPromissoryNote>();
            TblSafeReceiptPaymentSettleTransfers = new HashSet<TblSafeReceiptPaymentSettleTransfer>();
        }

        public long Id { get; set; }
        public long TblSafeId { get; set; }
        public long TblPersonId { get; set; }
        public long TblSafeReceiptPaymentTypeId { get; set; }
        public bool IsReceipt { get; set; }
        public long Number { get; set; }
        public string Date { get; set; }
        public string Comment { get; set; }
        public string PrintDate { get; set; }
        public string InvalidDate { get; set; }
        public string InvalidReason { get; set; }
        public string AccountNumber { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPerson TblPerson { get; set; }
        public virtual TblSafe TblSafe { get; set; }
        public virtual TblSafeReceiptPaymentType TblSafeReceiptPaymentType { get; set; }
        public virtual ICollection<TblDraftOrderSafeReceiptPayment> TblDraftOrderSafeReceiptPayments { get; set; }
        public virtual ICollection<TblSafeReceiptPaymentCash> TblSafeReceiptPaymentCashes { get; set; }
        public virtual ICollection<TblSafeReceiptPaymentChequeExpenditure> TblSafeReceiptPaymentChequeExpenditures { get; set; }
        public virtual ICollection<TblSafeReceiptPaymentCheque> TblSafeReceiptPaymentCheques { get; set; }
        public virtual ICollection<TblSafeReceiptPaymentPo> TblSafeReceiptPaymentPos { get; set; }
        public virtual ICollection<TblSafeReceiptPaymentPromissoryNote> TblSafeReceiptPaymentPromissoryNotes { get; set; }
        public virtual ICollection<TblSafeReceiptPaymentSettleTransfer> TblSafeReceiptPaymentSettleTransfers { get; set; }
    }
}
