using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblRole
    {
        public TblRole()
        {
            TblPersonRoles = new HashSet<TblPersonRole>();
            TblRolePermisions = new HashSet<TblRolePermision>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblPersonRole> TblPersonRoles { get; set; }
        public virtual ICollection<TblRolePermision> TblRolePermisions { get; set; }
    }
}
