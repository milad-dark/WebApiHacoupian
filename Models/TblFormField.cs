using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblFormField
    {
        public TblFormField()
        {
            TblFormFieldDefaults = new HashSet<TblFormFieldDefault>();
            TblFormFieldValues = new HashSet<TblFormFieldValue>();
        }

        public long Id { get; set; }
        public long TblFormId { get; set; }
        public long TblFormFieldTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblForm TblForm { get; set; }
        public virtual TblFormFieldType TblFormFieldType { get; set; }
        public virtual ICollection<TblFormFieldDefault> TblFormFieldDefaults { get; set; }
        public virtual ICollection<TblFormFieldValue> TblFormFieldValues { get; set; }
    }
}
