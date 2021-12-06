using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblHistory
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblHistoryOperationTypeId { get; set; }
        public string HistoryConversation { get; set; }
        public DateTime HistoryDate { get; set; }
        public TimeSpan HistoryTime { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblHistoryOperationType TblHistoryOperationType { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
