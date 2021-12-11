using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCompanyPhone
    {
        public long Id { get; set; }
        public long TblCompanyId { get; set; }
        public long TblPhoneTypeId { get; set; }
        public string Number { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompany TblCompany { get; set; }
        public virtual TblPhoneType TblPhoneType { get; set; }
    }
}
