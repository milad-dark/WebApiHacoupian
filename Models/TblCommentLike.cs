using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCommentLike
    {
        public long Id { get; set; }
        public long? TblCommentId { get; set; }
        public long? TblPersonId { get; set; }
        public int? Score { get; set; }
        public string Explanation { get; set; }
        public byte? Status { get; set; }
        public Guid? Guid { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsSent { get; set; }

        public virtual TblComment TblComment { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
