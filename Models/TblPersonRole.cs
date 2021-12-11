using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPersonRole
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblRoleId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPerson TblPerson { get; set; }
        public virtual TblRole TblRole { get; set; }
    }
}
