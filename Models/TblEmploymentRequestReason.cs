using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblEmploymentRequestReason
    {
        public long Id { get; set; }
        public long TblEmploymentRequestId { get; set; }
        public long TblReasonId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblEmploymentRequest TblEmploymentRequest { get; set; }
        public virtual TblReason TblReason { get; set; }
    }
}
