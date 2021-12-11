using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblLogicalProperty
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }
        public byte RelatedId { get; set; }
        public int Code { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }
    }
}
