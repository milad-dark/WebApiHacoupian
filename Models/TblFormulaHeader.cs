using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblFormulaHeader
    {
        public TblFormulaHeader()
        {
            TblFormulaDetails = new HashSet<TblFormulaDetail>();
        }

        public long Id { get; set; }
        public long TblFinancialCycleId { get; set; }
        public long? TblLedgerId { get; set; }
        public string FormulaName { get; set; }
        public string AccountCode { get; set; }
        public string StoreCode { get; set; }
        public bool IsDebit { get; set; }
        public string Description { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFinancialCycle TblFinancialCycle { get; set; }
        public virtual ICollection<TblFormulaDetail> TblFormulaDetails { get; set; }
    }
}
