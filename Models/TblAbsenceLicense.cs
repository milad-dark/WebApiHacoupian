using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblAbsenceLicense
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblLicenseId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Description { get; set; }
        public int Used { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblLicense TblLicense { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
