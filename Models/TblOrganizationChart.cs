using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblOrganizationChart
    {
        public long Id { get; set; }
        public long TblOrganizationChartKeyId { get; set; }
        public long NodeId { get; set; }
        public long ParentId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblOrganizationChartKey TblOrganizationChartKey { get; set; }
    }
}
