using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblLetterType
    {
        public TblLetterType()
        {
            TblLetters = new HashSet<TblLetter>();
        }

        public long Id { get; set; }
        public string LetterTypeCode { get; set; }
        public string LetterTypeName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblLetter> TblLetters { get; set; }
    }
}
