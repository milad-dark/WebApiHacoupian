using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPlan
    {
        public TblPlan()
        {
            TblStorePlans = new HashSet<TblStorePlan>();
        }

        public long Id { get; set; }
        public string PlanCode { get; set; }
        public string PlanName { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblStorePlan> TblStorePlans { get; set; }
    }
}
