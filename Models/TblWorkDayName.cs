using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblWorkDayName
    {
        public TblWorkDayName()
        {
            TblEvaluationPeriodCalendars = new HashSet<TblEvaluationPeriodCalendar>();
            TblWorkDays = new HashSet<TblWorkDay>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblEvaluationPeriodCalendar> TblEvaluationPeriodCalendars { get; set; }
        public virtual ICollection<TblWorkDay> TblWorkDays { get; set; }
    }
}
