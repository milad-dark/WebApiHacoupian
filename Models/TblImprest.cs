using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblImprest
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public string Date { get; set; }
        public long Amount { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPerson TblPerson { get; set; }
    }
}
