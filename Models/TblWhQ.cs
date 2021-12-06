#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblWhQ
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; }
    }
}
