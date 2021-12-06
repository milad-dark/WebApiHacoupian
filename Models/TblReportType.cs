using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblReportType
    {
        public TblReportType()
        {
            TblReportHeaders = new HashSet<TblReportHeader>();
        }

        public long Id { get; set; }
        public byte ReportType { get; set; }
        public string ReportName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblReportHeader> TblReportHeaders { get; set; }
    }
}
