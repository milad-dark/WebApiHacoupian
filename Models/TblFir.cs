using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblFir
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public string Fir { get; set; }
        public byte[] Firdata { get; set; }
        public int Firformat { get; set; }
        public string Firheader { get; set; }
        public int FingerId { get; set; }
        public int FirstReserved { get; set; }
        public int SecondReserved { get; set; }
        public int SampleNumber { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPerson TblPerson { get; set; }
    }
}
