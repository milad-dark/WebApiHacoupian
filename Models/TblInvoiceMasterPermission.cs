using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblInvoiceMasterPermission
    {
        public long Id { get; set; }
        public long TblRegistrarTypeId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public long FromNumber { get; set; }
        public long ToNumber { get; set; }
        public bool FullReturn { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblRegistrarType TblRegistrarType { get; set; }
    }
}
