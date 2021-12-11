using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPayrollFactor
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblPayrollKeyId { get; set; }
        public long KeyValue { get; set; }
        public string Date { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPayrollKey TblPayrollKey { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
