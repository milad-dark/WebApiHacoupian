using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblHistoryOperationType
    {
        public TblHistoryOperationType()
        {
            TblHistories = new HashSet<TblHistory>();
        }

        public long Id { get; set; }
        public long TblHistoryOperationId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblHistoryOperation TblHistoryOperation { get; set; }
        public virtual ICollection<TblHistory> TblHistories { get; set; }
    }
}
