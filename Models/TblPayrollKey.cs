using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPayrollKey
    {
        public TblPayrollKey()
        {
            TblPayrollFactors = new HashSet<TblPayrollFactor>();
        }

        public long Id { get; set; }
        public string KeyName { get; set; }
        public string KeyValue { get; set; }
        public string Code { get; set; }
        public string KeyGroup { get; set; }
        public long ParentId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblPayrollFactor> TblPayrollFactors { get; set; }
    }
}
