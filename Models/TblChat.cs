using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblChat
    {
        public long Id { get; set; }
        public long TblPersonIdAsFrom { get; set; }
        public long TblPersonIdAsTo { get; set; }
        public string Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Message { get; set; }
        public byte[] Attachment { get; set; }
        public long ParentId { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsSeen { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPerson TblPersonIdAsFromNavigation { get; set; }
        public virtual TblPerson TblPersonIdAsToNavigation { get; set; }
    }
}
