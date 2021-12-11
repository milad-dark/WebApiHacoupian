using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblFormalDay
    {
        public TblFormalDay()
        {
            TblWorkDays = new HashSet<TblWorkDay>();
        }

        public long Id { get; set; }
        public long TblFormalDayNameId { get; set; }
        public string Date { get; set; }
        public bool IsHoliday { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFormalDayName TblFormalDayName { get; set; }
        public virtual ICollection<TblWorkDay> TblWorkDays { get; set; }
    }
}
