using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblFinancialCycle
    {
        public TblFinancialCycle()
        {
            TblFloatLedgers = new HashSet<TblFloatLedger>();
            TblFormulaHeaders = new HashSet<TblFormulaHeader>();
            TblLedgerLevels = new HashSet<TblLedgerLevel>();
            TblSaves = new HashSet<TblSafe>();
            TblSeasonReportHeaders = new HashSet<TblSeasonReportHeader>();
        }

        public long Id { get; set; }
        public long TblCompanyId { get; set; }
        public long LedgerLevelsMaxNumber { get; set; }
        public string Cycle { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompany TblCompany { get; set; }
        public virtual ICollection<TblFloatLedger> TblFloatLedgers { get; set; }
        public virtual ICollection<TblFormulaHeader> TblFormulaHeaders { get; set; }
        public virtual ICollection<TblLedgerLevel> TblLedgerLevels { get; set; }
        public virtual ICollection<TblSafe> TblSaves { get; set; }
        public virtual ICollection<TblSeasonReportHeader> TblSeasonReportHeaders { get; set; }
    }
}
