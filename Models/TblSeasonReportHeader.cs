using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblSeasonReportHeader
    {
        public TblSeasonReportHeader()
        {
            TblSeasonReportDetails = new HashSet<TblSeasonReportDetail>();
        }

        public long Id { get; set; }
        public long TblFinancialCycleId { get; set; }
        public byte ReportType { get; set; }
        public string ReportNumber { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFinancialCycle TblFinancialCycle { get; set; }
        public virtual ICollection<TblSeasonReportDetail> TblSeasonReportDetails { get; set; }
    }
}
