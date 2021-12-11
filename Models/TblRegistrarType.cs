using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblRegistrarType
    {
        public TblRegistrarType()
        {
            TblCosts = new HashSet<TblCost>();
            TblInvoiceMasterPermissions = new HashSet<TblInvoiceMasterPermission>();
            TblInvoiceMasters = new HashSet<TblInvoiceMaster>();
        }

        public long Id { get; set; }
        public string RegistrarTypeCode { get; set; }
        public string RegistrarTypeName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblCost> TblCosts { get; set; }
        public virtual ICollection<TblInvoiceMasterPermission> TblInvoiceMasterPermissions { get; set; }
        public virtual ICollection<TblInvoiceMaster> TblInvoiceMasters { get; set; }
    }
}
