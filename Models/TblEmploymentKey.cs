using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblEmploymentKey
    {
        public TblEmploymentKey()
        {
            TblEmploymentFactors = new HashSet<TblEmploymentFactor>();
        }

        public long Id { get; set; }
        public string KeyName { get; set; }
        public string KeyValue { get; set; }
        public string Code { get; set; }
        public string KeyGroup { get; set; }
        public long ParentId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public int Priority { get; set; }
        public bool IsInTax { get; set; }
        public bool IsInInsurance { get; set; }
        public bool IsSalary { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblEmploymentFactor> TblEmploymentFactors { get; set; }
    }
}
