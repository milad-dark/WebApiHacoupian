using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblBudgetItemDetail
    {
        public long Id { get; set; }
        public long TblBudgetItemId { get; set; }
        public long EstimateBudget { get; set; }
        public long CurrentBudget { get; set; }
        public int Month { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblBudgetItem TblBudgetItem { get; set; }
    }
}
