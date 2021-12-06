using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblReportDetailItemYear
    {
        public long Id { get; set; }
        public long TblReportDetailItemId { get; set; }
        public string Date { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblReportDetailItem TblReportDetailItem { get; set; }
    }
}
