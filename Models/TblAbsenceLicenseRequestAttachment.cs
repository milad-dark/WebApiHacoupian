using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblAbsenceLicenseRequestAttachment
    {
        public long Id { get; set; }
        public long TblAbsenceLicenseRequestId { get; set; }
        public string FileName { get; set; }
        public byte[] Data { get; set; }
        public string ContentType { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAbsenceLicenseRequest TblAbsenceLicenseRequest { get; set; }
    }
}
