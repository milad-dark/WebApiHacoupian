using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblPersonSystem
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblComputerId { get; set; }
        public string Ip { get; set; }
        public string Adusername { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblComputer TblComputer { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
