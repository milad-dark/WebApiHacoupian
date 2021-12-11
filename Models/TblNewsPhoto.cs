using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblNewsPhoto
    {
        public long Id { get; set; }
        public long TblNewsId { get; set; }
        public int Order { get; set; }
        public byte[] Image { get; set; }
        public string Url { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblNews TblNews { get; set; }
    }
}
