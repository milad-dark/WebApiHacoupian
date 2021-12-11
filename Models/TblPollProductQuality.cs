using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPollProductQuality
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblInvoiceMasterId { get; set; }
        public long TblFinishedGoodProductId { get; set; }
        public string Date { get; set; }
        public string QuestionId { get; set; }
        public int Rate { get; set; }
        public string Pros { get; set; }
        public string Cons { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFinishedGoodProduct TblFinishedGoodProduct { get; set; }
        public virtual TblInvoiceMaster TblInvoiceMaster { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
