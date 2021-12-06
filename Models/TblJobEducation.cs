using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblJobEducation
    {
        public long Id { get; set; }
        public long TblJobId { get; set; }
        public long TblCertificateId { get; set; }
        public long TblFieldOfStudyId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCertificate TblCertificate { get; set; }
        public virtual TblFieldOfStudy TblFieldOfStudy { get; set; }
        public virtual TblJob TblJob { get; set; }
    }
}
