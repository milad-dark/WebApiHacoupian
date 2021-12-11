using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblLicense
    {
        public TblLicense()
        {
            TblAbsenceLicenseRequests = new HashSet<TblAbsenceLicenseRequest>();
            TblAbsenceLicenses = new HashSet<TblAbsenceLicense>();
            TblCorrections = new HashSet<TblCorrection>();
        }

        public long Id { get; set; }
        public int Code { get; set; }
        public string Type { get; set; }
        public bool IsMission { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblAbsenceLicenseRequest> TblAbsenceLicenseRequests { get; set; }
        public virtual ICollection<TblAbsenceLicense> TblAbsenceLicenses { get; set; }
        public virtual ICollection<TblCorrection> TblCorrections { get; set; }
    }
}
