using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCodingPatternKey
    {
        public long Id { get; set; }
        public long TblCodingPatternId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long Length { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCodingPattern TblCodingPattern { get; set; }
    }
}
