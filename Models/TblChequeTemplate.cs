using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblChequeTemplate
    {
        public TblChequeTemplate()
        {
            TblCheques = new HashSet<TblCheque>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long DateDigitLeft { get; set; }
        public long DateDigitTop { get; set; }
        public long DateDigitLength { get; set; }
        public long DateLetterLeft { get; set; }
        public long DateLetterTop { get; set; }
        public long DateLetterLength { get; set; }
        public long AmountDigitLeft { get; set; }
        public long AmountDigitTop { get; set; }
        public long AmountDigitLength { get; set; }
        public long AmountLetterLeft { get; set; }
        public long AmountLetterTop { get; set; }
        public long AmountLetterLength { get; set; }
        public long PaymentToLeft { get; set; }
        public long PaymentToTop { get; set; }
        public long PaymentToLength { get; set; }
        public long DraftedToLeft { get; set; }
        public long DraftedToTop { get; set; }
        public long DraftedToLength { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblCheque> TblCheques { get; set; }
    }
}
