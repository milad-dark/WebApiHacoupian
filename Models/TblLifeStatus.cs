using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblLifeStatus
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblLifeStatusTypeId { get; set; }
        public long KeyValue { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblLifeStatusType TblLifeStatusType { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
