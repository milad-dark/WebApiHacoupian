using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblBpmn
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public byte[] Attachment { get; set; }
        public string FileName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool Isdeleted { get; set; }

        public virtual TblPerson TblPerson { get; set; }
    }
}
