using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblInvoiceMaster
    {
        public TblInvoiceMaster()
        {
            TblInvoiceMasterAttachments = new HashSet<TblInvoiceMasterAttachment>();
            TblInvoiceMasterDiscounts = new HashSet<TblInvoiceMasterDiscount>();
            TblInvoiceMasterPayments = new HashSet<TblInvoiceMasterPayment>();
            TblInvoiceMasterPoints = new HashSet<TblInvoiceMasterPoint>();
            TblInvoiceMasterPrepayments = new HashSet<TblInvoiceMasterPrepayment>();
            TblInvoiceMasterRemains = new HashSet<TblInvoiceMasterRemain>();
            TblInvoiceMasterTypes = new HashSet<TblInvoiceMasterType>();
            TblInvoiceMoreInfos = new HashSet<TblInvoiceMoreInfo>();
            TblInvoiceSlaves = new HashSet<TblInvoiceSlave>();
            TblPersonCharges = new HashSet<TblPersonCharge>();
            TblPollProductQualities = new HashSet<TblPollProductQuality>();
            TblPollServiceQualities = new HashSet<TblPollServiceQuality>();
        }

        public long Id { get; set; }
        public long? TblCompanyIdAsOwner { get; set; }
        public long TblPlaceTypeIdAsIssuer { get; set; }
        public long TblPlaceTypeIdAsReceiver { get; set; }
        public long TblCompanyIdAsIssuer { get; set; }
        public long TblCompanyIdAsReceiver { get; set; }
        public long TblPersonIdAsIssuer { get; set; }
        public long TblPersonIdAsReceiver { get; set; }
        public long TblInvoiceRegistrarId { get; set; }
        public long TblInitializedTypeId { get; set; }
        public long TblEffectiveTypeId { get; set; }
        public long TblInvoiceStatusId { get; set; }
        public long? TblPersonId { get; set; }
        public string InvoiceDate { get; set; }
        public TimeSpan? InvoiceTime { get; set; }
        public DateTime InvoiceDateTime { get; set; }
        public long InvoiceNumber { get; set; }
        public string InvoiceTo { get; set; }
        public long ParentIdFromReturn { get; set; }
        public string EffectiveCode { get; set; }
        public string Comment { get; set; }
        public long? ParentId { get; set; }
        public string TaxPercent { get; set; }
        public string Tax { get; set; }
        public bool? CanBeReturned { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompany TblCompanyIdAsIssuerNavigation { get; set; }
        public virtual TblCompany TblCompanyIdAsOwnerNavigation { get; set; }
        public virtual TblCompany TblCompanyIdAsReceiverNavigation { get; set; }
        public virtual TblEffectiveType TblEffectiveType { get; set; }
        public virtual TblInitializedType TblInitializedType { get; set; }
        public virtual TblRegistrarType TblInvoiceRegistrar { get; set; }
        public virtual TblInvoiceStatus TblInvoiceStatus { get; set; }
        public virtual TblPerson TblPerson { get; set; }
        public virtual TblPerson TblPersonIdAsIssuerNavigation { get; set; }
        public virtual TblPerson TblPersonIdAsReceiverNavigation { get; set; }
        public virtual TblPlaceType TblPlaceTypeIdAsIssuerNavigation { get; set; }
        public virtual TblPlaceType TblPlaceTypeIdAsReceiverNavigation { get; set; }
        public virtual ICollection<TblInvoiceMasterAttachment> TblInvoiceMasterAttachments { get; set; }
        public virtual ICollection<TblInvoiceMasterDiscount> TblInvoiceMasterDiscounts { get; set; }
        public virtual ICollection<TblInvoiceMasterPayment> TblInvoiceMasterPayments { get; set; }
        public virtual ICollection<TblInvoiceMasterPoint> TblInvoiceMasterPoints { get; set; }
        public virtual ICollection<TblInvoiceMasterPrepayment> TblInvoiceMasterPrepayments { get; set; }
        public virtual ICollection<TblInvoiceMasterRemain> TblInvoiceMasterRemains { get; set; }
        public virtual ICollection<TblInvoiceMasterType> TblInvoiceMasterTypes { get; set; }
        public virtual ICollection<TblInvoiceMoreInfo> TblInvoiceMoreInfos { get; set; }
        public virtual ICollection<TblInvoiceSlave> TblInvoiceSlaves { get; set; }
        public virtual ICollection<TblPersonCharge> TblPersonCharges { get; set; }
        public virtual ICollection<TblPollProductQuality> TblPollProductQualities { get; set; }
        public virtual ICollection<TblPollServiceQuality> TblPollServiceQualities { get; set; }
    }
}
