using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblTaxBranchSummary
    {
        public long Id { get; set; }
        public long TblTaxBranchId { get; set; }
        public string Date { get; set; }
        public long First { get; set; }
        public long Second { get; set; }
        public long Third { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblTaxBranch TblTaxBranch { get; set; }
    }
}
