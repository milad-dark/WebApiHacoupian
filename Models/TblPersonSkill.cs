using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblPersonSkill
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblSkillId { get; set; }
        public byte SkillLevel { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPerson TblPerson { get; set; }
        public virtual TblSkill TblSkill { get; set; }
    }
}
