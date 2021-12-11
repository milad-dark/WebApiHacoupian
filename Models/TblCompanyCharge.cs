using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCompanyCharge
    {
        public long Id { get; set; }
        public long TblCompanyId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public long FromPercent { get; set; }
        public long ToPercent { get; set; }
        public long FromAmount { get; set; }
        public long ToAmount { get; set; }
        public long FromPurchase { get; set; }
        public long ToPurchase { get; set; }
        public long FromRemained { get; set; }
        public long ToRemained { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompany TblCompany { get; set; }
    }
}
