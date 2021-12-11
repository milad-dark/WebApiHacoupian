using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblAbsenceLicenseRequestDetail
    {
        public long Id { get; set; }
        public long TblAbsenceLicenseRequestId { get; set; }
        public long TblPersonId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAbsenceLicenseRequest TblAbsenceLicenseRequest { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
