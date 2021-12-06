using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblSkill
    {
        public TblSkill()
        {
            TblJobSkills = new HashSet<TblJobSkill>();
            TblPersonSkills = new HashSet<TblPersonSkill>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblJobSkill> TblJobSkills { get; set; }
        public virtual ICollection<TblPersonSkill> TblPersonSkills { get; set; }
    }
}
