using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblMenu
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int Parent { get; set; }
        public string Url { get; set; }
        public int Arrange { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }
    }
}
