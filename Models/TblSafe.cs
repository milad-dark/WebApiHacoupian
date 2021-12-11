using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblSafe
    {
        public TblSafe()
        {
            TblSafeReceiptPaymentCashBeginPeriods = new HashSet<TblSafeReceiptPaymentCashBeginPeriod>();
            TblSafeReceiptPaymentCashEndOfDayOperations = new HashSet<TblSafeReceiptPaymentCashEndOfDayOperation>();
            TblSafeReceiptPayments = new HashSet<TblSafeReceiptPayment>();
        }

        public long Id { get; set; }
        public long TblFinancialCycleId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long InitialBalance { get; set; }
        public string EstablishmentDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFinancialCycle TblFinancialCycle { get; set; }
        public virtual ICollection<TblSafeReceiptPaymentCashBeginPeriod> TblSafeReceiptPaymentCashBeginPeriods { get; set; }
        public virtual ICollection<TblSafeReceiptPaymentCashEndOfDayOperation> TblSafeReceiptPaymentCashEndOfDayOperations { get; set; }
        public virtual ICollection<TblSafeReceiptPayment> TblSafeReceiptPayments { get; set; }
    }
}
