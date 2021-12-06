using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblProcessingResultFactor
    {
        public long Id { get; set; }
        public long TblProcessingResultId { get; set; }
        public long TblKeyId { get; set; }
        public long KeyValue { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblProcessingResult TblProcessingResult { get; set; }
    }
}
