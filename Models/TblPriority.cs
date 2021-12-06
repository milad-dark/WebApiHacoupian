using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblPriority
    {
        public TblPriority()
        {
            TblProjectTasks = new HashSet<TblProjectTask>();
            TblProjects = new HashSet<TblProject>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblProjectTask> TblProjectTasks { get; set; }
        public virtual ICollection<TblProject> TblProjects { get; set; }
    }
}
