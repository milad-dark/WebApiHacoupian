using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblFeedback
    {
        public long Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Title { get; set; }
        public DateTime RecieveDateTime { get; set; }
        public string Body { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }
    }
}
