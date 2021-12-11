using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblDraftOrderAttachment
    {
        public long Id { get; set; }
        public long TblDraftOrderId { get; set; }
        public int ReferenceNumber { get; set; }
        public byte[] ReferenceScan { get; set; }
        public string ReferenceType { get; set; }
        public string ReferenceName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblDraftOrder TblDraftOrder { get; set; }
    }
}
