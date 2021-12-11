using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblEvidenceItemCurrency
    {
        public long Id { get; set; }
        public long TblEvidenceItemId { get; set; }
        public byte Currency { get; set; }
        public long Quantity { get; set; }
        public long Amount { get; set; }
        public byte Unit { get; set; }
        public string Description { get; set; }
        public string SubsystemReferenceId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblEvidenceItem TblEvidenceItem { get; set; }
    }
}
