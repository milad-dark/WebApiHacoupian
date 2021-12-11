using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPersonCertificate
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblCertificateId { get; set; }
        public long TblFieldOfStudyId { get; set; }
        public long TblPlaceTypeIdAsUniversity { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string GraduationLevel { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCertificate TblCertificate { get; set; }
        public virtual TblFieldOfStudy TblFieldOfStudy { get; set; }
        public virtual TblPerson TblPerson { get; set; }
        public virtual TblPlaceType TblPlaceTypeIdAsUniversityNavigation { get; set; }
    }
}
