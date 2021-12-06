using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblSeasonReportDetail
    {
        public long Id { get; set; }
        public long TblSeasonReportHeaderId { get; set; }
        public string SeasonReportNumber { get; set; }
        public string SeasonReportDate { get; set; }
        public string Subject { get; set; }
        public long TotalAmount { get; set; }
        public string PayDescription { get; set; }
        public bool IsReturned { get; set; }
        public long NotNetPayment { get; set; }
        public long AddedValue { get; set; }
        public long Tax { get; set; }
        public long MinusTax { get; set; }
        public long Discount { get; set; }
        public string PartCode { get; set; }
        public string PartName { get; set; }
        public long AllAmount { get; set; }
        public bool IsTotal { get; set; }
        public bool IsBelowTenPercentDeal { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblSeasonReportHeader TblSeasonReportHeader { get; set; }
    }
}
