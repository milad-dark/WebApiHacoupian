using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblReportDetailItem
    {
        public TblReportDetailItem()
        {
            TblReportDetailItemYears = new HashSet<TblReportDetailItemYear>();
        }

        public long Id { get; set; }
        public long TblReportDetailId { get; set; }
        public long TblFormulaHeaderId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblReportDetail TblReportDetail { get; set; }
        public virtual ICollection<TblReportDetailItemYear> TblReportDetailItemYears { get; set; }
    }
}
