using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblLogMaster
    {
        public TblLogMaster()
        {
            TblLogSlaves = new HashSet<TblLogSlave>();
        }

        public long Id { get; set; }
        public string SubSystem { get; set; }
        public string TableName { get; set; }
        public long TableRowId { get; set; }
        public DateTime ManipulationDateTime { get; set; }
        public string UserName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblLogSlave> TblLogSlaves { get; set; }
    }
}
