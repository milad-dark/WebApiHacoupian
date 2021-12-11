using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblJobAbility
    {
        public long Id { get; set; }
        public long TblJobId { get; set; }
        public long TblAbilityId { get; set; }
        public long PreferedValue { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAbility TblAbility { get; set; }
        public virtual TblJob TblJob { get; set; }
    }
}
