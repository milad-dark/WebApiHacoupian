using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblHistoryOperation
    {
        public TblHistoryOperation()
        {
            TblHistoryOperationTypes = new HashSet<TblHistoryOperationType>();
        }

        public long Id { get; set; }
        public byte Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblHistoryOperationType> TblHistoryOperationTypes { get; set; }
    }
}
