using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblLoanPayment
    {
        public long Id { get; set; }
        public long TblLoanId { get; set; }
        public string Date { get; set; }
        public long Amount { get; set; }
        public bool IsPassed { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblLoan TblLoan { get; set; }
    }
}
