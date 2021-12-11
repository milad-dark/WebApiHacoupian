using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblDefaultText
    {
        public long Id { get; set; }
        public string DefaultTextCode { get; set; }
        public string DefaultTextName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }
    }
}
