using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblJobInterest
    {
        public long Id { get; set; }
        public long TblJobId { get; set; }
        public long TblInterestId { get; set; }
        public long PreferedValue { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblInterest TblInterest { get; set; }
        public virtual TblJob TblJob { get; set; }
    }
}
