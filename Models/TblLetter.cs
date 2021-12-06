using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblLetter
    {
        public long Id { get; set; }
        public long TblPlaceTypeIdAsReceiver { get; set; }
        public long TblPlaceTypeIdAsIssue { get; set; }
        public long TblPersonIdAsReceiver { get; set; }
        public long TblPersonIdAsIssue { get; set; }
        public long TblLetterTypeId { get; set; }
        public byte[] Data { get; set; }
        public long LetterNumber { get; set; }
        public string Date { get; set; }
        public string Text { get; set; }
        public string Receivers { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblLetterType TblLetterType { get; set; }
        public virtual TblPerson TblPersonIdAsIssueNavigation { get; set; }
        public virtual TblPerson TblPersonIdAsReceiverNavigation { get; set; }
        public virtual TblPlaceType TblPlaceTypeIdAsIssueNavigation { get; set; }
        public virtual TblPlaceType TblPlaceTypeIdAsReceiverNavigation { get; set; }
    }
}
