using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblLedger
    {
        public TblLedger()
        {
            TblBudgetItems = new HashSet<TblBudgetItem>();
            TblEvidenceItems = new HashSet<TblEvidenceItem>();
            TblFloatLedgerItems = new HashSet<TblFloatLedgerItem>();
            TblLedgerInfos = new HashSet<TblLedgerInfo>();
        }

        public long Id { get; set; }
        public long ParentId { get; set; }
        public long TblLedgerLevelId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public byte Nature { get; set; }
        public string FullAccountCode { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblLedgerLevel TblLedgerLevel { get; set; }
        public virtual ICollection<TblBudgetItem> TblBudgetItems { get; set; }
        public virtual ICollection<TblEvidenceItem> TblEvidenceItems { get; set; }
        public virtual ICollection<TblFloatLedgerItem> TblFloatLedgerItems { get; set; }
        public virtual ICollection<TblLedgerInfo> TblLedgerInfos { get; set; }
    }
}
