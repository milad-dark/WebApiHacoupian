using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblFinishedGoodProductFusingLabel
    {
        public long Id { get; set; }
        public long TblOrderHeaderId { get; set; }
        public string Date { get; set; }
        public long Size { get; set; }
        public long Series { get; set; }
        public long Count { get; set; }
        public string Code { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblOrderHeader TblOrderHeader { get; set; }
    }
}
