using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCustomerCareDefect
    {
        public TblCustomerCareDefect()
        {
            TblCustomerCareSheetItemDefects = new HashSet<TblCustomerCareSheetItemDefect>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long CodeLength { get; set; }
        public long ParentId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblCustomerCareSheetItemDefect> TblCustomerCareSheetItemDefects { get; set; }
    }
}
