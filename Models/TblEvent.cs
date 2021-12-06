using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblEvent
    {
        public TblEvent()
        {
            TblEventPlaceTypes = new HashSet<TblEventPlaceType>();
        }

        public long Id { get; set; }
        public long TblDiscountTypeId { get; set; }
        public string EventCode { get; set; }
        public string EventName { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblDiscountType TblDiscountType { get; set; }
        public virtual ICollection<TblEventPlaceType> TblEventPlaceTypes { get; set; }
    }
}
