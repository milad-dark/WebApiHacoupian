using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCalendarArchive
    {
        public long Id { get; set; }
        public string DayOfWeek { get; set; }
        public string PersianDate { get; set; }
        public string GregorianDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }
    }
}
