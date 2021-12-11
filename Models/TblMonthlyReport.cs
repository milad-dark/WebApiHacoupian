using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblMonthlyReport
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public string Date { get; set; }
        public int OverBefore { get; set; }
        public int Delay { get; set; }
        public int TotalWork { get; set; }
        public int Rush { get; set; }
        public int OverAfter { get; set; }
        public int WithoutLicenseAbsence { get; set; }
        public bool Deleted { get; set; }
        public bool IsClosed { get; set; }
        public Guid Guid { get; set; }
        public bool Sent { get; set; }

        public virtual TblPerson TblPerson { get; set; }
    }
}
