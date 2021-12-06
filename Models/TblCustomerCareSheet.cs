using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblCustomerCareSheet
    {
        public TblCustomerCareSheet()
        {
            TblCustomerCareSheetItems = new HashSet<TblCustomerCareSheetItem>();
        }

        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblPlaceTypeId { get; set; }
        public long Number { get; set; }
        public string Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }
        public long OldId { get; set; }

        public virtual TblPerson TblPerson { get; set; }
        public virtual TblPlaceType TblPlaceType { get; set; }
        public virtual ICollection<TblCustomerCareSheetItem> TblCustomerCareSheetItems { get; set; }
    }
}
