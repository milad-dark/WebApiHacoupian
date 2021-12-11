using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPayrollAttachment
    {
        public long Id { get; set; }
        public long TblAttachmentTypeId { get; set; }
        public string Date { get; set; }
        public byte[] Data { get; set; }
        public string FileName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAttachmentType TblAttachmentType { get; set; }
    }
}
