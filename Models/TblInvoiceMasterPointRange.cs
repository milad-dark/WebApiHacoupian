using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblInvoiceMasterPointRange
    {
        public TblInvoiceMasterPointRange()
        {
            TblInvoiceMasterPointRangeDetails = new HashSet<TblInvoiceMasterPointRangeDetail>();
        }

        public long Id { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblInvoiceMasterPointRangeDetail> TblInvoiceMasterPointRangeDetails { get; set; }
    }
}
