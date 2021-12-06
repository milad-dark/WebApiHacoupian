using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblTaxInfo
    {
        public long Id { get; set; }
        public long TblLedgerInfoId { get; set; }
        public long TblEvidenceItemId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblEvidenceItem TblEvidenceItem { get; set; }
        public virtual TblLedgerInfo TblLedgerInfo { get; set; }
    }
}
