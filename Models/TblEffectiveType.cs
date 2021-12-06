using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblEffectiveType
    {
        public TblEffectiveType()
        {
            TblInvoiceMasters = new HashSet<TblInvoiceMaster>();
        }

        public long Id { get; set; }
        public string EffectiveTypeCode { get; set; }
        public string EffectiveTypeName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblInvoiceMaster> TblInvoiceMasters { get; set; }
    }
}
