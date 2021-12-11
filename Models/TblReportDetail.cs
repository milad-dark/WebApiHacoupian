using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblReportDetail
    {
        public TblReportDetail()
        {
            TblReportDetailItems = new HashSet<TblReportDetailItem>();
        }

        public long Id { get; set; }
        public long TblReportHeaderId { get; set; }
        public string DetailName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblReportHeader TblReportHeader { get; set; }
        public virtual ICollection<TblReportDetailItem> TblReportDetailItems { get; set; }
    }
}
