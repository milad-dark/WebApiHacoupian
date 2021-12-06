using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblCorrection
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long? TblLicenseId { get; set; }
        public byte Type { get; set; }
        public string Date { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblLicense TblLicense { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
