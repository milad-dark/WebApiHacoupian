using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblLogSlave
    {
        public long Id { get; set; }
        public long TblLogMasterId { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblLogMaster TblLogMaster { get; set; }
    }
}
