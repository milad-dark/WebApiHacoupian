using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCustomerCareSheetItem
    {
        public TblCustomerCareSheetItem()
        {
            TblCustomerCareSheetItemDefects = new HashSet<TblCustomerCareSheetItemDefect>();
            TblCustomerCareSheetItemTrackings = new HashSet<TblCustomerCareSheetItemTracking>();
        }

        public long Id { get; set; }
        public long TblCustomerCareSheetId { get; set; }
        public long TblInvoiceSlaveId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }
        public long OldId { get; set; }

        public virtual TblCustomerCareSheet TblCustomerCareSheet { get; set; }
        public virtual TblInvoiceSlave TblInvoiceSlave { get; set; }
        public virtual ICollection<TblCustomerCareSheetItemDefect> TblCustomerCareSheetItemDefects { get; set; }
        public virtual ICollection<TblCustomerCareSheetItemTracking> TblCustomerCareSheetItemTrackings { get; set; }
    }
}
