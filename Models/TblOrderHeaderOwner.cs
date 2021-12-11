using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblOrderHeaderOwner
    {
        public long Id { get; set; }
        public long TblOrderHeaderId { get; set; }
        public long TblCompanyId { get; set; }
        public long TblPersonId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompany TblCompany { get; set; }
        public virtual TblOrderHeader TblOrderHeader { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
