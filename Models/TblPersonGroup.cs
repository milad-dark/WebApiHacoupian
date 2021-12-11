using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPersonGroup
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblGroupId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblGroup TblGroup { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
