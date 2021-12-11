using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblNetworkUsage
    {
        public long Id { get; set; }
        public long TblIspcontractId { get; set; }
        public string Usage { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblIspcontract TblIspcontract { get; set; }
    }
}
