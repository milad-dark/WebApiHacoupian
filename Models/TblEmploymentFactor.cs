using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblEmploymentFactor
    {
        public long Id { get; set; }
        public long TblEmployementId { get; set; }
        public long TblEmploymentKeyId { get; set; }
        public long KeyValue { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblEmployment TblEmployement { get; set; }
        public virtual TblEmploymentKey TblEmploymentKey { get; set; }
    }
}
