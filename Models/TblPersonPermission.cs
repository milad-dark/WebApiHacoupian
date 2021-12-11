using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPersonPermission
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblPermissionId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPermission TblPermission { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
