using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblSm
    {
        public long Id { get; set; }
        public long? TblPersonId { get; set; }
        public long TblSmstypeId { get; set; }
        public string FromNumber { get; set; }
        public string ToNumber { get; set; }
        public string Message { get; set; }
        public string MessageStatus { get; set; }
        public string Smsdate { get; set; }
        public TimeSpan Smstime { get; set; }
        public long Reference { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPerson TblPerson { get; set; }
        public virtual TblSmstype TblSmstype { get; set; }
    }
}
