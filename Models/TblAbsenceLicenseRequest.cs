using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblAbsenceLicenseRequest
    {
        public TblAbsenceLicenseRequest()
        {
            TblAbsenceLicenseRequestAttachments = new HashSet<TblAbsenceLicenseRequestAttachment>();
            TblAbsenceLicenseRequestDetails = new HashSet<TblAbsenceLicenseRequestDetail>();
        }

        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblLicenceId { get; set; }
        public long Number { get; set; }
        public DateTime IssueDateTime { get; set; }
        public DateTime FromDateTime { get; set; }
        public DateTime ToDateTime { get; set; }
        public long Used { get; set; }
        public string Description { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblLicense TblLicence { get; set; }
        public virtual TblPerson TblPerson { get; set; }
        public virtual ICollection<TblAbsenceLicenseRequestAttachment> TblAbsenceLicenseRequestAttachments { get; set; }
        public virtual ICollection<TblAbsenceLicenseRequestDetail> TblAbsenceLicenseRequestDetails { get; set; }
    }
}
