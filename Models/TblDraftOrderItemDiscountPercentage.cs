using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblDraftOrderItemDiscountPercentage
    {
        public long Id { get; set; }
        public long Percentage { get; set; }
        public double Coefficient { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }
    }
}
