using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class ViewInvoiceMaster
    {
        public long TblInvoiceMasterId { get; set; }
        public long TblInvoiceRegistrarId { get; set; }
        public long TblInitializedTypeId { get; set; }
        public long TblEffectiveTypeId { get; set; }
        public long? TblPersonId { get; set; }
        public long InvoiceNumber { get; set; }
        public string InvoiceDate { get; set; }
        public TimeSpan? InvoiceTime { get; set; }
        public string InvoiceTo { get; set; }
        public string EffectiveCode { get; set; }
        public string Comment { get; set; }
        public long? ParentId { get; set; }
        public string TaxPercent { get; set; }
        public string Tax { get; set; }
        public bool IsDeleted { get; set; }
        public long? TblCompanyIdAsOwner { get; set; }
        public DateTime InvoiceDateTime { get; set; }
        public long ParentIdFromReturn { get; set; }
    }
}
