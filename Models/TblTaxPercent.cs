using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblTaxPercent
    {
        public long Id { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public long FromAmount { get; set; }
        public long ToAmount { get; set; }
        public long TaxPercentage { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }
    }
}
