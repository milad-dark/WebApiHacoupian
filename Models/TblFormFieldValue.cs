using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblFormFieldValue
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblFormFieldId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFormField TblFormField { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
