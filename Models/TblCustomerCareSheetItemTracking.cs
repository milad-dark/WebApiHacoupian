using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblCustomerCareSheetItemTracking
    {
        public long Id { get; set; }
        public long TblCustomerCareSheetItemId { get; set; }
        public long TblCustomerCareSheetItemTrackingTypeId { get; set; }
        public long TblCustomerCareSheetItemTrackingTypeAsResultId { get; set; }
        public long TblDraftId { get; set; }
        public long Cost { get; set; }
        public long TblPlaceTypeAsIssuerId { get; set; }
        public long TblPlaceTypeAsReceiverId { get; set; }
        public long TblPersonAsIssuerId { get; set; }
        public long TblPersonAsReceiverId { get; set; }
        public string IssueDate { get; set; }
        public string DetermineDate { get; set; }
        public TimeSpan IssueTime { get; set; }
        public TimeSpan DetermineTime { get; set; }
        public string Explanation { get; set; }
        public string IssuerNote { get; set; }
        public string DeterminerNote { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCustomerCareSheetItem TblCustomerCareSheetItem { get; set; }
        public virtual TblCustomerCareSheetItemTrackingType TblCustomerCareSheetItemTrackingType { get; set; }
        public virtual TblCustomerCareSheetItemTrackingType TblCustomerCareSheetItemTrackingTypeAsResult { get; set; }
        public virtual TblPerson TblPersonAsIssuer { get; set; }
        public virtual TblPerson TblPersonAsReceiver { get; set; }
        public virtual TblPlaceType TblPlaceTypeAsIssuer { get; set; }
        public virtual TblPlaceType TblPlaceTypeAsReceiver { get; set; }
    }
}
