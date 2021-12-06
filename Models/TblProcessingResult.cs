using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblProcessingResult
    {
        public TblProcessingResult()
        {
            TblProcessingResultFactors = new HashSet<TblProcessingResultFactor>();
        }

        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public string Date { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPerson TblPerson { get; set; }
        public virtual ICollection<TblProcessingResultFactor> TblProcessingResultFactors { get; set; }
    }
}
