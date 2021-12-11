using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCatalogeItem
    {
        public long Id { get; set; }
        public long TblCatalogeId { get; set; }
        public long Order { get; set; }
        public byte[] Image { get; set; }
        public long RatingValue { get; set; }
        public long RatingCount { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCataloge TblCataloge { get; set; }
    }
}
