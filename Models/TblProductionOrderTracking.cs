using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblProductionOrderTracking
    {
        public long Id { get; set; }
        public long TblProductionOrderId { get; set; }
        public long TblProductionOrderTrackingTypeId { get; set; }
        public long TblCompanyIdAsIssuer { get; set; }
        public long TblCompanyIdAsReceiver { get; set; }
        public long TblPlaceTypeIdAsIssuer { get; set; }
        public long TblPlaceTypeIdAsReceiver { get; set; }
        public long TblPersonIdAsIssuer { get; set; }
        public long TblPersonIdAsReceiver { get; set; }
        public DateTime IssueDateTime { get; set; }
        public DateTime ReceiveDateTime { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompany TblCompanyIdAsIssuerNavigation { get; set; }
        public virtual TblCompany TblCompanyIdAsReceiverNavigation { get; set; }
        public virtual TblPerson TblPersonIdAsIssuerNavigation { get; set; }
        public virtual TblPerson TblPersonIdAsReceiverNavigation { get; set; }
        public virtual TblPlaceType TblPlaceTypeIdAsIssuerNavigation { get; set; }
        public virtual TblPlaceType TblPlaceTypeIdAsReceiverNavigation { get; set; }
        public virtual TblProductionOrder TblProductionOrder { get; set; }
        public virtual TblProductionOrderTrackingType TblProductionOrderTrackingType { get; set; }
    }
}
