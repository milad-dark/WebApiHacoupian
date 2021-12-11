using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPersonEmploymentRequest
    {
        public TblPersonEmploymentRequest()
        {
            TblPersonInterviews = new HashSet<TblPersonInterview>();
        }

        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblEmploymentRequestId { get; set; }
        public string Date { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblEmploymentRequest TblEmploymentRequest { get; set; }
        public virtual TblPerson TblPerson { get; set; }
        public virtual ICollection<TblPersonInterview> TblPersonInterviews { get; set; }
    }
}
