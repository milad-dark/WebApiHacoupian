using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblUserRight
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Application { get; set; }
        public string UserControl { get; set; }
        public string Control { get; set; }
        public bool Visibility { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }
    }
}
