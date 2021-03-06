using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPointType
    {
        public TblPointType()
        {
            TblInvoiceMasterPoints = new HashSet<TblInvoiceMasterPoint>();
        }

        public long Id { get; set; }
        public string PointTypeCode { get; set; }
        public string PointTypeName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblInvoiceMasterPoint> TblInvoiceMasterPoints { get; set; }
    }
}
