using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblServiceEmployee
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblServiceId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPerson TblPerson { get; set; }
        public virtual TblService TblService { get; set; }
    }
}
