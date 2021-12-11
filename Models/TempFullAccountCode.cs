#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TempFullAccountCode
    {
        public long Id { get; set; }
        public string ChildName { get; set; }
        public long ParentId { get; set; }
        public string Parents { get; set; }
        public string FullName { get; set; }
    }
}
