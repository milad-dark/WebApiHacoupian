using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblPersonType
    {
        public TblPersonType()
        {
            TblPeople = new HashSet<TblPerson>();
        }

        public long Id { get; set; }
        public int Type { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblPerson> TblPeople { get; set; }
    }
}
