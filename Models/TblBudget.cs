using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblBudget
    {
        public TblBudget()
        {
            TblBudgetItems = new HashSet<TblBudgetItem>();
        }

        public long Id { get; set; }
        public int BudgetNo { get; set; }
        public string Date { get; set; }
        public byte BudgetType { get; set; }
        public byte BudgetMethod { get; set; }
        public byte RegistrationType { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblBudgetItem> TblBudgetItems { get; set; }
    }
}
