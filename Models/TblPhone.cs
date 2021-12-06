using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblPhone
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblPhoneTypeId { get; set; }
        public string Number { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPerson TblPerson { get; set; }
        public virtual TblPhoneType TblPhoneType { get; set; }
    }
}
