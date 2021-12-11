using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblLoan
    {
        public TblLoan()
        {
            TblLoanPayments = new HashSet<TblLoanPayment>();
        }

        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblLoanTypeId { get; set; }
        public string Date { get; set; }
        public long TotalLoan { get; set; }
        public long LoanPayment { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblLoanType TblLoanType { get; set; }
        public virtual TblPerson TblPerson { get; set; }
        public virtual ICollection<TblLoanPayment> TblLoanPayments { get; set; }
    }
}
