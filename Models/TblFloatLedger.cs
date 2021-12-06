using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblFloatLedger
    {
        public TblFloatLedger()
        {
            TblFloatLedgerItems = new HashSet<TblFloatLedgerItem>();
        }

        public long Id { get; set; }
        public long TblFinancialCycleId { get; set; }
        public long ParentId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFinancialCycle TblFinancialCycle { get; set; }
        public virtual ICollection<TblFloatLedgerItem> TblFloatLedgerItems { get; set; }
    }
}
