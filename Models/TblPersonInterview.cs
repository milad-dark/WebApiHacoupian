using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPersonInterview
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblPersonEmploymentRequestId { get; set; }
        public string Comment { get; set; }
        public string Date { get; set; }
        public TimeSpan FromTime { get; set; }
        public TimeSpan ToTime { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPerson TblPerson { get; set; }
        public virtual TblPersonEmploymentRequest TblPersonEmploymentRequest { get; set; }
    }
}
