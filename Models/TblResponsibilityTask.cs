using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblResponsibilityTask
    {
        public TblResponsibilityTask()
        {
            TblJobResponsibilities = new HashSet<TblJobResponsibility>();
        }

        public long Id { get; set; }
        public long TblResponsibilityId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblResponsibility TblResponsibility { get; set; }
        public virtual ICollection<TblJobResponsibility> TblJobResponsibilities { get; set; }
    }
}
