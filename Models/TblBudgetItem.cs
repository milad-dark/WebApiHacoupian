using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblBudgetItem
    {
        public TblBudgetItem()
        {
            TblBudgetItemDetails = new HashSet<TblBudgetItemDetail>();
        }

        public long Id { get; set; }
        public long TblBudgetId { get; set; }
        public long TblLedgerId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblBudget TblBudget { get; set; }
        public virtual TblLedger TblLedger { get; set; }
        public virtual ICollection<TblBudgetItemDetail> TblBudgetItemDetails { get; set; }
    }
}
