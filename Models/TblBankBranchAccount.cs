using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblBankBranchAccount
    {
        public TblBankBranchAccount()
        {
            TblCheques = new HashSet<TblCheque>();
            TblPos = new HashSet<TblPo>();
            TblSafeReceiptPaymentChequeTblBankBranchAccountAsReceipts = new HashSet<TblSafeReceiptPaymentCheque>();
            TblSafeReceiptPaymentChequeTblBankBranchAccounts = new HashSet<TblSafeReceiptPaymentCheque>();
            TblSafeReceiptPaymentSettleTransferTblBankBranchAccountAsIssuers = new HashSet<TblSafeReceiptPaymentSettleTransfer>();
            TblSafeReceiptPaymentSettleTransferTblBankBranchAccounts = new HashSet<TblSafeReceiptPaymentSettleTransfer>();
        }

        public long Id { get; set; }
        public long? TblCompanyId { get; set; }
        public long TblPersonId { get; set; }
        public long TblBankBranchId { get; set; }
        public long TblBankAccountTypeId { get; set; }
        public long TblExchangeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblBankAccountType TblBankAccountType { get; set; }
        public virtual TblBankBranch TblBankBranch { get; set; }
        public virtual TblCompany TblCompany { get; set; }
        public virtual TblExchange TblExchange { get; set; }
        public virtual TblPerson TblPerson { get; set; }
        public virtual ICollection<TblCheque> TblCheques { get; set; }
        public virtual ICollection<TblPo> TblPos { get; set; }
        public virtual ICollection<TblSafeReceiptPaymentCheque> TblSafeReceiptPaymentChequeTblBankBranchAccountAsReceipts { get; set; }
        public virtual ICollection<TblSafeReceiptPaymentCheque> TblSafeReceiptPaymentChequeTblBankBranchAccounts { get; set; }
        public virtual ICollection<TblSafeReceiptPaymentSettleTransfer> TblSafeReceiptPaymentSettleTransferTblBankBranchAccountAsIssuers { get; set; }
        public virtual ICollection<TblSafeReceiptPaymentSettleTransfer> TblSafeReceiptPaymentSettleTransferTblBankBranchAccounts { get; set; }
    }
}
