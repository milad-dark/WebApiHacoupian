using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblGroup
    {
        public TblGroup()
        {
            TblPersonGroups = new HashSet<TblPersonGroup>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblPersonGroup> TblPersonGroups { get; set; }
    }
}
