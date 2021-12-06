using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblAttachmentType
    {
        public TblAttachmentType()
        {
            TblAttachments = new HashSet<TblAttachment>();
            TblPayrollAttachments = new HashSet<TblPayrollAttachment>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblAttachment> TblAttachments { get; set; }
        public virtual ICollection<TblPayrollAttachment> TblPayrollAttachments { get; set; }
    }
}
