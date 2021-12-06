using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblJobModelFactorPrefered
    {
        public long Id { get; set; }
        public long TblJobId { get; set; }
        public long TblJobModelFactorId { get; set; }
        public long PreferedValue { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblJob TblJob { get; set; }
        public virtual TblJobModelFactor TblJobModelFactor { get; set; }
    }
}
