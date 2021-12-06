using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblFormulaGroup
    {
        public long Id { get; set; }
        public long TblFormulaDetailId { get; set; }
        public long TblKeyId { get; set; }
        public string FieldName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFormulaDetail TblFormulaDetail { get; set; }
    }
}
