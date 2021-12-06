using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblInvoiceMasterPrepayment
    {
        public long Id { get; set; }
        public long TblInvoiceMasterId { get; set; }
        public long TblPrepaymentTypeId { get; set; }
        public long Amount { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblInvoiceMaster TblInvoiceMaster { get; set; }
        public virtual TblPrepaymentType TblPrepaymentType { get; set; }
    }
}
