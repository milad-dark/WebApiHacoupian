using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCustomerCareSheetItemDefect
    {
        public long Id { get; set; }
        public long TblCustomerCareSheetItemId { get; set; }
        public long TblCustomerCareDefectId { get; set; }
        public long TblPersonId { get; set; }
        public long TblPlaceTypeId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCustomerCareDefect TblCustomerCareDefect { get; set; }
        public virtual TblCustomerCareSheetItem TblCustomerCareSheetItem { get; set; }
        public virtual TblPerson TblPerson { get; set; }
        public virtual TblPlaceType TblPlaceType { get; set; }
    }
}
