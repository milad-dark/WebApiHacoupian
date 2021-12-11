using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblEvidence
    {
        public TblEvidence()
        {
            TblEvidenceItems = new HashSet<TblEvidenceItem>();
        }

        public long Id { get; set; }
        public long TblEvidenceTypeId { get; set; }
        public int EvidenceNo { get; set; }
        public long RefferalNo { get; set; }
        public string ReferenceNo { get; set; }
        public int SubSystem { get; set; }
        public string UserId { get; set; }
        public string EvidenceDate { get; set; }
        public string Description { get; set; }
        public string SubSystemInfo { get; set; }
        public byte IsActive { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblEvidenceType TblEvidenceType { get; set; }
        public virtual ICollection<TblEvidenceItem> TblEvidenceItems { get; set; }
    }
}
